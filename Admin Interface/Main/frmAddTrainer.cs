using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.employee;
using csCY_Avenue.Custom;
using csCY_Avenue.Database;
using Guna.UI2.WinForms;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmAddTrainer : Form
    {
        public Employee _trainer;
        public EmployeeController _employeeController;
        public bool _success;

        //Global procedure para sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        private frmNotifications _frmNotifications;
        public frmAddTrainer(EmployeeController employeeController, bool success)
        {
            InitializeComponent();
            _employeeController = employeeController;
            _success = success;
            txtTrainerSalary.KeyPress += txtSalary_KeyPress;
            txtTrainerAge.KeyPress += txtSalary_KeyPress;
            txtTrainerPhoneNumber.KeyPress += txtSalary_KeyPress;
            _trainer = new Employee();
            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            _frmNotifications = new frmNotifications();
        }
        
        // DIGIT LOGGER
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
        
        // VALUE OR NULL
        string GetTextIfNotEmpty(Guna2TextBox textBox) =>
            !string.IsNullOrWhiteSpace(textBox.Text) ? textBox.Text : null;

        int? GetIntIfValid(Guna2TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int result))
            {
                return result;
            }

            return null; // Return null if parsing fails
        }


        //Cacncel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveTrainer_Click(object sender, EventArgs e)
        {
            _trainer.FullName = GetTextIfNotEmpty(txtTrainerFullname);
            _trainer.Email = GetTextIfNotEmpty(txtTrainerEmailAddress);
            _trainer.PhoneNumber = GetTextIfNotEmpty(txtTrainerPhoneNumber);
            _trainer.Age = GetIntIfValid(txtTrainerAge);
            _trainer.Gender = cmbTrainerGender.SelectedItem != null
                ? cmbTrainerGender.SelectedItem.ToString()
                : string.Empty;
            _trainer.EmployeeTypeId = cmbTrainerType.SelectedIndex >= 0
                ? cmbTrainerType.SelectedIndex + 3
                : null;
            _trainer.BirthDate = dtTrainerBirthdate.Value != DateTime.MinValue ? dtTrainerBirthdate.Value : null;

            // salary
            if (double.TryParse(txtTrainerSalary.Text, out double salary))
            {
                _trainer.Salary = salary;
            }
            // SAVE
            try
            {
                if (!_employeeController.Create(_trainer))
                {
                    _success = false;
                    return;
                }

                txtTrainershipID.Text = _trainer.EmployeeId.ToString() ?? string.Empty;
                picTrainerPhoto.Image = _trainer.ProfilePictureImage;


                //Add notif
                notificationService.AddNotification("Trainer Addition", $"New Trainer '{_trainer.FullName}' ", _trainer.FullName);
                MessageBox.Show($"New Trainer ' {_trainer.FullName}' ID: '{_trainer.EmployeeId}'",
                        "Trainer Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _success = true;
                Close();
            }
            catch (Exception exception)
            {
                _success = false;
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _trainer.SetProfilePicture(openFileDialog.FileName);
                picTrainerPhoto.Image = _trainer.ProfilePictureImage;
            }
        }
    }
}