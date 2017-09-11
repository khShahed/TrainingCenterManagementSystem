using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;

namespace TCMS.UI
{
    public partial class ManageRoomUc : UserControl
    {
        public ManageRoomUc()
        {
            InitializeComponent();
            this.traineeGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            LoadGridView(new RoomManager().GetAll());
        }
        public void LoadGridView(IEnumerable<Room> trainees)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Room No", typeof(string));
            dataTable.Columns.Add("Capacity", typeof(int));


            traineeGridView.RowTemplate.Height = 50;
            foreach (var trainee in trainees)
            {
                dataTable.Rows.Add(trainee.Id, trainee.RoomNo, trainee.Capacity);

            }
            traineeGridView.DataSource = dataTable;
            traineeGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                var id = Convert.ToInt32(IdTextBox.Text);
                var room = new Room { Id = id, Capacity = Convert.ToInt32(capacityTextBox.Text) };

                if (new RoomManager().Update(room))
                {
                    resultLabel.ForeColor = Color.Green;
                    resultLabel.Text = @"Updated!";
                    IdTextBox.Text = "";
                    capacityTextBox.Text = "";
                    LoadGridView(new RoomManager().GetAll());
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
                resultLabel.Text = @"Please, select a room first!";
            }
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
            roomNoTextBox.Text = row.Cells[1].Value.ToString();
            capacityTextBox.Text = row.Cells[2].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                var trainee = new RoomManager().Search(Convert.ToInt32(IdTextBox.Text));
                if (new RoomManager().Delete(trainee))
                {
                    resultLabel.ForeColor = Color.Green;
                    resultLabel.Text = @"Deleted!";
                    LoadGridView(new RoomManager().GetAll());
                    IdTextBox.Text = "";
                    capacityTextBox.Text = "";
                    roomNoTextBox.Text = "";
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
                resultLabel.Text = @"Please, select a room first!";
            }
        }
    }
}
