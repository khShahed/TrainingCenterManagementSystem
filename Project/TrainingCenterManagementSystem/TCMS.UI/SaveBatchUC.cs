using System;
using System.Drawing;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;

namespace TCMS.UI
{

    public partial class SaveBatchUc : UserControl
    {
        public SaveBatchUc()
        {
            InitializeComponent();
            LoadComboBoxes();
            startDatePicker.Value = DateTime.Now.Date;
            endDatePicker.Value = DateTime.Now.AddMonths(4);
        }

        private void LoadComboBoxes()
        {
            LoadRooms();
            LoadInstructors();
            LoadCourses();
        }

        private void LoadCourses()
        {
            var courses = new CourseManager().GetAll();
            foreach (var course in courses)
            {
                var comboboxItem = new ComboboxItem { Text = course.Name, Value = course.Id };
                courseComboBox.Items.Add(comboboxItem);
            }
            courseComboBox.DisplayMember = "Text";
            courseComboBox.ValueMember = "Value";
        }

        private void LoadInstructors()
        {
            var instructors = new InstructorManager().GetAll();
            foreach (var instructor in instructors)
            {
                var comboboxItem = new ComboboxItem { Text = instructor.Name, Value = instructor.Id };
                instructorComboBox.Items.Add(comboboxItem);
            }
            instructorComboBox.DisplayMember = "Text";
            instructorComboBox.ValueMember = "Value";
        }

        private void LoadRooms()
        {
            var rooms = new RoomManager().GetAll();
            foreach (var room in rooms)
            {
                var comboboxItem = new ComboboxItem { Text = room.RoomNo, Value = room.Id };
                roomComboBox.Items.Add(comboboxItem);
            }
            roomComboBox.DisplayMember = "Text";
            roomComboBox.ValueMember = "Value";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Name is required!";
                return;
            }
            if (new BatchManager().SearchName(nameTextBox.Text) != null)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Name should be unique.";
                return;
            }
            if (string.IsNullOrEmpty(feeTextBox.Text))
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Fee is required!";
                return;
            }
            if (Convert.ToInt32(feeTextBox.Text) < 0)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Fee must be a positive value.";
                return;
            }
            var batch = new Batch
            {
                Name = nameTextBox.Text,
                Fee = feeTextBox.Text,
                StartDate =
                    new DateTime(startDatePicker.Value.Year, startDatePicker.Value.Month, startDatePicker.Value.Day),
                EndDate = new DateTime(endDatePicker.Value.Year, endDatePicker.Value.Month, endDatePicker.Value.Day)
            };
            if (endDatePicker.Value.Date <= startDatePicker.Value.Date)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"End date must be greater then start!";
                return;
            }
            if (roomComboBox.SelectedItem == null)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Select a room!";
                return;
            }
            batch.RoomId = ((ComboboxItem)(roomComboBox.SelectedItem)).Value;
            if (courseComboBox.SelectedItem == null)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Select a course!";
                return;
            }
            batch.CourseId = ((ComboboxItem)(courseComboBox.SelectedItem)).Value;
            if (instructorComboBox.SelectedItem == null)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Select a instructor!";
                return;
            }
            batch.InstructorId = ((ComboboxItem)(instructorComboBox.SelectedItem)).Value;
            if (new BatchManager().Save(batch))
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Saved.";
                ClearAll();
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Save Failed!";
            }
        }

        void ClearAll()
        {
            nameTextBox.Text = "";
            feeTextBox.Text = "";
            capacityTextBox.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (roomComboBox.SelectedItem != null)
            {
                var v = (ComboboxItem)roomComboBox.SelectedItem;
                var value = v.Value;
                var text = new RoomManager().Search(value).Capacity.ToString();
                capacityTextBox.Text = text;
            }

        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            var form = new Form();
            form.Controls.Add(new SaveRoomUc());
            form.Size = new Size(930, 700);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void refreshRoomButton_Click(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            var form = new Form();
            form.Controls.Add(new SaveCourseUc());
            form.Size = new Size(930, 700);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void refreshCourseButton_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void instructorAddButton_Click(object sender, EventArgs e)
        {
            var form = new Form();
            form.Controls.Add(new SaveInstructorUc());
            form.Size = new Size(930, 700);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void instructorRefreshButton_Click(object sender, EventArgs e)
        {
            LoadInstructors();
        }
    }
}
