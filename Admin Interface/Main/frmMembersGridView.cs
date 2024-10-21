using CarlosYulo.backend;
using CarlosYulo.preload;
using csCY_Avenue.Custom;
using System;
using System.Collections;
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
    public partial class frmMembersGridView : Form
    {
        fncControl Control;
        private List<Client> Members = PreloadData.Members;
        private List<Client> Clients = PreloadData.Clients;

        public frmMembersGridView()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void frmMembersGridView_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
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

        //Button sa gridview
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMembers.Columns["clmRenew"].Index && e.RowIndex >= 0)
            {
                // Get the corresponding Client from the row
                var selectedClient = Members[e.RowIndex];

                // Pass the client to the frmRenewMember form
                var FormRenewMember = new frmRenewMember();

                // Show the form with blur effect (as per your code)
                Control.blurOverlay(FormRenewMember);
            }

        }
    }
}
