using System;
using System.Drawing;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;

namespace TCMS.UI
{
    public partial class SavePaymentMethodUc : UserControl
    {
        public SavePaymentMethodUc()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Name is required!";
                return;
            }
            if (new PaymentMethodManager().SearchName(nameTextBox.Text) != null)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Name must be unique!";
                return;
            }
            var paymentMethod = new PaymentMethod();
            paymentMethod.Name = nameTextBox.Text;
            if (new PaymentMethodManager().Save(paymentMethod))
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Saved!";
                nameTextBox.Text = "";
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"save failed!";
            }
        }
    }
}
