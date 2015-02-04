using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_Buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Tinh tien
        private void getPay()
        {
            if (txtName.Text.Equals(""))
            {
                string messBoxText = "Bạn chưa nhập tên khách hàng!!!";
                string caption = "Warning";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(messBoxText, caption, btn, icon);
            }
            else
            {
                long total = 0;
                if (chkClean.Checked)
                    total += 100000;
                if (chkWhitening.Checked)
                    total += 1200000;
                if (chkXRay.Checked)
                    total += 200000;
                total += ((long)numFilling.Value) * 80000;
                txtTotal.Text = total.ToString();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            getPay();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }
    }
}
