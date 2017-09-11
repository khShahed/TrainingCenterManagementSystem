using System;
using System.Drawing;
using System.Windows.Forms;
using TCMS.BLL;
using TCMS.Models;

namespace TCMS.UI
{
    public partial class SaveRoomUc : UserControl
    {
        public SaveRoomUc()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (new RoomManager().IsRoomNoExist(roomIdTextBox.Text))
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Room No must be unique!";
            }
            var room = new Room { RoomNo = roomIdTextBox.Text, Capacity = Convert.ToInt32(capacityTextBox.Text) };
            if (room.Capacity < 0)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = @"Room capacity must be positive!";
            }
            if (new RoomManager().Save(room))
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
            roomIdTextBox.Text = "";
            capacityTextBox.Text = "";
        }
    }
}
