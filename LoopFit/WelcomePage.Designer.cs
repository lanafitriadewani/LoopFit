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
            lblSignUp_Welcome = new Label();
            btnLogin_Welcome = new Button();
            btnSignUp_Welcome = new Button();
            label1_Welcome = new Label();
            SuspendLayout();
            // 
            // lblSignUp_Welcome
            // 
            lblSignUp_Welcome.AutoSize = true;
            lblSignUp_Welcome.BackColor = Color.Transparent;
            lblSignUp_Welcome.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignUp_Welcome.ForeColor = Color.FromArgb(100, 23, 61);
            lblSignUp_Welcome.Location = new Point(12, 146);
            lblSignUp_Welcome.MaximumSize = new Size(340, 0);
            lblSignUp_Welcome.Name = "lblSignUp_Welcome";
            lblSignUp_Welcome.Size = new Size(325, 134);
            lblSignUp_Welcome.TabIndex = 25;
            lblSignUp_Welcome.Text = "Welcome to LoopFit!";
            // 
            // btnLogin_Welcome
            // 
            btnLogin_Welcome.BackColor = Color.FromArgb(208, 154, 208);
            btnLogin_Welcome.FlatAppearance.BorderSize = 0;
            btnLogin_Welcome.FlatStyle = FlatStyle.Flat;
            btnLogin_Welcome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin_Welcome.ForeColor = Color.FromArgb(100, 23, 61);
            btnLogin_Welcome.Location = new Point(25, 417);
            btnLogin_Welcome.Name = "btnLogin_Welcome";
            btnLogin_Welcome.Size = new Size(111, 44);
            btnLogin_Welcome.TabIndex = 27;
            btnLogin_Welcome.Text = "Login";
            btnLogin_Welcome.UseVisualStyleBackColor = false;
            btnLogin_Welcome.Click += btnLogin_Click;
            // 
            // btnSignUp_Welcome
            // 
            btnSignUp_Welcome.BackColor = Color.Thistle;
            btnSignUp_Welcome.FlatAppearance.BorderColor = Color.FromArgb(208, 154, 208);
            btnSignUp_Welcome.FlatAppearance.BorderSize = 3;
            btnSignUp_Welcome.FlatStyle = FlatStyle.Flat;
            btnSignUp_Welcome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp_Welcome.ForeColor = Color.FromArgb(100, 23, 61);
            btnSignUp_Welcome.Location = new Point(160, 417);
            btnSignUp_Welcome.Name = "btnSignUp_Welcome";
            btnSignUp_Welcome.Size = new Size(111, 44);
            btnSignUp_Welcome.TabIndex = 28;
            btnSignUp_Welcome.Text = "Sign Up";
            btnSignUp_Welcome.UseVisualStyleBackColor = false;
            btnSignUp_Welcome.Click += btnSignUp_Click;
            // 
            // label1_Welcome
            // 
            label1_Welcome.AutoSize = true;
            label1_Welcome.BackColor = Color.Transparent;
            label1_Welcome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1_Welcome.ForeColor = Color.FromArgb(100, 23, 61);
            label1_Welcome.Location = new Point(21, 291);
            label1_Welcome.MaximumSize = new Size(420, 0);
            label1_Welcome.Name = "label1_Welcome";
            label1_Welcome.Size = new Size(416, 92);
            label1_Welcome.TabIndex = 29;
            label1_Welcome.Text = resources.GetString("label1_Welcome.Text");
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1006, 597);
            Controls.Add(label1_Welcome);
            Controls.Add(btnSignUp_Welcome);
            Controls.Add(btnLogin_Welcome);
            Controls.Add(lblSignUp_Welcome);
            Name = "WelcomePage";
            Text = "WelcomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSignUp_Welcome;
        private Button btnLogin_Welcome;
        private Button btnSignUp_Welcome;
        private Label label1_Welcome;
    }
}