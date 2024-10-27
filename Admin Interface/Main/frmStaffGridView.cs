using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            Load += frmStaffGridView_Load; // Corrected the event handler name
        }

        private void frmStaffGridView_Load(object sender, EventArgs e)
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

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchStaff.Text.ToLower(); // Assuming you have a TextBox named txtSearchStaff
            var filteredStaffs = employees.Where(staff => staff.FullName.ToLower().Contains(searchTerm)).ToList();

            dgvStaffs.Rows.Clear(); // Clear existing rows before adding filtered data
            foreach (var staff in filteredStaffs)
            {
                int rowIndex = dgvStaffs.Rows.Add();
                DataGridViewRow row = dgvStaffs.Rows[rowIndex];

                row.Cells["clmFullName"].Value = staff.FullName;
                row.Cells["clmEmail"].Value = staff.Email;
                row.Cells["clmPhoneNumber"].Value = staff.PhoneNumber;
                row.Cells["clmEmployeeType"].Value = staff.EmployeeType;
                row.Cells["clmSalary"].Value = staff.Salary?.ToString();
            }

            if (filteredStaffs.Count == 0)
            {
                MessageBox.Show("No staff members found matching that name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
