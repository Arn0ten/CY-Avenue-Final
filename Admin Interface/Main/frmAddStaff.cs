using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.employee;
using csCY_Avenue.Custom;
using csCY_Avenue.Database;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmAddStaff : Form
    {
        private EmployeeController _employeeController;
        public Employee _employee;
        public bool _success;

        //Global procedure para sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        private frmNotifications _frmNotifications;


        public frmAddStaff(Employee employee, bool success)
        {
            InitializeComponent();
            _employeeController = ServiceLocator.GetService<EmployeeController>();
            _employee = employee;
            _success = success;
            txtSalary.KeyPress += txtSalary_KeyPress;
            txtStaffAge.KeyPress += txtSalary_KeyPress;
            txtStaffPhoneNumber.KeyPress += txtSalary_KeyPress;

            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            _frmNotifications = new frmNotifications();
        }

        // Salary Only
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

        //Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            _employee.FullName = GetTextIfNotEmpty(txtStaffFullname);
            _employee.Email = GetTextIfNotEmpty(txtStaffEmailAddress);
            _employee.PhoneNumber = GetTextIfNotEmpty(txtStaffPhoneNumber);
            _employee.Age = GetIntIfValid(txtStaffAge);
            _employee.Gender = cmbStaffGender.SelectedItem != null
                ? cmbStaffGender.SelectedItem.ToString()
                : string.Empty;
            _employee.EmployeeTypeId = cmbStaffRole.SelectedIndex >= 0
                ? cmbStaffRole.SelectedIndex + 1
                : null;
            _employee.BirthDate = dtStaffBirthdate.Value != DateTime.MinValue ? dtStaffBirthdate.Value : null;

            // salary
            if (double.TryParse(txtSalary.Text, out double salary))
            {
                _employee.Salary = salary;
            }

            // SAVE
            try
            {
                if (!_employeeController.Create(_employee))
                {
                    _success = false;
                    return;
                }

                txtStaffshipID.Text = _employee.EmployeeId.ToString() ?? string.Empty;
                picStaffPhoto.Image = _employee.ProfilePictureImage;
                _success = true;
                Close();

                //Add notif
                notificationService.AddNotification("Staff Addition", $"New Staff '{_employee.FullName}' ", _employee.FullName);
                MessageBox.Show($"New Staff created. Name: '{_employee.FullName}' ID: '{_employee.EmployeeId}'",
                        "Staff Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _employee.SetProfilePicture(openFileDialog.FileName);
            }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
        }
    }
}