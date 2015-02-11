using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Xu ly su kien cho cac nut so
        private void actionedNumber(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string s = btn.Text;
            string name;
            if (s[0] >= '0' && s[0] <= '9')
            {
                if (txtSecurityCode.Text.Length < 4)
                {
                    txtSecurityCode.Text += s;
                }
            }
            if (s.Equals("C"))
            {
                txtSecurityCode.Text = "";
            }
            if (s.Equals("INS"))
            {
                int number = Convert.ToInt32(txtSecurityCode.Text);
                if (number == 1645 || number == 1689)
                {
                    name = "Technicans";
                }
                else if (number == 8345)
                    name = "Custodians";
                else if (number == 9998 || (number >= 1006 && number <= 1008))
                {
                    name = "Scientist";
                }
                else if (number >= 0 && number <= 9)
                {
                    name = "Restricted Access";
                }
                else
                {
                    name = "Access denied";
                }
                DateTime date = DateTime.Now;
                string xau = date.ToString();
                xau += "\t" + name;
                lbAccessLog.Items.Add(xau);

                //Ghi file log
                string path = @"D:\Visual Studio Projects\TH_Buoi2\Bai2\logfile.txt";
                if (!File.Exists(path))
                {
                    // tao ra 1 file de viet
                    StreamWriter sw = File.CreateText(path);
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    if (!name.Equals("Restricted Access"))
                    {
                        sw.WriteLine(xau);
                    }
                }	

                
                txtSecurityCode.Text = "";
            }
        }

       
    }
}
