using csCY_Avenue.Custom;
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
using System.Windows.Forms.VisualStyles;
using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.entities.class_session;
using CarlosYulo.backend.monolith.schedule;
using CarlosYulo.preload;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmPersonalTrainers : Form
    {
        private fncControl Control;
        private List<Employee> _trainers = PreloadData.Trainers;
        private ScheduleController _ScheduleController;
        private List<TrainerStudent> _trainerStudents;
        private List<ClassSession> _trainerSessions;

        public frmPersonalTrainers()
        {
            InitializeComponent();
            Control = new fncControl();
            _ScheduleController = ServiceLocator.GetService<ScheduleController>();
            _trainerStudents = new List<TrainerStudent>();
            _trainerSessions = new List<ClassSession>();
            dgvPersonalTrainers.CellPainting += dgvPersonalTrainers_CellPainting;
        }


        private void frmPersonalTrainers_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            dgvPersonalTrainers.Rows.Clear();

            foreach (var trainer in _trainers)
            {
                if (trainer.EmployeeTypeId == 4)
                {
                    Console.WriteLine(trainer);
                    dgvPersonalTrainers.Rows.Add(trainer.EmployeeId, trainer.FullName, "ACTIVE");
                }
            }
        }

        private void dgvPersonalTrainers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                // Check if the clicked cell is in the "Assigned Members" column
                if (e.ColumnIndex == 3)
                {
                    // Retrieve the EmployeeId from the selected row in dgvPersonalTrainers
                    var selectedEmployeeId = dgvPersonalTrainers.Rows[e.RowIndex].Cells[0].Value;

                    if (selectedEmployeeId is int trainerId) // Ensure it's an integer
                    {
                        // Search for the students assigned to this trainer
                        _trainerStudents = _ScheduleController.SearchTrainerStudents(trainerId);

                        // Open the frmPersonalTrainerAssignedMembers form
                        var FormPersonalTrainerAssignedMembers =
                            new frmPersonalTrainerAssignedMembers(_trainerStudents);
                        Control.blurOverlay(FormPersonalTrainerAssignedMembers);
                    }
                    else
                    {
                        MessageBox.Show("Selected row does not contain a valid Employee ID.");
                    }
                }
                else if (e.ColumnIndex == 4) // If another column (e.g., "Classes") is clicked
                {
                    var selectedEmployeeId = dgvPersonalTrainers.Rows[e.RowIndex].Cells[0].Value;

                    if (selectedEmployeeId is int trainerId) // Ensure it's an integer
                    {
                        _trainerSessions = _ScheduleController.SearchSchedulesAllByTrainerId(trainerId);
                        var FormPersonalTrainerClasses = new frmPersonalTrainerClasses(_trainerSessions);
                        Control.blurOverlay(FormPersonalTrainerClasses);
                    }
                    else
                    {
                        MessageBox.Show("Selected row does not contain a valid Employee ID.");
                    }
                }
            }
        }


        //Gridview buttons na Design
        private void dgvPersonalTrainers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            string cellValue = e.Value.ToString();
            e.CellStyle.Font = new Font("Nirmala UI", 9, FontStyle.Bold);

            if (e.ColumnIndex == dgvPersonalTrainers.Columns["AsignedMembers"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var buttonRect = e.CellBounds;
                buttonRect.Inflate(-2, -2);
                ButtonRenderer.DrawButton(e.Graphics, buttonRect, PushButtonState.Normal);
                e.Graphics.FillRectangle(Brushes.Blue, buttonRect);
                TextRenderer.DrawText(e.Graphics, "View", e.CellStyle.Font, buttonRect, Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
            else if (e.ColumnIndex == dgvPersonalTrainers.Columns["TrainerClasses"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var buttonRect = e.CellBounds;
                buttonRect.Inflate(-2, -2);
                ButtonRenderer.DrawButton(e.Graphics, buttonRect, PushButtonState.Normal);
                e.Graphics.FillRectangle(Brushes.Blue, buttonRect);
                TextRenderer.DrawText(e.Graphics, "View", e.CellStyle.Font, buttonRect, Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
        }

        private void dgvPersonalTrainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}