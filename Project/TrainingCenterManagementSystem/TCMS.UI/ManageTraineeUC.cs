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
    public partial class ManageTraineeUc : UserControl
    {
        public ManageTraineeUc()
        {
            InitializeComponent();
            this.traineeGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            LoadGridView(new TraineeManager().GetAll());
        }

        public void LoadGridView(IEnumerable<Trainee> trainees)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Photo", typeof(byte[]));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Father Name", typeof(string));
            dataTable.Columns.Add("Mother Name", typeof(string));
            dataTable.Columns.Add("Current Address", typeof(string));
            dataTable.Columns.Add("Permanent Address", typeof(string));


            traineeGridView.RowTemplate.Height = 50;
            foreach (var trainee in trainees)
            {
                dataTable.Rows.Add(trainee.Id, trainee.Name, trainee.Photo, trainee.Email, trainee.Phone,
                    trainee.FatherName, trainee.MotherName, trainee.CurrentAddress, trainee.PermanentAddress);

            }
            traineeGridView.DataSource = dataTable;
            traineeGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void searchTextBox_OnTextChange(object sender, EventArgs e)
        {
            ((DataTable)traineeGridView.DataSource).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", searchTextBox.Text);
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
            emailTextBox.Text = row.Cells[3].Value.ToString();
            phoneTextBox.Text = row.Cells[4].Value.ToString();
            fatherNameTextBox.Text = row.Cells[5].Value.ToString();
            motherNameTextBox.Text = row.Cells[6].Value.ToString();
            currentAddress.Text = row.Cells[7].Value.ToString();
            permanentAddressTextBox.Text = row.Cells[8].Value.ToString();

            try
            {
                if (row.Cells[2].Value != null)
                {
                    var ms = new MemoryStream((byte[])row.Cells[2].Value);
                    photoBox.Image = Image.FromStream(ms);
                }
            }
            catch (Exception exException)
            {

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var trainees = new TraineeManager().GetAll();
            var selected = from trainee in trainees
                           where trainee.Name.ToLower().Contains(searchTextBox.text.ToLower())
                           select trainee;
            LoadGridView(selected);
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
                var id = Convert.ToInt32(IdTextBox.Text);
                var trainee = new Trainee
                {
                    Id = id,
                    Name = nameTextBox.Text,
                    Email = emailTextBox.Text,
                    Phone = phoneTextBox.Text,
                    FatherName = fatherNameTextBox.Text,
                    MotherName = motherNameTextBox.Text,
                    CurrentAddress = currentAddress.Text,
                    PermanentAddress = permanentAddressTextBox.Text
                };

                if (photoBox.Image != null)
                {
                    var converter = new ImageConverter();
                    trainee.Photo = (byte[])converter.ConvertTo(photoBox.Image, typeof(byte[]));
                }
                if (new TraineeManager().Update(trainee))
                {
                    resultLabel.ForeColor = Color.Green;
                    resultLabel.Text = @"Updated!";
                    ClearAll();
                    LoadGridView(new TraineeManager().GetAll());
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
                var trainee = new TraineeManager().Search(Convert.ToInt32(IdTextBox.Text));
                if (new TraineeManager().Delete(trainee))
                {
                    resultLabel.ForeColor = Color.Green;
                    resultLabel.Text = @"Deleted!";
                    ClearAll();
                    LoadGridView(new TraineeManager().GetAll());
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
            fatherNameTextBox.Text = "";
            motherNameTextBox.Text = "";
        }

        private void manageTraineePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
