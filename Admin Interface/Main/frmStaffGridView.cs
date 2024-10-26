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
    public partial class frmStaffGridView : Form
    {
        private List<Employee> employees = PreloadData.Staffs;


        public frmStaffGridView()
        {
            InitializeComponent();
            Load += frmMembersGridView_Load;
        }


        private void frmMembersGridView_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            dgvStaffs.Rows.Clear();
            foreach (var staff in employees)
            {
                int rowIndex = dgvStaffs.Rows.Add();
                DataGridViewRow row = dgvStaffs.Rows[rowIndex];

                row.Cells["clmFullName"].Value = staff.FullName;
                row.Cells["clmEmail"].Value = staff.Email;
                row.Cells["clmPhoneNumber"].Value = staff.PhoneNumber;
                row.Cells["clmEmployeeType"].Value = staff.EmployeeType;
                row.Cells["clmSalary"].Value = staff.Salary?.ToString();
            }
        }
    }
}