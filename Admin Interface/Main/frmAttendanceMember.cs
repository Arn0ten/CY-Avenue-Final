using System;
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
    public partial class frmAttendanceMember : Form
    {
        public frmAttendanceMember()
        {
            InitializeComponent();
            dgvMembersAttendance.CellFormatting += dgvMembersAttendance_CellFormatting;
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

        //Na pindot
        private void frmAttendanceMember_Load(object sender, EventArgs e)
        {

        }
    }
}
