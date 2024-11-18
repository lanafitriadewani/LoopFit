﻿namespace LoopFit
{
    partial class ActivityUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityUser));
            btnLoadActivityUser = new Button();
            dgvActivityUser = new DataGridView();
            btnLogOut = new Button();
            btnActivity = new Button();
            btnHome = new Button();
            panel2 = new Panel();
            llProfile = new LinkLabel();
            picProfile = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            lblLoopFit = new LinkLabel();
            lblContactUs = new LinkLabel();
            lblDonate1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvActivityUser).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnLoadActivityUser
            // 
            btnLoadActivityUser.BackColor = Color.FromArgb(178, 113, 178);
            btnLoadActivityUser.FlatStyle = FlatStyle.Popup;
            btnLoadActivityUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadActivityUser.ForeColor = Color.FromArgb(100, 23, 61);
            btnLoadActivityUser.Location = new Point(1212, 630);
            btnLoadActivityUser.Margin = new Padding(2);
            btnLoadActivityUser.Name = "btnLoadActivityUser";
            btnLoadActivityUser.Size = new Size(97, 36);
            btnLoadActivityUser.TabIndex = 34;
            btnLoadActivityUser.Text = "Load";
            btnLoadActivityUser.UseVisualStyleBackColor = false;
            btnLoadActivityUser.Click += btnLoadActivityUser_Click;
            // 
            // dgvActivityUser
            // 
            dgvActivityUser.BackgroundColor = Color.Thistle;
            dgvActivityUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivityUser.Location = new Point(291, 231);
            dgvActivityUser.Margin = new Padding(2);
            dgvActivityUser.Name = "dgvActivityUser";
            dgvActivityUser.RowHeadersWidth = 82;
            dgvActivityUser.RowTemplate.Height = 41;
            dgvActivityUser.Size = new Size(1018, 383);
            dgvActivityUser.TabIndex = 33;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(208, 154, 208);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.FromArgb(100, 23, 61);
            btnLogOut.Location = new Point(0, 677);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(246, 44);
            btnLogOut.TabIndex = 26;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnActivity
            // 
            btnActivity.BackColor = Color.FromArgb(208, 154, 208);
            btnActivity.FlatAppearance.BorderSize = 0;
            btnActivity.FlatStyle = FlatStyle.Flat;
            btnActivity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnActivity.ForeColor = Color.FromArgb(100, 23, 61);
            btnActivity.Location = new Point(0, 148);
            btnActivity.Margin = new Padding(2);
            btnActivity.Name = "btnActivity";
            btnActivity.Size = new Size(246, 44);
            btnActivity.TabIndex = 27;
            btnActivity.Text = "Activity";
            btnActivity.UseVisualStyleBackColor = true;
            btnActivity.Click += btnActivity_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(208, 154, 208);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.FromArgb(100, 23, 61);
            btnHome.Location = new Point(0, 104);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(246, 44);
            btnHome.TabIndex = 28;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 113, 178);
            panel2.Controls.Add(llProfile);
            panel2.Controls.Add(picProfile);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 104);
            panel2.TabIndex = 30;
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
            llProfile.TabIndex = 2;
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
            picProfile.TabIndex = 3;
            picProfile.TabStop = false;
            picProfile.Click += picProfile_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(208, 154, 208);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 721);
            panel1.TabIndex = 31;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(215, 169, 205);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lblLoopFit);
            panel3.Controls.Add(lblContactUs);
            panel3.Controls.Add(lblDonate1);
            panel3.Location = new Point(245, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1102, 206);
            panel3.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(100, 23, 61);
            label3.Location = new Point(25, 105);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.MaximumSize = new Size(1000, 0);
            label3.Name = "label3";
            label3.Size = new Size(983, 69);
            label3.TabIndex = 89;
            label3.Text = resources.GetString("label3.Text");
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.logoloopfit_;
            pictureBox3.Location = new Point(955, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // lblLoopFit
            // 
            lblLoopFit.AutoSize = true;
            lblLoopFit.BackColor = Color.Transparent;
            lblLoopFit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoopFit.LinkColor = Color.FromArgb(80, 23, 61);
            lblLoopFit.Location = new Point(987, 22);
            lblLoopFit.Margin = new Padding(2, 0, 2, 0);
            lblLoopFit.Name = "lblLoopFit";
            lblLoopFit.Size = new Size(75, 25);
            lblLoopFit.TabIndex = 42;
            lblLoopFit.TabStop = true;
            lblLoopFit.Text = "LoopFit";
            lblLoopFit.LinkClicked += lblLoopFit_LinkClicked;
            // 
            // lblContactUs
            // 
            lblContactUs.AutoSize = true;
            lblContactUs.BackColor = Color.Transparent;
            lblContactUs.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblContactUs.LinkColor = Color.FromArgb(80, 23, 61);
            lblContactUs.Location = new Point(825, 22);
            lblContactUs.Margin = new Padding(2, 0, 2, 0);
            lblContactUs.Name = "lblContactUs";
            lblContactUs.Size = new Size(104, 25);
            lblContactUs.TabIndex = 40;
            lblContactUs.TabStop = true;
            lblContactUs.Text = "Contact Us";
            lblContactUs.LinkClicked += lblContactUs_LinkClicked;
            // 
            // lblDonate1
            // 
            lblDonate1.AutoSize = true;
            lblDonate1.BackColor = Color.Transparent;
            lblDonate1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonate1.ForeColor = Color.FromArgb(100, 23, 61);
            lblDonate1.Location = new Point(14, 38);
            lblDonate1.Margin = new Padding(2, 0, 2, 0);
            lblDonate1.Name = "lblDonate1";
            lblDonate1.Size = new Size(185, 60);
            lblDonate1.TabIndex = 0;
            lblDonate1.Text = "Activity";
            // 
            // ActivityUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1348, 721);
            Controls.Add(panel3);
            Controls.Add(btnLoadActivityUser);
            Controls.Add(dgvActivityUser);
            Controls.Add(btnLogOut);
            Controls.Add(btnActivity);
            Controls.Add(btnHome);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ActivityUser";
            Text = "ActivityUser";
            ((System.ComponentModel.ISupportInitialize)dgvActivityUser).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadActivityUser;
        private DataGridView dgvActivityUser;
        private Button btnLogOut;
        private Button btnActivity;
        private Button btnHome;
        private Panel panel2;
        private Panel panel1;
        private LinkLabel llProfile;
        private PictureBox picProfile;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox3;
        private LinkLabel lblLoopFit;
        private LinkLabel lblContactUs;
        private Label lblDonate1;
    }
}