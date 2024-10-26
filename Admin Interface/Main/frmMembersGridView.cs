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
using System.Windows.Forms.VisualStyles;

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


        //Design para sa mga member type aron mo achop
        private void dgvMembers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvMembers.Columns[e.ColumnIndex].Name == "clmMembership")
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
