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
using CarlosYulo.backend.monolith.employee;
using CarlosYulo.preload;

namespace csCY_Avenue.Admin_Interface
{
    public partial class frmAttendanceTrainer : Form
    {
        private EmployeeController _employeeController;
        private List<EmployeeAttendance> _staffs = PreloadAttendanceData.All;
        private List<Employee> _trainers = PreloadData.Trainers;


        public frmAttendanceTrainer()
        {
            InitializeComponent();
            _employeeController = ServiceLocator.GetService<EmployeeController>();
            LoadAttendanceGrid();
            LoadTrainersIntoComboBox();
        }

        // AUTO LOAD DATA AFTER WHATEVER SHIT
        public void AutoLoadNewAttendance()
        {
            PreloadAttendanceData.PreLoadAttendanceAll();
            _staffs = PreloadAttendanceData.All;
            LoadAttendanceGrid();
        }


        // LOAD DATAGRID
        public void LoadAttendanceGrid()
        {
            dgvTrainersAttendance.Rows.Clear(); // Clear the existing rows

            foreach (var staff in _staffs)
            {
                //Only add staff if their employeeType is "Manager" or "Staff"
                if (staff.employeeType == "Trainer" || staff.employeeType == "Personal Trainer")
                {
                    int rowIndex = dgvTrainersAttendance.Rows.Add();
                    DataGridViewRow row = dgvTrainersAttendance.Rows[rowIndex];

                    row.Cells["clmName"].Value = staff.fullName;
                    row.Cells["clmType"].Value = staff.employeeType;
                    row.Cells["clmDate"].Value = staff.date.ToString("MMMM, dd yyyy");
                    row.Cells["clmTimeIn"].Value = staff.checkInTime.ToString("yyyy MMMM dd");
                    row.Cells["clmTimeOut"].Value = staff.checkOutTime.ToString("h:mm:ss tt zz");
                    row.Cells["clmStatus"].Value = staff.attendanceStatus;
                }
            }
        }

        // LOAD FILTERED DATAGRID
        public void LoadFilteredAttendanceGrid(List<EmployeeAttendance> attendance)
        {
            dgvTrainersAttendance.Rows.Clear(); // Clear the existing rows

            foreach (var filtered in attendance)
            {
                //Only add staff if their employeeType is "Manager" or "Staff"
                if (filtered.employeeType == "Trainer" || filtered.employeeType == "Personal Trainer")
                {
                    int rowIndex = dgvTrainersAttendance.Rows.Add();
                    DataGridViewRow row = dgvTrainersAttendance.Rows[rowIndex];

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
        public void LoadTrainersIntoComboBox()
        {
            cmbTrainers.Items.Clear(); // Clear existing items
            cmbTrainers.Items.Add("ALL");
            foreach (var trainer in _trainers)
            {
                // Only add staff if their employeeType is "Manager" or "Staff"
                if (trainer.EmployeeTypeId == 3 || trainer.EmployeeTypeId == 4)
                {
                    cmbTrainers.Items.Add(trainer.FullName + " | " + trainer.EmployeeId); // Add the name to ComboBox
                }
            }

            // Optionally select the first item
            if (cmbTrainers.Items.Count > 0)
            {
                cmbTrainers.SelectedIndex = 0;
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

            int employeeId = Convert.ToInt32(cmbTrainers.SelectedItem?.ToString().Split(" | ")[1]);
            if (!_employeeController.CreateEmployeeAttendanceExact(employeeId, dtTimeIn.Value, dtTimeOut.Value,
                    attendanceStatus))
            {
                return;
            }

            MessageBox.Show("New Attendance Marked");
            AutoLoadNewAttendance();
        }

        private void btnDateFilterTrainer_Click(object sender, EventArgs e)
        {
            Console.Write(dtTrainerAttendanceDate.Value.ToString());
            var filterAttendance =
                _employeeController.SearchAllAttendances(dtTrainerAttendanceDate.Value, AttendanceType.ALL_DAILY);
            if (filterAttendance == null)
            {
                LoadFilteredAttendanceGrid(new List<EmployeeAttendance>());
                return;
            }
            LoadFilteredAttendanceGrid(filterAttendance);
        }
    }
}