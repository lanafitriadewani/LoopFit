namespace LoopFit
{
    partial class Profile
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
            lblProfile_Profile = new Label();
            panel4 = new Panel();
            picProfile = new PictureBox();
            llProfile = new LinkLabel();
            btnActivity = new Button();
            btnHome = new Button();
            panel2 = new Panel();
            btnLogOut = new Button();
            btnSubmitLanguage_Profile = new Button();
            rbEnglish_Profile = new RadioButton();
            rbIndo_Profile = new RadioButton();
            lblChangeLanguage_Profile = new Label();
            panel1 = new Panel();
            lblDataPhone_Profile = new Label();
            lblDataPassword_Profile = new Label();
            lblDataEmail_Profile = new Label();
            lblPhoneNumber_Profile = new Label();
            panel3 = new Panel();
            lblDataFullName_Profile = new Label();
            lblDataUser_Profile = new Label();
            btnEditProfile_Profile = new Button();
            picUserProfile = new PictureBox();
            lblPasword_Profile = new Label();
            lblEmail_Profile = new Label();
            lblFullName_Profile = new Label();
            lblUsername_Profile = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserProfile).BeginInit();
            SuspendLayout();
            // 
            // lblProfile_Profile
            // 
            lblProfile_Profile.AutoSize = true;
            lblProfile_Profile.BackColor = Color.Transparent;
            lblProfile_Profile.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfile_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblProfile_Profile.Location = new Point(261, 38);
            lblProfile_Profile.Margin = new Padding(2, 0, 2, 0);
            lblProfile_Profile.Name = "lblProfile_Profile";
            lblProfile_Profile.Size = new Size(163, 60);
            lblProfile_Profile.TabIndex = 48;
            lblProfile_Profile.Text = "Profile";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 113, 178);
            panel4.Controls.Add(picProfile);
            panel4.Controls.Add(llProfile);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 104);
            panel4.TabIndex = 39;
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.FromArgb(178, 113, 178);
            picProfile.Location = new Point(26, 27);
            picProfile.Margin = new Padding(2);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(56, 49);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 0;
            picProfile.TabStop = false;
            picProfile.Click += picProfile_Click;
            // 
            // llProfile
            // 
            llProfile.ActiveLinkColor = Color.LavenderBlush;
            llProfile.AutoSize = true;
            llProfile.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            llProfile.ForeColor = Color.FromArgb(100, 23, 61);
            llProfile.LinkColor = Color.Black;
            llProfile.Location = new Point(86, 37);
            llProfile.Margin = new Padding(2, 0, 2, 0);
            llProfile.Name = "llProfile";
            llProfile.Size = new Size(90, 32);
            llProfile.TabIndex = 1;
            llProfile.TabStop = true;
            llProfile.Text = "Profile";
            llProfile.LinkClicked += llProfile_LinkClicked;
            // 
            // btnActivity
            // 
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
            panel2.BackColor = Color.FromArgb(208, 154, 208);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnActivity);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 721);
            panel2.TabIndex = 47;
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
            btnLogOut.TabIndex = 30;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Profile_Click;
            // 
            // btnSubmitLanguage_Profile
            // 
            btnSubmitLanguage_Profile.BackColor = Color.FromArgb(178, 113, 178);
            btnSubmitLanguage_Profile.FlatStyle = FlatStyle.Popup;
            btnSubmitLanguage_Profile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitLanguage_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            btnSubmitLanguage_Profile.Location = new Point(377, 68);
            btnSubmitLanguage_Profile.Margin = new Padding(2);
            btnSubmitLanguage_Profile.Name = "btnSubmitLanguage_Profile";
            btnSubmitLanguage_Profile.Size = new Size(125, 35);
            btnSubmitLanguage_Profile.TabIndex = 3;
            btnSubmitLanguage_Profile.Text = "Submit";
            btnSubmitLanguage_Profile.UseVisualStyleBackColor = false;
            btnSubmitLanguage_Profile.Click += btnSubmitLanguage_Click;
            // 
            // rbEnglish_Profile
            // 
            rbEnglish_Profile.AutoSize = true;
            rbEnglish_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbEnglish_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            rbEnglish_Profile.Location = new Point(223, 73);
            rbEnglish_Profile.Margin = new Padding(2);
            rbEnglish_Profile.Name = "rbEnglish_Profile";
            rbEnglish_Profile.Size = new Size(95, 32);
            rbEnglish_Profile.TabIndex = 2;
            rbEnglish_Profile.TabStop = true;
            rbEnglish_Profile.Text = "English";
            rbEnglish_Profile.UseVisualStyleBackColor = true;
            // 
            // rbIndo_Profile
            // 
            rbIndo_Profile.AutoSize = true;
            rbIndo_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbIndo_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            rbIndo_Profile.Location = new Point(36, 73);
            rbIndo_Profile.Margin = new Padding(2);
            rbIndo_Profile.Name = "rbIndo_Profile";
            rbIndo_Profile.Size = new Size(182, 32);
            rbIndo_Profile.TabIndex = 1;
            rbIndo_Profile.TabStop = true;
            rbIndo_Profile.Text = "Bahasa Indonesia";
            rbIndo_Profile.UseVisualStyleBackColor = true;
            // 
            // lblChangeLanguage_Profile
            // 
            lblChangeLanguage_Profile.AutoSize = true;
            lblChangeLanguage_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblChangeLanguage_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblChangeLanguage_Profile.Location = new Point(36, 24);
            lblChangeLanguage_Profile.Margin = new Padding(2, 0, 2, 0);
            lblChangeLanguage_Profile.Name = "lblChangeLanguage_Profile";
            lblChangeLanguage_Profile.Size = new Size(190, 28);
            lblChangeLanguage_Profile.TabIndex = 0;
            lblChangeLanguage_Profile.Text = "Change Language :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(215, 169, 205);
            panel1.Controls.Add(btnSubmitLanguage_Profile);
            panel1.Controls.Add(rbEnglish_Profile);
            panel1.Controls.Add(rbIndo_Profile);
            panel1.Controls.Add(lblChangeLanguage_Profile);
            panel1.Location = new Point(289, 528);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 154);
            panel1.TabIndex = 50;
            // 
            // lblDataPhone_Profile
            // 
            lblDataPhone_Profile.AutoSize = true;
            lblDataPhone_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataPhone_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblDataPhone_Profile.Location = new Point(572, 283);
            lblDataPhone_Profile.Margin = new Padding(2, 0, 2, 0);
            lblDataPhone_Profile.Name = "lblDataPhone_Profile";
            lblDataPhone_Profile.Size = new Size(76, 28);
            lblDataPhone_Profile.TabIndex = 13;
            lblDataPhone_Profile.Text = "label13";
            // 
            // lblDataPassword_Profile
            // 
            lblDataPassword_Profile.AutoSize = true;
            lblDataPassword_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataPassword_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblDataPassword_Profile.Location = new Point(572, 231);
            lblDataPassword_Profile.Margin = new Padding(2, 0, 2, 0);
            lblDataPassword_Profile.Name = "lblDataPassword_Profile";
            lblDataPassword_Profile.Size = new Size(76, 28);
            lblDataPassword_Profile.TabIndex = 12;
            lblDataPassword_Profile.Text = "label12";
            // 
            // lblDataEmail_Profile
            // 
            lblDataEmail_Profile.AutoSize = true;
            lblDataEmail_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataEmail_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblDataEmail_Profile.Location = new Point(572, 181);
            lblDataEmail_Profile.Margin = new Padding(2, 0, 2, 0);
            lblDataEmail_Profile.Name = "lblDataEmail_Profile";
            lblDataEmail_Profile.Size = new Size(76, 28);
            lblDataEmail_Profile.TabIndex = 11;
            lblDataEmail_Profile.Text = "label11";
            // 
            // lblPhoneNumber_Profile
            // 
            lblPhoneNumber_Profile.AutoSize = true;
            lblPhoneNumber_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNumber_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblPhoneNumber_Profile.Location = new Point(395, 282);
            lblPhoneNumber_Profile.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber_Profile.Name = "lblPhoneNumber_Profile";
            lblPhoneNumber_Profile.Size = new Size(165, 28);
            lblPhoneNumber_Profile.TabIndex = 4;
            lblPhoneNumber_Profile.Text = "Phone Number :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(215, 169, 205);
            panel3.Controls.Add(lblDataPhone_Profile);
            panel3.Controls.Add(lblDataPassword_Profile);
            panel3.Controls.Add(lblDataEmail_Profile);
            panel3.Controls.Add(lblDataFullName_Profile);
            panel3.Controls.Add(lblDataUser_Profile);
            panel3.Controls.Add(btnEditProfile_Profile);
            panel3.Controls.Add(picUserProfile);
            panel3.Controls.Add(lblPhoneNumber_Profile);
            panel3.Controls.Add(lblPasword_Profile);
            panel3.Controls.Add(lblEmail_Profile);
            panel3.Controls.Add(lblFullName_Profile);
            panel3.Controls.Add(lblUsername_Profile);
            panel3.Location = new Point(289, 133);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1027, 373);
            panel3.TabIndex = 49;
            // 
            // lblDataFullName_Profile
            // 
            lblDataFullName_Profile.AutoSize = true;
            lblDataFullName_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataFullName_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblDataFullName_Profile.Location = new Point(572, 134);
            lblDataFullName_Profile.Margin = new Padding(2, 0, 2, 0);
            lblDataFullName_Profile.Name = "lblDataFullName_Profile";
            lblDataFullName_Profile.Size = new Size(76, 28);
            lblDataFullName_Profile.TabIndex = 10;
            lblDataFullName_Profile.Text = "label10";
            // 
            // lblDataUser_Profile
            // 
            lblDataUser_Profile.AutoSize = true;
            lblDataUser_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataUser_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblDataUser_Profile.Location = new Point(572, 89);
            lblDataUser_Profile.Margin = new Padding(2, 0, 2, 0);
            lblDataUser_Profile.Name = "lblDataUser_Profile";
            lblDataUser_Profile.Size = new Size(65, 28);
            lblDataUser_Profile.TabIndex = 9;
            lblDataUser_Profile.Text = "label9";
            // 
            // btnEditProfile_Profile
            // 
            btnEditProfile_Profile.BackColor = Color.FromArgb(178, 113, 178);
            btnEditProfile_Profile.FlatStyle = FlatStyle.Popup;
            btnEditProfile_Profile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditProfile_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            btnEditProfile_Profile.Location = new Point(899, 15);
            btnEditProfile_Profile.Margin = new Padding(2);
            btnEditProfile_Profile.Name = "btnEditProfile_Profile";
            btnEditProfile_Profile.Size = new Size(108, 35);
            btnEditProfile_Profile.TabIndex = 8;
            btnEditProfile_Profile.Text = "Edit Profile";
            btnEditProfile_Profile.UseVisualStyleBackColor = false;
            btnEditProfile_Profile.Click += btnEditProfile_Click;
            // 
            // picUserProfile
            // 
            picUserProfile.Location = new Point(36, 38);
            picUserProfile.Margin = new Padding(2);
            picUserProfile.Name = "picUserProfile";
            picUserProfile.Size = new Size(300, 300);
            picUserProfile.TabIndex = 5;
            picUserProfile.TabStop = false;
            // 
            // lblPasword_Profile
            // 
            lblPasword_Profile.AutoSize = true;
            lblPasword_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasword_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblPasword_Profile.Location = new Point(395, 231);
            lblPasword_Profile.Margin = new Padding(2, 0, 2, 0);
            lblPasword_Profile.Name = "lblPasword_Profile";
            lblPasword_Profile.Size = new Size(112, 28);
            lblPasword_Profile.TabIndex = 3;
            lblPasword_Profile.Text = "Password :";
            // 
            // lblEmail_Profile
            // 
            lblEmail_Profile.AutoSize = true;
            lblEmail_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblEmail_Profile.Location = new Point(395, 181);
            lblEmail_Profile.Margin = new Padding(2, 0, 2, 0);
            lblEmail_Profile.Name = "lblEmail_Profile";
            lblEmail_Profile.Size = new Size(75, 28);
            lblEmail_Profile.TabIndex = 2;
            lblEmail_Profile.Text = "Email :";
            // 
            // lblFullName_Profile
            // 
            lblFullName_Profile.AutoSize = true;
            lblFullName_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullName_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblFullName_Profile.Location = new Point(395, 134);
            lblFullName_Profile.Margin = new Padding(2, 0, 2, 0);
            lblFullName_Profile.Name = "lblFullName_Profile";
            lblFullName_Profile.Size = new Size(119, 28);
            lblFullName_Profile.TabIndex = 1;
            lblFullName_Profile.Text = "Full Name :";
            // 
            // lblUsername_Profile
            // 
            lblUsername_Profile.AutoSize = true;
            lblUsername_Profile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername_Profile.ForeColor = Color.FromArgb(100, 23, 61);
            lblUsername_Profile.Location = new Point(395, 89);
            lblUsername_Profile.Margin = new Padding(2, 0, 2, 0);
            lblUsername_Profile.Name = "lblUsername_Profile";
            lblUsername_Profile.Size = new Size(117, 28);
            lblUsername_Profile.TabIndex = 0;
            lblUsername_Profile.Text = "Username :";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1348, 721);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(lblProfile_Profile);
            Controls.Add(panel2);
            Name = "Profile";
            Text = "Profile";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProfile_Profile;
        private Panel panel4;
        private PictureBox picProfile;
        private LinkLabel llProfile;
        private Button btnActivity;
        private Button btnHome;
        private Panel panel2;
        private Button btnLogOut;
        private Button btnSubmitLanguage_Profile;
        private RadioButton rbEnglish_Profile;
        private RadioButton rbIndo_Profile;
        private Label lblChangeLanguage_Profile;
        private Panel panel1;
        private Label lblDataPhone_Profile;
        private Label lblDataPassword_Profile;
        private Label lblDataEmail_Profile;
        private Label lblPhoneNumber_Profile;
        private Panel panel3;
        private Label lblDataFullName_Profile;
        private Label lblDataUser_Profile;
        private Button btnEditProfile_Profile;
        private PictureBox picUserProfile;
        private Label lblPasword_Profile;
        private Label lblEmail_Profile;
        private Label lblFullName_Profile;
        private Label lblUsername_Profile;
    }
}