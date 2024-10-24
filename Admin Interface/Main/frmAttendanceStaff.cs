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
            dgvStaffsAttendance.CellFormatting += dgvStaffsAttendance_CellFormatting;
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
            dgvStaffsAttendance.Rows.Clear();

            Console.WriteLine("Loading attendance grid");
            foreach (var staff in _staffsAttendances)
            {
                Console.WriteLine(staff.ToString());
                
                
                //Only add staff if their employeeType is "Manager" or "Staff"
                if (staff.employeeType == "Manager" || staff.employeeType == "Staff")
                {
                    int rowIndex = dgvStaffsAttendance.Rows.Add();
                    DataGridViewRow row = dgvStaffsAttendance.Rows[rowIndex];

                    row.Cells["clmName"].Value = staff.fullName;
                    row.Cells["clmType"].Value = staff.employeeType;
                    row.Cells["clmDate"].Value = staff.date.ToString("MMMM, dd yyyy");
                    row.Cells["clmTimeIn"].Value = staff.checkInTime.ToString("h:mm:ss tt zz");
                    row.Cells["clmTimeOut"].Value = staff.checkOutTime.ToString("h:mm:ss tt zz");
                    row.Cells["clmStatus"].Value = staff.attendanceStatus;
                }
            }
        }

        // LOAD FILTERED DATAGRID
        public void LoadFilteredAttendanceGrid(List<EmployeeAttendance> attendance)
        {
            dgvStaffsAttendance.Rows.Clear(); 

            foreach (var filtered in attendance)
            {
                if (filtered.employeeType == "Manager" || filtered.employeeType == "Staff")
                {
                    int rowIndex = dgvStaffsAttendance.Rows.Add();
                    DataGridViewRow row = dgvStaffsAttendance.Rows[rowIndex];
                    
                    row.Cells["clmName"].Value = filtered.fullName;
                    row.Cells["clmType"].Value = filtered.employeeType;
                    row.Cells["clmDate"].Value = filtered.date.ToString("MMMM, dd yyyy");
                    row.Cells["clmTimeIn"].Value = filtered.checkInTime.ToString("yyyy MMMM dd");
                    row.Cells["clmTimeOut"].Value = filtered.checkOutTime.ToString("h:mm:ss tt zz");
                    row.Cells["clmStatus"].Value = filtered.attendanceStatus;
                }
            }
        }


        // FOR COMBO BOX OF EMPLOYEES <(X_X)>
        public void LoadStaffsIntoComboBox()
        {
            cmbStaffs.Items.Clear(); 
            cmbStaffs.Items.Add("ALL");
            foreach (var staff in _staffs)
            {
                if (staff.EmployeeTypeId == 1 || staff.EmployeeTypeId == 2)
                {
                    cmbStaffs.Items.Add(staff.FullName + " | " + staff.EmployeeId);
                }
            }
            if (cmbStaffs.Items.Count > 0)
            {
                cmbStaffs.SelectedIndex = 0;
            }
        }


        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            AttendanceStatus attendanceStatus;

            switch (true) 
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
                    attendanceStatus = AttendanceStatus.ABSENT;
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
            if (filterAttendance is null)
            {
                LoadFilteredAttendanceGrid(new List<EmployeeAttendance>());
                return;
            }
            LoadFilteredAttendanceGrid(filterAttendance);
        }


        //Attendncae gridview color
        private void dgvStaffsAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStaffsAttendance.Columns[e.ColumnIndex].HeaderText == "Status" && e.Value != null)
            {
                string notificationType = e.Value.ToString();

                if (notificationType.Contains("PRESENT"))
                {
                    dgvStaffsAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (notificationType.Contains("ABSENT"))
                {
                    dgvStaffsAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else if (notificationType.Contains("LATE"))
                {
                    dgvStaffsAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }
    }
}