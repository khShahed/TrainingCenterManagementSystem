namespace TCMS.UI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.sidePanel = new System.Windows.Forms.Panel();
            this.animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.dashboardPanel = new ns1.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.manageButton = new ns1.BunifuFlatButton();
            this.sendEmailButton = new ns1.BunifuFlatButton();
            this.addButton = new ns1.BunifuFlatButton();
            this.dashboardButton = new ns1.BunifuFlatButton();
            this.HeaderPanel = new ns1.BunifuGradientPanel();
            this.sidebarResizerButton = new ns1.BunifuImageButton();
            this.minimizeButton = new ns1.BunifuImageButton();
            this.closeFormButton = new ns1.BunifuImageButton();
            this.titleLabel = new ns1.BunifuCustomLabel();
            this.sidePanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarResizerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeFormButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.HeaderPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.sidePanel.Controls.Add(this.manageButton);
            this.sidePanel.Controls.Add(this.sendEmailButton);
            this.sidePanel.Controls.Add(this.addButton);
            this.sidePanel.Controls.Add(this.dashboardButton);
            this.animator.SetDecoration(this.sidePanel, BunifuAnimatorNS.DecorationType.None);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(109)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 41);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(184, 604);
            this.sidePanel.TabIndex = 1;
            // 
            // animator
            // 
            this.animator.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator.DefaultAnimation = animation1;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboardPanel.BackgroundImage")));
            this.dashboardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator.SetDecoration(this.dashboardPanel, BunifuAnimatorNS.DecorationType.None);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.dashboardPanel.GradientBottomRight = System.Drawing.Color.White;
            this.dashboardPanel.GradientTopLeft = System.Drawing.Color.White;
            this.dashboardPanel.GradientTopRight = System.Drawing.Color.White;
            this.dashboardPanel.Location = new System.Drawing.Point(184, 41);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Quality = 10;
            this.dashboardPanel.Size = new System.Drawing.Size(715, 578);
            this.dashboardPanel.TabIndex = 3;
            this.dashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboardPanel_Paint);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(42)))), ((int)(((byte)(123)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(42)))), ((int)(((byte)(123)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(42)))), ((int)(((byte)(123)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(42)))), ((int)(((byte)(123)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(184, 619);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(715, 26);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // manageButton
            // 
            this.manageButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.manageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.manageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageButton.BorderRadius = 1;
            this.manageButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageButton.ButtonText = "Manage";
            this.manageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.manageButton, BunifuAnimatorNS.DecorationType.None);
            this.manageButton.DisabledColor = System.Drawing.Color.Gray;
            this.manageButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.manageButton.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.manageButton.Iconimage = global::TCMS.UI.Properties.Resources.Maintenance_48px;
            this.manageButton.Iconimage_right = null;
            this.manageButton.Iconimage_right_Selected = null;
            this.manageButton.Iconimage_Selected = null;
            this.manageButton.IconMarginLeft = 0;
            this.manageButton.IconMarginRight = 0;
            this.manageButton.IconRightVisible = true;
            this.manageButton.IconRightZoom = 0D;
            this.manageButton.IconVisible = true;
            this.manageButton.IconZoom = 70D;
            this.manageButton.IsTab = true;
            this.manageButton.Location = new System.Drawing.Point(0, 85);
            this.manageButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.manageButton.Name = "manageButton";
            this.manageButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.manageButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.manageButton.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.manageButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.manageButton.selected = false;
            this.manageButton.Size = new System.Drawing.Size(184, 41);
            this.manageButton.TabIndex = 0;
            this.manageButton.Text = "Manage";
            this.manageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageButton.Textcolor = System.Drawing.Color.White;
            this.manageButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.sendEmailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.sendEmailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendEmailButton.BorderRadius = 1;
            this.sendEmailButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendEmailButton.ButtonText = "Send Email";
            this.sendEmailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.sendEmailButton, BunifuAnimatorNS.DecorationType.None);
            this.sendEmailButton.DisabledColor = System.Drawing.Color.Gray;
            this.sendEmailButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.sendEmailButton.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.sendEmailButton.Iconimage = global::TCMS.UI.Properties.Resources.Email_48px;
            this.sendEmailButton.Iconimage_right = null;
            this.sendEmailButton.Iconimage_right_Selected = null;
            this.sendEmailButton.Iconimage_Selected = null;
            this.sendEmailButton.IconMarginLeft = 0;
            this.sendEmailButton.IconMarginRight = 0;
            this.sendEmailButton.IconRightVisible = true;
            this.sendEmailButton.IconRightZoom = 0D;
            this.sendEmailButton.IconVisible = true;
            this.sendEmailButton.IconZoom = 80D;
            this.sendEmailButton.IsTab = true;
            this.sendEmailButton.Location = new System.Drawing.Point(0, 127);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.sendEmailButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.sendEmailButton.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.sendEmailButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sendEmailButton.selected = false;
            this.sendEmailButton.Size = new System.Drawing.Size(184, 41);
            this.sendEmailButton.TabIndex = 0;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendEmailButton.Textcolor = System.Drawing.Color.White;
            this.sendEmailButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // addButton
            // 
            this.addButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.BorderRadius = 1;
            this.addButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addButton.ButtonText = "Add";
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.addButton, BunifuAnimatorNS.DecorationType.None);
            this.addButton.DisabledColor = System.Drawing.Color.Gray;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.addButton.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.addButton.Iconimage = global::TCMS.UI.Properties.Resources.Plus_48px;
            this.addButton.Iconimage_right = null;
            this.addButton.Iconimage_right_Selected = null;
            this.addButton.Iconimage_Selected = null;
            this.addButton.IconMarginLeft = 0;
            this.addButton.IconMarginRight = 0;
            this.addButton.IconRightVisible = true;
            this.addButton.IconRightZoom = 0D;
            this.addButton.IconVisible = true;
            this.addButton.IconZoom = 80D;
            this.addButton.IsTab = true;
            this.addButton.Location = new System.Drawing.Point(0, 44);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addButton.Name = "addButton";
            this.addButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.addButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addButton.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addButton.selected = false;
            this.addButton.Size = new System.Drawing.Size(184, 41);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addButton.Textcolor = System.Drawing.Color.White;
            this.addButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.dashboardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardButton.BorderRadius = 1;
            this.dashboardButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dashboardButton.ButtonText = "Dashboard";
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.dashboardButton, BunifuAnimatorNS.DecorationType.None);
            this.dashboardButton.DisabledColor = System.Drawing.Color.Gray;
            this.dashboardButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.dashboardButton.Iconimage = global::TCMS.UI.Properties.Resources.Home_48px1;
            this.dashboardButton.Iconimage_right = null;
            this.dashboardButton.Iconimage_right_Selected = null;
            this.dashboardButton.Iconimage_Selected = null;
            this.dashboardButton.IconMarginLeft = 0;
            this.dashboardButton.IconMarginRight = 0;
            this.dashboardButton.IconRightVisible = true;
            this.dashboardButton.IconRightZoom = 0D;
            this.dashboardButton.IconVisible = true;
            this.dashboardButton.IconZoom = 80D;
            this.dashboardButton.IsTab = true;
            this.dashboardButton.Location = new System.Drawing.Point(3, 3);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(98)))), ((int)(((byte)(176)))));
            this.dashboardButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dashboardButton.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dashboardButton.selected = false;
            this.dashboardButton.Size = new System.Drawing.Size(181, 41);
            this.dashboardButton.TabIndex = 0;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dashboardButton.Textcolor = System.Drawing.Color.White;
            this.dashboardButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeaderPanel.BackgroundImage")));
            this.HeaderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeaderPanel.Controls.Add(this.sidebarResizerButton);
            this.HeaderPanel.Controls.Add(this.minimizeButton);
            this.HeaderPanel.Controls.Add(this.closeFormButton);
            this.HeaderPanel.Controls.Add(this.titleLabel);
            this.animator.SetDecoration(this.HeaderPanel, BunifuAnimatorNS.DecorationType.None);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.HeaderPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.HeaderPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.HeaderPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Quality = 10;
            this.HeaderPanel.Size = new System.Drawing.Size(899, 41);
            this.HeaderPanel.TabIndex = 0;
            // 
            // sidebarResizerButton
            // 
            this.sidebarResizerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.animator.SetDecoration(this.sidebarResizerButton, BunifuAnimatorNS.DecorationType.None);
            this.sidebarResizerButton.Image = global::TCMS.UI.Properties.Resources.Menu_48px;
            this.sidebarResizerButton.ImageActive = null;
            this.sidebarResizerButton.Location = new System.Drawing.Point(0, 0);
            this.sidebarResizerButton.Name = "sidebarResizerButton";
            this.sidebarResizerButton.Size = new System.Drawing.Size(52, 41);
            this.sidebarResizerButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sidebarResizerButton.TabIndex = 2;
            this.sidebarResizerButton.TabStop = false;
            this.sidebarResizerButton.Zoom = 10;
            this.sidebarResizerButton.Click += new System.EventHandler(this.sidebarResizerButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.animator.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.minimizeButton.Image = global::TCMS.UI.Properties.Resources.Minimize_Window_50px;
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(803, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(50, 41);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeFormButton
            // 
            this.closeFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.animator.SetDecoration(this.closeFormButton, BunifuAnimatorNS.DecorationType.None);
            this.closeFormButton.Image = global::TCMS.UI.Properties.Resources.red_cross_no_back;
            this.closeFormButton.ImageActive = null;
            this.closeFormButton.Location = new System.Drawing.Point(849, 0);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(50, 41);
            this.closeFormButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeFormButton.TabIndex = 1;
            this.closeFormButton.TabStop = false;
            this.closeFormButton.Zoom = 10;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.animator.SetDecoration(this.titleLabel, BunifuAnimatorNS.DecorationType.None);
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(47, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(388, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Training Center Management System";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 645);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.HeaderPanel);
            this.animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training Center Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidePanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidebarResizerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeFormButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuGradientPanel HeaderPanel;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuCustomLabel titleLabel;
        private System.Windows.Forms.Panel sidePanel;
        private ns1.BunifuFlatButton dashboardButton;
        private ns1.BunifuImageButton closeFormButton;
        private ns1.BunifuImageButton sidebarResizerButton;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private ns1.BunifuGradientPanel dashboardPanel;
        private ns1.BunifuFlatButton addButton;
        private ns1.BunifuFlatButton manageButton;
        private BunifuAnimatorNS.BunifuTransition animator;
        private ns1.BunifuImageButton minimizeButton;
        private ns1.BunifuFlatButton sendEmailButton;
    }
}