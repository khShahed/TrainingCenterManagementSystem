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
    public partial class AssignTraineeBatchUc : UserControl
    {
        public AssignTraineeBatchUc()
        {
            InitializeComponent();
            LoadGridView(new TraineeManager().GetAll());
            LoadBatches();
        }
        public void LoadGridView(IEnumerable<Trainee> trainees)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Photo", typeof(byte[]));

            traineeGridView.RowTemplate.Height = 50;
            foreach (var trainee in trainees)
            {
                dataTable.Rows.Add(trainee.Id, trainee.Name, trainee.Photo);
            }
            traineeGridView.DataSource = dataTable;
            traineeGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var trainees = new TraineeManager().GetAll();
            var selected = from trainee in trainees
                           where trainee.Name.ToLower().Contains(searchTextBox.text.ToLower())
                           select trainee;
            LoadGridView(selected);
        }
        private void LoadBatches()
        {
            var batches = new BatchManager().GetAll();
            foreach (var comboboxItem in batches.Select(batch => new ComboboxItem { Text = batch.Name, Value = batch.Id }))
            {
                batchComboBox.Items.Add(comboboxItem);
            }
            batchComboBox.DisplayMember = "Text";
            batchComboBox.ValueMember = "Value";
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
        }

        private void batchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (batchComboBox.SelectedItem == null) return;
            var selectedItem = (ComboboxItem)batchComboBox.SelectedItem;
            var batch = new BatchManager().Search(selectedItem.Value);
            feeTextBox.Text = batch.Fee.ToString();
            capacityTextBox.Text = (new RoomManager().Search(batch.RoomId)).Capacity.ToString();
            assignedTextBox.Text = (new TraineeBatchManager().GetAll()).Count(tb => tb.BatchId == batch.Id).ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            resultLabel.ForeColor = Color.Red;
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                resultLabel.Text = @"Select a Trainee.";
                return;
            }
            if (batchComboBox.SelectedItem == null)
            {
                resultLabel.Text = @"Select a batch.";
                return;
            }
            if (Convert.ToInt32(capacityTextBox.Text) < Convert.ToInt32(assignedTextBox.Text))
            {
                resultLabel.Text = @"Capacity full.";
                return;
            }
            if (Convert.ToInt32(discountTextBox.Text) < 0)
            {
                resultLabel.Text = @"Discount can't be negative.";
                return;
            }
            var traineeBatch = new TraineeBatch
            {
                TraineeId = Convert.ToInt32(IdTextBox.Text),
                BatchId = ((ComboboxItem)batchComboBox.SelectedItem).Value,
                Discount = Convert.ToInt32(discountTextBox.Text),
                Fee = Convert.ToInt32(feeTextBox.Text) - (Convert.ToInt32(discountTextBox.Text)
                                                          * Convert.ToInt32(feeTextBox.Text)) / 100
            };
            if (new TraineeBatchManager().SearchTrainee(traineeBatch.BatchId, traineeBatch.TraineeId))
            {
                resultLabel.Text = @"Trainee already assigned in that course.";
                return;
            }
            if (new TraineeBatchManager().Save(traineeBatch))
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Saved!";
                IdTextBox.Text = "";
                discountTextBox.Text = "";
            }
            else
            {
                resultLabel.Text = @"save failed!";
            }
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            var manageTraineeBranchUc = new ManageTraineeBranchUc();
            var form = new Form { StartPosition = FormStartPosition.CenterParent };
            form.Controls.Add(manageTraineeBranchUc);
            form.Size = new Size(930, 700);
            form.ShowDialog();
        }
    }
}
