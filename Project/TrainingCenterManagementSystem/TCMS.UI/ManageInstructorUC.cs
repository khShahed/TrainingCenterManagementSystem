using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;

namespace TCMS.UI
{
    public partial class ManageInstructorUc : UserControl
    {
        public ManageInstructorUc()
        {
            InitializeComponent();
            this.traineeGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            LoadGridView(new InstructorManager().GetAll());
        }
        public void LoadGridView(IEnumerable<Instructor> trainees)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Photo", typeof(byte[]));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Current Address", typeof(string));
            dataTable.Columns.Add("Permanent Address", typeof(string));


            traineeGridView.RowTemplate.Height = 50;
            foreach (var trainee in trainees)
            {
                dataTable.Rows.Add(trainee.Id, trainee.Name, trainee.Photo, trainee.Email, trainee.Phone,
                    trainee.CurrentAddress, trainee.PermanentAddress);

            }
            traineeGridView.DataSource = dataTable;
            traineeGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            var instructors = new InstructorManager().GetAll();
            var selected = from instructor in instructors
                           where instructor.Name.ToLower().Contains(searchTextBox.text.ToLower())
                           select instructor;
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
            emailTextBox.Text = row.Cells[3].Value.ToString();
            phoneTextBox.Text = row.Cells[4].Value.ToString();
            currentAddress.Text = row.Cells[5].Value.ToString();
            permanentAddressTextBox.Text = row.Cells[6].Value.ToString();

            try
            {
                if (row.Cells[2].Value != null)
                {
                    var ms = new MemoryStream((byte[])row.Cells[2].Value);
                    photoBox.Image = Image.FromStream(ms);
                }
            }
            catch (Exception exception)
            {
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                if (!string.IsNullOrEmpty(emailTextBox.Text))
                {
                    var email = emailTextBox.Text;
                    var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    var match = regex.Match(email);
                    if (match.Success) { }
                    else
                    {
                        resultLabel.ForeColor = Color.Red;
                        resultLabel.Text = @"Enter a valid email!";
                        return;
                    }
                }
                if (string.IsNullOrEmpty(emailTextBox.Text))
                {

                    resultLabel.ForeColor = Color.Red;
                    resultLabel.Text = @"Enter email address!";
                    return;

                }
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {

                    resultLabel.ForeColor = Color.Red;
                    resultLabel.Text = @"Name is required.";
                    return;

                }
                var id = Convert.ToInt32(IdTextBox.Text);
                var trainee = new Instructor
                {
                    Id = id,
                    Name = nameTextBox.Text,
                    Email = emailTextBox.Text,
                    Phone = phoneTextBox.Text,
                    CurrentAddress = currentAddress.Text,
                    PermanentAddress = permanentAddressTextBox.Text
                };

                if (photoBox.Image != null)
                {
                    var converter = new ImageConverter();
                    trainee.Photo = (byte[])converter.ConvertTo(photoBox.Image, typeof(byte[]));
                }
                if (new InstructorManager().Update(trainee))
                {
                    resultLabel.ForeColor = Color.Green;
                    resultLabel.Text = @"Updated!";
                    ClearAll();
                    LoadGridView(new InstructorManager().GetAll());
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
                resultLabel.Text = @"Please, select a trainee first!";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                var trainee = new InstructorManager().Search(Convert.ToInt32(IdTextBox.Text));
                if (new InstructorManager().Delete(trainee))
                {
                    resultLabel.ForeColor = Color.Green;
                    resultLabel.Text = @"Deleted!";
                    LoadGridView(new InstructorManager().GetAll());
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
                resultLabel.Text = @"Please, select a trainee first!";
            }
        }

        void ClearAll()
        {
            IdTextBox.Text = "";
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
            permanentAddressTextBox.Text = "";
            currentAddress.Text = "";
            photoBox.Image = null;
        }
    }
}
