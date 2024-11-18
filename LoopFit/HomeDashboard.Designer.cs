namespace LoopFit
{
    partial class HomeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDashboard));
            panel2 = new Panel();
            llProfile = new LinkLabel();
            picProfile = new PictureBox();
            btnHome = new Button();
            btnActivity = new Button();
            btnLogOut = new Button();
            panel1 = new Panel();
            btnProduct = new Button();
            lblWelcome = new Label();
            txtDescription = new TextBox();
            pnlWelcome = new Panel();
            lblFirstName = new Label();
            linkLabel3 = new LinkLabel();
            pictureBox3 = new PictureBox();
            linkLabel2 = new LinkLabel();
            btnDonate = new Button();
            btnContent = new Button();
            picSosmed = new PictureBox();
            picProduct = new PictureBox();
            picDonate = new PictureBox();
            lblDescProduct = new Label();
            lblSosmed = new Label();
            picInstagram = new PictureBox();
            picTiktok = new PictureBox();
            picTwitter = new PictureBox();
            lblDonate = new Label();
            lblDescDonate = new Label();
            lblContent = new Label();
            lblProduct = new Label();
            lblDescContent = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            panel1.SuspendLayout();
            pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSosmed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDonate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInstagram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTiktok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTwitter).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 113, 178);
            panel2.Controls.Add(llProfile);
            panel2.Controls.Add(picProfile);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 104);
            panel2.TabIndex = 1;
            // 
            // llProfile
            // 
            llProfile.ActiveLinkColor = Color.LavenderBlush;
            llProfile.AutoSize = true;
            llProfile.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            llProfile.ForeColor = Color.FromArgb(100, 23, 61);
            llProfile.LinkColor = Color.Black;
            llProfile.Location = new Point(86, 37);
            llProfile.Margin = new Padding(2, 0, 2, 0);
            llProfile.Name = "llProfile";
            llProfile.Size = new Size(86, 31);
            llProfile.TabIndex = 1;
            llProfile.TabStop = true;
            llProfile.Text = "Profile";
            llProfile.LinkClicked += llProfile_LinkClicked;
            // 
            // picProfile
            // 
            picProfile.Location = new Point(26, 27);
            picProfile.Margin = new Padding(2);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(56, 49);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 1;
            picProfile.TabStop = false;
            picProfile.Click += picProfile_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.FromArgb(100, 23, 61);
            btnHome.Location = new Point(0, 104);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(246, 44);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnActivity
            // 
            btnActivity.Dock = DockStyle.Top;
            btnActivity.FlatAppearance.BorderSize = 0;
            btnActivity.FlatStyle = FlatStyle.Flat;
            btnActivity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnActivity.ForeColor = Color.FromArgb(100, 23, 61);
            btnActivity.Location = new Point(0, 148);
            btnActivity.Margin = new Padding(2);
            btnActivity.Name = "btnActivity";
            btnActivity.Size = new Size(246, 44);
            btnActivity.TabIndex = 1;
            btnActivity.Text = "Activity";
            btnActivity.UseVisualStyleBackColor = true;
            btnActivity.Click += btnActivity_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.FromArgb(100, 23, 61);
            btnLogOut.Location = new Point(0, 677);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(246, 44);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(208, 154, 208);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnActivity);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 721);
            panel1.TabIndex = 21;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(208, 154, 208);
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduct.Location = new Point(989, 268);
            btnProduct.Margin = new Padding(2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(210, 282);
            btnProduct.TabIndex = 25;
            btnProduct.TextAlign = ContentAlignment.BottomCenter;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.FromArgb(100, 23, 61);
            lblWelcome.Location = new Point(14, 38);
            lblWelcome.Margin = new Padding(2, 0, 2, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(136, 60);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hello";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(215, 169, 205);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.ForeColor = Color.FromArgb(100, 23, 61);
            txtDescription.Location = new Point(22, 99);
            txtDescription.Margin = new Padding(2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(912, 77);
            txtDescription.TabIndex = 1;
            txtDescription.Text = resources.GetString("txtDescription.Text");
            // 
            // pnlWelcome
            // 
            pnlWelcome.BackColor = Color.FromArgb(215, 169, 205);
            pnlWelcome.Controls.Add(lblFirstName);
            pnlWelcome.Controls.Add(linkLabel3);
            pnlWelcome.Controls.Add(pictureBox3);
            pnlWelcome.Controls.Add(linkLabel2);
            pnlWelcome.Controls.Add(txtDescription);
            pnlWelcome.Controls.Add(lblWelcome);
            pnlWelcome.Dock = DockStyle.Top;
            pnlWelcome.Location = new Point(246, 0);
            pnlWelcome.Margin = new Padding(2);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(1102, 210);
            pnlWelcome.TabIndex = 22;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.ForeColor = Color.FromArgb(100, 23, 61);
            lblFirstName.Location = new Point(134, 38);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(0, 60);
            lblFirstName.TabIndex = 43;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel3.LinkColor = Color.FromArgb(80, 23, 61);
            linkLabel3.Location = new Point(987, 22);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(75, 25);
            linkLabel3.TabIndex = 42;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "LoopFit";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.logoloopfit_;
            pictureBox3.Location = new Point(955, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.FromArgb(80, 23, 61);
            linkLabel2.Location = new Point(825, 22);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(104, 25);
            linkLabel2.TabIndex = 40;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Contact Us";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // btnDonate
            // 
            btnDonate.BackColor = Color.FromArgb(208, 154, 208);
            btnDonate.FlatAppearance.BorderSize = 0;
            btnDonate.FlatStyle = FlatStyle.Flat;
            btnDonate.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDonate.Location = new Point(415, 268);
            btnDonate.Margin = new Padding(2);
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new Size(210, 282);
            btnDonate.TabIndex = 23;
            btnDonate.TextAlign = ContentAlignment.BottomCenter;
            btnDonate.UseVisualStyleBackColor = false;
            btnDonate.Click += btnDonate_Click;
            // 
            // btnContent
            // 
            btnContent.BackColor = Color.FromArgb(208, 154, 208);
            btnContent.FlatAppearance.BorderSize = 0;
            btnContent.FlatStyle = FlatStyle.Flat;
            btnContent.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnContent.Location = new Point(702, 268);
            btnContent.Margin = new Padding(2);
            btnContent.Name = "btnContent";
            btnContent.Size = new Size(210, 282);
            btnContent.TabIndex = 24;
            btnContent.TextAlign = ContentAlignment.BottomCenter;
            btnContent.UseVisualStyleBackColor = false;
            btnContent.Click += btnContent_Click;
            // 
            // picSosmed
            // 
            picSosmed.BackColor = Color.FromArgb(208, 154, 208);
            picSosmed.Image = (Image)resources.GetObject("picSosmed.Image");
            picSosmed.Location = new Point(720, 283);
            picSosmed.Margin = new Padding(2);
            picSosmed.Name = "picSosmed";
            picSosmed.Size = new Size(176, 169);
            picSosmed.SizeMode = PictureBoxSizeMode.Zoom;
            picSosmed.TabIndex = 26;
            picSosmed.TabStop = false;
            picSosmed.Click += picSosmed_Click;
            // 
            // picProduct
            // 
            picProduct.BackColor = Color.FromArgb(208, 154, 208);
            picProduct.Image = (Image)resources.GetObject("picProduct.Image");
            picProduct.Location = new Point(1007, 283);
            picProduct.Margin = new Padding(2);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(176, 169);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 27;
            picProduct.TabStop = false;
            picProduct.Click += picProduct_Click;
            // 
            // picDonate
            // 
            picDonate.BackColor = Color.FromArgb(208, 154, 208);
            picDonate.BackgroundImageLayout = ImageLayout.Center;
            picDonate.Image = (Image)resources.GetObject("picDonate.Image");
            picDonate.Location = new Point(432, 283);
            picDonate.Margin = new Padding(2);
            picDonate.Name = "picDonate";
            picDonate.Size = new Size(176, 169);
            picDonate.SizeMode = PictureBoxSizeMode.Zoom;
            picDonate.TabIndex = 28;
            picDonate.TabStop = false;
            picDonate.Click += picDonate_Click;
            // 
            // lblDescProduct
            // 
            lblDescProduct.AutoSize = true;
            lblDescProduct.BackColor = Color.FromArgb(208, 154, 208);
            lblDescProduct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescProduct.ForeColor = Color.FromArgb(100, 23, 61);
            lblDescProduct.Location = new Point(1007, 487);
            lblDescProduct.Margin = new Padding(2, 0, 2, 0);
            lblDescProduct.MaximumSize = new Size(180, 0);
            lblDescProduct.Name = "lblDescProduct";
            lblDescProduct.Size = new Size(180, 40);
            lblDescProduct.TabIndex = 39;
            lblDescProduct.Text = "Find our recycled clothing products.";
            lblDescProduct.Click += lblDescProduct_Click;
            // 
            // lblSosmed
            // 
            lblSosmed.AutoSize = true;
            lblSosmed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSosmed.ForeColor = Color.FromArgb(100, 23, 61);
            lblSosmed.Location = new Point(720, 632);
            lblSosmed.Margin = new Padding(2, 0, 2, 0);
            lblSosmed.Name = "lblSosmed";
            lblSosmed.Size = new Size(175, 20);
            lblSosmed.TabIndex = 30;
            lblSosmed.Text = "Follow Our Social Media";
            lblSosmed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picInstagram
            // 
            picInstagram.Image = (Image)resources.GetObject("picInstagram.Image");
            picInstagram.Location = new Point(738, 661);
            picInstagram.Margin = new Padding(2);
            picInstagram.Name = "picInstagram";
            picInstagram.Size = new Size(39, 29);
            picInstagram.SizeMode = PictureBoxSizeMode.Zoom;
            picInstagram.TabIndex = 31;
            picInstagram.TabStop = false;
            picInstagram.Click += picInstagram_Click;
            // 
            // picTiktok
            // 
            picTiktok.Image = (Image)resources.GetObject("picTiktok.Image");
            picTiktok.Location = new Point(782, 661);
            picTiktok.Margin = new Padding(2);
            picTiktok.Name = "picTiktok";
            picTiktok.Size = new Size(39, 29);
            picTiktok.SizeMode = PictureBoxSizeMode.Zoom;
            picTiktok.TabIndex = 32;
            picTiktok.TabStop = false;
            picTiktok.Click += picTiktok_Click;
            // 
            // picTwitter
            // 
            picTwitter.Image = (Image)resources.GetObject("picTwitter.Image");
            picTwitter.Location = new Point(826, 661);
            picTwitter.Margin = new Padding(2);
            picTwitter.Name = "picTwitter";
            picTwitter.Size = new Size(39, 29);
            picTwitter.SizeMode = PictureBoxSizeMode.Zoom;
            picTwitter.TabIndex = 33;
            picTwitter.TabStop = false;
            picTwitter.Click += picTwitter_Click;
            // 
            // lblDonate
            // 
            lblDonate.AutoSize = true;
            lblDonate.BackColor = Color.FromArgb(208, 154, 208);
            lblDonate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonate.ForeColor = Color.FromArgb(100, 23, 61);
            lblDonate.Location = new Point(432, 454);
            lblDonate.Margin = new Padding(2, 0, 2, 0);
            lblDonate.Name = "lblDonate";
            lblDonate.Size = new Size(81, 28);
            lblDonate.TabIndex = 34;
            lblDonate.Text = "Donate";
            lblDonate.Click += lblDonate_Click;
            // 
            // lblDescDonate
            // 
            lblDescDonate.AutoSize = true;
            lblDescDonate.BackColor = Color.FromArgb(208, 154, 208);
            lblDescDonate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescDonate.ForeColor = Color.FromArgb(100, 23, 61);
            lblDescDonate.Location = new Point(432, 487);
            lblDescDonate.Margin = new Padding(2, 0, 2, 0);
            lblDescDonate.MaximumSize = new Size(180, 0);
            lblDescDonate.Name = "lblDescDonate";
            lblDescDonate.Size = new Size(146, 40);
            lblDescDonate.TabIndex = 35;
            lblDescDonate.Text = "Donate your clothes easily here.\r\n";
            lblDescDonate.Click += lblDescDonate_Click;
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.BackColor = Color.FromArgb(208, 154, 208);
            lblContent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContent.ForeColor = Color.FromArgb(100, 23, 61);
            lblContent.Location = new Point(720, 454);
            lblContent.Margin = new Padding(2, 0, 2, 0);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(87, 28);
            lblContent.TabIndex = 36;
            lblContent.Text = "Content";
            lblContent.Click += lblContent_Click;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.BackColor = Color.FromArgb(208, 154, 208);
            lblProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct.ForeColor = Color.FromArgb(100, 23, 61);
            lblProduct.Location = new Point(1007, 454);
            lblProduct.Margin = new Padding(2, 0, 2, 0);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(127, 28);
            lblProduct.TabIndex = 37;
            lblProduct.Text = "Our Product";
            lblProduct.Click += lblProduct_Click;
            // 
            // lblDescContent
            // 
            lblDescContent.AutoSize = true;
            lblDescContent.BackColor = Color.FromArgb(208, 154, 208);
            lblDescContent.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescContent.ForeColor = Color.FromArgb(100, 23, 61);
            lblDescContent.Location = new Point(720, 487);
            lblDescContent.Margin = new Padding(2, 0, 2, 0);
            lblDescContent.MaximumSize = new Size(180, 0);
            lblDescContent.Name = "lblDescContent";
            lblDescContent.Size = new Size(160, 40);
            lblDescContent.TabIndex = 38;
            lblDescContent.Text = "See how LoopFit processes your clothes.";
            lblDescContent.Click += lblDescContent_Click;
            // 
            // HomeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1348, 721);
            Controls.Add(lblDescProduct);
            Controls.Add(lblDescContent);
            Controls.Add(lblProduct);
            Controls.Add(lblContent);
            Controls.Add(lblDescDonate);
            Controls.Add(lblDonate);
            Controls.Add(picTwitter);
            Controls.Add(picTiktok);
            Controls.Add(picInstagram);
            Controls.Add(lblSosmed);
            Controls.Add(picDonate);
            Controls.Add(picProduct);
            Controls.Add(picSosmed);
            Controls.Add(btnContent);
            Controls.Add(btnDonate);
            Controls.Add(pnlWelcome);
            Controls.Add(btnProduct);
            Controls.Add(panel1);
            Name = "HomeDashboard";
            Text = "Home Dashboard";
            Load += HomeDashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            panel1.ResumeLayout(false);
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSosmed).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDonate).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInstagram).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTiktok).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTwitter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private LinkLabel llProfile;
        private PictureBox picProfile;
        private Button btnHome;
        private Button btnActivity;
        private Button btnLogOut;
        private Panel panel1;
        private Button btnProduct;
        private Label lblWelcome;
        private TextBox txtDescription;
        private Panel pnlWelcome;
        private Button btnDonate;
        private Button btnContent;
        private PictureBox picSosmed;
        private PictureBox picProduct;
        private PictureBox picDonate;
        private Label lblDescProduct;
        private Label lblSosmed;
        private PictureBox picInstagram;
        private PictureBox picTiktok;
        private PictureBox picTwitter;
        private Label lblDonate;
        private Label lblDescDonate;
        private Label lblContent;
        private Label lblProduct;
        private Label lblDescContent;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox3;
        private Label lblFirstName;
    }
}