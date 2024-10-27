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
using MySqlX.XDevAPI;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmTrainerManagement : Form
    {
        private fncControl Control;

        // backend trainermana
        private EmployeeController employeeController;
        private List<Employee> trainers = PreloadData.Trainers;

        //Global procedure para sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        private frmNotifications _frmNotifications;
        public frmTrainerManagement()
        {
            InitializeComponent();
            Control = new fncControl();
            employeeController = ServiceLocator.GetService<EmployeeController>();
            dgvTrainer.SelectionChanged += dgvStaff_SelectionChanged;
            LoadDataGrid();

            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            _frmNotifications = new frmNotifications();
        }

        // MATCH LIST INDEX WITH DATAGRIDVIEW TABLE
        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTrainer.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTrainer.SelectedRows[0];  

                int membershipId = Convert.ToInt32(selectedRow.Cells["clmId"].Value);

                Employee selectedTrainer = trainers.FirstOrDefault(c => c.EmployeeId == membershipId);

                UpdateDetailsPanel(selectedRow, selectedTrainer);
            }
        }

        // UPDATE PANEL EVERY CLICK ROW
        private void UpdateDetailsPanel(DataGridViewRow row, Employee trainer)
        {
            // Update the controls that are part of the DataGridView
            lblTrainerFullname.Text = row.Cells["clmFullname"].Value?.ToString();

            txtTrainerID.Text = row.Cells["clmId"].Value?.ToString();
            txtTrainerFullname.Text = row.Cells["clmFullname"].Value?.ToString();
            txTrainerEmail.Text = row.Cells["clmEmail"].Value?.ToString();
            txtTrainerRole.Text = row.Cells["clmTrainerType"].Value?.ToString();

            // Update the extra controls using the Client object
            if (trainer != null)
            {
                txtTrainerPhoneNumber.Text = trainer.PhoneNumber ?? "";
                txtEditTrainerAge.Text = trainer.Age?.ToString();
                picTrainerPhoto.Image = trainer.ProfilePictureImage ?? null;
                dtTrainerBirthdate.Value = trainer.BirthDate ?? DateTime.Now;  
                picTrainerPhoto.Image = trainer.ProfilePictureImage ?? null;
            }
        }

        // LOAD TRAINER DATA TO DATAGRID
        private void LoadDataGrid()
        {
            dgvTrainer.Rows.Clear();
            foreach (var trainer in trainers)
            {
                int rowIndex = dgvTrainer.Rows.Add();
                DataGridViewRow row = dgvTrainer.Rows[rowIndex];

                row.Cells["clmId"].Value = trainer.EmployeeId;
                row.Cells["clmFullname"].Value = trainer.FullName;
                row.Cells["clmEmail"].Value = trainer.Email;
                row.Cells["clmPhoneNumber"].Value = trainer.PhoneNumber;
                row.Cells["clmTrainerType"].Value = trainer.EmployeeType;
            }
        }

        private void loadDataGridLive(Employee trainer)
        {
            int rowIndex = dgvTrainer.Rows.Add();
            DataGridViewRow row = dgvTrainer.Rows[rowIndex];

            row.Cells["clmId"].Value = trainer.EmployeeId;
            row.Cells["clmFullname"].Value = trainer.FullName;
            row.Cells["clmEmail"].Value = trainer.Email;
            row.Cells["clmPhoneNumber"].Value = trainer.PhoneNumber;
            row.Cells["clmTrainerType"].Value = trainer.EmployeeType;
        }

        private void UpdateDataGridLive(Employee employee, int staffId)
        {
            foreach (DataGridViewRow row in dgvTrainer.Rows)
            {
                if (Convert.ToInt32(row.Cells["clmId"].Value) == staffId)
                {

                    row.Cells["clmFullname"].Value = employee.FullName;
                    row.Cells["clmEmail"].Value = employee.Email;
                    row.Cells["clmPhoneNumber"].Value = employee.PhoneNumber;
                    row.Cells["clmTrainerType"].Value = employee.EmployeeType;

                    break;
                }
            }
        }




        private void frmTrainerManagement_Load(object sender, EventArgs e)
        {

        }

        //Add
        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            bool success = false;
            var FormAddTrainer = new frmAddTrainer(employeeController, success);
            Control.blurOverlay(FormAddTrainer);
            if (FormAddTrainer._success)
            {
                loadDataGridLive(FormAddTrainer._trainer);
                trainers.Add(FormAddTrainer._trainer);
            }
        }

        //Edit
        private void btnEditTrainer_Click(object sender, EventArgs e)
        {


            // Check if the StaffID is a valid integer
            if (!int.TryParse(txtTrainerID.Text, out int staffId))
            {
                MessageBox.Show("Invalid Staff ID");
                return;
            }

            var employeeIndex = trainers.FindIndex(emp => emp.EmployeeId == staffId);
            var employee = trainers[employeeIndex];

            // Open the edit form if employee exists
            bool success = false;
            var FormEditTrainer = new frmEditTrainer(employeeController, employee, success);
            Control.blurOverlay(FormEditTrainer);

            // success
            if (FormEditTrainer._success)
            {
                trainers[employeeIndex] = FormEditTrainer._trainer;
                UpdateDataGridLive(employee, staffId);
            }
        }
        private void btnDeleteTrainer_Click(object sender, EventArgs e)
        {
            // Step 1: Get the ID from the text box
            if (!int.TryParse(txtTrainerID.Text, out int staffId))
            {
                MessageBox.Show("Invalid Staff ID, try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation dialog
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete trainer '{txtTrainerFullname.Text}' with ID '{staffId}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Proceed only if the user confirmed
            if (result == DialogResult.Yes)
            {
                // Step 2: Try to delete from the database using the controller
                if (!employeeController.DeleteById(staffId))
                {
                    MessageBox.Show("Failed to delete the trainer from the database.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var employeeToRemove = trainers.FirstOrDefault(emp => emp.EmployeeId == staffId);
                if (employeeToRemove != null)
                {
                    trainers.Remove(employeeToRemove);
                }
                foreach (DataGridViewRow row in dgvTrainer.Rows)
                {
                    if (row.Cells["clmId"].Value != null && Convert.ToInt32(row.Cells["clmId"].Value) == staffId)
                    {
                        dgvTrainer.Rows.Remove(row);
                        break;
                    }
                }

                // Add notification
                notificationService.AddNotification("Trainer Deletion", $"Trainer '{txtTrainerFullname.Text}' has been successfully deleted!", txtTrainerFullname.Text);
                MessageBox.Show($"Trainer Deleted. Name: '{txtTrainerFullname.Text}' ID: '{txtTrainerID.Text}'",
                                "Trainer Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Trainer deletion canceled.", "Operation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearchTrainer_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchTrainer.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create an instance of GlobalProcedure
            GlobalProcedure globalProcedure = new GlobalProcedure();

            // Call the method to search for trainers
            DataTable trainerResults = globalProcedure.SearchTrainer(searchTerm);

            // Check if any results were found
            if (trainerResults == null || trainerResults.Rows.Count == 0)
            {
                MessageBox.Show("No trainers found matching the search term.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGrid();  
                return;
            }

            // Clear existing rows in the DataGridView
            dgvTrainer.Rows.Clear();

            // Populate the DataGridView with the search results
            foreach (DataRow row in trainerResults.Rows)
            {
                int rowIndex = dgvTrainer.Rows.Add();
                DataGridViewRow dataGridViewRow = dgvTrainer.Rows[rowIndex];

                dataGridViewRow.Cells["clmId"].Value = row["employee_id"]; 
                dataGridViewRow.Cells["clmFullname"].Value = row["full_name"]; 
                dataGridViewRow.Cells["clmEmail"].Value = row["email"];
                dataGridViewRow.Cells["clmPhoneNumber"].Value = row["phone_number"];
                dataGridViewRow.Cells["clmTrainerType"].Value = row["employee_type"];
            }
        }



    }
}
