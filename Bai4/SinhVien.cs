using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class SinhVien
    {
        private string diaChi;
        private string dienThoai;
        private string hoTen;
        private int maSo;
        private DateTime ngaySinh;
        private string nienKhoa;
        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }
        public string DienThoai
        {
            get
            {
                return dienThoai;
            }
            set
            {
                dienThoai = value;
            }
        }
        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set{
                hoTen=value;
            }
        }
        public int MSSV
        {
            get
            {
                return maSo;
            }
            set
            {
                maSo = value;
            }
        }
        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }
            set
            {
                ngaySinh = value;
            }
        }
        public string NienKhoa
        {
            get
            {
                return nienKhoa;
            }
            set
            {
                nienKhoa = value;
            }
        }
        public virtual string LoaiHinh()
        {
            return "Sinh vien";
        }
        public SinhVien()
        {

        }
        public SinhVien(string _diaChi,string _dienThoai,string _hoTen,int _MSSV, DateTime _ngaySinh,string _nienKhoa)
        {
            this.diaChi = _diaChi;
            this.dienThoai = _dienThoai;
            this.hoTen = _hoTen;
            this.maSo=_MSSV;
            this.ngaySinh = _ngaySinh;
            this.nienKhoa = _nienKhoa;
        }
       
    }
}
