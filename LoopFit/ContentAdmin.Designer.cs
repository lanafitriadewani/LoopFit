namespace LoopFit
{
    partial class ContentAdmin
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
            lblContent = new Label();
            lblVideoLink = new Label();
            tbVideoLink = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvContentAdmin = new DataGridView();
            btnLoadContent = new Button();
            lbId = new Label();
            lblTitle = new Label();
            tbTitle = new TextBox();
            tbId = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContentAdmin).BeginInit();
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
            panel1.TabIndex = 24;
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
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile.TabIndex = 1;
            picProfile.TabStop = false;
            picProfile.Click += picProfile_Click;
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.BackColor = Color.Transparent;
            lblContent.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblContent.ForeColor = Color.FromArgb(100, 23, 61);
            lblContent.Location = new Point(291, 46);
            lblContent.Margin = new Padding(2, 0, 2, 0);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(191, 60);
            lblContent.TabIndex = 25;
            lblContent.Text = "Content";
            // 
            // lblVideoLink
            // 
            lblVideoLink.AutoSize = true;
            lblVideoLink.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblVideoLink.ForeColor = Color.FromArgb(100, 23, 61);
            lblVideoLink.Location = new Point(304, 203);
            lblVideoLink.Margin = new Padding(2, 0, 2, 0);
            lblVideoLink.Name = "lblVideoLink";
            lblVideoLink.Size = new Size(99, 23);
            lblVideoLink.TabIndex = 49;
            lblVideoLink.Text = "Video Link :";
            // 
            // tbVideoLink
            // 
            tbVideoLink.Location = new Point(421, 199);
            tbVideoLink.Margin = new Padding(2);
            tbVideoLink.Name = "tbVideoLink";
            tbVideoLink.Size = new Size(402, 27);
            tbVideoLink.TabIndex = 51;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(178, 113, 178);
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.FromArgb(100, 23, 61);
            btnInsert.Location = new Point(869, 118);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(120, 112);
            btnInsert.TabIndex = 52;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(178, 113, 178);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(100, 23, 61);
            btnUpdate.Location = new Point(1024, 118);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 112);
            btnUpdate.TabIndex = 53;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(178, 113, 178);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(100, 23, 61);
            btnDelete.Location = new Point(1176, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 112);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvContentAdmin
            // 
            dgvContentAdmin.BackgroundColor = Color.Thistle;
            dgvContentAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContentAdmin.Location = new Point(304, 261);
            dgvContentAdmin.Margin = new Padding(2);
            dgvContentAdmin.Name = "dgvContentAdmin";
            dgvContentAdmin.RowHeadersWidth = 82;
            dgvContentAdmin.RowTemplate.Height = 41;
            dgvContentAdmin.Size = new Size(992, 382);
            dgvContentAdmin.TabIndex = 55;
            dgvContentAdmin.CellContentClick += dgvContentAdmin_CellContentClick;
            // 
            // btnLoadContent
            // 
            btnLoadContent.BackColor = Color.FromArgb(178, 113, 178);
            btnLoadContent.FlatStyle = FlatStyle.Popup;
            btnLoadContent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadContent.ForeColor = Color.FromArgb(100, 23, 61);
            btnLoadContent.Location = new Point(1193, 659);
            btnLoadContent.Margin = new Padding(2);
            btnLoadContent.Name = "btnLoadContent";
            btnLoadContent.Size = new Size(103, 37);
            btnLoadContent.TabIndex = 56;
            btnLoadContent.Text = "Load";
            btnLoadContent.UseVisualStyleBackColor = false;
            btnLoadContent.Click += btnLoadContent_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbId.ForeColor = Color.FromArgb(100, 23, 61);
            lbId.Location = new Point(304, 125);
            lbId.Margin = new Padding(2, 0, 2, 0);
            lbId.Name = "lbId";
            lbId.Size = new Size(99, 23);
            lbId.TabIndex = 62;
            lbId.Text = "Id              :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(100, 23, 61);
            lblTitle.Location = new Point(304, 162);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(101, 23);
            lblTitle.TabIndex = 63;
            lblTitle.Text = "Title           :";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(421, 158);
            tbTitle.Margin = new Padding(2);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(402, 27);
            tbTitle.TabIndex = 64;
            // 
            // tbId
            // 
            tbId.Location = new Point(421, 114);
            tbId.Margin = new Padding(2);
            tbId.Name = "tbId";
            tbId.Size = new Size(402, 27);
            tbId.TabIndex = 65;
            // 
            // ContentAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1348, 721);
            Controls.Add(tbId);
            Controls.Add(tbTitle);
            Controls.Add(lblTitle);
            Controls.Add(lbId);
            Controls.Add(btnLoadContent);
            Controls.Add(dgvContentAdmin);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(tbVideoLink);
            Controls.Add(lblVideoLink);
            Controls.Add(lblContent);
            Controls.Add(panel1);
            Name = "ContentAdmin";
            Text = "ContentAdmin";
            Load += ContentAdmin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContentAdmin).EndInit();
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
        private Label lblContent;
        private Label lblVideoLink;
        private TextBox tbVideoLink;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvContentAdmin;
        private Button btnLoadContent;
        private Label lbId;
        private Label lblTitle;
        private TextBox tbTitle;
        private TextBox tbId;
    }
}