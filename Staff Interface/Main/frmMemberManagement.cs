using csCY_Avenue.Admin_Interface.Main;
using csCY_Avenue.Custom;
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
using CarlosYulo.preload;
using csCY_Avenue.Database;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmMemberManagement : Form
    {
        fncControl Control;
        private ClientController _clientController;
        private List<Client> clients = PreloadData.Clients;

        //Global procedure para sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        private frmNotifications _frmNotifications;


        public frmMemberManagement()
        {
            InitializeComponent();
            Control = new fncControl();

            _clientController = ServiceLocator.GetService<ClientController>();
            dgvMember.SelectionChanged += dgvMember_SelectionChanged;

            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            _frmNotifications = new frmNotifications();
            Load += frmCustomerManagement_Load;
        }

        // MATCH LIST INDEX WITH DATAGRIDVIEW TABLE
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
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            dgvMember.Rows.Clear();
            HashSet<int> existingMembershipIds = new HashSet<int>();

            foreach (var client in clients)
            {
                if (!existingMembershipIds.Add(client.MembershipId))
                {
                    continue;
                }

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

        private void loadDataGridLive(Client client)
        {
            if (dgvMember.Rows.Cast<DataGridViewRow>()
                .Any(row => Convert.ToInt32(row.Cells["clmId"].Value) == client.MembershipId))
            {
                return;
            }

            int rowIndex = dgvMember.Rows.Add();
            DataGridViewRow row = dgvMember.Rows[rowIndex];

            row.Cells["clmId"].Value = client.MembershipId;
            row.Cells["clmFullname"].Value = client.FullName;
            row.Cells["clmEmail"].Value = client.Email;
            row.Cells["clmMembershipType"].Value = client.Membership;
            row.Cells["clmStatus"].Value = client.MembershipStatus;
            row.Cells["clmExpireAt"].Value = client.MembershipEnd?.ToString("MMMM/dd/yy");
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
                dtMembershipEnd.Value = DateTime.Now;
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

        //Add
        private void btnAddMember_Click(object sender, EventArgs e)
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

        //Edit
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
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
        }

        //Delete
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMember.Columns[e.ColumnIndex].Name == "clmMembershipType")
            {
                if (e.Value != null)
                {
                    string cellValue = e.Value.ToString();
                    e.CellStyle.Font = new Font("Nirmala UI", 10, FontStyle.Bold);


                    switch (cellValue)
                    {
                        case "VIP":
                            e.CellStyle.ForeColor = Color.DarkOrange;
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
}