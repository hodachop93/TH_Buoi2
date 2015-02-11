using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        ArrayList studentList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        // Ham cap nhat bang sinh vien
        void UpdateList()
        {
            lvSinhVien.Items.Clear();
            int i = 0;
            foreach (SinhVien sv in studentList)
            {
                ListViewItem item = new ListViewItem(sv.MSSV.ToString(), i++);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToString().Split(' ')[0]);
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.DienThoai.ToString());
                item.SubItems.Add(sv.NienKhoa.ToString());
                item.SubItems.Add(sv.LoaiHinh());
                lvSinhVien.Items.Add(item);
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = null;
            string dc = txtDiaChi.Text;
            string dt = txtDienThoai.Text;
            string ht = txtHoTen.Text;
            int mssv = Convert.ToInt32(txtMSSV.Text);
            DateTime ns = dtpNS.Value;
            string nk = txtNienKhoa.Text;


        }

        

       
    }
}
