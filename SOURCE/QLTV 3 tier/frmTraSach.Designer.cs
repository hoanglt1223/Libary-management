namespace QLTV
{
    partial class frmTraSach
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbMaThe = new System.Windows.Forms.Label();
            this.lbSoPhieu = new System.Windows.Forms.Label();
            this.btnTra = new MetroFramework.Controls.MetroButton();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboLuaChonTra = new System.Windows.Forms.ComboBox();
            this.tltTenChuThe = new MetroFramework.Components.MetroToolTip();
            this.tltTenSach = new MetroFramework.Components.MetroToolTip();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbInfo.Controls.Add(this.lbMaSach);
            this.gbInfo.Controls.Add(this.lbMaThe);
            this.gbInfo.Controls.Add(this.lbSoPhieu);
            this.gbInfo.Controls.Add(this.btnTra);
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
            this.gbInfo.Location = new System.Drawing.Point(33, 143);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(680, 226);
            this.gbInfo.TabIndex = 14;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin phiếu mượn:";
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Location = new System.Drawing.Point(115, 91);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(13, 17);
            this.lbMaSach.TabIndex = 23;
            this.lbMaSach.Text = "-";
            // 
            // lbMaThe
            // 
            this.lbMaThe.AutoSize = true;
            this.lbMaThe.Location = new System.Drawing.Point(115, 65);
            this.lbMaThe.Name = "lbMaThe";
            this.lbMaThe.Size = new System.Drawing.Size(13, 17);
            this.lbMaThe.TabIndex = 23;
            this.lbMaThe.Text = "-";
            // 
            // lbSoPhieu
            // 
            this.lbSoPhieu.AutoSize = true;
            this.lbSoPhieu.Location = new System.Drawing.Point(115, 39);
            this.lbSoPhieu.Name = "lbSoPhieu";
            this.lbSoPhieu.Size = new System.Drawing.Size(13, 17);
            this.lbSoPhieu.TabIndex = 23;
            this.lbSoPhieu.Text = "-";
            // 
            // btnTra
            // 
            this.btnTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTra.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnTra.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnTra.Highlight = true;
            this.btnTra.Location = new System.Drawing.Point(283, 185);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(114, 26);
            this.btnTra.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnTra.TabIndex = 22;
            this.btnTra.Text = "Trả sách";
            this.btnTra.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnTra.UseSelectable = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
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
            this.cboTinhTrang.Location = new System.Drawing.Point(427, 35);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(224, 25);
            this.cboTinhTrang.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tình trạng:";
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(427, 66);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(224, 98);
            this.rtbGhiChu.TabIndex = 19;
            this.rtbGhiChu.Text = "";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Location = new System.Drawing.Point(112, 139);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(224, 25);
            this.dtpNgayTra.TabIndex = 18;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Location = new System.Drawing.Point(112, 113);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(224, 25);
            this.dtpNgayMuon.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày mượn:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(54, 65);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(50, 17);
            this.lb.TabIndex = 2;
            this.lb.Text = "Mã thẻ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số phiếu:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(29, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chọn cuốn sách mang trả:";
            // 
            // cboLuaChonTra
            // 
            this.cboLuaChonTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLuaChonTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLuaChonTra.FormattingEnabled = true;
            this.cboLuaChonTra.Location = new System.Drawing.Point(223, 102);
            this.cboLuaChonTra.Name = "cboLuaChonTra";
            this.cboLuaChonTra.Size = new System.Drawing.Size(490, 25);
            this.cboLuaChonTra.TabIndex = 15;
            this.cboLuaChonTra.SelectedValueChanged += new System.EventHandler(this.cboLuaChonTra_SelectedValueChanged);
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
            // tltTenSach
            // 
            this.tltTenSach.AutoPopDelay = 32000;
            this.tltTenSach.InitialDelay = 10;
            this.tltTenSach.ReshowDelay = 10;
            this.tltTenSach.Style = MetroFramework.MetroColorStyle.Blue;
            this.tltTenSach.StyleManager = null;
            this.tltTenSach.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLuaChonTra);
            this.Controls.Add(this.gbInfo);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTraSach";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Trả sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTraSach_FormClosing);
            this.Load += new System.EventHandler(this.frmTraSach_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLuaChonTra;
        private MetroFramework.Controls.MetroButton btnTra;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbMaThe;
        private System.Windows.Forms.Label lbSoPhieu;
        private MetroFramework.Components.MetroToolTip tltTenChuThe;
        private MetroFramework.Components.MetroToolTip tltTenSach;
    }
}