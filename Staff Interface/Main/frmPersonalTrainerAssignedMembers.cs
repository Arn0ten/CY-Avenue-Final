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

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmPersonalTrainerAssignedMembers : Form
    {
        private List<TrainerStudent> student;

        public frmPersonalTrainerAssignedMembers(List<TrainerStudent> student)
        {
            InitializeComponent();
            this.student = student;
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            // Clear existing rows if needed
            dgvTrainerAssignedMembers.Rows.Clear();

            foreach (var st in student)
            {
                Console.WriteLine(st.ToString());
                dgvTrainerAssignedMembers.Rows.Add(
                    st.StudentId,
                    st.StudentName,
                    st.Status,
                    st.StartDate?.ToString("MMMM dd, yyyy")
                );
            }
        }

        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}