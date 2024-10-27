using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.client;
using CarlosYulo.backend.monolith.employee;
using CarlosYulo.preload;
using csCY_Avenue.Custom;
using csCY_Avenue.Database;
using MySql.Data.MySqlClient;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmMemberManagement : Form
    {
        private fncControl Control;
        private ClientController _clientController;
        private List<Client> clients = PreloadData.Clients;

        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        private frmNotifications _frmNotifications;

        public frmMemberManagement()
        {
            InitializeComponent();
            Control = new fncControl();
            _clientController = ServiceLocator.GetService<ClientController>();
            dgvMember.SelectionChanged += dgvMember_SelectionChanged;

            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            _frmNotifications = new frmNotifications();
            LoadDataGrid();
        }

        private void dgvMember_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMember.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMember.SelectedRows[0];
                int membershipId = Convert.ToInt32(selectedRow.Cells["clmId"].Value);
                Client selectedClient = clients.FirstOrDefault(c => c.MembershipId == membershipId);
                UpdateDetailsPanel(selectedRow, selectedClient);
            }
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
        }

        private void LoadDataGrid()
        {
            dgvMember.Rows.Clear();
            HashSet<int> existingMembershipIds = new HashSet<int>();

            foreach (var client in clients)
            {
                if (!existingMembershipIds.Add(client.MembershipId))
                    continue;

                int rowIndex = dgvMember.Rows.Add();
                DataGridViewRow row = dgvMember.Rows[rowIndex];
                row.Cells["clmId"].Value = client.MembershipId;
                row.Cells["clmFullname"].Value = client.FullName;
                row.Cells["clmEmail"].Value = client.Email;
                row.Cells["clmMembershipType"].Value = client.Membership;
                row.Cells["clmStatus"].Value = client.MembershipStatus;
                row.Cells["clmExpireAt"].Value = client.MembershipEnd?.ToString("MMMM dd, yyyy");
            }
        }

        private void loadDataGridLive(Client client)
        {
            if (dgvMember.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToInt32(row.Cells["clmId"].Value) == client.MembershipId))
                return;

            int rowIndex = dgvMember.Rows.Add();
            DataGridViewRow row = dgvMember.Rows[rowIndex];
            row.Cells["clmId"].Value = client.MembershipId;
            row.Cells["clmFullname"].Value = client.FullName;
            row.Cells["clmEmail"].Value = client.Email;
            row.Cells["clmMembershipType"].Value = client.Membership;
            row.Cells["clmStatus"].Value = client.MembershipStatus;
            row.Cells["clmExpireAt"].Value = client.MembershipEnd?.ToString("MMMM dd, yyyy");
        }

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
                    row.Cells["clmExpireAt"].Value = client.MembershipEnd?.ToString("MMMM dd, yyyy");
                    break;
                }
            }
        }

        private void UpdateDetailsPanel(DataGridViewRow row, Client client)
        {
            lblName.Text = row.Cells["clmFullname"].Value?.ToString();
            txtMembershipID.Text = row.Cells["clmId"].Value?.ToString();
            txtMemberFullname.Text = row.Cells["clmFullname"].Value?.ToString();
            txtMemberEmail.Text = row.Cells["clmEmail"].Value?.ToString();
            btnMemberType.Text = row.Cells["clmMembershipType"].Value?.ToString();

            if (DateTime.TryParse(row.Cells["clmExpireAt"].Value?.ToString(), out DateTime expireAt))
                dtMembershipEnd.Value = expireAt;
            else
                dtMembershipEnd.Value = DateTime.Now;

            if (client != null)
            {
                dtMemberBirthdate.Text = client.BirthDate?.ToString("MMMM dd, yyyy");
                dtMembershipStart.Text = client.MembershipStart?.ToString("MMMM dd, yyyy");
                txtMemberPhoneNumber.Text = client.PhoneNumber ?? "";
                txtMemberGender.Text = client.Gender;
                txtMemberAge.Text = client.Age?.ToString();
                picMemberPhoto.Image = client.ProfilePictureImage ?? null;
            }
        }

        private void btnAddMember_Click_1(object sender, EventArgs e)
        {
            Client _newClient = new Client();
            bool success = false;
            var FormAddMember = new frmAddMember(_clientController, _newClient, success);
            Control.blurOverlay(FormAddMember);

            if (FormAddMember._success)
            {
                loadDataGridLive(FormAddMember._newClient);
                clients.Add(FormAddMember._newClient);
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            _clientController.DeleteAllExpired(ClientDeleteType.WALK_IN);
            clients = PreloadData.Clients;
            LoadDataGrid();

          
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMembershipID.Text, out int membershipId))
            {
                MessageBox.Show("Invalid membership ID");
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

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchMember.Text.Trim();

            GlobalProcedure globalProcedure = new GlobalProcedure();

            DataTable searchResults = globalProcedure.SearchClient(searchTerm);

            dgvMember.Rows.Clear();

            foreach (DataRow row in searchResults.Rows)
            {
                int rowIndex = dgvMember.Rows.Add();
                dgvMember.Rows[rowIndex].Cells["clmId"].Value = row["id"];
                dgvMember.Rows[rowIndex].Cells["clmFullname"].Value = row["full_name"];
                dgvMember.Rows[rowIndex].Cells["clmEmail"].Value = row["email"];
                dgvMember.Rows[rowIndex].Cells["clmMembershipType"].Value = row["type"];
                dgvMember.Rows[rowIndex].Cells["clmExpireAt"].Value =
                    row["expire_at"] == DBNull.Value ? null : Convert.ToDateTime(row["expire_at"]).ToString("MMMM dd, yyyy");
                dgvMember.Rows[rowIndex].Cells["clmStatus"].Value = row["status"];
            }

            // Optionally inform the user if no results were found
            if (searchResults.Rows.Count == 0)
            {
                MessageBox.Show("No members found matching the search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }






        private void dgvMember_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMember.Columns[e.ColumnIndex].Name == "clmMembershipType" && e.Value != null)
            {
                e.CellStyle.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                switch (e.Value.ToString())
                {
                    case "VIP":
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        break;
                    case "Regular":
                        e.CellStyle.ForeColor = Color.DarkBlue;
                        break;
                    case "Basic":
                        e.CellStyle.ForeColor = Color.DarkBlue;
                        break;
                    case "Walk-in":
                        e.CellStyle.ForeColor = Color.Gray;
                        break;
                    default:
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }
    }
}
