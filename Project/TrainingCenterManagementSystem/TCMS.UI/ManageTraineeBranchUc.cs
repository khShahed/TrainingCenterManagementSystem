using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;

namespace TCMS.UI
{
    public partial class ManageTraineeBranchUc : UserControl
    {
        public int RowIndex;
        public ManageTraineeBranchUc()
        {
            InitializeComponent();
            this.traineeGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            LoadGridView(new TraineeBatchManager().GetAll());
        }

        void LoadGridView(IEnumerable<TraineeBatch> traineeBatches)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Trainee", typeof(string));
            dataTable.Columns.Add("Batch", typeof(string));
            dataTable.Columns.Add("Discount", typeof(int));
            dataTable.Columns.Add("Fee", typeof(int));


            traineeGridView.RowTemplate.Height = 50;
            foreach (var traineeBatch in traineeBatches)
            {
                dataTable.Rows.Add(traineeBatch.Id, new TraineeManager().Search(traineeBatch.TraineeId).Name,
                    new BatchManager().Search(traineeBatch.BatchId).Name, traineeBatch.Discount, traineeBatch.Fee);

            }
            traineeGridView.DataSource = dataTable;
            traineeGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void unassignButton_Click(object sender, EventArgs e)
        {

            if (RowIndex < 0)
            {
                return;

            }
            var row = traineeGridView.Rows[RowIndex];
            var traineeBatch = new TraineeBatch { Id = Convert.ToInt32(row.Cells[0].Value) };
            if (new TraineeBatchManager().Delete(traineeBatch))
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Successfully unassigned.";
                LoadGridView(new TraineeBatchManager().GetAll());
            }
            else
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Unassigning failed.";
            }

        }

        private void traineeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
        }
    }
}

