namespace LoopFit
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            btnLogOut = new Button();
            llProfile = new LinkLabel();
            btnActivity = new Button();
            btnHome = new Button();
            panel2 = new Panel();
            picProfile = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtDescription3 = new TextBox();
            txtDescription2 = new TextBox();
            txtDescription1 = new TextBox();
            lblAboutUs = new Label();
            linkLabel3 = new LinkLabel();
            pictureBox4 = new PictureBox();
            linkLabel2 = new LinkLabel();
            picTwitter = new PictureBox();
            picTiktok = new PictureBox();
            picInstagram = new PictureBox();
            lblSosmed = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTwitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTiktok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInstagram).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 22;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(956, 145);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(233, 176);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(672, 145);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 176);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(399, 145);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // txtDescription3
            // 
            txtDescription3.BackColor = Color.Thistle;
            txtDescription3.BorderStyle = BorderStyle.None;
            txtDescription3.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescription3.ForeColor = Color.FromArgb(100, 23, 61);
            txtDescription3.Location = new Point(337, 548);
            txtDescription3.Margin = new Padding(2);
            txtDescription3.Multiline = true;
            txtDescription3.Name = "txtDescription3";
            txtDescription3.ReadOnly = true;
            txtDescription3.Size = new Size(391, 32);
            txtDescription3.TabIndex = 28;
            txtDescription3.Text = "Together, we close the loop for a better planet.";
            // 
            // txtDescription2
            // 
            txtDescription2.BackColor = Color.Thistle;
            txtDescription2.BorderStyle = BorderStyle.None;
            txtDescription2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription2.ForeColor = Color.FromArgb(100, 23, 61);
            txtDescription2.Location = new Point(337, 449);
            txtDescription2.Margin = new Padding(2);
            txtDescription2.Multiline = true;
            txtDescription2.Name = "txtDescription2";
            txtDescription2.ReadOnly = true;
            txtDescription2.Size = new Size(912, 77);
            txtDescription2.TabIndex = 29;
            txtDescription2.Text = resources.GetString("txtDescription2.Text");
            // 
            // txtDescription1
            // 
            txtDescription1.BackColor = Color.Thistle;
            txtDescription1.BorderStyle = BorderStyle.None;
            txtDescription1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription1.ForeColor = Color.FromArgb(100, 23, 61);
            txtDescription1.Location = new Point(337, 363);
            txtDescription1.Margin = new Padding(2);
            txtDescription1.Multiline = true;
            txtDescription1.Name = "txtDescription1";
            txtDescription1.ReadOnly = true;
            txtDescription1.Size = new Size(924, 77);
            txtDescription1.TabIndex = 30;
            txtDescription1.Text = resources.GetString("txtDescription1.Text");
            // 
            // lblAboutUs
            // 
            lblAboutUs.AutoSize = true;
            lblAboutUs.BackColor = Color.Transparent;
            lblAboutUs.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblAboutUs.ForeColor = Color.FromArgb(100, 23, 61);
            lblAboutUs.Location = new Point(304, 46);
            lblAboutUs.Margin = new Padding(2, 0, 2, 0);
            lblAboutUs.Name = "lblAboutUs";
            lblAboutUs.Size = new Size(217, 60);
            lblAboutUs.TabIndex = 27;
            lblAboutUs.Text = "About Us";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel3.LinkColor = Color.FromArgb(80, 23, 61);
            linkLabel3.Location = new Point(1239, 37);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(75, 25);
            linkLabel3.TabIndex = 45;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "LoopFit";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.logoloopfit_;
            pictureBox4.Location = new Point(1207, 33);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.FromArgb(80, 23, 61);
            linkLabel2.Location = new Point(1077, 37);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(104, 25);
            linkLabel2.TabIndex = 43;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Contact Us";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // picTwitter
            // 
            picTwitter.Image = (Image)resources.GetObject("picTwitter.Image");
            picTwitter.Location = new Point(804, 658);
            picTwitter.Margin = new Padding(2);
            picTwitter.Name = "picTwitter";
            picTwitter.Size = new Size(39, 29);
            picTwitter.SizeMode = PictureBoxSizeMode.Zoom;
            picTwitter.TabIndex = 66;
            picTwitter.TabStop = false;
            picTwitter.Click += picTwitter_Click;
            // 
            // picTiktok
            // 
            picTiktok.Image = (Image)resources.GetObject("picTiktok.Image");
            picTiktok.Location = new Point(760, 658);
            picTiktok.Margin = new Padding(2);
            picTiktok.Name = "picTiktok";
            picTiktok.Size = new Size(39, 29);
            picTiktok.SizeMode = PictureBoxSizeMode.Zoom;
            picTiktok.TabIndex = 65;
            picTiktok.TabStop = false;
            picTiktok.Click += picTiktok_Click;
            // 
            // picInstagram
            // 
            picInstagram.Image = (Image)resources.GetObject("picInstagram.Image");
            picInstagram.Location = new Point(716, 658);
            picInstagram.Margin = new Padding(2);
            picInstagram.Name = "picInstagram";
            picInstagram.Size = new Size(39, 29);
            picInstagram.SizeMode = PictureBoxSizeMode.Zoom;
            picInstagram.TabIndex = 64;
            picInstagram.TabStop = false;
            picInstagram.Click += picInstagram_Click;
            // 
            // lblSosmed
            // 
            lblSosmed.AutoSize = true;
            lblSosmed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSosmed.ForeColor = Color.FromArgb(100, 23, 61);
            lblSosmed.Location = new Point(698, 629);
            lblSosmed.Margin = new Padding(2, 0, 2, 0);
            lblSosmed.Name = "lblSosmed";
            lblSosmed.Size = new Size(175, 20);
            lblSosmed.TabIndex = 63;
            lblSosmed.Text = "Follow Our Social Media";
            lblSosmed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1348, 721);
            Controls.Add(picTwitter);
            Controls.Add(picTiktok);
            Controls.Add(picInstagram);
            Controls.Add(lblSosmed);
            Controls.Add(linkLabel3);
            Controls.Add(pictureBox4);
            Controls.Add(linkLabel2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtDescription3);
            Controls.Add(txtDescription2);
            Controls.Add(txtDescription1);
            Controls.Add(lblAboutUs);
            Controls.Add(panel1);
            Name = "AboutUs";
            Text = "AboutUs";
            Load += AboutUs_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTwitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTiktok).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInstagram).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private LinkLabel llProfile;
        private Button btnActivity;
        private Button btnHome;
        private Panel panel2;
        private PictureBox picProfile;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtDescription3;
        private TextBox txtDescription2;
        private TextBox txtDescription1;
        private Label lblAboutUs;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox4;
        private LinkLabel linkLabel2;
        private PictureBox picTwitter;
        private PictureBox picTiktok;
        private PictureBox picInstagram;
        private Label lblSosmed;
    }
}