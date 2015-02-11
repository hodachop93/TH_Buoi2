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
        private bool editing = false;
        public Form1()
        {
            InitializeComponent();
        }
        // Ham cap nhat bang sinh vien
        private void UpdateList()
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


        // Khi an nut them
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = null;
            string dc = txtDiaChi.Text;
            string dt = txtDienThoai.Text;
            string ht = txtHoTen.Text;
            int mssv = Convert.ToInt32(txtMSSV.Text);
            DateTime ns = dtpNS.Value;
            string nk = txtNienKhoa.Text;
            //Kiem tra xem MSSV da ton tai hay chu
            foreach (SinhVien SV in studentList)
            {
                // Neu trung ma so thi cho chuyen den catch
                if (mssv == SV.MSSV)
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại", "Message");
                    return;
                }
            }
            // Neu la SV Dai hoc
            if (radDaiHoc.Checked)
            {
                string cn = cboCN.Text;
                sv = new SinhVienDaiHoc(dc, dt, ht, mssv, ns, nk, cn );
                radDaiHoc.Checked = false;
            }
            //Neu la sinh vien bang hai
            if (radBang2.Checked)
            {
                string bang1 = txtBang1.Text;
                string dv = txtCty.Text;
                sv = new SinhVienBangHai(dc, dt, ht, mssv, ns, nk, bang1, dv);
                radBang2.Checked = false;
            }

            //Neu la sinh vien cao dang
            if (radCaoDang.Checked)
            {
                sv = new SinhVienCaoDang(dc, dt, ht, mssv, ns, nk);
                radCaoDang.Checked = false;
            }
            this.studentList.Add(sv);
            UpdateList();
        }

        //Ham xu ly su kien CheckChanged cho các Radio Button
        private void radio_CheckChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            cboCN.Enabled = false;
            txtBang1.Enabled = false;
            txtCty.Enabled = false;
            if (control.Name == "radDaiHoc")
            {
                cboCN.Enabled = true;
            }
            if (control.Name == "radBang2")
            {
                txtBang1.Enabled = true;
                txtCty.Enabled = true;
            }
        }
        
        //Ham xu su kien cho nut xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList;
            selectedList = lvSinhVien.SelectedItems;
            foreach (ListViewItem item in selectedList)
            {
                string ms = item.Text;
                foreach (SinhVien sv in studentList)
                {
                    if (sv.MSSV.ToString()==ms)
                    {
                        studentList.Remove(sv);
                        break;
                    }
                }
            }
            UpdateList();
        }

        //Ham su ly su kien nut Sua
        private void btnSua_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = lvSinhVien.SelectedItems;
            int index = selectedList[0].Index;
            SinhVien sv = (SinhVien)studentList[index];
            if (!editing)
            {
                lvSinhVien.Enabled = false;
                txtHoTen.Text = sv.HoTen;
                txtDienThoai.Text = sv.DienThoai;
                txtDiaChi.Text = sv.DiaChi;
                dtpNS.Value = sv.NgaySinh;
                txtNienKhoa.Text = sv.NienKhoa;
                txtHoTen.Enabled = false;
                txtNienKhoa.Enabled = false;
                txtMSSV.Enabled = false;
                editing = true;
            }
            else
            {

                sv.DienThoai = txtDienThoai.Text;
                sv.DiaChi = txtDiaChi.Text;
                sv.NgaySinh = dtpNS.Value;
                editing = false;
                lvSinhVien.Enabled = true;
            }
            UpdateList();

            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        

       
    }
}
