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
using csCY_Avenue.Canedo.backend.entities;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmAttendanceMember : Form
    {
        private ClientController _clientController;
        private List<ClientAttendance> _clientAttendances = PreloadAttendanceData.ClientAllAttendance;
        private List<Client> _clients = PreloadData.Clients;


        public frmAttendanceMember()
        {
            InitializeComponent();
            _clientController = ServiceLocator.GetService<ClientController>();
            LoadAttendanceGrid();
            LoadStaffsIntoComboBox();
        }

        public void AutoLoadNewAttendance()
        {
            PreloadAttendanceData.PreLoadClientAttendance();
            _clientAttendances = PreloadAttendanceData.ClientAllAttendance;
            LoadAttendanceGrid();
        }

        public void LoadAttendanceGrid()
        {
            dgvMembersAttendance.Rows.Clear();

            Console.WriteLine("Loading attendance grid");
            foreach (var staff in _clientAttendances)
            {
                Console.WriteLine(staff.ToString());

                int rowIndex = dgvMembersAttendance.Rows.Add();
                DataGridViewRow row = dgvMembersAttendance.Rows[rowIndex];

                row.Cells["clmName"].Value = staff.ClientId;
                row.Cells["clmType"].Value = staff.ClientName;
                row.Cells["clmDate"].Value = staff.Date.ToString("MMMM, dd yyyy");
                row.Cells["clmTimeIn"].Value = staff.CheckInTime.ToString("h:mm:ss tt");
                row.Cells["clmStatus"].Value = staff.Status;
            }
        }

        // Filtered Shit
        public void LoadFilteredAttendanceGrid(List<ClientAttendance> attendance)
        {
            dgvMembersAttendance.Rows.Clear();

            foreach (var filtered in attendance)
            {
                int rowIndex = dgvMembersAttendance.Rows.Add();
                DataGridViewRow row = dgvMembersAttendance.Rows[rowIndex];

                row.Cells["clmName"].Value = filtered.ClientId;
                row.Cells["clmType"].Value = filtered.ClientName;
                row.Cells["clmDate"].Value = filtered.Date.ToString("MMMM, dd yyyy");
                row.Cells["clmTimeIn"].Value = filtered.CheckInTime.ToString("h:mm:ss tt");
                row.Cells["clmStatus"].Value = filtered.Status;
            }
        }


        // FOR COMBO BOX OF EMPLOYEES <(X_X)>
        public void LoadStaffsIntoComboBox()
        {
            cmbMembers.Items.Clear();
            cmbMembers.Items.Add("ALL");
            foreach (var staff in _clients)
            {
                if (staff.MembershipTypeId == 1 || staff.MembershipTypeId == 2)
                {
                    cmbMembers.Items.Add(staff);
                }
            }

            if (cmbMembers.Items.Count > 0)
            {
                cmbMembers.SelectedIndex = 0;
            }
        }


        //Attendance gridview color
        private void dgvMembersAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMembersAttendance.Columns[e.ColumnIndex].HeaderText == "Status" && e.Value != null)
            {
                string notificationType = e.Value.ToString();

                if (notificationType.Contains("PRESENT"))
                {
                    dgvMembersAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (notificationType.Contains("ABSENT"))
                {
                    dgvMembersAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else if (notificationType.Contains("LATE"))
                {
                    dgvMembersAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            // Check if a specific member is selected (not "ALL")
            if (cmbMembers.SelectedItem is Client selectedClient && selectedClient != null)
            {
                ClientAttendance clientAttendance = new ClientAttendance()
                {
                    ClientId = selectedClient.MembershipId,
                    ClientName = selectedClient.FullName,
                    Date = DateTime.Today,
                    CheckInTime = dtTimeIn.Value,
                    Status = "PRESENT"
                };
                
                Console.WriteLine(dtTimeIn.Value);

                if (!_clientController.CreateAttendance(clientAttendance))
                {
                    return;
                }

                MessageBox.Show($"Marked '{clientAttendance.Status}' to '{clientAttendance.ClientName}'",
                    "Marked Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoLoadNewAttendance();
            }
            else
            {
                MessageBox.Show("Please select a valid member.");
            }
        }


        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dtMemberAttendanceDate.Value.ToString("MMMM dd, yyyy"));
            var filteredAttendance = _clientController.SearchClientAttendanceByDay(dtMemberAttendanceDate.Value);
            if (!filteredAttendance.Any())
            {
                MessageBox.Show("No members attendance for this day");
            }

            LoadFilteredAttendanceGrid(filteredAttendance);
        }


        //Na pindot
        private void frmAttendanceMember_Load(object sender, EventArgs e)
        {
        }
    }
}