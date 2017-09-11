namespace TCMS.UI
{
    partial class ManageTraineeBranchUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTraineeBranchUc));
            this.traineeGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new ns1.BunifuTextbox();
            this.searchButton = new ns1.BunifuFlatButton();
            this.label1 = new ns1.BunifuCustomLabel();
            this.unassignButton = new ns1.BunifuFlatButton();
            this.resultLabel = new System.Windows.Forms.Label();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.traineeGridView)).BeginInit();
            this.SuspendLayout();
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
            this.traineeGridView.Location = new System.Drawing.Point(17, 154);
            this.traineeGridView.Name = "traineeGridView";
            this.traineeGridView.Size = new System.Drawing.Size(897, 510);
            this.traineeGridView.TabIndex = 8;
            this.traineeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traineeGridView_CellContentClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.Silver;
            this.searchTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTextBox.BackgroundImage")));
            this.searchTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTextBox.Icon")));
            this.searchTextBox.Location = new System.Drawing.Point(102, 68);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(361, 43);
            this.searchTextBox.TabIndex = 7;
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
            this.searchButton.Location = new System.Drawing.Point(469, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.searchButton.OnHoverTextColor = System.Drawing.Color.White;
            this.searchButton.selected = false;
            this.searchButton.Size = new System.Drawing.Size(159, 43);
            this.searchButton.TabIndex = 6;
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
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // unassignButton
            // 
            this.unassignButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.unassignButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.unassignButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.unassignButton.BorderRadius = 0;
            this.unassignButton.ButtonText = "Unassign";
            this.unassignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unassignButton.DisabledColor = System.Drawing.Color.Gray;
            this.unassignButton.Iconcolor = System.Drawing.Color.Transparent;
            this.unassignButton.Iconimage = null;
            this.unassignButton.Iconimage_right = null;
            this.unassignButton.Iconimage_right_Selected = null;
            this.unassignButton.Iconimage_Selected = null;
            this.unassignButton.IconMarginLeft = 0;
            this.unassignButton.IconMarginRight = 0;
            this.unassignButton.IconRightVisible = true;
            this.unassignButton.IconRightZoom = 0D;
            this.unassignButton.IconVisible = true;
            this.unassignButton.IconZoom = 90D;
            this.unassignButton.IsTab = false;
            this.unassignButton.Location = new System.Drawing.Point(647, 68);
            this.unassignButton.Name = "unassignButton";
            this.unassignButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.unassignButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.unassignButton.OnHoverTextColor = System.Drawing.Color.White;
            this.unassignButton.selected = false;
            this.unassignButton.Size = new System.Drawing.Size(159, 43);
            this.unassignButton.TabIndex = 6;
            this.unassignButton.Text = "Unassign";
            this.unassignButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unassignButton.Textcolor = System.Drawing.Color.White;
            this.unassignButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unassignButton.Click += new System.EventHandler(this.unassignButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(644, 114);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 9;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 18);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(201, 20);
            this.bunifuCustomLabel4.TabIndex = 82;
            this.bunifuCustomLabel4.Text = "Manage Trainee and Batch";
            // 
            // ManageTraineeBranchUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.traineeGridView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.unassignButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Name = "ManageTraineeBranchUc";
            this.Size = new System.Drawing.Size(930, 700);
            ((System.ComponentModel.ISupportInitialize)(this.traineeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView traineeGridView;
        private ns1.BunifuTextbox searchTextBox;
        private ns1.BunifuFlatButton searchButton;
        private ns1.BunifuCustomLabel label1;
        private ns1.BunifuFlatButton unassignButton;
        private System.Windows.Forms.Label resultLabel;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
    }
}
