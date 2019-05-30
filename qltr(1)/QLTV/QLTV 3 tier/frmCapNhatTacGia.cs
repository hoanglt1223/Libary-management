using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace QLTV
{
    public partial class frmCapNhatTacGia : MetroForm
    {
        private Form parentForm;
        public frmCapNhatTacGia(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmCapNhatTacGia_Load(object sender, EventArgs e)
        {
            txtMaTG.ReadOnly = true;
            txtTenTG.ReadOnly = true;
            rtbThongTinTG.ReadOnly = true;
            rtbThongTinTG.BackColor = SystemColors.Control;
            btnOkThem.Hide();
            btnCancel.Hide();
            btnOkSua.Hide();
            HienThiDuLieu();
            dgvTacGia.ReadOnly = true;
        }

        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvTacGia.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTacGia.Columns.Count; j++)
                {
                    if (dgvTacGia.Rows[i].Cells[j].Selected == true)
                    {
                        txtMaTG.Text = dgvTacGia.Rows[i].Cells[0].Value.ToString();
                        txtTenTG.Text = dgvTacGia.Rows[i].Cells[1].Value.ToString();
                        rtbThongTinTG.Text = dgvTacGia.Rows[i].Cells[2].Value.ToString();
                    }
                }
            }
        }
        private void HienThiDuLieu()
        {
            this.dgvTacGia.DataSource = null;
            this.dgvTacGia.DataSource = BUS_OBJ.loadDSTacGia();

            dgvTacGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvTacGia.Columns[0].HeaderText = "Mã tác giả";
            dgvTacGia.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
            dgvTacGia.Columns[1].HeaderText = "Tên tác giả";
            
            dgvTacGia.Columns[2].HeaderText = "Ghi chú";
            
            foreach (DataGridViewColumn col in dgvTacGia.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Thêm mới tác giả:";
            txtMaTG.ReadOnly = false;
            txtTenTG.ReadOnly = false;
            rtbThongTinTG.ReadOnly = false;
            rtbThongTinTG.BackColor = SystemColors.Window;
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            rtbThongTinTG.Text = "";
            btnOkThem.Show();
            btnCancel.Show();
            btnOkSua.Hide();
            txtMaTG.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "Thông tin tác giả:";
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            rtbThongTinTG.Text = "";
            txtMaTG.ReadOnly = true;
            txtTenTG.ReadOnly = true;
            rtbThongTinTG.ReadOnly = true;
            rtbThongTinTG.BackColor = SystemColors.Control;
            btnOkThem.Hide();
            btnOkSua.Hide();
            btnCancel.Hide();
            txtMaTG.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text != "")
            {
                gbInfo.Text = "Sửa thông tin tác giả:";
                txtMaTG.ReadOnly = true;
                txtTenTG.ReadOnly = false;
                rtbThongTinTG.ReadOnly = false;
                rtbThongTinTG.BackColor = SystemColors.Window;
                btnOkThem.Hide();
                btnOkSua.Show();
                btnCancel.Show();
                txtTenTG.Focus();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn tác giả muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel_Click(sender, e);
            }
        }

        private void btnOkSua_Click(object sender, EventArgs e)
        {
            if ((txtMaTG.Text != "") && (txtTenTG.Text != ""))
            {
                try
                {
                    TacGia_DTO tacGia = new TacGia_DTO(txtMaTG.Text, txtTenTG.Text, rtbThongTinTG.Text);
                    BUS_OBJ.suaTG(tacGia);
                    HienThiDuLieu();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this,ex.Message);
                }
                finally
                {
                    btnCancel_Click(sender, e);
                    //if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Nhập thiếu dữ liệu.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtMaTG.Text == "") txtMaTG.Focus();
                if (txtTenTG.Text == "") txtTenTG.Focus();
            }
        }

        private void btnOkThem_Click(object sender, EventArgs e)
        {
            if ((txtMaTG.Text != "") && (txtTenTG.Text != ""))
            {
                try
                {
                    TacGia_DTO tacGia = new TacGia_DTO(txtMaTG.Text, txtTenTG.Text, rtbThongTinTG.Text);
                    BUS_OBJ.themTG(tacGia);
                    HienThiDuLieu();

                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Mã tác giả bị trùng. \nKhông thể thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnCancel_Click(sender, e);
                    //if (conn.State == ConnectionState.Open) conn.Close();
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Nhập thiếu dữ liệu.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtTenTG.Text == "") txtTenTG.Focus();
                if (txtMaTG.Text == "") txtMaTG.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text != "")
            {
                DialogResult thongbao;
                thongbao = (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc chắn muốn xóa? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    try
                    {
                        BUS_OBJ.xoaTG(txtMaTG.Text);
                        MetroFramework.MetroMessageBox.Show(this, "Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDuLieu();
                        txtMaTG.Text = "";
                        txtTenTG.Text = "";
                        rtbThongTinTG.Text = "";
                    }
                    catch (Exception)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Không thể xóa tác giả đang có sách. \nVui lòng xem lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        //if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn một tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel_Click(sender, e);
            }
        }

        private void frmCapNhatTacGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
        }
    }
}
