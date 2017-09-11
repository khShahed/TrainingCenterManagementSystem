namespace TCMS.UI
{
    partial class SaveRoomUc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.saveButton = new ns1.BunifuFlatButton();
            this.capacityTextBox = new ns1.BunifuMaterialTextbox();
            this.label2 = new ns1.BunifuCustomLabel();
            this.roomIdTextBox = new ns1.BunifuMaterialTextbox();
            this.jlksf = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.capacityTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.roomIdTextBox);
            this.panel1.Controls.Add(this.jlksf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 700);
            this.panel1.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(380, 369);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 42;
            // 
            // saveButton
            // 
            this.saveButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.BorderRadius = 0;
            this.saveButton.ButtonText = "Save";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.DisabledColor = System.Drawing.Color.Gray;
            this.saveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.saveButton.Iconimage = global::TCMS.UI.Properties.Resources.Ok_48px;
            this.saveButton.Iconimage_right = null;
            this.saveButton.Iconimage_right_Selected = null;
            this.saveButton.Iconimage_Selected = null;
            this.saveButton.IconMarginLeft = 0;
            this.saveButton.IconMarginRight = 0;
            this.saveButton.IconRightVisible = true;
            this.saveButton.IconRightZoom = 0D;
            this.saveButton.IconVisible = true;
            this.saveButton.IconZoom = 90D;
            this.saveButton.IsTab = false;
            this.saveButton.Location = new System.Drawing.Point(380, 302);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(207, 48);
            this.saveButton.TabIndex = 41;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.capacityTextBox.Location = new System.Drawing.Point(380, 203);
            this.capacityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(308, 32);
            this.capacityTextBox.TabIndex = 38;
            this.capacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Room Capacity";
            // 
            // roomIdTextBox
            // 
            this.roomIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomIdTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.roomIdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.roomIdTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.roomIdTextBox.HintText = "";
            this.roomIdTextBox.isPassword = false;
            this.roomIdTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.roomIdTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.roomIdTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.roomIdTextBox.LineThickness = 3;
            this.roomIdTextBox.Location = new System.Drawing.Point(380, 132);
            this.roomIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomIdTextBox.Name = "roomIdTextBox";
            this.roomIdTextBox.Size = new System.Drawing.Size(308, 32);
            this.roomIdTextBox.TabIndex = 37;
            this.roomIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // jlksf
            // 
            this.jlksf.AutoSize = true;
            this.jlksf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jlksf.Location = new System.Drawing.Point(243, 147);
            this.jlksf.Name = "jlksf";
            this.jlksf.Size = new System.Drawing.Size(70, 17);
            this.jlksf.TabIndex = 40;
            this.jlksf.Text = "Room No";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(3, 17);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(92, 20);
            this.bunifuCustomLabel9.TabIndex = 84;
            this.bunifuCustomLabel9.Text = "Save Room";
            // 
            // SaveRoomUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SaveRoomUc";
            this.Size = new System.Drawing.Size(930, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuFlatButton saveButton;
        private ns1.BunifuMaterialTextbox capacityTextBox;
        private ns1.BunifuCustomLabel label2;
        private ns1.BunifuMaterialTextbox roomIdTextBox;
        private ns1.BunifuCustomLabel jlksf;
        private System.Windows.Forms.Label resultLabel;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
    }
}
