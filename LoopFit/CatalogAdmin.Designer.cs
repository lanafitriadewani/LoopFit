namespace LoopFit
{
    partial class CatalogAdmin
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
            lblCatalog = new Label();
            picProduct = new PictureBox();
            dgvCatalogAdmin = new DataGridView();
            lblProductName = new Label();
            lblProductPrice = new Label();
            tbProductName = new TextBox();
            tbProductPrice = new TextBox();
            btnUpdateCatalog = new Button();
            btnLoadCatalog = new Button();
            btnUpload = new Button();
            lbId = new Label();
            tbCatalogId = new TextBox();
            btnInsert = new Button();
            tbLink = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogAdmin).BeginInit();
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
            panel1.TabIndex = 23;
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
            // lblCatalog
            // 
            lblCatalog.AutoSize = true;
            lblCatalog.BackColor = Color.Transparent;
            lblCatalog.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatalog.ForeColor = Color.FromArgb(100, 23, 61);
            lblCatalog.Location = new Point(291, 46);
            lblCatalog.Margin = new Padding(2, 0, 2, 0);
            lblCatalog.Name = "lblCatalog";
            lblCatalog.Size = new Size(184, 60);
            lblCatalog.TabIndex = 24;
            lblCatalog.Text = "Catalog";
            // 
            // picProduct
            // 
            picProduct.Location = new Point(318, 146);
            picProduct.Margin = new Padding(2);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(183, 173);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 41;
            picProduct.TabStop = false;
            // 
            // dgvCatalogAdmin
            // 
            dgvCatalogAdmin.BackgroundColor = Color.Thistle;
            dgvCatalogAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalogAdmin.Location = new Point(292, 358);
            dgvCatalogAdmin.Margin = new Padding(2);
            dgvCatalogAdmin.Name = "dgvCatalogAdmin";
            dgvCatalogAdmin.RowHeadersWidth = 82;
            dgvCatalogAdmin.RowTemplate.Height = 41;
            dgvCatalogAdmin.Size = new Size(1009, 288);
            dgvCatalogAdmin.TabIndex = 47;
            dgvCatalogAdmin.CellContentClick += dgvCatalogAdmin_CellContentClick;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.ForeColor = Color.FromArgb(100, 23, 61);
            lblProductName.Location = new Point(542, 200);
            lblProductName.Margin = new Padding(2, 0, 2, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(130, 23);
            lblProductName.TabIndex = 48;
            lblProductName.Text = "Product Name :";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductPrice.ForeColor = Color.FromArgb(100, 23, 61);
            lblProductPrice.Location = new Point(542, 245);
            lblProductPrice.Margin = new Padding(2, 0, 2, 0);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(56, 23);
            lblProductPrice.TabIndex = 49;
            lblProductPrice.Text = "Price :";
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(674, 200);
            tbProductName.Margin = new Padding(2);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(268, 27);
            tbProductName.TabIndex = 50;
            // 
            // tbProductPrice
            // 
            tbProductPrice.Location = new Point(674, 245);
            tbProductPrice.Margin = new Padding(2);
            tbProductPrice.Name = "tbProductPrice";
            tbProductPrice.Size = new Size(268, 27);
            tbProductPrice.TabIndex = 51;
            // 
            // btnUpdateCatalog
            // 
            btnUpdateCatalog.BackColor = Color.FromArgb(178, 113, 178);
            btnUpdateCatalog.FlatStyle = FlatStyle.Popup;
            btnUpdateCatalog.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCatalog.ForeColor = Color.FromArgb(100, 23, 61);
            btnUpdateCatalog.Location = new Point(1129, 151);
            btnUpdateCatalog.Margin = new Padding(2);
            btnUpdateCatalog.Name = "btnUpdateCatalog";
            btnUpdateCatalog.Size = new Size(145, 157);
            btnUpdateCatalog.TabIndex = 52;
            btnUpdateCatalog.Text = "Update";
            btnUpdateCatalog.UseVisualStyleBackColor = false;
            btnUpdateCatalog.Click += btnUpdateCatalog_Click;
            // 
            // btnLoadCatalog
            // 
            btnLoadCatalog.BackColor = Color.FromArgb(178, 113, 178);
            btnLoadCatalog.FlatStyle = FlatStyle.Popup;
            btnLoadCatalog.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadCatalog.ForeColor = Color.FromArgb(100, 23, 61);
            btnLoadCatalog.Location = new Point(1198, 666);
            btnLoadCatalog.Margin = new Padding(2);
            btnLoadCatalog.Name = "btnLoadCatalog";
            btnLoadCatalog.Size = new Size(103, 37);
            btnLoadCatalog.TabIndex = 53;
            btnLoadCatalog.Text = "Load";
            btnLoadCatalog.UseVisualStyleBackColor = false;
            btnLoadCatalog.Click += btnLoadCatalog_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(178, 113, 178);
            btnUpload.FlatStyle = FlatStyle.Popup;
            btnUpload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpload.ForeColor = Color.FromArgb(100, 23, 61);
            btnUpload.Location = new Point(432, 147);
            btnUpload.Margin = new Padding(2);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(69, 35);
            btnUpload.TabIndex = 54;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbId.ForeColor = Color.FromArgb(100, 23, 61);
            lbId.Location = new Point(542, 158);
            lbId.Margin = new Padding(2, 0, 2, 0);
            lbId.Name = "lbId";
            lbId.Size = new Size(98, 23);
            lbId.TabIndex = 55;
            lbId.Text = "Catalog Id :";
            // 
            // tbCatalogId
            // 
            tbCatalogId.Location = new Point(674, 152);
            tbCatalogId.Margin = new Padding(2);
            tbCatalogId.Name = "tbCatalogId";
            tbCatalogId.Size = new Size(268, 27);
            tbCatalogId.TabIndex = 56;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(178, 113, 178);
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.FromArgb(100, 23, 61);
            btnInsert.Location = new Point(968, 151);
            btnInsert.Margin = new Padding(2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(145, 157);
            btnInsert.TabIndex = 57;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // tbLink
            // 
            tbLink.Location = new Point(674, 289);
            tbLink.Margin = new Padding(2);
            tbLink.Name = "tbLink";
            tbLink.Size = new Size(268, 27);
            tbLink.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(100, 23, 61);
            label1.Location = new Point(542, 289);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 58;
            label1.Text = "Link Product:";
            // 
            // CatalogAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1348, 721);
            Controls.Add(tbLink);
            Controls.Add(label1);
            Controls.Add(btnInsert);
            Controls.Add(tbCatalogId);
            Controls.Add(lbId);
            Controls.Add(btnUpload);
            Controls.Add(btnLoadCatalog);
            Controls.Add(btnUpdateCatalog);
            Controls.Add(tbProductPrice);
            Controls.Add(tbProductName);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductName);
            Controls.Add(dgvCatalogAdmin);
            Controls.Add(picProduct);
            Controls.Add(lblCatalog);
            Controls.Add(panel1);
            Name = "CatalogAdmin";
            Text = "CatalogAdmin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogAdmin).EndInit();
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
        private Label lblCatalog;
        private PictureBox picProduct;
        private DataGridView dgvCatalogAdmin;
        private Label lblProductName;
        private Label lblProductPrice;
        private TextBox tbProductName;
        private TextBox tbProductPrice;
        private Button btnUpdateCatalog;
        private Button btnLoadCatalog;
        private Button btnUpload;
        private Label lbId;
        private TextBox tbCatalogId;
        private Button btnInsert;
        private TextBox tbLink;
        private Label label1;
    }
}