using System;
using System.Windows.Forms;

namespace TCMS.UI
{
    public partial class ManageUc : UserControl
    {
        public ManageUc()
        {
            InitializeComponent();
        }

        private void ManagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageTraineeButton_Click(object sender, EventArgs e)
        {
            var manageTrainee = new ManageTraineeUc();
            ManagePanel.Controls.Clear();
            ManagePanel.Controls.Add(manageTrainee);
        }

        private void manageInstructorButton_Click(object sender, EventArgs e)
        {
            var manageTrainee = new ManageInstructorUc();
            ManagePanel.Controls.Clear();
            ManagePanel.Controls.Add(manageTrainee);
        }

        private void manageClassRoomButton_Click(object sender, EventArgs e)
        {
            var manageTrainee = new ManageRoomUc();
            ManagePanel.Controls.Clear();
            ManagePanel.Controls.Add(manageTrainee);
        }

        private void manageCourseButton_Click(object sender, EventArgs e)
        {
            var manageTrainee = new ManageCourseUc();
            ManagePanel.Controls.Clear();
            ManagePanel.Controls.Add(manageTrainee);
        }

        private void manageBatchButton_Click(object sender, EventArgs e)
        {
            var manageTrainee = new ManageBatchUc();
            ManagePanel.Controls.Clear();
            ManagePanel.Controls.Add(manageTrainee);
        }

        private void managePaymentMethodButton_Click(object sender, EventArgs e)
        {
            var managePaymentMehtodUc = new ManagePaymentMehtodUc();
            ManagePanel.Controls.Clear();
            ManagePanel.Controls.Add(managePaymentMehtodUc);
        }

        private void assignStudentToBatchButton_Click(object sender, EventArgs e)
        {
            var managePaymentMehtodUc = new AssignTraineeBatchUc();
            ManagePanel.Controls.Clear();
            ManagePanel.Controls.Add(managePaymentMehtodUc);
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            var managePaymentMehtodUc = new ManagePaymentUc();
            ManagePanel.Controls.Clear();
            ManagePanel.Controls.Add(managePaymentMehtodUc);
        }
    }
}
