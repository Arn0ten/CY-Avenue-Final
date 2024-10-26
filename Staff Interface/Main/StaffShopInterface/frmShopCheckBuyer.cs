using csCY_Avenue.Custom;
using csCY_Avenue.Staff_Interface.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo.backend;
using CarlosYulo.preload;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmShopCheckBuyer : Form
    {
        fncControl Control;
        private List<Client> members = PreloadData.Members;


        public frmShopCheckBuyer()
        {
            InitializeComponent();
            Control = new fncControl();
            Load += frmMembers_Load;
            members = PreloadData.Members;
            
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadItemDataGrid();
        }

        private void LoadItemDataGrid()
        {
            dgvMember.Rows.Clear();
            foreach (var _members in members)
            {
                int rowIndex = dgvMember.Rows.Add();
                DataGridViewRow row = dgvMember.Rows[rowIndex];

                row.Cells["clmMemberId"].Value = _members.MembershipId;
                row.Cells["clmName"].Value = _members.FullName;
                row.Cells["clmMembershipType"].Value = _members.Membership;
                row.Cells["clmStatus"].Value = _members.MembershipStatus;
            }
        }


        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (dgvMember.SelectedRows.Count > 0)
            {
                var selectedRow = dgvMember.SelectedRows[0];
                string membershipType = selectedRow.Cells["clmMembershipType"].Value?.ToString();

                bool isVIP = string.Equals(membershipType, "VIP", StringComparison.OrdinalIgnoreCase);

                this.Close();
                Console.WriteLine(isVIP);
                var FormBuyItem = new frmShopBuyItem(isVIP);
                Control.blurOverlay(FormBuyItem);
            }
            else
            {
                MessageBox.Show("Please select a member from the list.");
            }
        }
    }
}