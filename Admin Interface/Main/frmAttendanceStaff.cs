using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

namespace csCY_Avenue.Admin_Interface
{
    public partial class frmAttendanceStaff : Form
    {
        private EmployeeController _employeeController;
        private List<EmployeeAttendance> _staffsAttendances = PreloadAttendanceData.All;
        private List<Employee> _staffs = PreloadData.Staffs;


        public frmAttendanceStaff()
        {
            InitializeComponent();
            _employeeController = ServiceLocator.GetService<EmployeeController>();
            LoadAttendanceGrid();
            LoadStaffsIntoComboBox();
        }

        //
        public void AutoLoadNewAttendance()
        {
            PreloadAttendanceData.PreLoadAttendanceAll();
            _staffsAttendances = PreloadAttendanceData.All;
            LoadAttendanceGrid();
        }

        // LOAD THIS SHIT
        public void LoadAttendanceGrid()
        {
            dgvStaffsAttendance.Rows.Clear(); // Clear the existing rows

            foreach (var staff in _staffsAttendances)
            {
                //Only add staff if their employeeType is "Manager" or "Staff"
                if (staff.employeeType == "Manager" || staff.employeeType == "Staff")
                {
                    int rowIndex = dgvStaffsAttendance.Rows.Add();
                    DataGridViewRow row = dgvStaffsAttendance.Rows[rowIndex];

                    row.Cells["clmName"].Value = staff.fullName;
                    row.Cells["clmType"].Value = staff.employeeType;
                    row.Cells["clmTimeIn"].Value = staff.checkInTime.ToString("yyyy MMMM dd");
                    row.Cells["clmTimeOut"].Value = staff.checkOutTime.ToString("h:mm:ss tt zz");
                    row.Cells["clmStatus"].Value = staff.attendanceStatus;
                }
            }
        }

        // LOAD FILTERED DATAGRID
        public void LoadFilteredAttendanceGrid(List<EmployeeAttendance> attendance)
        {
            dgvStaffsAttendance.Rows.Clear(); // Clear the existing rows

            foreach (var filtered in attendance)
            {
                //Only add staff if their employeeType is "Manager" or "Staff"
                if (filtered.employeeType == "Trainer" || filtered.employeeType == "Personal Trainer")
                {
                    int rowIndex = dgvStaffsAttendance.Rows.Add();
                    DataGridViewRow row = dgvStaffsAttendance.Rows[rowIndex];
                    
                    row.Cells["clmName"].Value = filtered.fullName;
                    row.Cells["clmType"].Value = filtered.employeeType;
                    row.Cells["clmTimeIn"].Value = filtered.checkInTime.ToString("yyyy MMMM dd");
                    row.Cells["clmTimeOut"].Value = filtered.checkOutTime.ToString("h:mm:ss tt zz");
                    row.Cells["clmStatus"].Value = filtered.attendanceStatus;
                }
            }
        }


        // FOR COMBO BOX OF EMPLOYEES <(X_X)>
        public void LoadStaffsIntoComboBox()
        {
            cmbStaffs.Items.Clear(); // Clear existing items
            cmbStaffs.Items.Add("ALL");
            foreach (var staff in _staffs)
            {
                // Only add staff if their employeeType is "Manager" or "Staff"
                if (staff.EmployeeTypeId == 1 || staff.EmployeeTypeId == 2)
                {
                    cmbStaffs.Items.Add(staff.FullName + " | " + staff.EmployeeId); // Add the name to ComboBox
                }
            }

            // Optionally select the first item
            if (cmbStaffs.Items.Count > 0)
            {
                cmbStaffs.SelectedIndex = 0;
            }
        }


        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            AttendanceStatus attendanceStatus;

            switch (true) // Using `true` to evaluate conditions
            {
                case bool _ when radPresent.Checked:
                    attendanceStatus = AttendanceStatus.PRESENT;
                    break;

                case bool _ when radLate.Checked:
                    attendanceStatus = AttendanceStatus.LATE;
                    break;

                case bool _ when radAbsent.Checked:
                    attendanceStatus = AttendanceStatus.ABSENT;
                    break;

                default:
                    // Handle the case where no radio button is checked if necessary
                    attendanceStatus = AttendanceStatus.ABSENT; // Default or error handling
                    break;
            }

            int employeeId = Convert.ToInt32(cmbStaffs.SelectedItem?.ToString().Split(" | ")[1]);
            if (!_employeeController.CreateEmployeeAttendanceExact(employeeId, dtTimeIn.Value, dtTimeOut.Value,
                    attendanceStatus))
            {
                return;
            }

            MessageBox.Show("New Attendance Marked");
            AutoLoadNewAttendance();
        }

        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            Console.Write(dtStaffAttendanceDate.Value.ToString());
            var filterAttendance = _employeeController.SearchAllAttendances(dtStaffAttendanceDate.Value, AttendanceType.ALL_DAILY);
            if (filterAttendance == null)
            {
                LoadFilteredAttendanceGrid(new List<EmployeeAttendance>());
                return;
            }
            LoadFilteredAttendanceGrid(filterAttendance);
        }
    }
}