using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;
namespace TCMS.UI
{
    public partial class SaveTraineeUc : UserControl
    {
        public SaveTraineeUc()
        {
            InitializeComponent();
        }

        private void loadPhotoButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = @"JPG FIles(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*",
                Title = @"Select trainee photo."
            };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            var picLoc = dialog.FileName;
            traineePictureBox.ImageLocation = picLoc;
            pathTextBox.Text = picLoc;
        }

        private void saveTraineePanel_Paint(object sender, PaintEventArgs e)
        {
            datePicker.Value = DateTime.Now.Date;
        }

        private void saveButton_Click(object sender, EventArgs e)
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
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Enter a email!";
                return;
            }
            if (new TraineeManager().SearchEmail(emailTextBox.Text) != null || new TraineeManager().SearchPhone(phoneTextBox.Text) != null)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Enter unique email and phone!";
                return;
            }
            byte[] photoBytes = null;
            if (!string.IsNullOrEmpty(pathTextBox.Text))
            {
                var fileStream = new FileStream(pathTextBox.Text, FileMode.Open, FileAccess.Read);
                var binaryReader = new BinaryReader(fileStream);
                photoBytes = binaryReader.ReadBytes((int)fileStream.Length);
            }

            var trainee = new Trainee
            {
                Name = nameTextBox.Text,
                Photo = photoBytes,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
                DateOfBirth = datePicker.Value,
                FatherName = fatherNameTextBox.Text,
                MotherName = motherNameTextBox.Text,
                CurrentAddress = currentAddress.Text,
                PermanentAddress = permanentAddressTextBox.Text
            };

            if (new TraineeManager().Save(trainee))
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = @"Saved!";
                ClearAll();
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Save Failed!";
            }

        }

        void ClearAll()
        {
            nameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            motherNameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
            currentAddress.Text = "";
            permanentAddressTextBox.Text = "";
            pathTextBox.Text = "";
        }
    }
}
