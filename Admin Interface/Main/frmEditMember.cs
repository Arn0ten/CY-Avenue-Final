using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.client;
using CarlosYulo.backend.monolith.employee;
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
    public partial class frmEditMember : Form
    {
        public ClientController _clientController;
        public Client _client;
        public bool _success;

        public frmEditMember(ClientController employeeController, Client client, bool success)
        {
            InitializeComponent();
            _clientController = employeeController;
            _client = client;
            _success = success;
        }
        string GetTextIfNotEmpty(Guna2TextBox textBox) =>
        !string.IsNullOrWhiteSpace(textBox.Text) ? textBox.Text : null;

        int? GetIntIfValid(Guna2TextBox textBox)
        {
            return int.TryParse(textBox.Text, out int result) ? result : (int?)null;
        }


        //Save
        private void btnSaveEditMember_Click(object sender, EventArgs e)
        {


            var newFullName = GetTextIfNotEmpty(txtEditMemberFullname);
            _client.FullName = newFullName ?? _client.FullName;

            var newEmail = GetTextIfNotEmpty(txtEditMemberEmailAddress);
            _client.Email = newEmail ?? _client.Email;

            var newPhoneNumber = GetTextIfNotEmpty(txtEditMemberPhoneNumber);
            _client.PhoneNumber = newPhoneNumber ?? _client.PhoneNumber;

            var newAge = GetIntIfValid(txtEditMemberAge);
            _client.Age = newAge ?? _client.Age;

            _client.Gender = cmbEditMemberGender.SelectedItem != null
                ? cmbEditMemberGender.SelectedItem.ToString()
                : _client.Gender;

            _client.MembershipTypeId = cmbEditMembershipType.SelectedIndex >= 0
                ? cmbEditMembershipType.SelectedIndex + 1
                : _client.MembershipTypeId;

            _client.BirthDate = dtEditMemberBirthdate.Value != DateTime.MinValue
                ? dtEditMemberBirthdate.Value
                : _client.BirthDate;


            try
            {

                if (!_clientController.UpdateDetails(_client))
                {
                    _success = false;
                    return;
                }
                MessageBox.Show("Client updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _success = true;
                Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        //Browse
        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _client.SetProfilePicture(openFileDialog.FileName);
                picEditMemberPhoto.Image = _client.ProfilePictureImage;
            }
        }


        //Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
