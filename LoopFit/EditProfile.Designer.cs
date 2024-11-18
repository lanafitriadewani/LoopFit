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
            button1 = new Button();
            picProfile = new PictureBox();
            llProfile = new LinkLabel();
            panel4 = new Panel();
            btnActivity = new Button();
            btnHome = new Button();
            panel2 = new Panel();
            lblDonate1 = new Label();
            btnSubmitEdit = new Button();
            btnChangeImage = new Button();
            profilePic = new PictureBox();
            btnVerify = new Button();
            tbLastName = new TextBox();
            label1 = new Label();
            btnSendVerifCode = new Button();
            tbPhoneNumber = new TextBox();
            tbConfirmPw = new TextBox();
            tbNewPw = new TextBox();
            tbVerifCode = new TextBox();
            tbEmail = new TextBox();
            tbFirstName = new TextBox();
            tbUsername = new TextBox();
            lblPhoneNumber = new Label();
            lblConfirmPw = new Label();
            lblNewPw = new Label();
            lblVerificationCode = new Label();
            lblEmail = new Label();
            lblFullName = new Label();
            lblUsername = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePic).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(208, 154, 208);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(100, 23, 61);
            button1.Location = new Point(0, 677);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(246, 44);
            button1.TabIndex = 30;
            button1.Text = "Log Out";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnActivity);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 721);
            panel2.TabIndex = 45;
            // 
            // lblDonate1
            // 
            lblDonate1.AutoSize = true;
            lblDonate1.BackColor = Color.Transparent;
            lblDonate1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonate1.ForeColor = Color.FromArgb(100, 23, 61);
            lblDonate1.Location = new Point(261, 38);
            lblDonate1.Margin = new Padding(2, 0, 2, 0);
            lblDonate1.Name = "lblDonate1";
            lblDonate1.Size = new Size(255, 60);
            lblDonate1.TabIndex = 46;
            lblDonate1.Text = "Edit Profile";
            // 
            // btnSubmitEdit
            // 
            btnSubmitEdit.BackColor = Color.FromArgb(178, 113, 178);
            btnSubmitEdit.FlatStyle = FlatStyle.Popup;
            btnSubmitEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitEdit.ForeColor = Color.FromArgb(100, 23, 61);
            btnSubmitEdit.Location = new Point(1113, 653);
            btnSubmitEdit.Margin = new Padding(2);
            btnSubmitEdit.Name = "btnSubmitEdit";
            btnSubmitEdit.Size = new Size(131, 38);
            btnSubmitEdit.TabIndex = 64;
            btnSubmitEdit.Text = "Submit";
            btnSubmitEdit.UseVisualStyleBackColor = false;
            btnSubmitEdit.Click += btnSubmitEdit_Click;
            // 
            // btnChangeImage
            // 
            btnChangeImage.BackColor = Color.FromArgb(178, 113, 178);
            btnChangeImage.FlatStyle = FlatStyle.Popup;
            btnChangeImage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeImage.ForeColor = Color.FromArgb(100, 23, 61);
            btnChangeImage.Location = new Point(1113, 159);
            btnChangeImage.Margin = new Padding(2);
            btnChangeImage.Name = "btnChangeImage";
            btnChangeImage.Size = new Size(129, 39);
            btnChangeImage.TabIndex = 63;
            btnChangeImage.Text = "Change Image";
            btnChangeImage.UseVisualStyleBackColor = false;
            btnChangeImage.Click += btnChangeImage_Click;
            // 
            // profilePic
            // 
            profilePic.Location = new Point(855, 159);
            profilePic.Margin = new Padding(2);
            profilePic.Name = "profilePic";
            profilePic.Size = new Size(387, 435);
            profilePic.TabIndex = 62;
            profilePic.TabStop = false;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.FromArgb(178, 113, 178);
            btnVerify.FlatStyle = FlatStyle.Popup;
            btnVerify.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerify.ForeColor = Color.FromArgb(100, 23, 61);
            btnVerify.Location = new Point(465, 431);
            btnVerify.Margin = new Padding(2);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(97, 31);
            btnVerify.TabIndex = 82;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(465, 254);
            tbLastName.Margin = new Padding(2);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(315, 27);
            tbLastName.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(100, 23, 61);
            label1.Location = new Point(360, 254);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 80;
            label1.Text = "Last Name :";
            // 
            // btnSendVerifCode
            // 
            btnSendVerifCode.BackColor = Color.FromArgb(178, 113, 178);
            btnSendVerifCode.FlatStyle = FlatStyle.Popup;
            btnSendVerifCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSendVerifCode.ForeColor = Color.FromArgb(100, 23, 61);
            btnSendVerifCode.Location = new Point(465, 343);
            btnSendVerifCode.Margin = new Padding(2);
            btnSendVerifCode.Name = "btnSendVerifCode";
            btnSendVerifCode.Size = new Size(97, 31);
            btnSendVerifCode.TabIndex = 79;
            btnSendVerifCode.Text = "Send Code";
            btnSendVerifCode.UseVisualStyleBackColor = false;
            btnSendVerifCode.Click += btnSendVerifCode_Click;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(465, 571);
            tbPhoneNumber.Margin = new Padding(2);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(315, 27);
            tbPhoneNumber.TabIndex = 78;
            // 
            // tbConfirmPw
            // 
            tbConfirmPw.Location = new Point(465, 526);
            tbConfirmPw.Margin = new Padding(2);
            tbConfirmPw.Name = "tbConfirmPw";
            tbConfirmPw.Size = new Size(315, 27);
            tbConfirmPw.TabIndex = 77;
            tbConfirmPw.UseSystemPasswordChar = true;
            // 
            // tbNewPw
            // 
            tbNewPw.Location = new Point(465, 481);
            tbNewPw.Margin = new Padding(2);
            tbNewPw.Name = "tbNewPw";
            tbNewPw.Size = new Size(315, 27);
            tbNewPw.TabIndex = 76;
            tbNewPw.UseSystemPasswordChar = true;
            // 
            // tbVerifCode
            // 
            tbVerifCode.Location = new Point(465, 392);
            tbVerifCode.Margin = new Padding(2);
            tbVerifCode.Name = "tbVerifCode";
            tbVerifCode.Size = new Size(315, 27);
            tbVerifCode.TabIndex = 75;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(465, 303);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(315, 27);
            tbEmail.TabIndex = 74;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(465, 207);
            tbFirstName.Margin = new Padding(2);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(315, 27);
            tbFirstName.TabIndex = 73;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(465, 159);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(315, 27);
            tbUsername.TabIndex = 72;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = Color.FromArgb(100, 23, 61);
            lblPhoneNumber.Location = new Point(328, 571);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(136, 23);
            lblPhoneNumber.TabIndex = 71;
            lblPhoneNumber.Text = "Phone Number :";
            // 
            // lblConfirmPw
            // 
            lblConfirmPw.AutoSize = true;
            lblConfirmPw.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmPw.ForeColor = Color.FromArgb(100, 23, 61);
            lblConfirmPw.Location = new Point(306, 526);
            lblConfirmPw.Margin = new Padding(2, 0, 2, 0);
            lblConfirmPw.Name = "lblConfirmPw";
            lblConfirmPw.Size = new Size(158, 23);
            lblConfirmPw.TabIndex = 70;
            lblConfirmPw.Text = "Confirm Password :";
            // 
            // lblNewPw
            // 
            lblNewPw.AutoSize = true;
            lblNewPw.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewPw.ForeColor = Color.FromArgb(100, 23, 61);
            lblNewPw.Location = new Point(333, 480);
            lblNewPw.Margin = new Padding(2, 0, 2, 0);
            lblNewPw.Name = "lblNewPw";
            lblNewPw.Size = new Size(131, 23);
            lblNewPw.TabIndex = 69;
            lblNewPw.Text = "New Password :";
            // 
            // lblVerificationCode
            // 
            lblVerificationCode.AutoSize = true;
            lblVerificationCode.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblVerificationCode.ForeColor = Color.FromArgb(100, 23, 61);
            lblVerificationCode.Location = new Point(314, 393);
            lblVerificationCode.Margin = new Padding(2, 0, 2, 0);
            lblVerificationCode.Name = "lblVerificationCode";
            lblVerificationCode.Size = new Size(150, 23);
            lblVerificationCode.TabIndex = 68;
            lblVerificationCode.Text = "Verification Code :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(100, 23, 61);
            lblEmail.Location = new Point(402, 305);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 23);
            lblEmail.TabIndex = 67;
            lblEmail.Text = "Email :";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullName.ForeColor = Color.FromArgb(100, 23, 61);
            lblFullName.Location = new Point(358, 211);
            lblFullName.Margin = new Padding(2, 0, 2, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(102, 23);
            lblFullName.TabIndex = 66;
            lblFullName.Text = "First Name :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(100, 23, 61);
            lblUsername.Location = new Point(364, 163);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(96, 23);
            lblUsername.TabIndex = 65;
            lblUsername.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(100, 23, 61);
            label2.Location = new Point(579, 343);
            label2.MaximumSize = new Size(210, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 34);
            label2.TabIndex = 83;
            label2.Text = "*Click it if you change your email and you will get your code soon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(100, 23, 61);
            label3.Location = new Point(574, 343);
            label3.MaximumSize = new Size(210, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 34);
            label3.TabIndex = 84;
            label3.Text = "*Click it if you change your email and you will get your code soon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(100, 23, 61);
            label4.Location = new Point(574, 428);
            label4.MaximumSize = new Size(210, 0);
            label4.Name = "label4";
            label4.Size = new Size(207, 34);
            label4.TabIndex = 85;
            label4.Text = "*Click it to verify your code before submitting changes";
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1348, 721);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnVerify);
            Controls.Add(tbLastName);
            Controls.Add(label1);
            Controls.Add(btnSendVerifCode);
            Controls.Add(tbPhoneNumber);
            Controls.Add(tbConfirmPw);
            Controls.Add(tbNewPw);
            Controls.Add(tbVerifCode);
            Controls.Add(tbEmail);
            Controls.Add(tbFirstName);
            Controls.Add(tbUsername);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblConfirmPw);
            Controls.Add(lblNewPw);
            Controls.Add(lblVerificationCode);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Controls.Add(lblUsername);
            Controls.Add(btnSubmitEdit);
            Controls.Add(btnChangeImage);
            Controls.Add(profilePic);
            Controls.Add(lblDonate1);
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

        private Button button1;
        private PictureBox picProfile;
        private LinkLabel llProfile;
        private Panel panel4;
        private Button btnActivity;
        private Button btnHome;
        private Panel panel2;
        private Label lblDonate1;
        private Button btnSubmitEdit;
        private Button btnChangeImage;
        private PictureBox profilePic;
        private Button btnVerify;
        private TextBox tbLastName;
        private Label label1;
        private Button btnSendVerifCode;
        private TextBox tbPhoneNumber;
        private TextBox tbConfirmPw;
        private TextBox tbNewPw;
        private TextBox tbVerifCode;
        private TextBox tbEmail;
        private TextBox tbFirstName;
        private TextBox tbUsername;
        private Label lblPhoneNumber;
        private Label lblConfirmPw;
        private Label lblNewPw;
        private Label lblVerificationCode;
        private Label lblEmail;
        private Label lblFullName;
        private Label lblUsername;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}