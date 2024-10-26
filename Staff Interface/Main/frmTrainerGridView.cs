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
using CarlosYulo.preload;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmTrainerGridView : Form
    {
        private List<Employee> trainers = PreloadData.Trainers;

        
        public frmTrainerGridView()
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
            dgvTrainers.Rows.Clear();
            foreach (var trainer in trainers)
            {
                int rowIndex = dgvTrainers.Rows.Add();
                DataGridViewRow row = dgvTrainers.Rows[rowIndex];

                row.Cells["clmFullName"].Value = trainer.FullName;
                row.Cells["clmEmail"].Value = trainer.Email;
                row.Cells["clmPhoneNumber"].Value = trainer.PhoneNumber;
                row.Cells["clmTrainerType"].Value = trainer.EmployeeType;
                row.Cells["clmSalary"].Value = trainer.Salary?.ToString();
            }
        }
    }
}
