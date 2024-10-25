using System;
using System.Collections;
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
using CarlosYulo.backend.entities.class_session;
using CarlosYulo.backend.monolith.schedule;
using CarlosYulo.preload;
using csCY_Avenue.Custom;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmFixedTrainers : Form
    {
        private fncControl Control;
        private List<Employee> _trainers = PreloadData.Trainers;
        private ScheduleController _ScheduleController;
        private List<ClassSession> _trainerSessions;

        public frmFixedTrainers()
        {
            InitializeComponent();
            Control = new fncControl();
            _ScheduleController = ServiceLocator.GetService<ScheduleController>();
            _trainerSessions = new List<ClassSession>();
        }

        private void frmFixedTrainers_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            dgvFixedTrainers.Rows.Clear(); // Clear existing rows

            foreach (var trainer in _trainers)
            {
                if (trainer.EmployeeTypeId == 3)
                {
                    Console.WriteLine(trainer);
                    dgvFixedTrainers.Rows.Add(trainer.EmployeeId, trainer.FullName, "ACTIVE"); // Add new row
                }
            }
        }

        private void dgvFixedTrainers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                if (e.ColumnIndex == 3)
                {
                    var selectedEmployeeId = dgvFixedTrainers.Rows[e.RowIndex].Cells[0].Value;

                    if (selectedEmployeeId is int trainerId) // Ensure it's an integer
                    {
                        _trainerSessions = _ScheduleController.SearchSchedulesAllByTrainerId(trainerId);

                        var FormFixedTrainerClasses = new frmFixedTrainerClasses(_trainerSessions);
                        Control.blurOverlay(FormFixedTrainerClasses);
                    }
                    else
                    {
                        MessageBox.Show("Selected row does not contain a valid Employee ID.");
                    }
                }
            }
        }
    }
}