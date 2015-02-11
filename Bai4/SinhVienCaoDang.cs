using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    class SinhVienCaoDang : SinhVien
    {
        public SinhVienCaoDang() { }
        public SinhVienCaoDang(string _diaChi, string _dienThoai, string _hoTen, int _MSSV, DateTime _ngaySinh, string _nienKhoa)
            : base(_diaChi, _dienThoai, _hoTen, _MSSV, _ngaySinh, _nienKhoa)
        {

        }
        public override string LoaiHinh()
        {
            return "Cao dang";
        }
    }
}
