namespace QLTV
{
    partial class frmDuyetPhieuMuonDangCho
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnOkSua = new System.Windows.Forms.Button();
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
            this.btnTuChoi = new MetroFramework.Controls.MetroButton();
            this.btnSua = new MetroFramework.Controls.MetroButton();
            this.btnDuyet = new MetroFramework.Controls.MetroButton();
            this.dgvPhieuMuon = new MetroFramework.Controls.MetroGrid();
            this.tltTenSach = new MetroFramework.Components.MetroToolTip();
            this.tltTenChuThe = new MetroFramework.Components.MetroToolTip();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnOkSua);
            this.gbInfo.Controls.Add(this.btnTuChoi);
            this.gbInfo.Controls.Add(this.btnCancel);
            this.gbInfo.Controls.Add(this.btnSua);
            this.gbInfo.Controls.Add(this.lbMaSach);
            this.gbInfo.Controls.Add(this.btnDuyet);
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
            this.gbInfo.Location = new System.Drawing.Point(34, 81);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(706, 226);
            this.gbInfo.TabIndex = 13;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin phiếu mượn:";
            // 
            // btnOkSua
            // 
            this.btnOkSua.Location = new System.Drawing.Point(253, 183);
            this.btnOkSua.Name = "btnOkSua";
            this.btnOkSua.Size = new System.Drawing.Size(80, 28);
            this.btnOkSua.TabIndex = 14;
            this.btnOkSua.Text = "Đồng ý";
            this.btnOkSua.UseVisualStyleBackColor = true;
            this.btnOkSua.Click += new System.EventHandler(this.btnOkSua_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(112, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Location = new System.Drawing.Point(115, 84);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(13, 17);
            this.lbMaSach.TabIndex = 24;
            this.lbMaSach.Text = "-";
            // 
            // lbMaThe
            // 
            this.lbMaThe.AutoSize = true;
            this.lbMaThe.Location = new System.Drawing.Point(115, 59);
            this.lbMaThe.Name = "lbMaThe";
            this.lbMaThe.Size = new System.Drawing.Size(13, 17);
            this.lbMaThe.TabIndex = 23;
            this.lbMaThe.Text = "-";
            // 
            // lbSoPhieu
            // 
            this.lbSoPhieu.AutoSize = true;
            this.lbSoPhieu.Location = new System.Drawing.Point(115, 32);
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
            this.cboTinhTrang.Location = new System.Drawing.Point(457, 28);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(221, 25);
            this.cboTinhTrang.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tình trạng:";
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(457, 55);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(221, 103);
            this.rtbGhiChu.TabIndex = 19;
            this.rtbGhiChu.Text = "";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Location = new System.Drawing.Point(112, 133);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(221, 25);
            this.dtpNgayTra.TabIndex = 18;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Location = new System.Drawing.Point(112, 107);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(221, 25);
            this.dtpNgayMuon.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày mượn:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(56, 59);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(50, 17);
            this.lb.TabIndex = 2;
            this.lb.Text = "Mã thẻ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số phiếu:";
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTuChoi.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnTuChoi.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnTuChoi.Highlight = true;
            this.btnTuChoi.Location = new System.Drawing.Point(578, 176);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(100, 35);
            this.btnTuChoi.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnTuChoi.TabIndex = 15;
            this.btnTuChoi.Text = "Từ chối";
            this.btnTuChoi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnTuChoi.UseSelectable = true;
            this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSua.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnSua.Highlight = true;
            this.btnSua.Location = new System.Drawing.Point(472, 176);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSua.UseSelectable = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDuyet
            // 
            this.btnDuyet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDuyet.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDuyet.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnDuyet.Highlight = true;
            this.btnDuyet.Location = new System.Drawing.Point(366, 176);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(100, 35);
            this.btnDuyet.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnDuyet.TabIndex = 17;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDuyet.UseSelectable = true;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvPhieuMuon.AllowUserToResizeColumns = false;
            this.dgvPhieuMuon.AllowUserToResizeRows = false;
            this.dgvPhieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvPhieuMuon.Location = new System.Drawing.Point(34, 323);
            this.dgvPhieuMuon.MultiSelect = false;
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.ReadOnly = true;
            this.dgvPhieuMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuMuon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhieuMuon.RowHeadersVisible = false;
            this.dgvPhieuMuon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPhieuMuon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(706, 168);
            this.dgvPhieuMuon.TabIndex = 19;
            this.dgvPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellContentClick);
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
            // frmDuyetPhieuMuonDangCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 520);
            this.Controls.Add(this.dgvPhieuMuon);
            this.Controls.Add(this.gbInfo);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDuyetPhieuMuonDangCho";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Duyệt phiếu mượn đang chờ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDuyetPhieuMuonDangCho_FormClosing);
            this.Load += new System.EventHandler(this.frmDuyetPhieuMuonDangCho_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnOkSua;
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
        private MetroFramework.Controls.MetroButton btnTuChoi;
        private MetroFramework.Controls.MetroButton btnSua;
        private MetroFramework.Controls.MetroButton btnDuyet;
        private MetroFramework.Controls.MetroGrid dgvPhieuMuon;
        private MetroFramework.Components.MetroToolTip tltTenSach;
        private MetroFramework.Components.MetroToolTip tltTenChuThe;

    }
}