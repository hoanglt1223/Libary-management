using System;
using System.Runtime.InteropServices;
using System.Text;
using Xunit;

namespace QLTV.Test
{
    public class BookDataTest
    {
        [Theory]
        [InlineData("vn1001")]
        public void GetBookNameTest(string maSach)
        {
            Assert.IsType<System.String>(DAO.Sach_DAO.layTenSach(maSach));
        }

        [Theory]
        [InlineData("test", "test", "0002", "102", "1002", 2000, 2000, 2000, 2000, 2000)]
        public void BookCreateTest(string maSach, string tenSach, string maTacGia, string maTheLoai, string maNXB, int namXuatBan, int soTrang, int gia, int soBan, int soBanTon)
        {
            DTO.Sach_DTO book = new DTO.Sach_DTO(maSach, tenSach, maTacGia, maTheLoai, maNXB, namXuatBan, soTrang, gia, soBan, soBanTon);
            DAO.Sach_DAO.themSach(book);
            Assert.NotNull(DAO.Sach_DAO.layTenSach(book.MaSach));
            DAO.Sach_DAO.xoaSach(book.MaSach);
        }

        [Theory]
        [InlineData("vn1001")]
        public void BookReadTest(string bookId)
        {
            Assert.NotNull(DAO.Sach_DAO.layTenSach(bookId));
        }

        [Theory]
        [InlineData("test", "test", "0002", "102", "1002", 2000, 2000, 2000, 2000, 2000)]
        public void BookDeleteTest(string maSach, string tenSach, string maTacGia, string maTheLoai, string maNXB, int namXuatBan, int soTrang, int gia, int soBan, int soBanTon)
        {
            DTO.Sach_DTO book = new DTO.Sach_DTO(maSach, tenSach, maTacGia, maTheLoai, maNXB, namXuatBan, soTrang, gia, soBan, soBanTon);
            DAO.Sach_DAO.themSach(book);
            DAO.Sach_DAO.xoaSach(book.MaSach);
            Assert.Equal("", DAO.Sach_DAO.layTenSach(book.MaSach));
        }

        [Theory]
        [InlineData("test", "test", "test")]
        public void AddAuthorTest(string id, string name, string note)
        {
            DTO.TacGia_DTO author = new DTO.TacGia_DTO(id, name, note);
            DAO.Sach_DAO.themTG(author);
            Assert.Equal(name, DAO.Sach_DAO.layTenTacGia(id));
            DAO.Sach_DAO.xoaTG(id);
        }

        [Theory]
        [InlineData("test", "test", "test")]
        public void DeleteAuthorTest(string id, string name, string note)
        {
            DTO.TacGia_DTO author = new DTO.TacGia_DTO(id, name, note);
            DAO.Sach_DAO.themTG(author);
            DAO.Sach_DAO.xoaTG(id);
            Assert.Equal("", DAO.Sach_DAO.layTenTacGia(id));
        }

        [Theory]
        [InlineData("test", "test", "test")]
        public void AddPublisherTest(string id, string name, string note)
        {
            DTO.NXB_DTO publisher = new DTO.NXB_DTO(id, name, note);
            DAO.Sach_DAO.themNXB(publisher);
            Assert.Equal(name, DAO.Sach_DAO.layTenNXB(id));
            DAO.Sach_DAO.xoaNXB(id);
        }

        [Theory]
        [InlineData("test", "test", "test")]
        public void DeletePublisherTest(string id, string name, string note)
        {
            DTO.NXB_DTO publisher = new DTO.NXB_DTO(id, name, note);
            DAO.Sach_DAO.themNXB(publisher);
            DAO.Sach_DAO.xoaNXB(id);
            Assert.Equal("", DAO.Sach_DAO.layTenTacGia(id));
        }

        [Theory]
        [InlineData("test", "test")]
        public void AddCategoryTest(string id, string name)
        {
            DTO.TheLoai_DTO category = new DTO.TheLoai_DTO(id, name);
            DAO.Sach_DAO.themTL(category);
            Assert.Equal(name, DAO.Sach_DAO.layTenTheLoai(id));
            DAO.Sach_DAO.xoaTL(id);
        }

        [Theory]
        [InlineData("test", "test")]
        public void DelteCategoryTest(string id, string name)
        {
            DTO.TheLoai_DTO category = new DTO.TheLoai_DTO(id, name);
            DAO.Sach_DAO.themTL(category);
            DAO.Sach_DAO.xoaTL(id);
            Assert.Equal("", DAO.Sach_DAO.layTenTheLoai(id));
        }
    }
}
