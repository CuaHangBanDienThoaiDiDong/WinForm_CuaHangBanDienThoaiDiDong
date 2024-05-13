namespace WinForm_CuaHangBanDienThoai
{
    partial class frmCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tblCategories = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HinhDM = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.TenDM = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            this.cboFind = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategories)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tblCategories);
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Controls.Add(this.panel5);
            this.guna2Panel1.Controls.Add(this.btn_Find);
            this.guna2Panel1.Controls.Add(this.cboFind);
            this.guna2Panel1.Controls.Add(this.txtFind);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1940, 1100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // tblCategories
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tblCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblCategories.ColumnHeadersHeight = 35;
            this.tblCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblCategories.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblCategories.Location = new System.Drawing.Point(21, 133);
            this.tblCategories.Name = "tblCategories";
            this.tblCategories.RowHeadersVisible = false;
            this.tblCategories.Size = new System.Drawing.Size(1309, 615);
            this.tblCategories.TabIndex = 42;
            this.tblCategories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tblCategories.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tblCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblCategories.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tblCategories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblCategories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tblCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblCategories.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblCategories.ThemeStyle.HeaderStyle.Height = 35;
            this.tblCategories.ThemeStyle.ReadOnly = false;
            this.tblCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tblCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tblCategories.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblCategories.ThemeStyle.RowsStyle.Height = 22;
            this.tblCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblCategories.Click += new System.EventHandler(this.tblCategories_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.HinhDM);
            this.panel2.Controls.Add(this.guna2Button6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.TenDM);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(21, 754);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1919, 296);
            this.panel2.TabIndex = 41;
            // 
            // HinhDM
            // 
            this.HinhDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HinhDM.DefaultText = "";
            this.HinhDM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HinhDM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HinhDM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HinhDM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HinhDM.Enabled = false;
            this.HinhDM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HinhDM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HinhDM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HinhDM.Location = new System.Drawing.Point(888, 73);
            this.HinhDM.Name = "HinhDM";
            this.HinhDM.PasswordChar = '\0';
            this.HinhDM.PlaceholderText = "";
            this.HinhDM.SelectedText = "";
            this.HinhDM.Size = new System.Drawing.Size(609, 36);
            this.HinhDM.TabIndex = 34;
            // 
            // guna2Button6
            // 
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.Enabled = false;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(1516, 73);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(236, 36);
            this.guna2Button6.TabIndex = 33;
            this.guna2Button6.Text = "Thêm Hình Ảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(706, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Hình ảnh sản phẩm";
            // 
            // btnThoat
            // 
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1220, 225);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 45);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(476, 225);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 45);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "THÊM";
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.FillColor = System.Drawing.Color.Gold;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(848, 225);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 45);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "SỬA";
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.FillColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(662, 225);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 45);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "XÓA";
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.FillColor = System.Drawing.Color.Green;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1034, 225);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(180, 45);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "LƯU";
            // 
            // TenDM
            // 
            this.TenDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TenDM.DefaultText = "";
            this.TenDM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TenDM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TenDM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenDM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenDM.Enabled = false;
            this.TenDM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenDM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TenDM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenDM.Location = new System.Drawing.Point(298, 73);
            this.TenDM.Name = "TenDM";
            this.TenDM.PasswordChar = '\0';
            this.TenDM.PlaceholderText = "";
            this.TenDM.SelectedText = "";
            this.TenDM.Size = new System.Drawing.Size(372, 36);
            this.TenDM.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên danh mục sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(29, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục mới:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(1336, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(604, 615);
            this.panel5.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 499);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(18, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 47);
            this.label5.TabIndex = 37;
            this.label5.Text = "Hình ảnh danh mục";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Find
            // 
            this.btn_Find.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Find.Location = new System.Drawing.Point(832, 89);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(165, 36);
            this.btn_Find.TabIndex = 38;
            this.btn_Find.Text = "Tìm kiếm";
            this.btn_Find.UseVisualStyleBackColor = true;
            // 
            // cboFind
            // 
            this.cboFind.BackColor = System.Drawing.Color.Transparent;
            this.cboFind.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFind.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFind.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFind.ForeColor = System.Drawing.Color.Black;
            this.cboFind.ItemHeight = 30;
            this.cboFind.Items.AddRange(new object[] {
            "Mã Danh Mục",
            "Tên Danh Mục"});
            this.cboFind.Location = new System.Drawing.Point(542, 89);
            this.cboFind.Name = "cboFind";
            this.cboFind.Size = new System.Drawing.Size(284, 36);
            this.cboFind.TabIndex = 37;
            // 
            // txtFind
            // 
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultText = "";
            this.txtFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.Black;
            this.txtFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Location = new System.Drawing.Point(21, 89);
            this.txtFind.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderText = "";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(515, 36);
            this.txtFind.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Image = global::WinForm_CuaHangBanDienThoai.Properties.Resources.best_product;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(486, 54);
            this.label8.TabIndex = 17;
            this.label8.Text = "     QUẢN LÍ DANH MỤC ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategories)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox HinhDM;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2TextBox TenDM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Find;
        private Guna.UI2.WinForms.Guna2ComboBox cboFind;
        private Guna.UI2.WinForms.Guna2TextBox txtFind;
        private Guna.UI2.WinForms.Guna2DataGridView tblCategories;
    }
}