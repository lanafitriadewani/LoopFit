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
            lblWelcome_Home = new Label();
            pnlWelcome = new Panel();
            lblDescription_Home = new Label();
            lblFirstName = new Label();
            linkLabel3 = new LinkLabel();
            pictureBox3 = new PictureBox();
            linkLabel2_Home = new LinkLabel();
            btnDonate = new Button();
            btnContent = new Button();
            picSosmed = new PictureBox();
            picProduct = new PictureBox();
            picDonate = new PictureBox();
            lblDescProduct_Home = new Label();
            lblSosmed_Home = new Label();
            picInstagram = new PictureBox();
            picTiktok = new PictureBox();
            picTwitter = new PictureBox();
            lblDonate_Home = new Label();
            lblDescDonate_Home = new Label();
            lblContent_Home = new Label();
            lblProduct_Home = new Label();
            lblDescContent_Home = new Label();
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
            btnProduct.Size = new Size(210, 294);
            btnProduct.TabIndex = 25;
            btnProduct.TextAlign = ContentAlignment.BottomCenter;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // lblWelcome_Home
            // 
            lblWelcome_Home.AutoSize = true;
            lblWelcome_Home.BackColor = Color.Transparent;
            lblWelcome_Home.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome_Home.ForeColor = Color.FromArgb(100, 23, 61);
            lblWelcome_Home.Location = new Point(14, 38);
            lblWelcome_Home.Margin = new Padding(2, 0, 2, 0);
            lblWelcome_Home.Name = "lblWelcome_Home";
            lblWelcome_Home.Size = new Size(136, 60);
            lblWelcome_Home.TabIndex = 0;
            lblWelcome_Home.Text = "Hello";
            // 
            // pnlWelcome
            // 
            pnlWelcome.BackColor = Color.FromArgb(215, 169, 205);
            pnlWelcome.Controls.Add(lblDescription_Home);
            pnlWelcome.Controls.Add(lblFirstName);
            pnlWelcome.Controls.Add(linkLabel3);
            pnlWelcome.Controls.Add(pictureBox3);
            pnlWelcome.Controls.Add(linkLabel2_Home);
            pnlWelcome.Controls.Add(lblWelcome_Home);
            pnlWelcome.Dock = DockStyle.Top;
            pnlWelcome.Location = new Point(246, 0);
            pnlWelcome.Margin = new Padding(2);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(1102, 210);
            pnlWelcome.TabIndex = 22;
            // 
            // lblDescription_Home
            // 
            lblDescription_Home.AutoSize = true;
            lblDescription_Home.BackColor = Color.Transparent;
            lblDescription_Home.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription_Home.ForeColor = Color.FromArgb(100, 23, 61);
            lblDescription_Home.Location = new Point(22, 99);
            lblDescription_Home.Margin = new Padding(2, 0, 2, 0);
            lblDescription_Home.MaximumSize = new Size(1000, 0);
            lblDescription_Home.Name = "lblDescription_Home";
            lblDescription_Home.Size = new Size(962, 75);
            lblDescription_Home.TabIndex = 44;
            lblDescription_Home.Text = resources.GetString("lblDescription_Home.Text");
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
            // linkLabel2_Home
            // 
            linkLabel2_Home.AutoSize = true;
            linkLabel2_Home.BackColor = Color.Transparent;
            linkLabel2_Home.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2_Home.LinkColor = Color.FromArgb(80, 23, 61);
            linkLabel2_Home.Location = new Point(825, 22);
            linkLabel2_Home.Name = "linkLabel2_Home";
            linkLabel2_Home.Size = new Size(104, 25);
            linkLabel2_Home.TabIndex = 40;
            linkLabel2_Home.TabStop = true;
            linkLabel2_Home.Text = "Contact Us";
            linkLabel2_Home.LinkClicked += linkLabel2_LinkClicked;
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
            btnDonate.Size = new Size(210, 294);
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
            btnContent.Size = new Size(210, 294);
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
            // lblDescProduct_Home
            // 
            lblDescProduct_Home.AutoSize = true;
            lblDescProduct_Home.BackColor = Color.FromArgb(208, 154, 208);
            lblDescProduct_Home.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescProduct_Home.ForeColor = Color.FromArgb(100, 23, 61);
            lblDescProduct_Home.Location = new Point(1007, 487);
            lblDescProduct_Home.Margin = new Padding(2, 0, 2, 0);
            lblDescProduct_Home.MaximumSize = new Size(180, 0);
            lblDescProduct_Home.Name = "lblDescProduct_Home";
            lblDescProduct_Home.Size = new Size(180, 40);
            lblDescProduct_Home.TabIndex = 39;
            lblDescProduct_Home.Text = "Find our recycled clothing products.";
            lblDescProduct_Home.Click += lblDescProduct_Click;
            // 
            // lblSosmed_Home
            // 
            lblSosmed_Home.AutoSize = true;
            lblSosmed_Home.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSosmed_Home.ForeColor = Color.FromArgb(100, 23, 61);
            lblSosmed_Home.Location = new Point(720, 632);
            lblSosmed_Home.Margin = new Padding(2, 0, 2, 0);
            lblSosmed_Home.Name = "lblSosmed_Home";
            lblSosmed_Home.Size = new Size(175, 20);
            lblSosmed_Home.TabIndex = 30;
            lblSosmed_Home.Text = "Follow Our Social Media";
            lblSosmed_Home.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblDonate_Home
            // 
            lblDonate_Home.AutoSize = true;
            lblDonate_Home.BackColor = Color.FromArgb(208, 154, 208);
            lblDonate_Home.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonate_Home.ForeColor = Color.FromArgb(100, 23, 61);
            lblDonate_Home.Location = new Point(432, 454);
            lblDonate_Home.Margin = new Padding(2, 0, 2, 0);
            lblDonate_Home.Name = "lblDonate_Home";
            lblDonate_Home.Size = new Size(81, 28);
            lblDonate_Home.TabIndex = 34;
            lblDonate_Home.Text = "Donate";
            lblDonate_Home.Click += lblDonate_Click;
            // 
            // lblDescDonate_Home
            // 
            lblDescDonate_Home.AutoSize = true;
            lblDescDonate_Home.BackColor = Color.FromArgb(208, 154, 208);
            lblDescDonate_Home.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescDonate_Home.ForeColor = Color.FromArgb(100, 23, 61);
            lblDescDonate_Home.Location = new Point(432, 487);
            lblDescDonate_Home.Margin = new Padding(2, 0, 2, 0);
            lblDescDonate_Home.MaximumSize = new Size(180, 0);
            lblDescDonate_Home.Name = "lblDescDonate_Home";
            lblDescDonate_Home.Size = new Size(146, 40);
            lblDescDonate_Home.TabIndex = 35;
            lblDescDonate_Home.Text = "Donate your clothes easily here.\r\n";
            lblDescDonate_Home.Click += lblDescDonate_Click;
            // 
            // lblContent_Home
            // 
            lblContent_Home.AutoSize = true;
            lblContent_Home.BackColor = Color.FromArgb(208, 154, 208);
            lblContent_Home.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContent_Home.ForeColor = Color.FromArgb(100, 23, 61);
            lblContent_Home.Location = new Point(720, 454);
            lblContent_Home.Margin = new Padding(2, 0, 2, 0);
            lblContent_Home.Name = "lblContent_Home";
            lblContent_Home.Size = new Size(87, 28);
            lblContent_Home.TabIndex = 36;
            lblContent_Home.Text = "Content";
            lblContent_Home.Click += lblContent_Click;
            // 
            // lblProduct_Home
            // 
            lblProduct_Home.AutoSize = true;
            lblProduct_Home.BackColor = Color.FromArgb(208, 154, 208);
            lblProduct_Home.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct_Home.ForeColor = Color.FromArgb(100, 23, 61);
            lblProduct_Home.Location = new Point(1007, 454);
            lblProduct_Home.Margin = new Padding(2, 0, 2, 0);
            lblProduct_Home.Name = "lblProduct_Home";
            lblProduct_Home.Size = new Size(127, 28);
            lblProduct_Home.TabIndex = 37;
            lblProduct_Home.Text = "Our Product";
            lblProduct_Home.Click += lblProduct_Click;
            // 
            // lblDescContent_Home
            // 
            lblDescContent_Home.AutoSize = true;
            lblDescContent_Home.BackColor = Color.FromArgb(208, 154, 208);
            lblDescContent_Home.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescContent_Home.ForeColor = Color.FromArgb(100, 23, 61);
            lblDescContent_Home.Location = new Point(720, 487);
            lblDescContent_Home.Margin = new Padding(2, 0, 2, 0);
            lblDescContent_Home.MaximumSize = new Size(180, 0);
            lblDescContent_Home.Name = "lblDescContent_Home";
            lblDescContent_Home.Size = new Size(160, 40);
            lblDescContent_Home.TabIndex = 38;
            lblDescContent_Home.Text = "See how LoopFit processes your clothes.";
            lblDescContent_Home.Click += lblDescContent_Click;
            // 
            // HomeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1348, 721);
            Controls.Add(lblDescProduct_Home);
            Controls.Add(lblDescContent_Home);
            Controls.Add(lblProduct_Home);
            Controls.Add(lblContent_Home);
            Controls.Add(lblDescDonate_Home);
            Controls.Add(lblDonate_Home);
            Controls.Add(picTwitter);
            Controls.Add(picTiktok);
            Controls.Add(picInstagram);
            Controls.Add(lblSosmed_Home);
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
        private Label lblWelcome_Home;
        private Label lblDescription_Home;
        private Panel pnlWelcome;
        private Button btnDonate;
        private Button btnContent;
        private PictureBox picSosmed;
        private PictureBox picProduct;
        private PictureBox picDonate;
        private Label lblDescProduct_Home;
        private Label lblSosmed_Home;
        private PictureBox picInstagram;
        private PictureBox picTiktok;
        private PictureBox picTwitter;
        private Label lblDonate_Home;
        private Label lblDescDonate_Home;
        private Label lblContent_Home;
        private Label lblProduct_Home;
        private Label lblDescContent_Home;
        private LinkLabel linkLabel2_Home;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox3;
        private Label lblFirstName;
        private Label label1;
    }
}