using System;
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

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmAddClass : Form
    {
        private fncNotificationService notificationService;
        private List<Employee> trainers = PreloadData.Trainers;
        private ScheduleController _scheduleController;
        private Employee trainerType = new Employee();
        public bool success = false;


        public frmAddClass(bool success)
        {
            _scheduleController = ServiceLocator.GetService<ScheduleController>();
            InitializeComponent();
            LoadTrainers();
            this.success = success;
        }

        private void frmAddClass_Load(object sender, EventArgs e)
        {
            LoadTrainers();
        }

        private void cmbClassTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected trainer
            string selectedTrainer = cmbClassTrainer.SelectedItem.ToString();

            // Find the corresponding staff based on the selection
            var selectedStaff = trainers.FirstOrDefault(staff => selectedTrainer.Contains(staff.FullName));
            trainerType = selectedStaff ?? new Employee();


            // Update the trainer's picture
            if (selectedStaff != null)
            {
                picClassTrainerPhoto.Image = selectedStaff.ProfilePictureImage;
            }
        }

        private void LoadTrainers()
        {
            // trainer list na ibutang sa dropdown sa addclass trainer
            cmbClassTrainer.Items.Clear();
            foreach (var staff in trainers)
            {
                if (staff.EmployeeTypeId == 3 || staff.EmployeeTypeId == 4)
                {
                    cmbClassTrainer.Items.Add(staff.FullName + " | " + staff.EmployeeType);
                }
            }

            if (cmbClassTrainer.Items.Count > 0)
            {
                cmbClassTrainer.SelectedIndex = 0;
            }

            cmbClassTrainer.SelectedIndexChanged += cmbClassTrainer_SelectedIndexChanged;

            // Initialize the picture with the first trainer's photo
            if (trainers.Count > 0)
            {
                picClassTrainerPhoto.Image = trainers[0].ProfilePictureImage; 
            }
        }


        //Save
        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            DateTime baseDate = dtClassSchedule.Value.Date;
            ClassSession newSchedule = new ClassSession()
            {
                SessionTitle = txtClassName.Text,
                SessionDescription = txtDescription.Text,
                SessionType = trainerType.EmployeeType,
                SessionRoomNumber = int.TryParse(cmbClassRoom.SelectedItem?.ToString(), out int roomNumber)
                    ? roomNumber
                    : 1,
                SessionStartAt = baseDate.Add(dtStart.Value.TimeOfDay),
                SessionEndAt = baseDate.Add(dtEnd.Value.TimeOfDay),

                TrainerId = trainerType.EmployeeId,
                TrainerName = trainerType.FullName
            };

            Console.WriteLine(newSchedule.ToString());

            if (newSchedule.SessionEndAt <= newSchedule.SessionStartAt)
            {
                MessageBox.Show("End time must be after start time.", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }


            if (trainerType.EmployeeTypeId == 3 && !_scheduleController.CreateClassFixedSession(newSchedule))
            {
                success = false;
                return;
            }

            if (trainerType.EmployeeTypeId == 4 && !_scheduleController.CreatePersonalClassSession(newSchedule))
            {
                success = false;
                return;
            }

            MessageBox.Show("Class has been created successfully", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            success = true;
            Close();
        }

        //Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}