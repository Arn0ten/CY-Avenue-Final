using CarlosYulo.backend;
using CarlosYulo.preload;
using csCY_Avenue.Custom;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmMembersGridView : Form
    {
        fncControl Control;
        private List<Client> Members = PreloadData.Members;

        public frmMembersGridView()
        {
            InitializeComponent();
            Control = new fncControl();
            Load += frmMembersGridView_Load; // Ensure Load event is wired up
        }

        private void frmMembersGridView_Load(object sender, EventArgs e)
        {
            UpdateMemberGrid();
        }

        private void UpdateMemberGrid()
        {
            dgvMembers.Rows.Clear();
            foreach (var client in Members)
            {
                int rowIndex = dgvMembers.Rows.Add();
                DataGridViewRow row = dgvMembers.Rows[rowIndex];

                row.Cells["clmName"].Value = client.FullName;
                row.Cells["clmEmail"].Value = client.Email;
                row.Cells["clmPhonenumber"].Value = client.PhoneNumber;
                row.Cells["clmMembership"].Value = client.Membership;
                row.Cells["clmStatus"].Value = client.MembershipStatus;
            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchMember.Text.Trim();
            SearchMembers(searchTerm);
        }

        private void SearchMembers(string searchTerm)
        {
            dgvMembers.Rows.Clear();

            var filteredMembers = Members
                .Where(client => client.FullName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            foreach (var client in filteredMembers)
            {
                int rowIndex = dgvMembers.Rows.Add();
                DataGridViewRow row = dgvMembers.Rows[rowIndex];

                row.Cells["clmName"].Value = client.FullName;
                row.Cells["clmEmail"].Value = client.Email;
                row.Cells["clmPhonenumber"].Value = client.PhoneNumber;
                row.Cells["clmMembership"].Value = client.Membership;
                row.Cells["clmStatus"].Value = client.MembershipStatus;
            }

            // Optional: Notify user if no results are found
            if (filteredMembers.Count == 0)
            {
                MessageBox.Show("No members found matching that name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Cell formatting for membership types
        private void dgvMembers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMembers.Columns[e.ColumnIndex].Name == "clmMembership" && e.Value != null)
            {
                string cellValue = e.Value.ToString();
                e.CellStyle.Font = new Font("Nirmala UI", 10, FontStyle.Bold);

                switch (cellValue)
                {
                    case "VIP":
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        break;
                    case "Regular":
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
