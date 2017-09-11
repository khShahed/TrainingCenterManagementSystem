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
    public partial class ManageBatchUc : UserControl
    {
        public ManageBatchUc()
        {
            InitializeComponent();
            this.traineeGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            LoadGridView(new BatchManager().GetAll());
        }
        public void LoadGridView(IEnumerable<Batch> batches)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Fee", typeof(string));
            dataTable.Columns.Add("Start Date", typeof(DateTime));
            dataTable.Columns.Add("End Date", typeof(DateTime));
            dataTable.Columns.Add("Course", typeof(string));
            dataTable.Columns.Add("Instructor", typeof(string));
            dataTable.Columns.Add("Room", typeof(int));


            traineeGridView.RowTemplate.Height = 50;
            foreach (var batch in batches)
            {
                dataTable.Rows.Add(batch.Id, batch.Name, batch.Fee, batch.StartDate, batch.EndDate,
                    (new CourseManager().Search(batch.CourseId)).Name,
                    (new InstructorManager().Search(batch.InstructorId)).Name, batch.RoomId);

            }
            traineeGridView.DataSource = dataTable;
            traineeGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var batches = new BatchManager().GetAll();
            var selected = from batch in batches
                           where batch.Name.ToLower().Contains(searchTextBox.text.ToLower())
                           select batch;
            LoadGridView(selected);
        }

        private void traineeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            var row = traineeGridView.Rows[index];
            IdTextBox.Text = row.Cells[0].Value.ToString();
            nameTextBox.Text = row.Cells[1].Value.ToString();
            feeTextBox.Text = row.Cells[2].Value.ToString();
            startDatePicker.Value = (DateTime)row.Cells[3].Value;
            endDatePicker.Value = (DateTime)row.Cells[4].Value;
            //loading data to combo box
            var instructors = new InstructorManager().GetAll();
            foreach (var instructor in instructors)
            {
                var comboboxItem = new ComboboxItem { Text = instructor.Name, Value = instructor.Id };
                instructorComboBox.Items.Add(comboboxItem);
                if (row.Cells[6].Value.ToString() == instructor.Name)
                {
                    instructorComboBox.SelectedItem = comboboxItem;
                }
            }
            instructorComboBox.DisplayMember = @"Text";
            instructorComboBox.ValueMember = @"Value";

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Select a batch first.";
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
            if (endDatePicker.Value.Date <= startDatePicker.Value.Date)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"End date must be greater then start!";
                return;
            }
            if (instructorComboBox.SelectedItem == null)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Select a instructor!";
                return;
            }
            var batch = new Batch
            {
                Id = Convert.ToInt32(IdTextBox.Text),
                Name = nameTextBox.Text,
                Fee = feeTextBox.Text,
                StartDate =
                    new DateTime(startDatePicker.Value.Year, startDatePicker.Value.Month, startDatePicker.Value.Day),
                EndDate = new DateTime(endDatePicker.Value.Year, endDatePicker.Value.Month, endDatePicker.Value.Day),
                CourseId = (new BatchManager().Search(Convert.ToInt32(IdTextBox.Text))).CourseId,
                RoomId = (new BatchManager().Search(Convert.ToInt32(IdTextBox.Text))).RoomId
            };

            batch.InstructorId = ((ComboboxItem)(instructorComboBox.SelectedItem)).Value;
            if (new BatchManager().Update(batch))
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Updated.";
                LoadGridView(new BatchManager().GetAll());
                ClearAll();
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Update Failed!";
            }
        }
        void ClearAll()
        {
            nameTextBox.Text = "";
            feeTextBox.Text = "";
            IdTextBox.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"select a batch.";
                return;
            }
            var batch = new Batch
            {
                Id = Convert.ToInt32(IdTextBox.Text)
            };
            if (new BatchManager().Delete(batch))
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Deleted.";
                LoadGridView(new BatchManager().GetAll());
                ClearAll();
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Delete Failed!";
            }
        }
    }
}
