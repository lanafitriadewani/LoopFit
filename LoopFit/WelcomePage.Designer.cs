namespace LoopFit
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            lblSignUp = new Label();
            btnLogin = new Button();
            btnSignUp = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.BackColor = Color.Transparent;
            lblSignUp.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignUp.ForeColor = Color.FromArgb(100, 23, 61);
            lblSignUp.Location = new Point(12, 154);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(311, 134);
            lblSignUp.TabIndex = 25;
            lblSignUp.Text = "Welcome to\r\nLoopFit!";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(208, 154, 208);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(100, 23, 61);
            btnLogin.Location = new Point(25, 416);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(111, 44);
            btnLogin.TabIndex = 27;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Thistle;
            btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(208, 154, 208);
            btnSignUp.FlatAppearance.BorderSize = 3;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.ForeColor = Color.FromArgb(100, 23, 61);
            btnSignUp.Location = new Point(160, 416);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(111, 44);
            btnSignUp.TabIndex = 28;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(100, 23, 61);
            label1.Location = new Point(21, 299);
            label1.MaximumSize = new Size(420, 0);
            label1.Name = "label1";
            label1.Size = new Size(416, 92);
            label1.TabIndex = 29;
            label1.Text = resources.GetString("label1.Text");
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1006, 597);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(lblSignUp);
            Name = "WelcomePage";
            Text = "WelcomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSignUp;
        private Button btnLogin;
        private Button btnSignUp;
        private Label label1;
    }
}