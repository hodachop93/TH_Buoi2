using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    public class SinhVienBangHai : SinhVien
    {
        private string bang1;
        private string donVi;
        public string Bang1
        {
            get
            {
                return bang1;
            }
            set
            {
                bang1 = value;
            }
        }
        public string DonVi
        {
            get
            {
                return donVi;
            }
            set
            {
                donVi = value;
            }
        }
        public override string LoaiHinh()
        {
            return "Bang Hai";
        }
        public SinhVienBangHai() { }
        public SinhVienBangHai(string _diaChi, string _dienThoai, string _hoTen, int _MSSV, DateTime _ngaySinh, string _nienKhoa,
            string _bang1, string _donVi)
            : base(_diaChi, _dienThoai, _hoTen, _MSSV, _ngaySinh, _nienKhoa)
        {

        }
    }
}
