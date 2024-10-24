using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csCY_Avenue.Custom;
using System;
using System.Collections.Generic;
using csCY_Avenue.Database;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmNotifications : Form
    {
        private fncNotificationService notificationService;
        private GlobalProcedure globalProcedure;

        public frmNotifications()
        {
            InitializeComponent();
            dgvNotification.CellClick += dgvNotification_CellClick;
            dgvNotification.CellFormatting += dgvNotification_CellFormatting;

            globalProcedure = new GlobalProcedure();
            if (globalProcedure.fncConnectToDatabase())
            {
                notificationService = new fncNotificationService(globalProcedure);
                LoadNotifications();
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.");
            }
        }

        private void frmNotifications_Load(object sender, EventArgs e)
        {
            LoadNotifications();
        }

        private void dgvNotification_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNotification.Columns[e.ColumnIndex].HeaderText == "Notification Type" && e.Value != null)
            {
                string notificationType = e.Value.ToString();

                // Check if the notification type contains specific keywords
                if (notificationType.Contains("Addition"))
                {
                    dgvNotification.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (notificationType.Contains("Deletion"))
                {
                    dgvNotification.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else if (notificationType.Contains("Update"))
                {
                    dgvNotification.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
            }
        }


        public void LoadNotifications()
        {
            try
            {
                List<Notification> notifications = notificationService.GetNotifications();
                if (notifications.Count == 0)
                {
                    MessageBox.Show("No notifications found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvNotification.DataSource = notifications;
                dgvNotification.Columns["NotificationId"].Visible = false;
                dgvNotification.Columns["Type"].HeaderText = "Notification Type";
                dgvNotification.Columns["Message"].HeaderText = "Message";
                dgvNotification.Columns["Date"].HeaderText = "Date";
                dgvNotification.Columns["Status"].HeaderText = "Status";

                foreach (DataGridViewColumn column in dgvNotification.Columns)
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                dgvNotification.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading notifications: " + ex.Message);
            }
        }

        private void dgvNotification_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int notificationId = Convert.ToInt32(dgvNotification.Rows[e.RowIndex].Cells["NotificationId"].Value);
                string currentStatus = dgvNotification.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                if (currentStatus == "Unread")
                {
                    notificationService.UpdateNotificationStatus(notificationId, "Read");
                    dgvNotification.Rows[e.RowIndex].Cells["Status"].Value = "Read";
                }
            }
        }



    }
}