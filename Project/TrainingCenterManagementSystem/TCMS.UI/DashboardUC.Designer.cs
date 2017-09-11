namespace TCMS.UI
{
    partial class DashboardUc
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
            this.bunifuCards2 = new ns1.BunifuCards();
            this.label3 = new System.Windows.Forms.Label();
            this.totalBatchLabel = new System.Windows.Forms.Label();
            this.bunifuCards4 = new ns1.BunifuCards();
            this.bunifuCards5 = new ns1.BunifuCards();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCards6 = new ns1.BunifuCards();
            this.totalEarnLabel = new System.Windows.Forms.Label();
            this.bunifuCards1 = new ns1.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCoursetLabel = new System.Windows.Forms.Label();
            this.bunifuCards3 = new ns1.BunifuCards();
            this.panel1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards5.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCards2);
            this.panel1.Controls.Add(this.bunifuCards5);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.label3);
            this.bunifuCards2.Controls.Add(this.totalBatchLabel);
            this.bunifuCards2.Controls.Add(this.bunifuCards4);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(498, 15);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(386, 310);
            this.bunifuCards2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Batch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalBatchLabel
            // 
            this.totalBatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBatchLabel.ForeColor = System.Drawing.Color.Red;
            this.totalBatchLabel.Location = new System.Drawing.Point(67, 50);
            this.totalBatchLabel.Name = "totalBatchLabel";
            this.totalBatchLabel.Size = new System.Drawing.Size(226, 163);
            this.totalBatchLabel.TabIndex = 1;
            this.totalBatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.Tomato;
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(3, 342);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(430, 336);
            this.bunifuCards4.TabIndex = 0;
            // 
            // bunifuCards5
            // 
            this.bunifuCards5.BackColor = System.Drawing.Color.White;
            this.bunifuCards5.BorderRadius = 5;
            this.bunifuCards5.BottomSahddow = true;
            this.bunifuCards5.color = System.Drawing.Color.White;
            this.bunifuCards5.Controls.Add(this.label4);
            this.bunifuCards5.Controls.Add(this.bunifuCards6);
            this.bunifuCards5.Controls.Add(this.totalEarnLabel);
            this.bunifuCards5.LeftSahddow = false;
            this.bunifuCards5.Location = new System.Drawing.Point(45, 346);
            this.bunifuCards5.Name = "bunifuCards5";
            this.bunifuCards5.RightSahddow = true;
            this.bunifuCards5.ShadowDepth = 20;
            this.bunifuCards5.Size = new System.Drawing.Size(839, 310);
            this.bunifuCards5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(831, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Earned in Last 30 Days";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards6
            // 
            this.bunifuCards6.BackColor = System.Drawing.Color.White;
            this.bunifuCards6.BorderRadius = 5;
            this.bunifuCards6.BottomSahddow = true;
            this.bunifuCards6.color = System.Drawing.Color.Tomato;
            this.bunifuCards6.LeftSahddow = false;
            this.bunifuCards6.Location = new System.Drawing.Point(3, 342);
            this.bunifuCards6.Name = "bunifuCards6";
            this.bunifuCards6.RightSahddow = true;
            this.bunifuCards6.ShadowDepth = 20;
            this.bunifuCards6.Size = new System.Drawing.Size(430, 336);
            this.bunifuCards6.TabIndex = 0;
            // 
            // totalEarnLabel
            // 
            this.totalEarnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEarnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.totalEarnLabel.Location = new System.Drawing.Point(49, 49);
            this.totalEarnLabel.Name = "totalEarnLabel";
            this.totalEarnLabel.Size = new System.Drawing.Size(715, 163);
            this.totalEarnLabel.TabIndex = 1;
            this.totalEarnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Purple;
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.totalCoursetLabel);
            this.bunifuCards1.Controls.Add(this.bunifuCards3);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(45, 15);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(386, 310);
            this.bunifuCards1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Course";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCoursetLabel
            // 
            this.totalCoursetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCoursetLabel.ForeColor = System.Drawing.Color.Purple;
            this.totalCoursetLabel.Location = new System.Drawing.Point(69, 50);
            this.totalCoursetLabel.Name = "totalCoursetLabel";
            this.totalCoursetLabel.Size = new System.Drawing.Size(226, 163);
            this.totalCoursetLabel.TabIndex = 1;
            this.totalCoursetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Tomato;
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(3, 342);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(430, 336);
            this.bunifuCards3.TabIndex = 0;
            // 
            // DashboardUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DashboardUc";
            this.Size = new System.Drawing.Size(930, 700);
            this.panel1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards5.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCards bunifuCards1;
        private ns1.BunifuCards bunifuCards2;
        private ns1.BunifuCards bunifuCards4;
        private ns1.BunifuCards bunifuCards5;
        private ns1.BunifuCards bunifuCards6;
        private ns1.BunifuCards bunifuCards3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalCoursetLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalBatchLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalEarnLabel;
    }
}
