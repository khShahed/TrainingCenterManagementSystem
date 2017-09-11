namespace TCMS.UI
{
    partial class ManageRoomUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRoomUc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.updateBtn = new ns1.BunifuFlatButton();
            this.deleteButton = new ns1.BunifuFlatButton();
            this.roomNoTextBox = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.IdTextBox = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.capacityTextBox = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.traineeGridView = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.roomNoTextBox);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.IdTextBox);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.capacityTextBox);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.traineeGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 700);
            this.panel1.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(444, 616);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 35;
            // 
            // updateBtn
            // 
            this.updateBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.BorderRadius = 0;
            this.updateBtn.ButtonText = "Update";
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateBtn.Iconimage")));
            this.updateBtn.Iconimage_right = null;
            this.updateBtn.Iconimage_right_Selected = null;
            this.updateBtn.Iconimage_Selected = null;
            this.updateBtn.IconMarginLeft = 0;
            this.updateBtn.IconMarginRight = 0;
            this.updateBtn.IconRightVisible = true;
            this.updateBtn.IconRightZoom = 0D;
            this.updateBtn.IconVisible = true;
            this.updateBtn.IconZoom = 90D;
            this.updateBtn.IsTab = false;
            this.updateBtn.Location = new System.Drawing.Point(297, 556);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.updateBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.updateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateBtn.selected = false;
            this.updateBtn.Size = new System.Drawing.Size(182, 48);
            this.updateBtn.TabIndex = 33;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Textcolor = System.Drawing.Color.White;
            this.updateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.BorderRadius = 0;
            this.deleteButton.ButtonText = "Delete";
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.DisabledColor = System.Drawing.Color.Gray;
            this.deleteButton.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("deleteButton.Iconimage")));
            this.deleteButton.Iconimage_right = null;
            this.deleteButton.Iconimage_right_Selected = null;
            this.deleteButton.Iconimage_Selected = null;
            this.deleteButton.IconMarginLeft = 0;
            this.deleteButton.IconMarginRight = 0;
            this.deleteButton.IconRightVisible = true;
            this.deleteButton.IconRightZoom = 0D;
            this.deleteButton.IconVisible = true;
            this.deleteButton.IconZoom = 90D;
            this.deleteButton.IsTab = false;
            this.deleteButton.Location = new System.Drawing.Point(512, 556);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.deleteButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.deleteButton.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteButton.selected = false;
            this.deleteButton.Size = new System.Drawing.Size(181, 48);
            this.deleteButton.TabIndex = 34;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Textcolor = System.Drawing.Color.White;
            this.deleteButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomNoTextBox.Enabled = false;
            this.roomNoTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.roomNoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.roomNoTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.roomNoTextBox.HintText = "";
            this.roomNoTextBox.isPassword = false;
            this.roomNoTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.roomNoTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.roomNoTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.roomNoTextBox.LineThickness = 3;
            this.roomNoTextBox.Location = new System.Drawing.Point(322, 439);
            this.roomNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(308, 32);
            this.roomNoTextBox.TabIndex = 29;
            this.roomNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(246, 454);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(70, 17);
            this.bunifuCustomLabel3.TabIndex = 31;
            this.bunifuCustomLabel3.Text = "Room No";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.IdTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.IdTextBox.HintText = "";
            this.IdTextBox.isPassword = false;
            this.IdTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.IdTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.IdTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.IdTextBox.LineThickness = 3;
            this.IdTextBox.Location = new System.Drawing.Point(322, 375);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(308, 32);
            this.IdTextBox.TabIndex = 29;
            this.IdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(246, 390);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(21, 17);
            this.bunifuCustomLabel2.TabIndex = 31;
            this.bunifuCustomLabel2.Text = "ID";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.capacityTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.capacityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.capacityTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.capacityTextBox.HintText = "";
            this.capacityTextBox.isPassword = false;
            this.capacityTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.capacityTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.capacityTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.capacityTextBox.LineThickness = 3;
            this.capacityTextBox.Location = new System.Drawing.Point(322, 493);
            this.capacityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(308, 32);
            this.capacityTextBox.TabIndex = 30;
            this.capacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(237, 508);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 17);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "Capacity";
            // 
            // traineeGridView
            // 
            this.traineeGridView.BackgroundColor = System.Drawing.Color.White;
            this.traineeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traineeGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.traineeGridView.Location = new System.Drawing.Point(15, 118);
            this.traineeGridView.Name = "traineeGridView";
            this.traineeGridView.Size = new System.Drawing.Size(897, 225);
            this.traineeGridView.TabIndex = 8;
            this.traineeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellContentClick);
            this.traineeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellContentClick);
            this.traineeGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellContentClick);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 26);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(122, 20);
            this.bunifuCustomLabel4.TabIndex = 81;
            this.bunifuCustomLabel4.Text = "Manage Rooms";
            // 
            // ManageRoomUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ManageRoomUc";
            this.Size = new System.Drawing.Size(930, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView traineeGridView;
        private ns1.BunifuFlatButton updateBtn;
        private ns1.BunifuFlatButton deleteButton;
        private ns1.BunifuMaterialTextbox IdTextBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuMaterialTextbox capacityTextBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label resultLabel;
        private ns1.BunifuMaterialTextbox roomNoTextBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
    }
}
