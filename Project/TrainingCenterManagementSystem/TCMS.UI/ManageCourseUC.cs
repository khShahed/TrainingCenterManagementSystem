using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;

namespace TCMS.UI
{
    public partial class ManageCourseUc : UserControl
    {
        public ManageCourseUc()
        {
            InitializeComponent();
            this.traineeGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            LoadGridView(new CourseManager().GetAll());
        }
        public void LoadGridView(IEnumerable<Course> courses)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("About", typeof(string));
            dataTable.Columns.Add("Objective", typeof(string));
            dataTable.Columns.Add("Prerequisite", typeof(string));
            dataTable.Columns.Add("Duration", typeof(double));


            traineeGridView.RowTemplate.Height = 50;
            foreach (var course in courses)
            {
                dataTable.Rows.Add(course.Id, course.Name, course.About, course.Objective, course.Prerequisites,
                    course.Duration);

            }
            traineeGridView.DataSource = dataTable;
            traineeGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var courses = new CourseManager().GetAll();
            var selected = from course in courses
                           where course.Name.ToLower().Contains(searchTextBox.text.ToLower())
                           select course;
            LoadGridView(selected);
        }

        private void traineeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            var row = traineeGridView.Rows[index];
            IdTextBox.Text = row.Cells[0].Value.ToString();
            nameTextBox.Text = row.Cells[1].Value.ToString();
            aboutTextBox.Text = row.Cells[2].Value.ToString();
            objectiveTextBox.Text = row.Cells[3].Value.ToString();
            prerequisitesTextBox.Text = row.Cells[4].Value.ToString();
            durationTextBox.Text = row.Cells[5].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                var id = Convert.ToInt32(IdTextBox.Text);
                var trainee = new Course();
                trainee.Id = id;
                trainee.Name = nameTextBox.Text;
                trainee.About = aboutTextBox.Text;
                trainee.Objective = objectiveTextBox.Text;
                trainee.Prerequisites = prerequisitesTextBox.Text;
                trainee.Duration = Convert.ToDouble(durationTextBox.Text);


                if (new CourseManager().Update(trainee))
                {
                    resultLabel.ForeColor = Color.Green;
                    resultLabel.Text = @"Updated!";
                    LoadGridView(new CourseManager().GetAll());
                    ClearAll();
                }
                else
                {
                    resultLabel.ForeColor = Color.Red;
                    resultLabel.Text = @"update failed!";
                }
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Please, select a course first!";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                var trainee = new CourseManager().Search(Convert.ToInt32(IdTextBox.Text));
                if (new CourseManager().Delete(trainee))
                {
                    resultLabel.ForeColor = Color.Green;
                    resultLabel.Text = @"Deleted!";
                    LoadGridView(new CourseManager().GetAll());
                    ClearAll();
                }
                else
                {
                    resultLabel.ForeColor = Color.Red;
                    resultLabel.Text = @"delete failed!";
                }
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Please, select a course first!";
            }
        }

        void ClearAll()
        {
            IdTextBox.Text = "";
            nameTextBox.Text = "";
            aboutTextBox.Text = "";
            objectiveTextBox.Text = "";
            durationTextBox.Text = "";
            prerequisitesTextBox.Text = "";
        }
    }
}
