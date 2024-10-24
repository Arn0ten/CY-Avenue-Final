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
using csCY_Avenue.Database;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmNotifications : Form
    {
        private fncNotificationService notificationService;
        private GlobalProcedure globalProcedure;
        private ContextMenuStrip contextMenu;

        public frmNotifications()
        {
            InitializeComponent();
            dgvNotification.CellClick += dgvNotification_CellClick;
            dgvNotification.CellFormatting += dgvNotification_CellFormatting;
            dgvNotification.MouseDown += dgvNotification_MouseDown; 

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

            contextMenu = new ContextMenuStrip();
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete Notification");
            deleteMenuItem.Click += DeleteNotification_Click;
            contextMenu.Items.Add(deleteMenuItem);
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

            if (e.ColumnIndex == dgvNotification.Columns["Status"].Index && e.RowIndex >= 0)
            {
                string status = dgvNotification.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (status == "Unread")
                {
                    dgvNotification.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Nirmala UI", dgvNotification.Font.Size, FontStyle.Bold);
                }
                else
                {
                    dgvNotification.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Nirmala UI", dgvNotification.Font.Size, FontStyle.Regular);
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
                    dgvNotification.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Nirmala UI", dgvNotification.Font.Size, FontStyle.Regular);
                }
            }
        }

        private void dgvNotification_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvNotification.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dgvNotification.ClearSelection();
                    dgvNotification.Rows[hti.RowIndex].Selected = true;
                    contextMenu.Show(dgvNotification, e.Location);
                }
            }
        }

        // Event for handling delete notification
        private void DeleteNotification_Click(object sender, EventArgs e)
        {
            if (dgvNotification.SelectedRows.Count > 0)
            {
                int notificationId = Convert.ToInt32(dgvNotification.SelectedRows[0].Cells["NotificationId"].Value);
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this notification?", "Delete Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    notificationService.DeleteNotification(notificationId);
                    LoadNotifications();
                    MessageBox.Show($"Notification deleted successfully.",
                       "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
