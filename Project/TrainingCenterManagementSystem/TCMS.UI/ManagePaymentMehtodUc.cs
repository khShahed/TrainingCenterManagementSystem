using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;

namespace TCMS.UI
{
    public partial class ManagePaymentMehtodUc : UserControl
    {
        public ManagePaymentMehtodUc()
        {
            InitializeComponent();
            this.traineeGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            LoadGridView(new PaymentMethodManager().GetAll());
        }
        public void LoadGridView(IEnumerable<PaymentMethod> paymentMethods)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));


            traineeGridView.RowTemplate.Height = 50;
            foreach (var paymentMethod in paymentMethods)
            {
                dataTable.Rows.Add(paymentMethod.Id, paymentMethod.Name);

            }
            traineeGridView.DataSource = dataTable;
            traineeGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
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
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Select a method";
                return;
            }
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Name is required.";
                return;
            }
            var paymentMethod = new PaymentMethod();
            paymentMethod.Id = Convert.ToInt32(IdTextBox.Text);
            paymentMethod.Name = nameTextBox.Text;
            if (new PaymentMethodManager().Update(paymentMethod))
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Updated!";
                IdTextBox.Text = "";
                nameTextBox.Text = "";
                LoadGridView(new PaymentMethodManager().GetAll());
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Update Failed!";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Select a method";
                return;
            }
            var paymentMethod = new PaymentMethod();
            if (new PaymentMethodManager().Delete(paymentMethod))
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Deleted!";
                IdTextBox.Text = "";
                nameTextBox.Text = "";
                LoadGridView(new PaymentMethodManager().GetAll());
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Delete Failed!";
            }
        }
    }
}
