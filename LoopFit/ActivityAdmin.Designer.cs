namespace LoopFit
{
    partial class ActivityAdmin
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
            panel1 = new Panel();
            btnLogOut = new Button();
            btnContent = new Button();
            btnCatalog = new Button();
            btnDonateAct = new Button();
            panel2 = new Panel();
            llProfile = new LinkLabel();
            picProfile = new PictureBox();
            lblDonateActivity = new Label();
            btnLoadDonate = new Button();
            tbFixedPrice = new TextBox();
            tbStatus = new TextBox();
            tbDonateId = new TextBox();
            lblFixedPrice = new Label();
            lblStatus = new Label();
            lbIdDonate = new Label();
            dgvDonateActivity = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonateActivity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(208, 154, 208);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnContent);
            panel1.Controls.Add(btnCatalog);
            panel1.Controls.Add(btnDonateAct);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 721);
            panel1.TabIndex = 22;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(208, 154, 208);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.FromArgb(100, 23, 61);
            btnLogOut.Location = new Point(0, 678);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(246, 44);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnContent
            // 
            btnContent.Dock = DockStyle.Top;
            btnContent.FlatAppearance.BorderSize = 0;
            btnContent.FlatStyle = FlatStyle.Flat;
            btnContent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnContent.ForeColor = Color.FromArgb(100, 23, 61);
            btnContent.Location = new Point(0, 192);
            btnContent.Margin = new Padding(2);
            btnContent.Name = "btnContent";
            btnContent.Size = new Size(246, 44);
            btnContent.TabIndex = 2;
            btnContent.Text = "Content";
            btnContent.UseVisualStyleBackColor = true;
            btnContent.Click += btnContent_Click;
            // 
            // btnCatalog
            // 
            btnCatalog.Dock = DockStyle.Top;
            btnCatalog.FlatAppearance.BorderSize = 0;
            btnCatalog.FlatStyle = FlatStyle.Flat;
            btnCatalog.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCatalog.ForeColor = Color.FromArgb(100, 23, 61);
            btnCatalog.Location = new Point(0, 148);
            btnCatalog.Margin = new Padding(2);
            btnCatalog.Name = "btnCatalog";
            btnCatalog.Size = new Size(246, 44);
            btnCatalog.TabIndex = 1;
            btnCatalog.Text = "Catalog";
            btnCatalog.UseVisualStyleBackColor = true;
            btnCatalog.Click += btnCatalog_Click;
            // 
            // btnDonateAct
            // 
            btnDonateAct.Dock = DockStyle.Top;
            btnDonateAct.FlatAppearance.BorderSize = 0;
            btnDonateAct.FlatStyle = FlatStyle.Flat;
            btnDonateAct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDonateAct.ForeColor = Color.FromArgb(100, 23, 61);
            btnDonateAct.Location = new Point(0, 104);
            btnDonateAct.Margin = new Padding(2);
            btnDonateAct.Name = "btnDonateAct";
            btnDonateAct.Size = new Size(246, 44);
            btnDonateAct.TabIndex = 1;
            btnDonateAct.Text = "Donate Activity";
            btnDonateAct.UseVisualStyleBackColor = true;
            btnDonateAct.Click += btnDonateAct_Click;
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
            llProfile.Text = "Admin";
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
            // lblDonateActivity
            // 
            lblDonateActivity.AutoSize = true;
            lblDonateActivity.BackColor = Color.Transparent;
            lblDonateActivity.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonateActivity.ForeColor = Color.FromArgb(100, 23, 61);
            lblDonateActivity.Location = new Point(281, 46);
            lblDonateActivity.Margin = new Padding(2, 0, 2, 0);
            lblDonateActivity.Name = "lblDonateActivity";
            lblDonateActivity.Size = new Size(348, 60);
            lblDonateActivity.TabIndex = 23;
            lblDonateActivity.Text = "Donate Activity";
            // 
            // btnLoadDonate
            // 
            btnLoadDonate.BackColor = Color.FromArgb(178, 113, 178);
            btnLoadDonate.FlatStyle = FlatStyle.Popup;
            btnLoadDonate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadDonate.ForeColor = Color.FromArgb(100, 23, 61);
            btnLoadDonate.Location = new Point(1213, 658);
            btnLoadDonate.Margin = new Padding(2);
            btnLoadDonate.Name = "btnLoadDonate";
            btnLoadDonate.Size = new Size(97, 36);
            btnLoadDonate.TabIndex = 25;
            btnLoadDonate.Text = "Load";
            btnLoadDonate.UseVisualStyleBackColor = false;
            btnLoadDonate.Click += btnLoadDonate_Click;
            // 
            // tbFixedPrice
            // 
            tbFixedPrice.Location = new Point(480, 216);
            tbFixedPrice.Margin = new Padding(2);
            tbFixedPrice.Name = "tbFixedPrice";
            tbFixedPrice.Size = new Size(449, 27);
            tbFixedPrice.TabIndex = 75;
            // 
            // tbStatus
            // 
            tbStatus.Location = new Point(480, 177);
            tbStatus.Margin = new Padding(2);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(449, 27);
            tbStatus.TabIndex = 74;
            // 
            // tbDonateId
            // 
            tbDonateId.Location = new Point(480, 138);
            tbDonateId.Margin = new Padding(2);
            tbDonateId.Name = "tbDonateId";
            tbDonateId.Size = new Size(449, 27);
            tbDonateId.TabIndex = 73;
            // 
            // lblFixedPrice
            // 
            lblFixedPrice.AutoSize = true;
            lblFixedPrice.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblFixedPrice.ForeColor = Color.FromArgb(100, 23, 61);
            lblFixedPrice.Location = new Point(323, 216);
            lblFixedPrice.Margin = new Padding(2, 0, 2, 0);
            lblFixedPrice.Name = "lblFixedPrice";
            lblFixedPrice.Size = new Size(137, 23);
            lblFixedPrice.TabIndex = 72;
            lblFixedPrice.Text = "Fixed Price        :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(100, 23, 61);
            lblStatus.Location = new Point(323, 177);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(136, 23);
            lblStatus.TabIndex = 71;
            lblStatus.Text = "Status               :";
            // 
            // lbIdDonate
            // 
            lbIdDonate.AutoSize = true;
            lbIdDonate.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbIdDonate.ForeColor = Color.FromArgb(100, 23, 61);
            lbIdDonate.Location = new Point(323, 142);
            lbIdDonate.Margin = new Padding(2, 0, 2, 0);
            lbIdDonate.Name = "lbIdDonate";
            lbIdDonate.Size = new Size(135, 23);
            lbIdDonate.TabIndex = 70;
            lbIdDonate.Text = "Donate Id         :";
            // 
            // dgvDonateActivity
            // 
            dgvDonateActivity.BackgroundColor = Color.Thistle;
            dgvDonateActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonateActivity.Location = new Point(292, 273);
            dgvDonateActivity.Margin = new Padding(2);
            dgvDonateActivity.Name = "dgvDonateActivity";
            dgvDonateActivity.RowHeadersWidth = 82;
            dgvDonateActivity.RowTemplate.Height = 41;
            dgvDonateActivity.Size = new Size(1018, 358);
            dgvDonateActivity.TabIndex = 69;
            dgvDonateActivity.CellContentClick += dgvDonateActivity_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(178, 113, 178);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(100, 23, 61);
            btnDelete.Location = new Point(1127, 137);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 112);
            btnDelete.TabIndex = 77;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(178, 113, 178);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(100, 23, 61);
            btnUpdate.Location = new Point(974, 137);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 112);
            btnUpdate.TabIndex = 76;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ActivityAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1348, 721);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(tbFixedPrice);
            Controls.Add(tbStatus);
            Controls.Add(tbDonateId);
            Controls.Add(lblFixedPrice);
            Controls.Add(lblStatus);
            Controls.Add(lbIdDonate);
            Controls.Add(dgvDonateActivity);
            Controls.Add(btnLoadDonate);
            Controls.Add(lblDonateActivity);
            Controls.Add(panel1);
            Name = "ActivityAdmin";
            Text = "ActivityAdmin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonateActivity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogOut;
        private Button btnContent;
        private Button btnCatalog;
        private Button btnDonateAct;
        private Panel panel2;
        private LinkLabel llProfile;
        private PictureBox picProfile;
        private Label lblDonateActivity;
        private Button btnLoadDonate;
        private TextBox tbFixedPrice;
        private TextBox tbStatus;
        private TextBox tbDonateId;
        private Label lblFixedPrice;
        private Label lblStatus;
        private Label lbIdDonate;
        private DataGridView dgvDonateActivity;
        private Button btnDelete;
        private Button btnUpdate;
    }
}