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
    public partial class frmClassGridView : Form
    {
        private List<ClassSession> classes = PreloadClassSchedule.AllSchedule;
        
        public frmClassGridView()
        {
            InitializeComponent();
            Load += frmMembersGridView_Load;
        }
        
        private void frmMembersGridView_Load(object sender, EventArgs e)
        {
            update();
        }
        
        
        private void update()
        {
            dgvClass.Rows.Clear();
            foreach (var classSession in classes)
            {
                int rowIndex = dgvClass.Rows.Add();
                DataGridViewRow row = dgvClass.Rows[rowIndex];

                row.Cells["clmId"].Value = classSession.SessionId;
                row.Cells["clmClassName"].Value = classSession.SessionTitle;
                row.Cells["clmClassType"].Value = classSession.SessionType;
                row.Cells["clmTrainer"].Value = classSession.TrainerName;
                row.Cells["clmSchedule"].Value = classSession.SessionStartAt?.ToString("MMMM dd, yyyy");
            }
        }
        
        

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
