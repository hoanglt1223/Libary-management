using Xunit;

namespace QLTV.Test
{
    public class LoginTest
    {

        [Theory]
        [InlineData("admin", "1")]
        public void AdminLoginTest(string username, string password)
        {
            Assert.Equal(1, DAO.Sach_DAO.loaiTaiKhoan(username, password));
        }

        [Theory]
        [InlineData("user", "1")]
        public void UserLoginTest(string username, string password)
        {
            Assert.Equal(0, DAO.Sach_DAO.loaiTaiKhoan(username, password));
        }

        [Theory]
        [InlineData("user", "1", "0")]
        public void ChangePasswordTest(string username, string old_password, string new_password)
        {
            DAO.Sach_DAO.doiMK(username, new_password);
            Assert.NotNull(DAO.Sach_DAO.loaiTaiKhoan(username, new_password));
            DAO.Sach_DAO.doiMK(username, old_password);
        }

        [Theory]
        [InlineData("user", "1", "0")]
        public void PreventPasswordReuseTest(string username, string old_password, string new_password)
        {
            DAO.Sach_DAO.doiMK(username, old_password);
            Assert.Null(DAO.Sach_DAO.loaiTaiKhoan(username, old_password));
        }
    }
}
