using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    public class SinhVienDaiHoc : SinhVien
    {
        private string chuyenNganh;
        public string ChuyenNganh
        {
            get
            {
                return chuyenNganh;
            }
            set
            {
                chuyenNganh = value;
            }
        }
        public override string LoaiHinh()
        {
            return "Dai hoc";
        }
        public SinhVienDaiHoc()
        {

        }
        public SinhVienDaiHoc(string _diaChi, string _dienThoai, string _hoTen, int _MSSV, DateTime _ngaySinh, string _nienKhoa, string _chuyenNganh)
            : base(_diaChi,_dienThoai,_hoTen,_MSSV,_ngaySinh,_nienKhoa)
        {
            this.chuyenNganh = _chuyenNganh;
        }
    }
}
