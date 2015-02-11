using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    public class SinhVienCaoDang : SinhVien
    {
        public SinhVienCaoDang() { }
        public SinhVienCaoDang(string _diaChi, string _dienThoai, string _hoTen, int _MSSV, DateTime _ngaySinh, string _nienKhoa, string _chuyenNganh)
            : base(_diaChi, _dienThoai, _hoTen, _MSSV, _ngaySinh, _nienKhoa)
        {

        }
    }
}
