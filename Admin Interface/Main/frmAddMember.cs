using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.client;
using CarlosYulo.preload;
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
    public partial class frmAddMember : Form
    {
        // FIELD INJECTION
        private ClientController _clientController;
        private Client _newClient;

        //Connection sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        public frmAddMember()
        {
            InitializeComponent();
            _clientController = ServiceLocator.GetService<ClientController>();
            _newClient = new Client();
            txtMemberPhoneNumber.KeyPress += txtBox_KeyPress;
            txtMemberAge.KeyPress += txtBox_KeyPress;

            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
        }

        // Modifications
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a control key (like backspace) and is not a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input
            }
        }


        private void frmAddMember_Load(object sender, EventArgs e)
        {
        }

        //Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Save
        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            _newClient.FullName = GetTextIfNotEmpty(txtMemberFullname);
            _newClient.Email = GetTextIfNotEmpty(txtMemberEmailAddress);
            _newClient.PhoneNumber = GetTextIfNotEmpty(txtMemberPhoneNumber);
            _newClient.Age = GetIntIfValid(txtMemberAge);
            _newClient.BirthDate = dtMemberBirthdate.Value != DateTime.MinValue ? dtMemberBirthdate.Value : (DateTime?)null;
            _newClient.Gender = cmbMemberGender.SelectedItem != null
                ? cmbMemberGender.SelectedItem.ToString()
                : string.Empty;
            _newClient.MembershipTypeId = cmbMembershipType.SelectedIndex > 0 ? cmbMembershipType.SelectedIndex + 1 : (int?)null;
            _newClient.MembershipStart = dtMembershiptStart.Value != DateTime.MinValue ? dtMembershiptStart.Value : (DateTime?)null;

            if (cmbMembershipType.SelectedIndex == 2)
            {
            }

            if (!_clientController.CreateNewMember(_newClient))
            {
                return;
            }

            txtMembershipID.Text = _newClient.MembershipTypeId.ToString();

            //add og notification
            notificationService.AddNotification("Member Addition", $"New Member '{_newClient.FullName}' added. on", _newClient.FullName);

            MessageBox.Show("New Client created. Name: " + _newClient.FullName + " ID: " + _newClient.MembershipId);
            PreloadData.UpdateMembersAdd(_newClient);
            PreloadData.UpdateClientsAdd(_newClient);
            this.Close();
        }


        // Image
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _newClient.SetProfilePicture(openFileDialog.FileName);
            }

            picMemberPhoto.Image = _newClient.ProfilePictureImage;
        }


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
    }
}