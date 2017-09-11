namespace TCMS.UI
{
    partial class SavePaymentUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavePaymentUc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.paymentMehtodComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new ns1.BunifuFlatButton();
            this.datePicker = new ns1.BunifuDatepicker();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.amountTextBox = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.IdTextBox = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.traineeGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new ns1.BunifuTextbox();
            this.searchButton = new ns1.BunifuFlatButton();
            this.label1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Controls.Add(this.paymentMehtodComboBox);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.amountTextBox);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.IdTextBox);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.traineeGridView);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 700);
            this.panel1.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(124, 495);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 36;
            // 
            // paymentMehtodComboBox
            // 
            this.paymentMehtodComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMehtodComboBox.FormattingEnabled = true;
            this.paymentMehtodComboBox.Location = new System.Drawing.Point(124, 338);
            this.paymentMehtodComboBox.Name = "paymentMehtodComboBox";
            this.paymentMehtodComboBox.Size = new System.Drawing.Size(290, 25);
            this.paymentMehtodComboBox.TabIndex = 35;
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
            this.saveButton.Location = new System.Drawing.Point(124, 440);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(207, 48);
            this.saveButton.TabIndex = 34;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.SystemColors.Control;
            this.datePicker.BorderRadius = 0;
            this.datePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.FormatCustom = null;
            this.datePicker.Location = new System.Drawing.Point(124, 206);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(290, 45);
            this.datePicker.TabIndex = 32;
            this.datePicker.Value = new System.DateTime(2016, 12, 25, 10, 46, 46, 0);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(82, 234);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(40, 17);
            this.bunifuCustomLabel4.TabIndex = 33;
            this.bunifuCustomLabel4.Text = "Date";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.amountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.amountTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.amountTextBox.HintText = "";
            this.amountTextBox.isPassword = false;
            this.amountTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.amountTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.amountTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.amountTextBox.LineThickness = 3;
            this.amountTextBox.Location = new System.Drawing.Point(124, 271);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(290, 32);
            this.amountTextBox.TabIndex = 30;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 341);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(119, 17);
            this.bunifuCustomLabel3.TabIndex = 31;
            this.bunifuCustomLabel3.Text = "Payment Mehtod";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(62, 286);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(60, 17);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "Amount";
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
            this.IdTextBox.Location = new System.Drawing.Point(124, 152);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(290, 32);
            this.IdTextBox.TabIndex = 30;
            this.IdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(52, 167);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 17);
            this.bunifuCustomLabel2.TabIndex = 31;
            this.bunifuCustomLabel2.Text = "Trainee ID";
            // 
            // traineeGridView
            // 
            this.traineeGridView.AllowUserToAddRows = false;
            this.traineeGridView.AllowUserToDeleteRows = false;
            this.traineeGridView.AllowUserToOrderColumns = true;
            this.traineeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.traineeGridView.BackgroundColor = System.Drawing.Color.White;
            this.traineeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traineeGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.traineeGridView.Location = new System.Drawing.Point(421, 152);
            this.traineeGridView.Name = "traineeGridView";
            this.traineeGridView.Size = new System.Drawing.Size(489, 217);
            this.traineeGridView.TabIndex = 29;
            this.traineeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellContentClick);
            this.traineeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellContentClick);
            this.traineeGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellContentClick);
            this.traineeGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellContentClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.Silver;
            this.searchTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTextBox.BackgroundImage")));
            this.searchTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTextBox.Icon")));
            this.searchTextBox.Location = new System.Drawing.Point(480, 71);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 43);
            this.searchTextBox.TabIndex = 28;
            this.searchTextBox.text = "";
            // 
            // searchButton
            // 
            this.searchButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.BorderRadius = 0;
            this.searchButton.ButtonText = "Search";
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.DisabledColor = System.Drawing.Color.Gray;
            this.searchButton.Iconcolor = System.Drawing.Color.Transparent;
            this.searchButton.Iconimage = null;
            this.searchButton.Iconimage_right = null;
            this.searchButton.Iconimage_right_Selected = null;
            this.searchButton.Iconimage_Selected = null;
            this.searchButton.IconMarginLeft = 0;
            this.searchButton.IconMarginRight = 0;
            this.searchButton.IconRightVisible = true;
            this.searchButton.IconRightZoom = 0D;
            this.searchButton.IconVisible = true;
            this.searchButton.IconZoom = 90D;
            this.searchButton.IsTab = false;
            this.searchButton.Location = new System.Drawing.Point(751, 71);
            this.searchButton.Name = "searchButton";
            this.searchButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchButton.OnHoverTextColor = System.Drawing.Color.White;
            this.searchButton.selected = false;
            this.searchButton.Size = new System.Drawing.Size(159, 43);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.Textcolor = System.Drawing.Color.White;
            this.searchButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(2, 22);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(111, 20);
            this.bunifuCustomLabel9.TabIndex = 84;
            this.bunifuCustomLabel9.Text = "Save Payment";
            // 
            // SavePaymentUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SavePaymentUc";
            this.Size = new System.Drawing.Size(930, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuMaterialTextbox IdTextBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridView traineeGridView;
        private ns1.BunifuTextbox searchTextBox;
        private ns1.BunifuFlatButton searchButton;
        private ns1.BunifuCustomLabel label1;
        private ns1.BunifuFlatButton saveButton;
        private ns1.BunifuDatepicker datePicker;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuMaterialTextbox amountTextBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox paymentMehtodComboBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Label resultLabel;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
    }
}
