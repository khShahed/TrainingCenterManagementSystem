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
    public partial class SavePaymentUc : UserControl
    {
        public SavePaymentUc()
        {
            InitializeComponent();
            this.traineeGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            LoadPaymentMethod();
            LoadGridView(new TraineeManager().GetAll());
            datePicker.Value = DateTime.Now.Date;
        }
        private void LoadPaymentMethod()
        {
            var paymentMehods = new PaymentMethodManager().GetAll();
            foreach (var comboboxItem in paymentMehods.Select(paymentMethod => new ComboboxItem { Text = paymentMethod.Name, Value = paymentMethod.Id }))
            {
                paymentMehtodComboBox.Items.Add(comboboxItem);
            }
            paymentMehtodComboBox.DisplayMember = "Text";
            paymentMehtodComboBox.ValueMember = "Value";
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

        private void traineeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            var row = traineeGridView.Rows[index];
            IdTextBox.Text = row.Cells[0].Value.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Select a trainee first.";
                return;
            }

            if (Convert.ToInt32(amountTextBox.Text) <= 0)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Amount should be greater than 0.";
                return;
            }
            if (paymentMehtodComboBox.SelectedItem == null)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Select payment method.";
                return;
            }
            var payment = new Payment
            {
                TraineeId = Convert.ToInt32(IdTextBox.Text),
                Amount = Convert.ToInt32(amountTextBox.Text),
                Date = datePicker.Value.Date,
                PaymentMethodId = ((ComboboxItem)paymentMehtodComboBox.SelectedItem).Value
            };
            if (new PaymentManager().Save(payment))
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Saved.";
                IdTextBox.Text = "";
                amountTextBox.Text = "";

            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Save failed.";
            }
        }

    }
}
