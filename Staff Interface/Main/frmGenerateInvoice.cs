using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.client;
using CarlosYulo.backend.monolith.revenue;
using csCY_Avenue.Custom;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmGenerateInvoice : Form
    {
        private Client walkIn = new Client();
        private ClientController _clientController;
        private RevenueController _revenueController;
        private fncControl Control;


        public frmGenerateInvoice()
        {
            InitializeComponent();
            Control = new fncControl();
            _clientController = ServiceLocator.GetService<ClientController>();
            _revenueController = ServiceLocator.GetService<RevenueController>();
            InitializeNewWalkIn();
        }

        private void InitializeNewWalkIn()
        {
            walkIn = new Client()
            {
                MembershipTypeId = 3,
                FullName = "",
                Email = "",
                PhoneNumber = "",
                Age = 0,
                Gender = "",
            };
        }

        private void CreateWalkInClient()
        {
            if (!ValidateInputFields())
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            walkIn.FullName = txtName.Text.Trim();
            walkIn.Email = txtEmail.Text.Trim();
            walkIn.PhoneNumber = txtPhoneNumber.Text.Trim();
            walkIn.Gender = cmbGender.Text.Trim();
            walkIn.Age = 99;

            // Send to controller to save walk-in client
            if (!_clientController.CreateNewWalkIn(walkIn))
            {
                return;
            }


            var newWalkIn = _revenueController.GeneratePendingMembership(walkIn);
            if (newWalkIn != null)
            {
                MessageBox.Show($"New Walk In {newWalkIn.member_name} Successfully Created", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Failed to create new walk in", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputFields()
        {
            return !string.IsNullOrWhiteSpace(txtName.Text)
                   && !string.IsNullOrWhiteSpace(txtEmail.Text)
                   && !string.IsNullOrWhiteSpace(txtPhoneNumber.Text)
                   && !string.IsNullOrWhiteSpace(cmbGender.Text);
        }


        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            CreateWalkInClient();
        }
    }
}