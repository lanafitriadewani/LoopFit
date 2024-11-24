namespace LoopFit
{
    partial class EditProfile
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
            btnLogOut = new Button();
            picProfile = new PictureBox();
            llProfile = new LinkLabel();
            panel4 = new Panel();
            btnActivity = new Button();
            btnHome = new Button();
            panel2 = new Panel();
            lblDonate1_Edit = new Label();
            btnSubmitEdit_EditProfile = new Button();
            btnChangeImage_EditProfile = new Button();
            profilePic = new PictureBox();
            btnVerify_EditProfile = new Button();
            tbLastName = new TextBox();
            label1_Edit = new Label();
            btnSendVerifCode_EditProfile = new Button();
            tbPhoneNumber = new TextBox();
            tbConfirmPw = new TextBox();
            tbNewPw = new TextBox();
            tbVerifCode = new TextBox();
            tbEmail = new TextBox();
            tbFirstName = new TextBox();
            tbUsername = new TextBox();
            lblPhoneNumber_Edit = new Label();
            lblConfirmPw_Edit = new Label();
            lblNewPw_Edit = new Label();
            lblVerificationCode_Edit = new Label();
            lblEmail = new Label();
            lblFullName_Edit = new Label();
            lblUsername_Edit = new Label();
            label2 = new Label();
            label3_Edit = new Label();
            label4_Edit = new Label();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePic).BeginInit();
            SuspendLayout();
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
            btnLogOut.Click += button1_Click;
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.FromArgb(178, 113, 178);
            picProfile.Location = new Point(26, 27);
            picProfile.Margin = new Padding(2);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(56, 49);
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
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
            panel2.TabIndex = 45;
            // 
            // lblDonate1_Edit
            // 
            lblDonate1_Edit.AutoSize = true;
            lblDonate1_Edit.BackColor = Color.Transparent;
            lblDonate1_Edit.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonate1_Edit.ForeColor = Color.FromArgb(100, 23, 61);
            lblDonate1_Edit.Location = new Point(261, 38);
            lblDonate1_Edit.Margin = new Padding(2, 0, 2, 0);
            lblDonate1_Edit.Name = "lblDonate1_Edit";
            lblDonate1_Edit.Size = new Size(255, 60);
            lblDonate1_Edit.TabIndex = 46;
            lblDonate1_Edit.Text = "Edit Profile";
            // 
            // btnSubmitEdit_EditProfile
            // 
            btnSubmitEdit_EditProfile.BackColor = Color.FromArgb(178, 113, 178);
            btnSubmitEdit_EditProfile.FlatStyle = FlatStyle.Popup;
            btnSubmitEdit_EditProfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitEdit_EditProfile.ForeColor = Color.FromArgb(100, 23, 61);
            btnSubmitEdit_EditProfile.Location = new Point(1113, 653);
            btnSubmitEdit_EditProfile.Margin = new Padding(2);
            btnSubmitEdit_EditProfile.Name = "btnSubmitEdit_EditProfile";
            btnSubmitEdit_EditProfile.Size = new Size(131, 38);
            btnSubmitEdit_EditProfile.TabIndex = 64;
            btnSubmitEdit_EditProfile.Text = "Submit";
            btnSubmitEdit_EditProfile.UseVisualStyleBackColor = false;
            btnSubmitEdit_EditProfile.Click += btnSubmitEdit_Click;
            // 
            // btnChangeImage_EditProfile
            // 
            btnChangeImage_EditProfile.BackColor = Color.FromArgb(178, 113, 178);
            btnChangeImage_EditProfile.FlatStyle = FlatStyle.Popup;
            btnChangeImage_EditProfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeImage_EditProfile.ForeColor = Color.FromArgb(100, 23, 61);
            btnChangeImage_EditProfile.Location = new Point(1125, 159);
            btnChangeImage_EditProfile.Margin = new Padding(2);
            btnChangeImage_EditProfile.Name = "btnChangeImage_EditProfile";
            btnChangeImage_EditProfile.Size = new Size(129, 39);
            btnChangeImage_EditProfile.TabIndex = 63;
            btnChangeImage_EditProfile.Text = "Change Image";
            btnChangeImage_EditProfile.UseVisualStyleBackColor = false;
            btnChangeImage_EditProfile.Click += btnChangeImage_Click;
            // 
            // profilePic
            // 
            profilePic.Location = new Point(867, 159);
            profilePic.Margin = new Padding(2);
            profilePic.Name = "profilePic";
            profilePic.Size = new Size(387, 435);
            profilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePic.TabIndex = 62;
            profilePic.TabStop = false;
            // 
            // btnVerify_EditProfile
            // 
            btnVerify_EditProfile.BackColor = Color.FromArgb(178, 113, 178);
            btnVerify_EditProfile.FlatStyle = FlatStyle.Popup;
            btnVerify_EditProfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerify_EditProfile.ForeColor = Color.FromArgb(100, 23, 61);
            btnVerify_EditProfile.Location = new Point(521, 431);
            btnVerify_EditProfile.Margin = new Padding(2);
            btnVerify_EditProfile.Name = "btnVerify_EditProfile";
            btnVerify_EditProfile.Size = new Size(97, 31);
            btnVerify_EditProfile.TabIndex = 82;
            btnVerify_EditProfile.Text = "Verify";
            btnVerify_EditProfile.UseVisualStyleBackColor = false;
            btnVerify_EditProfile.Click += btnVerify_Click;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(521, 254);
            tbLastName.Margin = new Padding(2);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(315, 27);
            tbLastName.TabIndex = 81;
            // 
            // label1_Edit
            // 
            label1_Edit.AutoSize = true;
            label1_Edit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1_Edit.ForeColor = Color.FromArgb(100, 23, 61);
            label1_Edit.Location = new Point(324, 254);
            label1_Edit.Margin = new Padding(2, 0, 2, 0);
            label1_Edit.Name = "label1_Edit";
            label1_Edit.Size = new Size(100, 23);
            label1_Edit.TabIndex = 80;
            label1_Edit.Text = "Last Name :";
            // 
            // btnSendVerifCode_EditProfile
            // 
            btnSendVerifCode_EditProfile.BackColor = Color.FromArgb(178, 113, 178);
            btnSendVerifCode_EditProfile.FlatStyle = FlatStyle.Popup;
            btnSendVerifCode_EditProfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSendVerifCode_EditProfile.ForeColor = Color.FromArgb(100, 23, 61);
            btnSendVerifCode_EditProfile.Location = new Point(521, 343);
            btnSendVerifCode_EditProfile.Margin = new Padding(2);
            btnSendVerifCode_EditProfile.Name = "btnSendVerifCode_EditProfile";
            btnSendVerifCode_EditProfile.Size = new Size(97, 31);
            btnSendVerifCode_EditProfile.TabIndex = 79;
            btnSendVerifCode_EditProfile.Text = "Send Code";
            btnSendVerifCode_EditProfile.UseVisualStyleBackColor = false;
            btnSendVerifCode_EditProfile.Click += btnSendVerifCode_Click;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(521, 571);
            tbPhoneNumber.Margin = new Padding(2);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(315, 27);
            tbPhoneNumber.TabIndex = 78;
            // 
            // tbConfirmPw
            // 
            tbConfirmPw.Location = new Point(521, 526);
            tbConfirmPw.Margin = new Padding(2);
            tbConfirmPw.Name = "tbConfirmPw";
            tbConfirmPw.Size = new Size(315, 27);
            tbConfirmPw.TabIndex = 77;
            tbConfirmPw.UseSystemPasswordChar = true;
            // 
            // tbNewPw
            // 
            tbNewPw.Location = new Point(521, 481);
            tbNewPw.Margin = new Padding(2);
            tbNewPw.Name = "tbNewPw";
            tbNewPw.Size = new Size(315, 27);
            tbNewPw.TabIndex = 76;
            tbNewPw.UseSystemPasswordChar = true;
            // 
            // tbVerifCode
            // 
            tbVerifCode.Location = new Point(521, 392);
            tbVerifCode.Margin = new Padding(2);
            tbVerifCode.Name = "tbVerifCode";
            tbVerifCode.Size = new Size(315, 27);
            tbVerifCode.TabIndex = 75;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(521, 303);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(315, 27);
            tbEmail.TabIndex = 74;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(521, 207);
            tbFirstName.Margin = new Padding(2);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(315, 27);
            tbFirstName.TabIndex = 73;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(521, 159);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(315, 27);
            tbUsername.TabIndex = 72;
            // 
            // lblPhoneNumber_Edit
            // 
            lblPhoneNumber_Edit.AutoSize = true;
            lblPhoneNumber_Edit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNumber_Edit.ForeColor = Color.FromArgb(100, 23, 61);
            lblPhoneNumber_Edit.Location = new Point(324, 571);
            lblPhoneNumber_Edit.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber_Edit.Name = "lblPhoneNumber_Edit";
            lblPhoneNumber_Edit.Size = new Size(136, 23);
            lblPhoneNumber_Edit.TabIndex = 71;
            lblPhoneNumber_Edit.Text = "Phone Number :";
            // 
            // lblConfirmPw_Edit
            // 
            lblConfirmPw_Edit.AutoSize = true;
            lblConfirmPw_Edit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmPw_Edit.ForeColor = Color.FromArgb(100, 23, 61);
            lblConfirmPw_Edit.Location = new Point(324, 526);
            lblConfirmPw_Edit.Margin = new Padding(2, 0, 2, 0);
            lblConfirmPw_Edit.Name = "lblConfirmPw_Edit";
            lblConfirmPw_Edit.Size = new Size(158, 23);
            lblConfirmPw_Edit.TabIndex = 70;
            lblConfirmPw_Edit.Text = "Confirm Password :";
            // 
            // lblNewPw_Edit
            // 
            lblNewPw_Edit.AutoSize = true;
            lblNewPw_Edit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewPw_Edit.ForeColor = Color.FromArgb(100, 23, 61);
            lblNewPw_Edit.Location = new Point(324, 481);
            lblNewPw_Edit.Margin = new Padding(2, 0, 2, 0);
            lblNewPw_Edit.Name = "lblNewPw_Edit";
            lblNewPw_Edit.Size = new Size(131, 23);
            lblNewPw_Edit.TabIndex = 69;
            lblNewPw_Edit.Text = "New Password :";
            // 
            // lblVerificationCode_Edit
            // 
            lblVerificationCode_Edit.AutoSize = true;
            lblVerificationCode_Edit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblVerificationCode_Edit.ForeColor = Color.FromArgb(100, 23, 61);
            lblVerificationCode_Edit.Location = new Point(324, 393);
            lblVerificationCode_Edit.Margin = new Padding(2, 0, 2, 0);
            lblVerificationCode_Edit.Name = "lblVerificationCode_Edit";
            lblVerificationCode_Edit.Size = new Size(150, 23);
            lblVerificationCode_Edit.TabIndex = 68;
            lblVerificationCode_Edit.Text = "Verification Code :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(100, 23, 61);
            lblEmail.Location = new Point(324, 303);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 23);
            lblEmail.TabIndex = 67;
            lblEmail.Text = "Email :";
            // 
            // lblFullName_Edit
            // 
            lblFullName_Edit.AutoSize = true;
            lblFullName_Edit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullName_Edit.ForeColor = Color.FromArgb(100, 23, 61);
            lblFullName_Edit.Location = new Point(324, 211);
            lblFullName_Edit.Margin = new Padding(2, 0, 2, 0);
            lblFullName_Edit.Name = "lblFullName_Edit";
            lblFullName_Edit.Size = new Size(102, 23);
            lblFullName_Edit.TabIndex = 66;
            lblFullName_Edit.Text = "First Name :";
            // 
            // lblUsername_Edit
            // 
            lblUsername_Edit.AutoSize = true;
            lblUsername_Edit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername_Edit.ForeColor = Color.FromArgb(100, 23, 61);
            lblUsername_Edit.Location = new Point(324, 159);
            lblUsername_Edit.Margin = new Padding(2, 0, 2, 0);
            lblUsername_Edit.Name = "lblUsername_Edit";
            lblUsername_Edit.Size = new Size(96, 23);
            lblUsername_Edit.TabIndex = 65;
            lblUsername_Edit.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(100, 23, 61);
            label2.Location = new Point(635, 343);
            label2.MaximumSize = new Size(210, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 34);
            label2.TabIndex = 83;
            label2.Text = "*Click it if you change your email and you will get your code soon";
            // 
            // label3_Edit
            // 
            label3_Edit.AutoSize = true;
            label3_Edit.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3_Edit.ForeColor = Color.FromArgb(100, 23, 61);
            label3_Edit.Location = new Point(630, 343);
            label3_Edit.MaximumSize = new Size(210, 0);
            label3_Edit.Name = "label3_Edit";
            label3_Edit.Size = new Size(201, 34);
            label3_Edit.TabIndex = 84;
            label3_Edit.Text = "*Click it if you change your email and you will get your code soon";
            // 
            // label4_Edit
            // 
            label4_Edit.AutoSize = true;
            label4_Edit.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4_Edit.ForeColor = Color.FromArgb(100, 23, 61);
            label4_Edit.Location = new Point(630, 428);
            label4_Edit.MaximumSize = new Size(210, 0);
            label4_Edit.Name = "label4_Edit";
            label4_Edit.Size = new Size(207, 34);
            label4_Edit.TabIndex = 85;
            label4_Edit.Text = "*Click it to verify your code before submitting changes";
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1348, 721);
            Controls.Add(label4_Edit);
            Controls.Add(label3_Edit);
            Controls.Add(label2);
            Controls.Add(btnVerify_EditProfile);
            Controls.Add(tbLastName);
            Controls.Add(label1_Edit);
            Controls.Add(btnSendVerifCode_EditProfile);
            Controls.Add(tbPhoneNumber);
            Controls.Add(tbConfirmPw);
            Controls.Add(tbNewPw);
            Controls.Add(tbVerifCode);
            Controls.Add(tbEmail);
            Controls.Add(tbFirstName);
            Controls.Add(tbUsername);
            Controls.Add(lblPhoneNumber_Edit);
            Controls.Add(lblConfirmPw_Edit);
            Controls.Add(lblNewPw_Edit);
            Controls.Add(lblVerificationCode_Edit);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName_Edit);
            Controls.Add(lblUsername_Edit);
            Controls.Add(btnSubmitEdit_EditProfile);
            Controls.Add(btnChangeImage_EditProfile);
            Controls.Add(profilePic);
            Controls.Add(lblDonate1_Edit);
            Controls.Add(panel2);
            Name = "EditProfile";
            Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profilePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private PictureBox picProfile;
        private LinkLabel llProfile;
        private Panel panel4;
        private Button btnActivity;
        private Button btnHome;
        private Panel panel2;
        private Label lblDonate1_Edit;
        private Button btnSubmitEdit_EditProfile;
        private Button btnChangeImage_EditProfile;
        private PictureBox profilePic;
        private Button btnVerify_EditProfile;
        private TextBox tbLastName;
        private Label label1_Edit;
        private Button btnSendVerifCode_EditProfile;
        private TextBox tbPhoneNumber;
        private TextBox tbConfirmPw;
        private TextBox tbNewPw;
        private TextBox tbVerifCode;
        private TextBox tbEmail;
        private TextBox tbFirstName;
        private TextBox tbUsername;
        private Label lblPhoneNumber_Edit;
        private Label lblConfirmPw_Edit;
        private Label lblNewPw_Edit;
        private Label lblVerificationCode_Edit;
        private Label lblEmail;
        private Label lblFullName_Edit;
        private Label lblUsername_Edit;
        private Label label2;
        private Label label3_Edit;
        private Label label4_Edit;
    }
}