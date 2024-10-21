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
using CarlosYulo.backend.monolith.employee;
using CarlosYulo.preload;
using csCY_Avenue.Custom;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmMemberManagement : Form
    {
        private fncControl Control;
        private ClientController _clientController;

        private List<Client> clients = PreloadData.Clients;

        public frmMemberManagement()
        {
            InitializeComponent();
            Control = new fncControl();

            _clientController = ServiceLocator.GetService<ClientController>();

            dgvMember.SelectionChanged += dgvMember_SelectionChanged;
            LoadDataGrid();
        }

        // MATCH LIST INDEX WITH DATAGRIDVIEW TABLE
        private void dgvMember_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMember.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMember.SelectedRows[0]; // Get the first selected row

                int membershipId = Convert.ToInt32(selectedRow.Cells["clmId"].Value);

                Client selectedClient = clients.FirstOrDefault(c => c.MembershipId == membershipId);

                UpdateDetailsPanel(selectedRow, selectedClient);
            }
        }

        // LOAD DATA
        private void LoadDataGrid()
        {
            dgvMember.Rows.Clear();
            foreach (var client in clients)
            {
                int rowIndex = dgvMember.Rows.Add();
                DataGridViewRow row = dgvMember.Rows[rowIndex];

                row.Cells["clmId"].Value = client.MembershipId;
                row.Cells["clmFullname"].Value = client.FullName;
                row.Cells["clmEmail"].Value = client.Email;
                row.Cells["clmMembershipType"].Value = client.Membership;
                row.Cells["clmStatus"].Value = client.MembershipStatus;
                row.Cells["clmExpireAt"].Value = client.MembershipEnd?.ToString("MMMM/dd/yy");
            }
        }

        // UPDATE DATA
        private void UpdateDataGridLive(Client client, int membershipId)
        {
            foreach (DataGridViewRow row in dgvMember.Rows)
            {
                if (Convert.ToInt32(row.Cells["clmId"].Value) == membershipId)
                {
                    row.Cells["clmId"].Value = client.MembershipId;
                    row.Cells["clmFullname"].Value = client.FullName;
                    row.Cells["clmEmail"].Value = client.Email;
                    row.Cells["clmMembershipType"].Value = client.Membership;
                    row.Cells["clmStatus"].Value = client.MembershipStatus;
                    row.Cells["clmExpireAt"].Value = client.MembershipEnd?.ToString("MMMM/dd/yy");

                    break;
                }
            }
        }


        // UPDATE PANEL EVERY CLICK ROW
        private void UpdateDetailsPanel(DataGridViewRow row, Client client)
        {
            // Update the controls that are part of the DataGridView
            txtMembershipID.Text = row.Cells["clmId"].Value?.ToString();
            txtMemberFullname.Text = row.Cells["clmFullname"].Value?.ToString();
            txtMemberEmail.Text = row.Cells["clmEmail"].Value?.ToString();
            btnMemberType.Text = row.Cells["clmMembershipType"].Value?.ToString();

            if (DateTime.TryParse(row.Cells["clmExpireAt"].Value?.ToString(), out DateTime expireAt))
            {
                dtMembershipEnd.Value = expireAt;
            }
            else
            {
                dtMembershipEnd.Value = DateTime.Now; // Default date
            }

            // Update the extra controls using the Client object
            if (client != null)
            {
                dtMemberBirthdate.Text = client.BirthDate?.ToString("MMMM/dd/yy");
                dtMembershipStart.Text = client.MembershipStart?.ToString("MMMM/dd/yy");
                txtMemberPhoneNumber.Text = client.PhoneNumber ?? "";
                txtMemberGender.Text = client.Gender;
                txtMemberAge.Text = client.Age?.ToString();
                picMemberPhoto.Image = client.ProfilePictureImage ?? null;
            }
        }


        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
        }

        // Add
        private void btnAddMember_Click_1(object sender, EventArgs e)
        {
            var FormAddMember = new frmAddMember();
            Control.blurOverlay(FormAddMember);
        }

        //Delete
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            // Step 2: Try to delete from the database using the controller
            _clientController.DeleteAllExpired(ClientDeleteType.WALK_IN);
            clients = PreloadData.Clients;
            LoadDataGrid();
        }


        // Edit 
        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMembershipID.Text, out int membershipId))
            {
                MessageBox.Show("Invalid membershipship ID");
                return;
            }

            var clientIndex = clients.FindIndex(emp => emp.MembershipId == membershipId);
            var client = clients[clientIndex];

            bool success = false;
            var FormEditMember = new frmEditMember(_clientController, client, success);
            Control.blurOverlay(FormEditMember);

            if (FormEditMember._success)
            {
                clients[clientIndex] = FormEditMember._client;
                UpdateDataGridLive(client, membershipId);
            }
        }

        //Search


        //Display


        //Na pindot
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}