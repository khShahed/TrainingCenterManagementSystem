using System;
using System.Threading;
using System.Windows.Forms;
using TCMS.BLL;
namespace TCMS.UI
{
    public partial class MainForm : Form
    {
        private static bool _firstLoad = false;
        public MainForm()
        {
            InitializeComponent();
            var dashboard = new DashboardUc();
            this.dashboardPanel.Controls.Clear();
            this.dashboardPanel.Controls.Add(dashboard);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Set form size maximized
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            var thread = new Thread(PrepareForUse);
            thread.Start();
            InactiveAll();
            dashboardButton.selected = true;
        }

        public static void PrepareForUse()
        {
            if (!_firstLoad)
            {
                new TraineeManager().GetAll();
            }
        }
        private void closeFormButton_Click(object sender, EventArgs e)
        {

            var dialog = MetroFramework.MetroMessageBox.Show(this,
                "Do you really want to exit?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InactiveAll();
            var addUserControl = new AddUc();
            this.dashboardPanel.Controls.Clear();
            this.dashboardPanel.Controls.Add(addUserControl);
            addButton.selected = true;
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            InactiveAll();
            dashboardButton.selected = true;
            var dashboard = new DashboardUc();
            this.dashboardPanel.Controls.Clear();
            this.dashboardPanel.Controls.Add(dashboard);
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            InactiveAll();
            var manageUserControl = new ManageUc();
            this.dashboardPanel.Controls.Clear();
            this.dashboardPanel.Controls.Add(manageUserControl);
            manageButton.selected = true;
        }

        public void InactiveAll()
        {
            dashboardButton.selected = false;
            addButton.selected = false;
            manageButton.selected = false;
        }

        private void sidebarResizerButton_Click(object sender, EventArgs e)
        {
            if (sidePanel.Width == 40)
            {
                sidePanel.Visible = false;
                sidePanel.Width = 184;
                animator.ShowSync(sidePanel);
            }
            else
            {
                sidePanel.Visible = false;
                sidePanel.Width = 40;
                animator.ShowSync(sidePanel);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            InactiveAll();
            var manageUserControl = new SendEmailUc();
            this.dashboardPanel.Controls.Clear();
            this.dashboardPanel.Controls.Add(manageUserControl);
            sendEmailButton.selected = true;
        }
    }
}
