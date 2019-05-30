using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public class AutoCompleteComboBox : ComboBox
    {
        // Biến cờ dùng khi một phím đặc biệt được nhấn
        // (trong trường hợp này, thao tác thay thế text sẽ bị bỏ qua).
        private bool controlKey = false;
        // Xác định xem phím đặc biệt có được nhấn hay không.
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (int)Keys.Escape)
            {
                // Xóa text.
                this.SelectedIndex = -1;
                this.Text = "";
                controlKey = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                controlKey = true;
            }
            else
            {
                controlKey = false;
            }
        }
        // Thực hiện thay thế text.
        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            if (this.Text != "" && !controlKey)
            {
                // Tìm kiếm item trùng khớp.
                string matchText = this.Text;
                int match = this.FindString(matchText);
                // Nếu tìm thấy thì chèn nó vào.
                if (match != -1)
                {
                    this.SelectedIndex = match;
                    // Chọn (bôi đen) phần text vừa thêm vào để
                    // nó có thể được thay thế nếu người dùng kiếp tục gõ.
                    this.SelectionStart = matchText.Length;
                    this.SelectionLength =
                    this.Text.Length - this.SelectionStart;
                }
            }
        }
    }
}
