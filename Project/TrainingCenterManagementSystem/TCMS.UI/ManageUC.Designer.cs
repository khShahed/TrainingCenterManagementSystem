namespace TCMS.UI
{
    partial class ManageUc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ManagePanel = new System.Windows.Forms.Panel();
            this.manageClassRoomButton = new ns1.BunifuTileButton();
            this.manageInstructorButton = new ns1.BunifuTileButton();
            this.paymentButton = new ns1.BunifuTileButton();
            this.assignStudentToBatchButton = new ns1.BunifuTileButton();
            this.managePaymentMethodButton = new ns1.BunifuTileButton();
            this.manageBatchButton = new ns1.BunifuTileButton();
            this.manageCourseButton = new ns1.BunifuTileButton();
            this.manageTraineeButton = new ns1.BunifuTileButton();
            this.ManagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagePanel
            // 
            this.ManagePanel.Controls.Add(this.manageClassRoomButton);
            this.ManagePanel.Controls.Add(this.manageInstructorButton);
            this.ManagePanel.Controls.Add(this.paymentButton);
            this.ManagePanel.Controls.Add(this.assignStudentToBatchButton);
            this.ManagePanel.Controls.Add(this.managePaymentMethodButton);
            this.ManagePanel.Controls.Add(this.manageBatchButton);
            this.ManagePanel.Controls.Add(this.manageCourseButton);
            this.ManagePanel.Controls.Add(this.manageTraineeButton);
            this.ManagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagePanel.Location = new System.Drawing.Point(0, 0);
            this.ManagePanel.Name = "ManagePanel";
            this.ManagePanel.Size = new System.Drawing.Size(930, 700);
            this.ManagePanel.TabIndex = 0;
            this.ManagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ManagePanel_Paint);
            // 
            // manageClassRoomButton
            // 
            this.manageClassRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageClassRoomButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageClassRoomButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageClassRoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageClassRoomButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.manageClassRoomButton.ForeColor = System.Drawing.Color.White;
            this.manageClassRoomButton.Image = global::TCMS.UI.Properties.Resources.Classroom_48px;
            this.manageClassRoomButton.ImagePosition = 20;
            this.manageClassRoomButton.ImageZoom = 50;
            this.manageClassRoomButton.LabelPosition = 41;
            this.manageClassRoomButton.LabelText = "Room";
            this.manageClassRoomButton.Location = new System.Drawing.Point(641, 91);
            this.manageClassRoomButton.Margin = new System.Windows.Forms.Padding(6);
            this.manageClassRoomButton.Name = "manageClassRoomButton";
            this.manageClassRoomButton.Size = new System.Drawing.Size(170, 146);
            this.manageClassRoomButton.TabIndex = 9;
            this.manageClassRoomButton.Click += new System.EventHandler(this.manageClassRoomButton_Click);
            // 
            // manageInstructorButton
            // 
            this.manageInstructorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageInstructorButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageInstructorButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageInstructorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageInstructorButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.manageInstructorButton.ForeColor = System.Drawing.Color.White;
            this.manageInstructorButton.Image = global::TCMS.UI.Properties.Resources.School_Director_48px;
            this.manageInstructorButton.ImagePosition = 20;
            this.manageInstructorButton.ImageZoom = 50;
            this.manageInstructorButton.LabelPosition = 41;
            this.manageInstructorButton.LabelText = "Instructor";
            this.manageInstructorButton.Location = new System.Drawing.Point(393, 91);
            this.manageInstructorButton.Margin = new System.Windows.Forms.Padding(6);
            this.manageInstructorButton.Name = "manageInstructorButton";
            this.manageInstructorButton.Size = new System.Drawing.Size(170, 146);
            this.manageInstructorButton.TabIndex = 8;
            this.manageInstructorButton.Click += new System.EventHandler(this.manageInstructorButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.paymentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paymentButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.paymentButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.paymentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.paymentButton.ForeColor = System.Drawing.Color.White;
            this.paymentButton.Image = global::TCMS.UI.Properties.Resources.Cash_In_Hand_48px;
            this.paymentButton.ImagePosition = 20;
            this.paymentButton.ImageZoom = 50;
            this.paymentButton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.paymentButton.LabelPosition = 51;
            this.paymentButton.LabelText = "Payment";
            this.paymentButton.Location = new System.Drawing.Point(141, 479);
            this.paymentButton.Margin = new System.Windows.Forms.Padding(6);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(170, 152);
            this.paymentButton.TabIndex = 3;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // assignStudentToBatchButton
            // 
            this.assignStudentToBatchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.assignStudentToBatchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.assignStudentToBatchButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.assignStudentToBatchButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.assignStudentToBatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assignStudentToBatchButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.assignStudentToBatchButton.ForeColor = System.Drawing.Color.White;
            this.assignStudentToBatchButton.Image = global::TCMS.UI.Properties.Resources.Shuffle_48px;
            this.assignStudentToBatchButton.ImagePosition = 20;
            this.assignStudentToBatchButton.ImageZoom = 50;
            this.assignStudentToBatchButton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.assignStudentToBatchButton.LabelPosition = 51;
            this.assignStudentToBatchButton.LabelText = "Assign Student to Batch";
            this.assignStudentToBatchButton.Location = new System.Drawing.Point(641, 479);
            this.assignStudentToBatchButton.Margin = new System.Windows.Forms.Padding(6);
            this.assignStudentToBatchButton.Name = "assignStudentToBatchButton";
            this.assignStudentToBatchButton.Size = new System.Drawing.Size(170, 146);
            this.assignStudentToBatchButton.TabIndex = 3;
            this.assignStudentToBatchButton.Click += new System.EventHandler(this.assignStudentToBatchButton_Click);
            // 
            // managePaymentMethodButton
            // 
            this.managePaymentMethodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.managePaymentMethodButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.managePaymentMethodButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.managePaymentMethodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managePaymentMethodButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.managePaymentMethodButton.ForeColor = System.Drawing.Color.White;
            this.managePaymentMethodButton.Image = global::TCMS.UI.Properties.Resources.Money_Bag_48px;
            this.managePaymentMethodButton.ImagePosition = 20;
            this.managePaymentMethodButton.ImageZoom = 50;
            this.managePaymentMethodButton.LabelPosition = 51;
            this.managePaymentMethodButton.LabelText = "Payment Method";
            this.managePaymentMethodButton.Location = new System.Drawing.Point(641, 285);
            this.managePaymentMethodButton.Margin = new System.Windows.Forms.Padding(6);
            this.managePaymentMethodButton.Name = "managePaymentMethodButton";
            this.managePaymentMethodButton.Size = new System.Drawing.Size(170, 146);
            this.managePaymentMethodButton.TabIndex = 4;
            this.managePaymentMethodButton.Click += new System.EventHandler(this.managePaymentMethodButton_Click);
            // 
            // manageBatchButton
            // 
            this.manageBatchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageBatchButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageBatchButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageBatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageBatchButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.manageBatchButton.ForeColor = System.Drawing.Color.White;
            this.manageBatchButton.Image = global::TCMS.UI.Properties.Resources.Paste_Special_48px;
            this.manageBatchButton.ImagePosition = 20;
            this.manageBatchButton.ImageZoom = 50;
            this.manageBatchButton.LabelPosition = 41;
            this.manageBatchButton.LabelText = "Batch";
            this.manageBatchButton.Location = new System.Drawing.Point(393, 285);
            this.manageBatchButton.Margin = new System.Windows.Forms.Padding(6);
            this.manageBatchButton.Name = "manageBatchButton";
            this.manageBatchButton.Size = new System.Drawing.Size(170, 146);
            this.manageBatchButton.TabIndex = 5;
            this.manageBatchButton.Click += new System.EventHandler(this.manageBatchButton_Click);
            // 
            // manageCourseButton
            // 
            this.manageCourseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageCourseButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageCourseButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageCourseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageCourseButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.manageCourseButton.ForeColor = System.Drawing.Color.White;
            this.manageCourseButton.Image = global::TCMS.UI.Properties.Resources.Book_48px;
            this.manageCourseButton.ImagePosition = 20;
            this.manageCourseButton.ImageZoom = 50;
            this.manageCourseButton.LabelPosition = 41;
            this.manageCourseButton.LabelText = "Course";
            this.manageCourseButton.Location = new System.Drawing.Point(141, 285);
            this.manageCourseButton.Margin = new System.Windows.Forms.Padding(6);
            this.manageCourseButton.Name = "manageCourseButton";
            this.manageCourseButton.Size = new System.Drawing.Size(170, 146);
            this.manageCourseButton.TabIndex = 6;
            this.manageCourseButton.Click += new System.EventHandler(this.manageCourseButton_Click);
            // 
            // manageTraineeButton
            // 
            this.manageTraineeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageTraineeButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageTraineeButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageTraineeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageTraineeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.manageTraineeButton.ForeColor = System.Drawing.Color.White;
            this.manageTraineeButton.Image = global::TCMS.UI.Properties.Resources.Student_Male_48px;
            this.manageTraineeButton.ImagePosition = 20;
            this.manageTraineeButton.ImageZoom = 50;
            this.manageTraineeButton.LabelPosition = 41;
            this.manageTraineeButton.LabelText = "Trainee";
            this.manageTraineeButton.Location = new System.Drawing.Point(141, 91);
            this.manageTraineeButton.Margin = new System.Windows.Forms.Padding(6);
            this.manageTraineeButton.Name = "manageTraineeButton";
            this.manageTraineeButton.Size = new System.Drawing.Size(170, 146);
            this.manageTraineeButton.TabIndex = 7;
            this.manageTraineeButton.Click += new System.EventHandler(this.manageTraineeButton_Click);
            // 
            // ManageUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ManagePanel);
            this.Name = "ManageUc";
            this.Size = new System.Drawing.Size(930, 700);
            this.ManagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManagePanel;
        private ns1.BunifuTileButton manageClassRoomButton;
        private ns1.BunifuTileButton manageInstructorButton;
        private ns1.BunifuTileButton assignStudentToBatchButton;
        private ns1.BunifuTileButton managePaymentMethodButton;
        private ns1.BunifuTileButton manageBatchButton;
        private ns1.BunifuTileButton manageCourseButton;
        private ns1.BunifuTileButton manageTraineeButton;
        private ns1.BunifuTileButton paymentButton;
    }
}
