namespace QLTV
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMớiTKNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cậpNhậtTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtNXBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cậpNhậtĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThẻToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupboxLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.dgvSach = new MetroFramework.Controls.MetroGrid();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lbXinChao = new MetroFramework.Controls.MetroLabel();
            this.tmShowInfo = new System.Windows.Forms.Timer(this.components);
            this.timertieude = new System.Windows.Forms.Timer(this.components);
            this.lbtieude = new MetroFramework.Controls.MetroLabel();
            this.menuStripMain.SuspendLayout();
            this.groupboxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.LightGreen;
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýHệThốngToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(23, 78);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(0);
            this.menuStripMain.Size = new System.Drawing.Size(914, 32);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoMớiTKNVToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.tàiKhoảnToolStripMenuItem.Text = "&Hệ thống";
            // 
            // tạoMớiTKNVToolStripMenuItem
            // 
            this.tạoMớiTKNVToolStripMenuItem.Name = "tạoMớiTKNVToolStripMenuItem";
            this.tạoMớiTKNVToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.tạoMớiTKNVToolStripMenuItem.Text = "Tạo tài khoản";
            this.tạoMớiTKNVToolStripMenuItem.Click += new System.EventHandler(this.tạoMớiTKNVToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýHệThốngToolStripMenuItem
            // 
            this.quảnLýHệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtSáchToolStripMenuItem,
            this.toolStripSeparator1,
            this.cậpNhậtTácGiảToolStripMenuItem,
            this.cậpNhậtNXBToolStripMenuItem,
            this.cậpNhậtThểLoạiToolStripMenuItem,
            this.toolStripSeparator2,
            this.cậpNhậtĐộcGiảToolStripMenuItem,
            this.cậpNhậtThẻToolStripMenuItem});
            this.quảnLýHệThốngToolStripMenuItem.Name = "quảnLýHệThốngToolStripMenuItem";
            this.quảnLýHệThốngToolStripMenuItem.Size = new System.Drawing.Size(132, 32);
            this.quảnLýHệThốngToolStripMenuItem.Text = "&Quản lý sách";
            // 
            // cậpNhậtSáchToolStripMenuItem
            // 
            this.cậpNhậtSáchToolStripMenuItem.Name = "cậpNhậtSáchToolStripMenuItem";
            this.cậpNhậtSáchToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.cậpNhậtSáchToolStripMenuItem.Text = "Cập nhật sách";
            this.cậpNhậtSáchToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtSáchToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // cậpNhậtTácGiảToolStripMenuItem
            // 
            this.cậpNhậtTácGiảToolStripMenuItem.Name = "cậpNhậtTácGiảToolStripMenuItem";
            this.cậpNhậtTácGiảToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.cậpNhậtTácGiảToolStripMenuItem.Text = "Cập nhật tác giả";
            this.cậpNhậtTácGiảToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtTácGiảToolStripMenuItem_Click);
            // 
            // cậpNhậtNXBToolStripMenuItem
            // 
            this.cậpNhậtNXBToolStripMenuItem.Name = "cậpNhậtNXBToolStripMenuItem";
            this.cậpNhậtNXBToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.cậpNhậtNXBToolStripMenuItem.Text = "Cập nhật nxb";
            this.cậpNhậtNXBToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtNXBToolStripMenuItem_Click);
            // 
            // cậpNhậtThểLoạiToolStripMenuItem
            // 
            this.cậpNhậtThểLoạiToolStripMenuItem.Name = "cậpNhậtThểLoạiToolStripMenuItem";
            this.cậpNhậtThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.cậpNhậtThểLoạiToolStripMenuItem.Text = "Cập nhật thể loại";
            this.cậpNhậtThểLoạiToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThểLoạiToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // cậpNhậtĐộcGiảToolStripMenuItem
            // 
            this.cậpNhậtĐộcGiảToolStripMenuItem.Name = "cậpNhậtĐộcGiảToolStripMenuItem";
            this.cậpNhậtĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.cậpNhậtĐộcGiảToolStripMenuItem.Text = "Cập nhật độc giả";
            this.cậpNhậtĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtĐộcGiảToolStripMenuItem_Click);
            // 
            // cậpNhậtThẻToolStripMenuItem
            // 
            this.cậpNhậtThẻToolStripMenuItem.Name = "cậpNhậtThẻToolStripMenuItem";
            this.cậpNhậtThẻToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.cậpNhậtThẻToolStripMenuItem.Text = "Cập nhật thẻ";
            this.cậpNhậtThẻToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThẻToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(72, 32);
            this.thoátToolStripMenuItem.Text = "&Thoát";
            // 
            // groupboxLogin
            // 
            this.groupboxLogin.Controls.Add(this.btnLogin);
            this.groupboxLogin.Controls.Add(this.dgvSach);
            this.groupboxLogin.Controls.Add(this.txtPwd);
            this.groupboxLogin.Controls.Add(this.metroLabel2);
            this.groupboxLogin.Controls.Add(this.txtUser);
            this.groupboxLogin.Controls.Add(this.metroLabel3);
            this.groupboxLogin.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxLogin.Location = new System.Drawing.Point(370, 152);
            this.groupboxLogin.Name = "groupboxLogin";
            this.groupboxLogin.Size = new System.Drawing.Size(433, 154);
            this.groupboxLogin.TabIndex = 10;
            this.groupboxLogin.TabStop = false;
            this.groupboxLogin.Text = "Đăng nhập";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.CausesValidation = false;
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnLogin.Highlight = true;
            this.btnLogin.Location = new System.Drawing.Point(280, 104);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 32);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Green;
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToResizeColumns = false;
            this.dgvSach.AllowUserToResizeRows = false;
            this.dgvSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSach.EnableHeadersVisualStyles = false;
            this.dgvSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSach.Location = new System.Drawing.Point(-131, 195);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(716, 176);
            this.dgvSach.TabIndex = 6;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(163, 73);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(210, 29);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(139, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Tên đăng nhập: ";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(163, 43);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(210, 29);
            this.txtUser.TabIndex = 1;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Mật khẩu: ";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monthCalendar.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(23, 165);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // lbXinChao
            // 
            this.lbXinChao.AutoSize = true;
            this.lbXinChao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbXinChao.ForeColor = System.Drawing.Color.Green;
            this.lbXinChao.Location = new System.Drawing.Point(23, 135);
            this.lbXinChao.Name = "lbXinChao";
            this.lbXinChao.Size = new System.Drawing.Size(85, 25);
            this.lbXinChao.Style = MetroFramework.MetroColorStyle.Green;
            this.lbXinChao.TabIndex = 0;
            this.lbXinChao.Text = "Xin chào!";
            this.lbXinChao.UseCustomForeColor = true;
            // 
            // tmShowInfo
            // 
            this.tmShowInfo.Interval = 60000;
            this.tmShowInfo.Tick += new System.EventHandler(this.tmShowInfo_Tick);
            // 
            // timertieude
            // 
            this.timertieude.Tick += new System.EventHandler(this.timertieude_Tick);
            // 
            // lbtieude
            // 
            this.lbtieude.AutoSize = true;
            this.lbtieude.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbtieude.ForeColor = System.Drawing.Color.Green;
            this.lbtieude.Location = new System.Drawing.Point(246, 109);
            this.lbtieude.Name = "lbtieude";
            this.lbtieude.Size = new System.Drawing.Size(235, 25);
            this.lbtieude.Style = MetroFramework.MetroColorStyle.Green;
            this.lbtieude.TabIndex = 12;
            this.lbtieude.Text = "Phần mềm quản lý thư viện ";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.groupboxLogin);
            this.Controls.Add(this.lbtieude);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.lbXinChao);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "THỰC TẬP - QUẢN LÝ THƯ VIỆN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupboxLogin.ResumeLayout(false);
            this.groupboxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMớiTKNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtNXBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThẻToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupboxLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txtUser;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private MetroFramework.Controls.MetroLabel lbXinChao;
        private System.Windows.Forms.Timer tmShowInfo;
        private MetroFramework.Controls.MetroGrid dgvSach;
        private System.Windows.Forms.Timer timertieude;
        private MetroFramework.Controls.MetroLabel lbtieude;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnLogin;

    }
}

