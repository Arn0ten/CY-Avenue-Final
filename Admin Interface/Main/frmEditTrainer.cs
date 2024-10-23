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
    public partial class frmEditTrainer : Form
    {
        private EmployeeController _employeeController;
        public Employee _trainer;
        public bool _success;

        //Global procedure para sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        private frmNotifications _frmNotifications;
        public frmEditTrainer(EmployeeController employeeController, Employee trainer, bool success)
        {
            InitializeComponent();
            _employeeController = employeeController;
            _trainer = trainer;
            _success = success;
            PlaceHolder();

            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            _frmNotifications = new frmNotifications();
        }

        private void PlaceHolder()
        {
            txtTrainerID.PlaceholderText = _trainer.EmployeeId.ToString();
            txtEditTrainerFullname.PlaceholderText = _trainer.FullName;
            txtEditTrainerEmailAddress.PlaceholderText = _trainer.Email;
            txtEditTrainerPhoneNumber.PlaceholderText = _trainer.PhoneNumber;
            txtEditTrainerAge.PlaceholderText = _trainer.Age.ToString();
        }
        
        
        // Check inputs
        string GetTextIfNotEmpty(Guna2TextBox textBox) =>
            !string.IsNullOrWhiteSpace(textBox.Text) ? textBox.Text : null;

        int? GetIntIfValid(Guna2TextBox textBox)
        {
            return int.TryParse(textBox.Text, out int result) ? result : (int?)null;
        }


        //Save
        private void btnSaveEditTrainer_Click(object sender, EventArgs e)
        {

            var newFullName = GetTextIfNotEmpty(txtEditTrainerFullname);
            _trainer.FullName = newFullName ?? _trainer.FullName;

            var newEmail = GetTextIfNotEmpty(txtEditTrainerEmailAddress);
            _trainer.Email = newEmail ?? _trainer.Email;

            var newPhoneNumber = GetTextIfNotEmpty(txtEditTrainerPhoneNumber);
            _trainer.PhoneNumber = newPhoneNumber ?? _trainer.PhoneNumber;

            var newAge = GetIntIfValid(txtEditTrainerAge);
            _trainer.Age = newAge ?? _trainer.Age;

            _trainer.Gender = cmbEditTrainerGender.SelectedItem != null
                ? cmbEditTrainerGender.SelectedItem.ToString()
                : _trainer.Gender;

            _trainer.EmployeeTypeId = cmbEditTrainerType.SelectedIndex >= 0
                ? cmbEditTrainerType.SelectedIndex + 3
                : _trainer.EmployeeTypeId;

            _trainer.BirthDate = dtEditTrainerBirthdate.Value != DateTime.MinValue
                ? dtEditTrainerBirthdate.Value
                : _trainer.BirthDate;

            Console.WriteLine(_trainer.ToString());

            // UPDATE
            try
            {
                if (!_employeeController.UpdateDetails(_trainer))
                {
                    _success = false;
                    return;
                }

                MessageBox.Show("Trainer updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Add notif
                notificationService.AddNotification("Trainer Update", $" '{_trainer.FullName}' Has been updated! ", _trainer.FullName);
                MessageBox.Show($"Trainer updated successfully!. Name: '{_trainer.FullName}",
                        "Trainer Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
                _success = true;
                Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        //Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Browse
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _trainer.SetProfilePicture(openFileDialog.FileName);
                picEditTrainerPhoto.Image = _trainer.ProfilePictureImage;
            }
        }
    }
}
