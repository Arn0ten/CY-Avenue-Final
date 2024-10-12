using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using csCY_Avenue.Database;
using csCY_Avenue.Custom;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmAddClass : Form
    {
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;

        public frmAddClass()
        {
            InitializeComponent();
            globalProcedure = new GlobalProcedure(); 
            notificationService = new fncNotificationService(globalProcedure); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddClass_Load(object sender, EventArgs e)
        {
            LoadTrainers(); 
        }

        private void LoadTrainers()
        {
            // trainer list the ibutang sa dropdown sa addclass trainer
        }


        //Save
        private void btnSaveClass_Click_1(object sender, EventArgs e)
        {
            string className = txtClassName.Text;
            DateTime schedule = dtClassSchedule.Value;

            if (int.TryParse(txtClassCapacity.Text, out int capacity))
            {
                string trainer = cmbClassTrainer.SelectedItem?.ToString() ?? "Default Trainer";

                try
                {
                    MySqlCommand gProcCmd = globalProcedure.sqlCommand;
                    gProcCmd.CommandText = "prcAddClass";
                    gProcCmd.CommandType = CommandType.StoredProcedure;
                    gProcCmd.Parameters.Clear();
                    gProcCmd.Parameters.AddWithValue("@p_classname", className);
                    gProcCmd.Parameters.AddWithValue("@p_trainer", trainer);
                    gProcCmd.Parameters.AddWithValue("@p_schedule", schedule);
                    gProcCmd.Parameters.AddWithValue("@p_capacity", capacity);
                    globalProcedure.checkDatabaseConnection();
                    gProcCmd.ExecuteNonQuery();

                    MessageBox.Show($"Class '{className}' has been successfully added!",
                                    "Class Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    notificationService.AddNotification("Class Addition", $"New class '{className}' added.", className);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the class: {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for capacity.",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
