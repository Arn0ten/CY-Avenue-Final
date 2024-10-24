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
using csCY_Avenue.Custom;
using csCY_Avenue.Database;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmstaffManagement : Form
    {
        private fncControl Control;
        private EmployeeController _employeeController;
        private List<Employee> _employees = PreloadData.Staffs;

        //Global procedure para sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        private frmNotifications _frmNotifications;
        public frmstaffManagement()
        {
            InitializeComponent();
            Control = new fncControl();
            _employeeController = ServiceLocator.GetService<EmployeeController>();
            dgvStaff.SelectionChanged += dgvStaff_SelectionChanged;
            loadDataGrid();

            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            _frmNotifications = new frmNotifications();
        }

        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStaff.SelectedRows[0]; // Get the first selected row

                int membershipId = Convert.ToInt32(selectedRow.Cells["clmId"].Value);

                Employee selectedClient = _employees.FirstOrDefault(c => c.EmployeeId == membershipId);

                UpdateDetailsPanel(selectedRow, selectedClient);
            }
        }

        private void loadDataGrid()
        {
            dgvStaff.Rows.Clear();
            foreach (var employee in _employees)
            {
                int rowIndex = dgvStaff.Rows.Add();
                DataGridViewRow row = dgvStaff.Rows[rowIndex];

                row.Cells["clmId"].Value = employee.EmployeeId;
                row.Cells["clmFullname"].Value = employee.FullName;
                row.Cells["clmEmail"].Value = employee.Email;
                row.Cells["clmPhoneNumber"].Value = employee.PhoneNumber;
                row.Cells["clmEmployeeType"].Value = employee.EmployeeType;
                row.Cells["clmSalary"].Value = employee.Salary;
            }
        }

        private void loadDataGridLive(Employee employee)
        {
            int rowIndex = dgvStaff.Rows.Add();
            DataGridViewRow row = dgvStaff.Rows[rowIndex];

            row.Cells["clmId"].Value = employee.EmployeeId;
            row.Cells["clmFullname"].Value = employee.FullName;
            row.Cells["clmEmail"].Value = employee.Email;
            row.Cells["clmPhoneNumber"].Value = employee.PhoneNumber;
            row.Cells["clmEmployeeType"].Value = employee.EmployeeType;
            row.Cells["clmSalary"].Value = employee.Salary;
        }

        private void UpdateDataGridLive(Employee employee, int staffId)
        {
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                if (Convert.ToInt32(row.Cells["clmId"].Value) == staffId)
                {
                  
                    row.Cells["clmFullname"].Value = employee.FullName;
                    row.Cells["clmEmail"].Value = employee.Email;
                    row.Cells["clmPhoneNumber"].Value = employee.PhoneNumber;
                    row.Cells["clmEmployeeType"].Value = employee.EmployeeType;
                    row.Cells["clmSalary"].Value = employee.Salary;

                    break; 
                }
            }
        }


        // UPDATE PANEL EVERY CLICK ROW
        private void UpdateDetailsPanel(DataGridViewRow row, Employee employee)
        {
            // Update the controls that are part of the DataGridView
            lblStaffFullname.Text = row.Cells["clmFullname"].Value?.ToString();

            txtStaffID.Text = row.Cells["clmId"].Value?.ToString();
            txtStaffFullname.Text = row.Cells["clmFullname"].Value?.ToString();
            txtStaffEmail.Text = row.Cells["clmEmail"].Value?.ToString();
            txtStaffRole.Text = row.Cells["clmEmployeeType"].Value?.ToString();

            // Update the extra controls using the Client object
            if (employee != null)
            {
                txtStaffPhoneNumber.Text = employee.PhoneNumber ?? "";
                txtStaffGender.Text = employee.Gender;
                txtStaffAge.Text = employee.Age?.ToString();
                picStaffPhoto.Image = employee.ProfilePictureImage ?? null;
                dtStaffBirthdate.Value = employee.BirthDate ?? DateTime.Now; // Set to the current date if null
                picStaffPhoto.Image = employee.ProfilePictureImage ?? null;
            }
        }


        private void frmstaffManagement_Load(object sender, EventArgs e)
        {
        }

        //Add
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            bool success = false;
            var FormAddStaff = new frmAddStaff(employee, success);
            Control.blurOverlay(FormAddStaff);

            if (FormAddStaff._success)
            {
                loadDataGridLive(FormAddStaff._employee);
                _employees.Add(FormAddStaff._employee);
            }
        }

        //Edit
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            // Check if the StaffID is a valid integer
            if (!int.TryParse(txtStaffID.Text, out int staffId))
            {
                MessageBox.Show("Invalid Staff ID");
                return;
            }

            var employeeIndex = _employees.FindIndex(emp => emp.EmployeeId == staffId);
            var employee = _employees[employeeIndex];

            // Open the edit form if employee exists
            bool success = false;
            var formEditStaff = new frmEditStaff(_employeeController, employee, success);
            Control.blurOverlay(formEditStaff);

            // success
            if (formEditStaff._success)
            {
                _employees[employeeIndex] = formEditStaff._employee;
                UpdateDataGridLive(employee, staffId);
            }
        }

        //Delete
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            // Step 1: Get the ID from the text box
            if (!int.TryParse(txtStaffID.Text, out int staffId))
            {
                MessageBox.Show("Invalid Staff ID, try again.");
                return;
            }

            // Step 2: Try to delete from the database using the controller
            if (!_employeeController.DeleteById(staffId))
            {
                return;
            }

            // Step 3: Find the object in the list by its ID
            var employeeToRemove = _employees.FirstOrDefault(emp => emp.EmployeeId == staffId);
            if (employeeToRemove != null)
            {
                _employees.Remove(employeeToRemove);
            }

            // Step 5: Remove the corresponding row in the DataGridView
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                if (row.Cells["clmId"].Value != null && Convert.ToInt32(row.Cells["clmId"].Value) == staffId)
                {
                    dgvStaff.Rows.Remove(row);
                    break;
                }
            }

            //Add notif
            notificationService.AddNotification("Staff Deletion", $"Staff  '{txtStaffFullname.Text}' has been successfully deleted!  ", txtStaffFullname.Text);
            MessageBox.Show($"Staff Deleted. Name: '{txtStaffFullname.Text}' ID: '{txtStaffID.Text}'",
                    "Staff Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Na pindot
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}