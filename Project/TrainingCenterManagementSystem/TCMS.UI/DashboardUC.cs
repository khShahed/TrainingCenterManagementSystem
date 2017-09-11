using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TCMS.BLL;

namespace TCMS.UI
{
    public partial class DashboardUc : UserControl
    {
        public DashboardUc()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var courseThread = new Thread(LoadCourses);
            var batchThread = new Thread(LoadBatch);
            var earningThread = new Thread(LoadEarning);
            earningThread.Start();
            courseThread.Start();
            batchThread.Start();
        }

        private void LoadCourses()
        {
            var count = new CourseManager().GetAll().Count;
            if (totalCoursetLabel.InvokeRequired)
            {
                totalCoursetLabel.Invoke((MethodInvoker)delegate
                {
                    totalCoursetLabel.Text = count.ToString();
                });
            }
            else
            {
                totalCoursetLabel.Text = count.ToString();
            }
        }

        void LoadEarning()
        {
            var earns = new PaymentManager().GetAll();
            var selected = earns.Where(er => er.Date > DateTime.Now.AddDays(-30));
            var sum = selected.Sum(payment => payment.Amount);
            if (totalEarnLabel.InvokeRequired)
            {
                totalEarnLabel.Invoke((MethodInvoker)delegate { totalEarnLabel.Text = sum.ToString() + @" TK"; });
            }
            else
            {
                totalEarnLabel.Text = sum.ToString() + @" TK";
            }
        }
        private void LoadBatch()
        {
            var batchCount = new BatchManager().GetAll().Count;
            if (totalBatchLabel.InvokeRequired)
            {
                totalBatchLabel.Invoke((MethodInvoker)delegate { totalBatchLabel.Text = batchCount.ToString(); });
            }
            else
            {
                totalBatchLabel.Text = batchCount.ToString();
            }
        }
    }
}
