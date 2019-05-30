namespace QLTV
{
    partial class frmCapNhatDocGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnSua = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTaoThe = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOkSua = new System.Windows.Forms.Button();
            this.btnOkThem = new System.Windows.Forms.Button();
            this.cboLoaiDG = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtSoCMT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDocGia = new MetroFramework.Controls.MetroGrid();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnThem.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnThem.Highlight = true;
            this.btnThem.Location = new System.Drawing.Point(339, 193);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm ";
            this.btnThem.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSua.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnSua.Highlight = true;
            this.btnSua.Location = new System.Drawing.Point(463, 193);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSua.UseSelectable = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnXoa.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnXoa.Highlight = true;
            this.btnXoa.Location = new System.Drawing.Point(584, 193);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnXoa.UseSelectable = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbInfo.Controls.Add(this.cbHienMK);
            this.gbInfo.Controls.Add(this.txtMK);
            this.gbInfo.Controls.Add(this.btnXoa);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.btnSua);
            this.gbInfo.Controls.Add(this.cbTaoThe);
            this.gbInfo.Controls.Add(this.btnThem);
            this.gbInfo.Controls.Add(this.btnCancel);
            this.gbInfo.Controls.Add(this.btnOkSua);
            this.gbInfo.Controls.Add(this.btnOkThem);
            this.gbInfo.Controls.Add(this.cboLoaiDG);
            this.gbInfo.Controls.Add(this.dtpNgaySinh);
            this.gbInfo.Controls.Add(this.cboGioiTinh);
            this.gbInfo.Controls.Add(this.txtSoCMT);
            this.gbInfo.Controls.Add(this.txtDiaChi);
            this.gbInfo.Controls.Add(this.txtTenDG);
            this.gbInfo.Controls.Add(this.txtMaDG);
            this.gbInfo.Controls.Add(this.label10);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Location = new System.Drawing.Point(40, 81);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(693, 242);
            this.gbInfo.TabIndex = 9;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Nhập đầy đủ các thông tin:";
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Location = new System.Drawing.Point(463, 154);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(108, 21);
            this.cbHienMK.TabIndex = 25;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(463, 121);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(221, 25);
            this.txtMK.TabIndex = 24;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mật khẩu đăng nhập:";
            // 
            // cbTaoThe
            // 
            this.cbTaoThe.AutoSize = true;
            this.cbTaoThe.Location = new System.Drawing.Point(85, 154);
            this.cbTaoThe.Name = "cbTaoThe";
            this.cbTaoThe.Size = new System.Drawing.Size(158, 21);
            this.cbTaoThe.TabIndex = 10;
            this.cbTaoThe.Text = "Tạo thẻ mượn sách mới";
            this.cbTaoThe.UseVisualStyleBackColor = true;
            this.cbTaoThe.CheckedChanged += new System.EventHandler(this.cbTaoThe_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOkSua
            // 
            this.btnOkSua.Location = new System.Drawing.Point(85, 193);
            this.btnOkSua.Name = "btnOkSua";
            this.btnOkSua.Size = new System.Drawing.Size(80, 28);
            this.btnOkSua.TabIndex = 21;
            this.btnOkSua.Text = "Đồng ý";
            this.btnOkSua.UseVisualStyleBackColor = true;
            this.btnOkSua.Click += new System.EventHandler(this.btnOkSua_Click);
            // 
            // btnOkThem
            // 
            this.btnOkThem.Location = new System.Drawing.Point(85, 193);
            this.btnOkThem.Name = "btnOkThem";
            this.btnOkThem.Size = new System.Drawing.Size(80, 28);
            this.btnOkThem.TabIndex = 20;
            this.btnOkThem.Text = "Đồng ý";
            this.btnOkThem.UseVisualStyleBackColor = true;
            this.btnOkThem.Click += new System.EventHandler(this.btnOkThem_Click);
            // 
            // cboLoaiDG
            // 
            this.cboLoaiDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiDG.FormattingEnabled = true;
            this.cboLoaiDG.Location = new System.Drawing.Point(463, 88);
            this.cboLoaiDG.Name = "cboLoaiDG";
            this.cboLoaiDG.Size = new System.Drawing.Size(221, 25);
            this.cboLoaiDG.TabIndex = 19;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(85, 121);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(221, 25);
            this.dtpNgaySinh.TabIndex = 18;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(85, 88);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(221, 25);
            this.cboGioiTinh.TabIndex = 17;
            // 
            // txtSoCMT
            // 
            this.txtSoCMT.Location = new System.Drawing.Point(463, 55);
            this.txtSoCMT.Name = "txtSoCMT";
            this.txtSoCMT.Size = new System.Drawing.Size(221, 25);
            this.txtSoCMT.TabIndex = 15;
            this.txtSoCMT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoCMT_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(463, 22);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(221, 25);
            this.txtDiaChi.TabIndex = 14;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(85, 55);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(221, 25);
            this.txtTenDG.TabIndex = 11;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(85, 22);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(221, 25);
            this.txtMaDG.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Loại độc giả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số CMT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên độc giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã độc giả:";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            this.dgvDocGia.AllowUserToResizeColumns = false;
            this.dgvDocGia.AllowUserToResizeRows = false;
            this.dgvDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocGia.EnableHeadersVisualStyles = false;
            this.dgvDocGia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDocGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDocGia.Location = new System.Drawing.Point(40, 329);
            this.dgvDocGia.MultiSelect = false;
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocGia.RowHeadersVisible = false;
            this.dgvDocGia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGreen;
            this.dgvDocGia.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDocGia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.Size = new System.Drawing.Size(693, 169);
            this.dgvDocGia.TabIndex = 10;
            this.dgvDocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellContentClick);
            // 
            // frmCapNhatDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 529);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.gbInfo);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCapNhatDocGia";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Cập nhật độc giả";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCapNhatDocGia_FormClosing);
            this.Load += new System.EventHandler(this.frmCapNhatDocGia_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btnSua;
        private MetroFramework.Controls.MetroButton btnXoa;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.CheckBox cbHienMK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbTaoThe;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkSua;
        private System.Windows.Forms.Button btnOkThem;
        private System.Windows.Forms.ComboBox cboLoaiDG;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtSoCMT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid dgvDocGia;


    }
}