using System;
using System.Windows.Forms;

namespace TCMS.UI
{
    public partial class AddUc : UserControl
    {
        public AddUc()
        {
            InitializeComponent();
            addPanel.Dock = DockStyle.Top;
        }

        private void addTraineeButton_Click(object sender, EventArgs e)
        {
            var saveTrainee = new SaveTraineeUc();
            this.addPanel.Controls.Clear();
            this.addPanel.Controls.Add(saveTrainee);
            saveTrainee.Dock = DockStyle.Fill;
            //Form form =  new Form();
            //form.Controls.Add(new SaveTraineeUserControl());
            //form.Size = new Size(800,600);
            //form.StartPosition = FormStartPosition.CenterParent;
            //form.ShowDialog();
        }

        private void addInstructorButton_Click(object sender, EventArgs e)
        {
            var saveInstructor = new SaveInstructorUc();
            this.addPanel.Controls.Clear();
            this.addPanel.Controls.Add(saveInstructor);
        }

        private void addClassRoomButton_Click(object sender, EventArgs e)
        {
            var saveInstructor = new SaveRoomUc();
            this.addPanel.Controls.Clear();
            this.addPanel.Controls.Add(saveInstructor);
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            var saveInstructor = new SaveCourseUc();
            this.addPanel.Controls.Clear();
            this.addPanel.Controls.Add(saveInstructor);
        }

        private void addBatchButton_Click(object sender, EventArgs e)
        {
            var saveInstructor = new SaveBatchUc();
            this.addPanel.Controls.Clear();
            this.addPanel.Controls.Add(saveInstructor);
        }

        private void addPaymentMethodButton_Click(object sender, EventArgs e)
        {
            var saveInstructor = new SavePaymentMethodUc();
            this.addPanel.Controls.Clear();
            this.addPanel.Controls.Add(saveInstructor);
        }

        private void addPayment_Click(object sender, EventArgs e)
        {
            var saveInstructor = new SavePaymentUc();
            this.addPanel.Controls.Clear();
            this.addPanel.Controls.Add(saveInstructor);
        }
    }
}
