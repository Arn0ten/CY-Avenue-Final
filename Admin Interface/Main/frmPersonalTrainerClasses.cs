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

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmPersonalTrainerClasses : Form
    {
        private List<ClassSession> _trainerSessions;

        public frmPersonalTrainerClasses(List<ClassSession> trainerSessions)
        {
            InitializeComponent();
            _trainerSessions = trainerSessions;
            LoadDataGrid();
        }

        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTrainerClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            // Clear existing rows if needed
            dgvTrainerClass.Rows.Clear();

            foreach (var st in _trainerSessions)
            {
                Console.WriteLine(st.ToString());
                dgvTrainerClass.Rows.Add(
                    st.SessionStartAt?.ToString("MMMM dd, yyyy"),
                    st.SessionTitle,
                    st.SessionStartAt?.ToString("h:mm tt"),
                    st.SessionEndAt?.ToString("h:mm tt")
                );
            }
        }
    }
}