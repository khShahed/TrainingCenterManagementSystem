namespace TCMS.UI
{
    partial class AssignTraineeBatchUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignTraineeBatchUc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.batchComboBox = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.saveButton = new ns1.BunifuFlatButton();
            this.discountTextBox = new ns1.BunifuMaterialTextbox();
            this.Discount = new ns1.BunifuCustomLabel();
            this.assignedTextBox = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.capacityTextBox = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.feeTextBox = new ns1.BunifuMaterialTextbox();
            this.Fee = new ns1.BunifuCustomLabel();
            this.IdTextBox = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.traineeGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new ns1.BunifuTextbox();
            this.searchButton = new ns1.BunifuFlatButton();
            this.label1 = new ns1.BunifuCustomLabel();
            this.manageButton = new ns1.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Controls.Add(this.batchComboBox);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.manageButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.discountTextBox);
            this.panel1.Controls.Add(this.Discount);
            this.panel1.Controls.Add(this.assignedTextBox);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.capacityTextBox);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.feeTextBox);
            this.panel1.Controls.Add(this.Fee);
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
            this.resultLabel.Location = new System.Drawing.Point(130, 533);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 46;
            // 
            // batchComboBox
            // 
            this.batchComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchComboBox.FormattingEnabled = true;
            this.batchComboBox.Location = new System.Drawing.Point(113, 227);
            this.batchComboBox.Name = "batchComboBox";
            this.batchComboBox.Size = new System.Drawing.Size(290, 25);
            this.batchComboBox.TabIndex = 45;
            this.batchComboBox.SelectedIndexChanged += new System.EventHandler(this.batchComboBox_SelectedIndexChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(59, 230);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(45, 17);
            this.bunifuCustomLabel3.TabIndex = 44;
            this.bunifuCustomLabel3.Text = "Batch";
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
            this.saveButton.Location = new System.Drawing.Point(113, 478);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(207, 48);
            this.saveButton.TabIndex = 43;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // discountTextBox
            // 
            this.discountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.discountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.discountTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.discountTextBox.HintText = "";
            this.discountTextBox.isPassword = false;
            this.discountTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.discountTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.discountTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.discountTextBox.LineThickness = 3;
            this.discountTextBox.Location = new System.Drawing.Point(112, 426);
            this.discountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(290, 32);
            this.discountTextBox.TabIndex = 39;
            this.discountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(41, 441);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(64, 17);
            this.Discount.TabIndex = 41;
            this.Discount.Text = "Discount";
            // 
            // assignedTextBox
            // 
            this.assignedTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.assignedTextBox.Enabled = false;
            this.assignedTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.assignedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.assignedTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.assignedTextBox.HintText = "";
            this.assignedTextBox.isPassword = false;
            this.assignedTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.assignedTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.assignedTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.assignedTextBox.LineThickness = 3;
            this.assignedTextBox.Location = new System.Drawing.Point(112, 375);
            this.assignedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.assignedTextBox.Name = "assignedTextBox";
            this.assignedTextBox.Size = new System.Drawing.Size(290, 32);
            this.assignedTextBox.TabIndex = 40;
            this.assignedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(45, 390);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(64, 17);
            this.bunifuCustomLabel4.TabIndex = 42;
            this.bunifuCustomLabel4.Text = "Assigned";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.capacityTextBox.Enabled = false;
            this.capacityTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.capacityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.capacityTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.capacityTextBox.HintText = "";
            this.capacityTextBox.isPassword = false;
            this.capacityTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.capacityTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.capacityTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.capacityTextBox.LineThickness = 3;
            this.capacityTextBox.Location = new System.Drawing.Point(112, 324);
            this.capacityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(290, 32);
            this.capacityTextBox.TabIndex = 40;
            this.capacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(41, 339);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 17);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Capacity";
            // 
            // feeTextBox
            // 
            this.feeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.feeTextBox.Enabled = false;
            this.feeTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.feeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.feeTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.feeTextBox.HintText = "";
            this.feeTextBox.isPassword = false;
            this.feeTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.feeTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.feeTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.feeTextBox.LineThickness = 3;
            this.feeTextBox.Location = new System.Drawing.Point(112, 270);
            this.feeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(290, 32);
            this.feeTextBox.TabIndex = 40;
            this.feeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Fee
            // 
            this.Fee.AutoSize = true;
            this.Fee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fee.Location = new System.Drawing.Point(74, 285);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(30, 17);
            this.Fee.TabIndex = 42;
            this.Fee.Text = "Fee";
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
            this.IdTextBox.Location = new System.Drawing.Point(112, 162);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(290, 32);
            this.IdTextBox.TabIndex = 40;
            this.IdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(34, 177);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 17);
            this.bunifuCustomLabel2.TabIndex = 42;
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
            this.traineeGridView.Location = new System.Drawing.Point(409, 162);
            this.traineeGridView.Name = "traineeGridView";
            this.traineeGridView.RowTemplate.ReadOnly = true;
            this.traineeGridView.Size = new System.Drawing.Size(489, 217);
            this.traineeGridView.TabIndex = 38;
            this.traineeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.Silver;
            this.searchTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTextBox.BackgroundImage")));
            this.searchTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTextBox.Icon")));
            this.searchTextBox.Location = new System.Drawing.Point(468, 81);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 43);
            this.searchTextBox.TabIndex = 37;
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
            this.searchButton.Location = new System.Drawing.Point(739, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchButton.OnHoverTextColor = System.Drawing.Color.White;
            this.searchButton.selected = false;
            this.searchButton.Size = new System.Drawing.Size(159, 43);
            this.searchButton.TabIndex = 36;
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
            this.label1.Location = new System.Drawing.Point(394, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Name";
            // 
            // manageButton
            // 
            this.manageButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageButton.BorderRadius = 0;
            this.manageButton.ButtonText = "Manage";
            this.manageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageButton.DisabledColor = System.Drawing.Color.Gray;
            this.manageButton.Iconcolor = System.Drawing.Color.Transparent;
            this.manageButton.Iconimage = global::TCMS.UI.Properties.Resources.Ok_48px;
            this.manageButton.Iconimage_right = null;
            this.manageButton.Iconimage_right_Selected = null;
            this.manageButton.Iconimage_Selected = null;
            this.manageButton.IconMarginLeft = 0;
            this.manageButton.IconMarginRight = 0;
            this.manageButton.IconRightVisible = true;
            this.manageButton.IconRightZoom = 0D;
            this.manageButton.IconVisible = true;
            this.manageButton.IconZoom = 90D;
            this.manageButton.IsTab = false;
            this.manageButton.Location = new System.Drawing.Point(371, 478);
            this.manageButton.Name = "manageButton";
            this.manageButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.manageButton.OnHoverTextColor = System.Drawing.Color.White;
            this.manageButton.selected = false;
            this.manageButton.Size = new System.Drawing.Size(207, 48);
            this.manageButton.TabIndex = 43;
            this.manageButton.Text = "Manage";
            this.manageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageButton.Textcolor = System.Drawing.Color.White;
            this.manageButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // AssignTraineeBatchUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AssignTraineeBatchUc";
            this.Size = new System.Drawing.Size(930, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuFlatButton saveButton;
        private ns1.BunifuMaterialTextbox discountTextBox;
        private ns1.BunifuCustomLabel Discount;
        private ns1.BunifuMaterialTextbox IdTextBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridView traineeGridView;
        private ns1.BunifuTextbox searchTextBox;
        private ns1.BunifuFlatButton searchButton;
        private ns1.BunifuCustomLabel label1;
        private System.Windows.Forms.ComboBox batchComboBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuMaterialTextbox feeTextBox;
        private ns1.BunifuCustomLabel Fee;
        private ns1.BunifuMaterialTextbox assignedTextBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuMaterialTextbox capacityTextBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label resultLabel;
        private ns1.BunifuFlatButton manageButton;
    }
}
