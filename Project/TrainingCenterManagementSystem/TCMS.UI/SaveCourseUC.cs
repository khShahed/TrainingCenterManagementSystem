using System;
using System.Drawing;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;

namespace TCMS.UI
{
    public partial class SaveCourseUc : UserControl
    {
        public SaveCourseUc()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (new CourseManager().SearchName(nameTextBox.Text) != null)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Name must be unique!";
                return;
            }
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Name is required";
                return;
            }
            var course = new Course
            {
                Name = nameTextBox.Text,
                About = aboutTextBox.Text,
                Duration = Convert.ToDouble(durationTextBox.Text),
                Objective = objectiveTextBox.Text,
                Prerequisites = prerequisitesTextBox.Text
            };
            if (new CourseManager().Save(course))
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Saved!";
                ClearAllTextBox();
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Save Failed!";
            }
        }

        void ClearAllTextBox()
        {
            nameTextBox.Text = "";
            aboutTextBox.Text = "";
            durationTextBox.Text = "";
            objectiveTextBox.Text = "";
            prerequisitesTextBox.Text = "";
        }
    }
}
