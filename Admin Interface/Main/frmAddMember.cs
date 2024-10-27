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
using CarlosYulo.backend.entities.class_session;
using CarlosYulo.backend.monolith.revenue;
using CarlosYulo.backend.monolith.schedule;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmAddMember : Form
    {
        private ClientController _clientController;
        private List<Employee> _trainers;
        private Employee _trainer;
        private RevenueController _revenueController;
        private ScheduleController _scheduleController;
        public Client _newClient;
        public bool _success;

        //Connection sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;

        public frmAddMember(ClientController clientController, Client client, bool success)
        {
            InitializeComponent();
            _trainers = PreloadData.Trainers;

            _clientController = clientController;
            _newClient = client;
            _success = success;
            _revenueController = ServiceLocator.GetService<RevenueController>();
            _scheduleController = ServiceLocator.GetService<ScheduleController>();

            txtMemberPhoneNumber.KeyPress += txtBox_KeyPress;
            txtMemberAge.KeyPress += txtBox_KeyPress;

            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            cmbAssignTrainer.SelectedIndexChanged += cmbAssignTrainer_SelectedIndexChanged;
            LoadComboBoxTrainer();

            cmbMembershipType.SelectedIndexChanged += cmbMembershipType_SelectedIndexChanged;
        }

        private void LoadComboBoxTrainer()
        {
            _trainers = _trainers.Where(e => e.EmployeeTypeId == 4).ToList();
            cmbAssignTrainer.Items.Clear();

            foreach (var trainer in _trainers)
            {
                cmbAssignTrainer.Items.Add(trainer);
            }
        }

        // Event handler for Membership Type selection
        private void cmbMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbMembershipType.SelectedIndex == 1)
            {

                cmbAssignTrainer.Enabled = true;
            }
            else
            {

                cmbAssignTrainer.Enabled = false;
                cmbAssignTrainer.SelectedIndex = -1; 
            }
        }

        // Trainer selection handler remains unchanged
        private void cmbAssignTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAssignTrainer.SelectedItem is Employee selectedTrainer)
            {
                _trainer = selectedTrainer;
            }
        }


        // Modifications
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
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
            _newClient.BirthDate =
                dtMemberBirthdate.Value != DateTime.MinValue ? dtMemberBirthdate.Value : (DateTime?)null;
            _newClient.Gender = cmbMemberGender.SelectedItem != null
                ? cmbMemberGender.SelectedItem.ToString()
                : string.Empty;
            _newClient.MembershipTypeId =
                cmbMembershipType.SelectedIndex + 1 > 0 ? cmbMembershipType.SelectedIndex + 1 : (int?)null;
            _newClient.MembershipStart = DateTime.Today;
            _newClient.MembershipStatus = "Active";


            if (!_clientController.CreateNewMember(_newClient))
            {
                return;
            }
    
            // ASSIGN PERSONAL TRAINER
            if (_newClient.MembershipTypeId == 2)
            {
                TrainerStudent newStudent = new TrainerStudent
                {
                    TrainerId = _trainer.EmployeeId,
                    TrainerName = _trainer.FullName,
                    StudentId = _newClient.MembershipId,
                    StudentName = _newClient.FullName,
                    Status = "Active",
                    StartDate = DateTime.Today
                };

                if (!_scheduleController.CreateStudent(newStudent))
                {
                    return;
                }
            }

            // create in-voice for pending shit
            
            var yawa = _revenueController.GeneratePendingMembership(_newClient);
            
            PreloadPayPending.PreUnpaidLoad();
            _success = true;
            txtMembershipID.Text = _newClient.MembershipTypeId.ToString();


            //add og notification
            notificationService.AddNotification("Member Addition", $"New Member '{_newClient.FullName}' added.",
                _newClient.FullName);
            MessageBox.Show($"New member created. Name: '{_newClient.FullName}' ID: '{_newClient.MembershipId}'",
            "Member Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
          

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

            return null; 
        }
    }
}