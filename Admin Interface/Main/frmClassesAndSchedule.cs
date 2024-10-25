using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo.backend;
using CarlosYulo.backend.entities.class_session;
using CarlosYulo.preload;
using csCY_Avenue.Custom;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmClassesAndSchedule : Form
    {
        private fncControl Control;
        private List<ClassSession> PersonalSessions = PreloadClassSchedule.PersonalSchedule;
        private List<ClassSession> FixedSessions = PreloadClassSchedule.FixedSchedule;

        public frmClassesAndSchedule()
        {
            InitializeComponent();
            Control = new fncControl();
            Load += frmClassesAndSchedule_Load;
        }

        private void frmClassesAndSchedule_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            var allSessions = new List<ClassSession>();
            allSessions.AddRange(PersonalSessions);
            allSessions.AddRange(FixedSessions);

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
            var FormEditClass = new frmEditClass();
            Control.blurOverlay(FormEditClass);
        }

        //Delete
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
        }

        //Search
        private void btnSearchClass_Click(object sender, EventArgs e)
        {
        }

        //Na pindot
        private void txtEditClassName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}