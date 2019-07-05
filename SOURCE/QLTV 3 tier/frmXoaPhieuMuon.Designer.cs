namespace QLTV
{
    partial class frmXoaPhieuMuon
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
            this.dgvPhieuMuon = new MetroFramework.Controls.MetroGrid();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btXoaToanBo = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbMaThe = new System.Windows.Forms.Label();
            this.lbSoPhieu = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTim = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLuaChonTim = new System.Windows.Forms.ComboBox();
            this.txtThongTinTimKiem = new System.Windows.Forms.TextBox();
            this.tltTenSach = new MetroFramework.Components.MetroToolTip();
            this.tltTenChuThe = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToResizeColumns = false;
            this.dgvPhieuMuon.AllowUserToResizeRows = false;
            this.dgvPhieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPhieuMuon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPhieuMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuMuon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuMuon.EnableHeadersVisualStyles = false;
            this.dgvPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPhieuMuon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPhieuMuon.Location = new System.Drawing.Point(19, 341);
            this.dgvPhieuMuon.MultiSelect = false;
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.ReadOnly = true;
            this.dgvPhieuMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuMuon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhieuMuon.RowHeadersVisible = false;
            this.dgvPhieuMuon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPhieuMuon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(757, 211);
            this.dgvPhieuMuon.TabIndex = 24;
            this.dgvPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellContentClick);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btXoaToanBo);
            this.gbInfo.Controls.Add(this.btnXoa);
            this.gbInfo.Controls.Add(this.btnCancel);
            this.gbInfo.Controls.Add(this.lbMaSach);
            this.gbInfo.Controls.Add(this.lbMaThe);
            this.gbInfo.Controls.Add(this.lbSoPhieu);
            this.gbInfo.Controls.Add(this.cboTinhTrang);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.rtbGhiChu);
            this.gbInfo.Controls.Add(this.dtpNgayTra);
            this.gbInfo.Controls.Add(this.dtpNgayMuon);
            this.gbInfo.Controls.Add(this.label10);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.lb);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Location = new System.Drawing.Point(10, 119);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(772, 215);
            this.gbInfo.TabIndex = 20;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin phiếu mượn:";
            // 
            // btXoaToanBo
            // 
            this.btXoaToanBo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btXoaToanBo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btXoaToanBo.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btXoaToanBo.Highlight = true;
            this.btXoaToanBo.Location = new System.Drawing.Point(657, 174);
            this.btXoaToanBo.Name = "btXoaToanBo";
            this.btXoaToanBo.Size = new System.Drawing.Size(100, 35);
            this.btXoaToanBo.Style = MetroFramework.MetroColorStyle.Silver;
            this.btXoaToanBo.TabIndex = 25;
            this.btXoaToanBo.Text = "Xóa toàn bộ";
            this.btXoaToanBo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btXoaToanBo.UseSelectable = true;
            this.btXoaToanBo.Click += new System.EventHandler(this.btXoaToanBo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnXoa.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnXoa.Highlight = true;
            this.btnXoa.Location = new System.Drawing.Point(494, 174);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnXoa.UseSelectable = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Location = new System.Drawing.Point(133, 76);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(13, 17);
            this.lbMaSach.TabIndex = 24;
            this.lbMaSach.Text = "-";
            // 
            // lbMaThe
            // 
            this.lbMaThe.AutoSize = true;
            this.lbMaThe.Location = new System.Drawing.Point(133, 51);
            this.lbMaThe.Name = "lbMaThe";
            this.lbMaThe.Size = new System.Drawing.Size(13, 17);
            this.lbMaThe.TabIndex = 23;
            this.lbMaThe.Text = "-";
            // 
            // lbSoPhieu
            // 
            this.lbSoPhieu.AutoSize = true;
            this.lbSoPhieu.Location = new System.Drawing.Point(133, 24);
            this.lbSoPhieu.Name = "lbSoPhieu";
            this.lbSoPhieu.Size = new System.Drawing.Size(13, 17);
            this.lbSoPhieu.TabIndex = 22;
            this.lbSoPhieu.Text = "-";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Chờ phê duyệt",
            "Chưa trả",
            "Chờ duyệt trả",
            "Đã trả",
            "Trễ hạn",
            "Chờ duyệt trả trễ",
            "Trả trễ"});
            this.cboTinhTrang.Location = new System.Drawing.Point(523, 24);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(234, 25);
            this.cboTinhTrang.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tình trạng:";
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(523, 51);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(234, 73);
            this.rtbGhiChu.TabIndex = 19;
            this.rtbGhiChu.Text = "";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Location = new System.Drawing.Point(130, 125);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(234, 25);
            this.dtpNgayTra.TabIndex = 18;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Location = new System.Drawing.Point(130, 99);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(234, 25);
            this.dtpNgayMuon.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày mượn:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(74, 51);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(50, 17);
            this.lb.TabIndex = 2;
            this.lb.Text = "Mã thẻ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số phiếu:";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnTim.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnTim.Highlight = true;
            this.btnTim.Location = new System.Drawing.Point(670, 92);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(113, 26);
            this.btnTim.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnTim.TabIndex = 27;
            this.btnTim.Text = "Lọc";
            this.btnTim.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnTim.UseSelectable = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lọc phiếu mượn theo:";
            // 
            // cboLuaChonTim
            // 
            this.cboLuaChonTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLuaChonTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLuaChonTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cboLuaChonTim.FormattingEnabled = true;
            this.cboLuaChonTim.Items.AddRange(new object[] {
            "Số phiếu",
            "Mã thẻ",
            "Tên chủ thẻ",
            "Mã sách",
            "Tên sách"});
            this.cboLuaChonTim.Location = new System.Drawing.Point(187, 93);
            this.cboLuaChonTim.Name = "cboLuaChonTim";
            this.cboLuaChonTim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboLuaChonTim.Size = new System.Drawing.Size(101, 25);
            this.cboLuaChonTim.TabIndex = 25;
            this.cboLuaChonTim.SelectedIndexChanged += new System.EventHandler(this.cboLuaChonTim_SelectedIndexChanged);
            // 
            // txtThongTinTimKiem
            // 
            this.txtThongTinTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThongTinTimKiem.Location = new System.Drawing.Point(294, 93);
            this.txtThongTinTimKiem.Name = "txtThongTinTimKiem";
            this.txtThongTinTimKiem.Size = new System.Drawing.Size(356, 25);
            this.txtThongTinTimKiem.TabIndex = 26;
            this.txtThongTinTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThongTinTimKiem_KeyPress);
            // 
            // tltTenSach
            // 
            this.tltTenSach.AutoPopDelay = 32000;
            this.tltTenSach.InitialDelay = 10;
            this.tltTenSach.ReshowDelay = 10;
            this.tltTenSach.Style = MetroFramework.MetroColorStyle.Blue;
            this.tltTenSach.StyleManager = null;
            this.tltTenSach.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tltTenChuThe
            // 
            this.tltTenChuThe.AutoPopDelay = 32000;
            this.tltTenChuThe.InitialDelay = 10;
            this.tltTenChuThe.ReshowDelay = 10;
            this.tltTenChuThe.Style = MetroFramework.MetroColorStyle.Blue;
            this.tltTenChuThe.StyleManager = null;
            this.tltTenChuThe.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmXoaPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 581);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLuaChonTim);
            this.Controls.Add(this.txtThongTinTimKiem);
            this.Controls.Add(this.dgvPhieuMuon);
            this.Controls.Add(this.gbInfo);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmXoaPhieuMuon";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Xóa phiếu mượn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXoaPhieuMuon_FormClosing);
            this.Load += new System.EventHandler(this.frmXoaPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvPhieuMuon;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbMaThe;
        private System.Windows.Forms.Label lbSoPhieu;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btXoaToanBo;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLuaChonTim;
        private System.Windows.Forms.TextBox txtThongTinTimKiem;
        private MetroFramework.Components.MetroToolTip tltTenSach;
        private MetroFramework.Components.MetroToolTip tltTenChuThe;
    }
}