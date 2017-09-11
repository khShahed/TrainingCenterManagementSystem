using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;

namespace TCMS.UI
{
    public partial class SendEmailUc : UserControl
    {
        public SendEmailUc()
        {
            InitializeComponent();
            LoadTraineeGridView(new TraineeManager().GetAll());
            LoadComboBox();
        }

        public void LoadComboBox()
        {
            var batches = new BatchManager().GetAll();

            batchCombobox.Items.Add(new ComboboxItem { Text = "All Trainee", Value = 5000 });
            foreach (var batch in batches)
            {
                var comboboxItem = new ComboboxItem { Text = batch.Name, Value = batch.Id };
                batchCombobox.Items.Add(comboboxItem);
            }
            batchCombobox.DisplayMember = "Text";
            batchCombobox.ValueMember = "Value";
        }
        public void LoadTraineeGridView(IEnumerable<Trainee> trainees)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Photo", typeof(byte[]));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Send Email", typeof(bool));


            traineeGridView.RowTemplate.Height = 50;
            foreach (var trainee in trainees)
            {
                dataTable.Rows.Add(trainee.Id, trainee.Name, trainee.Photo, trainee.Email, true);

            }
            traineeGridView.DataSource = dataTable;
            traineeGridView.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }
        

        private void sendButton_Click_1(object sender, EventArgs e)
        {
            resultLabel.ForeColor = Color.Red;
            if (string.IsNullOrEmpty(EmailTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                resultLabel.Text = @"Enter email and password.";
                return;
            }
            if (string.IsNullOrEmpty(subjectTextBox.Text) && string.IsNullOrEmpty(bodyTextBox.Text))
            {
                resultLabel.Text = @"Enter subject or body.";
                return;
            }
            var basicAuthenticationInfo = new System.Net.NetworkCredential(EmailTextBox.Text, passwordTextBox.Text);


            int total = 0, failed = 0;
            for (var i = 0; i < traineeGridView.Rows.Count; ++i)
            {
                if (Convert.ToBoolean(traineeGridView.Rows[i].Cells[4].Value))
                {
                    try
                    {
                        total++;
                        MailMessage message = new MailMessage();
                        SmtpClient smtp = new SmtpClient();

                        message.From = new MailAddress(EmailTextBox.Text);
                        message.To.Add(new MailAddress(traineeGridView.Rows[i].Cells[3].Value.ToString()));
                        message.Subject = subjectTextBox.Text;
                        message.Body = bodyTextBox.Text;

                        smtp.Port = 587;
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(EmailTextBox.Text, passwordTextBox.Text);
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Send(message);
                    }
                    catch (Exception ex)
                    {
                        failed++;
                    }
                }

            }
            resultLabel.Text = failed + @" failed,";
            resultLabel.ForeColor = Color.Green;
            resultLabel.Text += " " + (total - failed) + @" successfull.";

        }

        private void batchCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (batchCombobox.SelectedItem == null) return;
            var selectedValue = ((ComboboxItem)(batchCombobox.SelectedItem)).Value;
            if (selectedValue == 5000)
            {
                LoadTraineeGridView(new TraineeManager().GetAll());
            }
            else
            {
                var selectedTraineeBatches = new TraineeBatchManager().GetAll().Where(tb => tb.BatchId == selectedValue);
                var traineeList = new List<Trainee>();
                var manager = new TraineeManager();
                foreach (TraineeBatch traineeBatch in selectedTraineeBatches)
                {
                    traineeList.Add(manager.Search(traineeBatch.TraineeId));
                }
                LoadTraineeGridView(traineeList);
            }
        }
    }
}
