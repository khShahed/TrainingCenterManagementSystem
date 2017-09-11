namespace TCMS.UI
{
    partial class ManagePaymentUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePaymentUc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.totalTextBox = new ns1.BunifuMetroTextbox();
            this.paymentGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new ns1.BunifuTextbox();
            this.showTotalButton = new ns1.BunifuFlatButton();
            this.searchButton = new ns1.BunifuFlatButton();
            this.label1 = new ns1.BunifuCustomLabel();
            this.traineeGridView = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.traineeGridView);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.totalTextBox);
            this.panel1.Controls.Add(this.paymentGridView);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.showTotalButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 700);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 17);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(133, 20);
            this.bunifuCustomLabel4.TabIndex = 81;
            this.bunifuCustomLabel4.Text = "Manage Payment";
            // 
            // totalTextBox
            // 
            this.totalTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.totalTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.totalTextBox.BorderThickness = 3;
            this.totalTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.totalTextBox.isPassword = false;
            this.totalTextBox.Location = new System.Drawing.Point(716, 618);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(199, 43);
            this.totalTextBox.TabIndex = 43;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paymentGridView
            // 
            this.paymentGridView.AllowUserToAddRows = false;
            this.paymentGridView.AllowUserToDeleteRows = false;
            this.paymentGridView.AllowUserToOrderColumns = true;
            this.paymentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.paymentGridView.BackgroundColor = System.Drawing.Color.White;
            this.paymentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.paymentGridView.Location = new System.Drawing.Point(18, 406);
            this.paymentGridView.Name = "paymentGridView";
            this.paymentGridView.RowTemplate.ReadOnly = true;
            this.paymentGridView.Size = new System.Drawing.Size(897, 206);
            this.paymentGridView.TabIndex = 42;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.Silver;
            this.searchTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTextBox.BackgroundImage")));
            this.searchTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTextBox.Icon")));
            this.searchTextBox.Location = new System.Drawing.Point(183, 81);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(492, 43);
            this.searchTextBox.TabIndex = 41;
            this.searchTextBox.text = "";
            // 
            // showTotalButton
            // 
            this.showTotalButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.showTotalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.showTotalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showTotalButton.BorderRadius = 0;
            this.showTotalButton.ButtonText = "Show Total";
            this.showTotalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showTotalButton.DisabledColor = System.Drawing.Color.Gray;
            this.showTotalButton.Iconcolor = System.Drawing.Color.Transparent;
            this.showTotalButton.Iconimage = null;
            this.showTotalButton.Iconimage_right = null;
            this.showTotalButton.Iconimage_right_Selected = null;
            this.showTotalButton.Iconimage_Selected = null;
            this.showTotalButton.IconMarginLeft = 0;
            this.showTotalButton.IconMarginRight = 0;
            this.showTotalButton.IconRightVisible = true;
            this.showTotalButton.IconRightZoom = 0D;
            this.showTotalButton.IconVisible = true;
            this.showTotalButton.IconZoom = 90D;
            this.showTotalButton.IsTab = false;
            this.showTotalButton.Location = new System.Drawing.Point(566, 618);
            this.showTotalButton.Name = "showTotalButton";
            this.showTotalButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.showTotalButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.showTotalButton.OnHoverTextColor = System.Drawing.Color.White;
            this.showTotalButton.selected = false;
            this.showTotalButton.Size = new System.Drawing.Size(142, 43);
            this.showTotalButton.TabIndex = 40;
            this.showTotalButton.Text = "Show Total";
            this.showTotalButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showTotalButton.Textcolor = System.Drawing.Color.White;
            this.showTotalButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTotalButton.Click += new System.EventHandler(this.showTotalButton_Click);
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
            this.searchButton.Location = new System.Drawing.Point(681, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchButton.OnHoverTextColor = System.Drawing.Color.White;
            this.searchButton.selected = false;
            this.searchButton.Size = new System.Drawing.Size(159, 43);
            this.searchButton.TabIndex = 40;
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
            this.label1.Location = new System.Drawing.Point(126, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Name";
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
            this.traineeGridView.Location = new System.Drawing.Point(18, 146);
            this.traineeGridView.Name = "traineeGridView";
            this.traineeGridView.Size = new System.Drawing.Size(897, 217);
            this.traineeGridView.TabIndex = 82;
            this.traineeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellContentClick);
            this.traineeGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellContentClick);
            this.traineeGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellContentClick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(14, 375);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel1.TabIndex = 81;
            this.bunifuCustomLabel1.Text = "Payments";
            // 
            // ManagePaymentUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ManagePaymentUc";
            this.Size = new System.Drawing.Size(930, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView paymentGridView;
        private ns1.BunifuTextbox searchTextBox;
        private ns1.BunifuFlatButton searchButton;
        private ns1.BunifuCustomLabel label1;
        private ns1.BunifuFlatButton showTotalButton;
        private ns1.BunifuMetroTextbox totalTextBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.DataGridView traineeGridView;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
    }
}
