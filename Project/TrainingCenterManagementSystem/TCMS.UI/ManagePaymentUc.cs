using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;

namespace TCMS.UI
{
    public partial class ManagePaymentUc : UserControl
    {
        public ManagePaymentUc()
        {
            InitializeComponent();
            this.traineeGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.paymentGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
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
        public void LoadGridView(IEnumerable<Payment> payments)
        {
            paymentGridView.DataSource = null;
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Trainee", typeof(string));
            dataTable.Columns.Add("Payment Method", typeof(string));
            dataTable.Columns.Add("Amount", typeof(int));

            paymentGridView.RowTemplate.Height = 50;
            foreach (var payment in payments)
            {
                dataTable.Rows.Add(payment.Id, payment.Date, (new TraineeManager().Search(payment.TraineeId)).Name,
                    new PaymentMethodManager().Search(payment.PaymentMethodId).Name, payment.Amount);
            }
            paymentGridView.DataSource = dataTable;
            paymentGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var trainees = new TraineeManager().GetAll();
            var selected = from trainee in trainees
                           where trainee.Name.ToLower().Contains(searchTextBox.text.ToLower())
                           select trainee;
            LoadGridView(selected);
        }

        private void showTotalButton_Click(object sender, EventArgs e)
        {
            var sum = 0;
            for (var i = 0; i < paymentGridView.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(paymentGridView.Rows[i].Cells[4].Value);
            }
            totalTextBox.Text = sum.ToString();
        }

        private void traineeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index < 0)
            {
                return;

            }
            var row = traineeGridView.Rows[index];
            var traineeId = Convert.ToInt32(row.Cells[0].Value);
            var payments = new PaymentManager().GetAll().Where(t => t.TraineeId == traineeId);
            LoadGridView(payments);
        }
    }
}
