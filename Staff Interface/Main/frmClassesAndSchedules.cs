using csCY_Avenue.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo.backend.entities.class_session;
using CarlosYulo.preload;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmClassesAndSchedules : Form
    {
        fncControl Control;
        private List<ClassSession> PersonalSessions = PreloadClassSchedule.PersonalSchedule;
        private List<ClassSession> FixedSessions = PreloadClassSchedule.FixedSchedule;

        public frmClassesAndSchedules()
        {
            InitializeComponent();
            Control = new fncControl();
            Load += frmClassesAndSchedule_Load;
            dgvClass.SelectionChanged += dgvClass_SelectionChanged;
        }
        
        private void frmClassesAndSchedule_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        
        

        private void dgvClass_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvClass.SelectedRows[0];
                int sessionId = Convert.ToInt32(selectedRow.Cells["clmSessionId"].Value);

                // Retrieve session details from combined lists
                ClassSession? selectedSession = PersonalSessions.FirstOrDefault(s => s.SessionId == sessionId)
                                                ?? FixedSessions.FirstOrDefault(s => s.SessionId == sessionId);

                if (selectedSession != null)
                {
                    UpdateDetailsPanel(selectedSession);
                }
            }
        }

        // Update panel with session details only
        private void UpdateDetailsPanel(ClassSession session)
        {
            btnType.Text = session.SessionType;
            txtRoom.Text = session.SessionRoomNumber.ToString();
            txtClassName.Text = session.SessionTitle ?? "";
            txtClassTrainer.Text = session.TrainerName ?? "";
            txtClassDescription.Text = session.SessionDescription ?? "";

            // Populate session-specific details
            dtClassSchedule.Text = session.SessionStartAt?.ToString("MMMM dd, yyyy") ?? "No Date";
            dtStart.Text = session.SessionStartAt?.ToString("hh:mm tt") ?? "No Start Time";
            dtEnd.Text = session.SessionEndAt?.ToString("hh:mm tt") ?? "No End Time";
        }

        private void LoadDataGrid()
        {
            var allSessions = PersonalSessions.Concat(FixedSessions).ToList();

            dgvClass.Rows.Clear();
            foreach (var schedule in allSessions)
            {
                int rowIndex = dgvClass.Rows.Add();
                DataGridViewRow row = dgvClass.Rows[rowIndex];

                row.Cells["clmSessionId"].Value = schedule.SessionId;
                row.Cells["clmName"].Value = schedule.SessionTitle;
                row.Cells["clmType"].Value = schedule.SessionType;
                row.Cells["clmTrainer"].Value = schedule.TrainerName;
                row.Cells["clmSchedule"].Value = schedule.SessionStartAt?.ToString("MMMM dd, yyyy");
                row.Cells["clmRoom"].Value = schedule.SessionRoomNumber.HasValue
                    ? schedule.SessionRoomNumber.Value.ToString()
                    : "None";
            }
        }


        //Add
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            bool success = false;
            var FormAddClass = new frmAddClass(success);
            Control.blurOverlay(FormAddClass);

            if (FormAddClass.success)
            {
                PreloadClassSchedule.PreLoadSchedule();
                PersonalSessions = PreloadClassSchedule.PersonalSchedule;
                FixedSessions = PreloadClassSchedule.FixedSchedule;
                LoadDataGrid();
            }
        }

        //Edit
        private void btnEditClass_Click(object sender, EventArgs e)
        {
            var EditClass = new frmEditClass();
            Control.blurOverlay(EditClass);
        }

        //Delete
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
        }

        //Search
        private void btnSearchClass_Click(object sender, EventArgs e)
        {
        }
    }
}