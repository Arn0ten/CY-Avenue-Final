﻿using System;
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
using MySqlX.XDevAPI;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmEditStaff : Form
    {
        private EmployeeController _employeeController;
        public Employee _employee;
        public bool _success;

        //Global procedure para sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        private frmNotifications _frmNotifications;

        public frmEditStaff(EmployeeController employeeController, Employee employee, bool success)
        {
            InitializeComponent();
            _employeeController = employeeController;
            _employee = employee;
            _success = success;
            PlaceHolder();

            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            _frmNotifications = new frmNotifications();
        }

        private void PlaceHolder()
        {
            txtStaffID.PlaceholderText = _employee.EmployeeId.ToString();
            txtEditStaffFullname.PlaceholderText = _employee.FullName;
            txtEditStaffEmailAddress.PlaceholderText = _employee.Email;
            txtEditStaffPhoneNumber.PlaceholderText = _employee.PhoneNumber;
            txtEditStaffAge.PlaceholderText = _employee.Age.ToString();
            
        }

        string GetTextIfNotEmpty(Guna2TextBox textBox) =>
            !string.IsNullOrWhiteSpace(textBox.Text) ? textBox.Text : null;

        int? GetIntIfValid(Guna2TextBox textBox)
        {
            return int.TryParse(textBox.Text, out int result) ? result : (int?)null;
        }


        //Save
        private void btnSaveEditStaff_Click(object sender, EventArgs e)
        {
            var newFullName = GetTextIfNotEmpty(txtEditStaffFullname);
            _employee.FullName = newFullName ?? _employee.FullName;

            var newEmail = GetTextIfNotEmpty(txtEditStaffEmailAddress);
            _employee.Email = newEmail ?? _employee.Email;

            var newPhoneNumber = GetTextIfNotEmpty(txtEditStaffPhoneNumber);
            _employee.PhoneNumber = newPhoneNumber ?? _employee.PhoneNumber;

            var newAge = GetIntIfValid(txtEditStaffAge);
            _employee.Age = newAge ?? _employee.Age;

            _employee.Gender = cmbEditStaffGender.SelectedItem != null
                ? cmbEditStaffGender.SelectedItem.ToString()
                : _employee.Gender;

            _employee.EmployeeTypeId = cmbEditStaffRole.SelectedIndex >= 0
                ? cmbEditStaffRole.SelectedIndex + 1
                : _employee.EmployeeTypeId;

            _employee.BirthDate = dtEditStaffBirthdate.Value != DateTime.MinValue
                ? dtEditStaffBirthdate.Value
                : _employee.BirthDate;

            Console.WriteLine(_employee.ToString());

            // UPDATE
            try
            {
                if (!_employeeController.UpdateDetails(_employee))
                {
                    _success = false;
                    return;
                }

                MessageBox.Show("Staff updated successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Add notif
                notificationService.AddNotification("Staff Update", $" '{_employee.FullName}' Has been updated! ", _employee.FullName);
                MessageBox.Show($"Staff updated successfully!. Name: '{_employee.FullName}",
                        "Staff Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _employee.SetProfilePicture(openFileDialog.FileName);
                picEditStaffPhoto.Image = _employee.ProfilePictureImage;
            }
        }
    }
}