using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form3 : Form
    {
        private List<DataTable> listBan;
        public Form3()
        {
            InitializeComponent();
            listBan = new List<DataTable>(4);
            for (int i = 0; i < 4; i++)
            {
                DataTable dtTable = new DataTable();
                dtTable.Columns.Add("FoodName", typeof(string));
                dtTable.Columns.Add("Quality", typeof(int));
                listBan.Add(dtTable);
            }
        }
         
        

        //Xu ly su kien click button
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            List<string> listFood = new List<string>();
            string[] s = {"btnPMBo","btnPMGa","btnPMTom","btnPMCa","btnTomVienCola","btnGaVienCola","btnGaRanPhan","btnComGaTender","btnPepsi",
                         "btn7Up","btnCafe","btnCam","btnLipton","btnCoca","btnKhoaiTayChien"};
            listFood.AddRange(s);
            if (!cbBoxBan.Text.Equals(""))
            {
                if (listFood.Contains(btn.Name))
                {
                    int indexOfBan = getIndexOfBan(cbBoxBan.Text);
                    insertFoodInTable(btn.Text, indexOfBan);

                }
            }
           
        }

        //Lay thu tu cua ban
        private int getIndexOfBan(string nameBan)
        {
            int i = 0;
            switch (nameBan)
            {
               
                case "Bàn 1":
                    i = 0;
                    break;
                case "Bàn 2":
                    i = 1;
                    break;
                case "Bàn 3":
                    i = 2;
                    break;
                case "Bàn 4":
                    i = 3;
                    break;

            }

            return i;
        }

        //Tim mon an trong DataTable
        private void insertFoodInTable(string foodName, int indexOfBan)
        {
            DataView view = listBan[indexOfBan].DefaultView;
            int i;
            for (i = 0; i < view.Count; i++)
            {
               

                if (view[i]["FoodName"].Equals(foodName))
                {

                    listBan[indexOfBan].Rows[i][1]=listBan[indexOfBan].Rows[i].Field<int>(1)+1;
                    break;
                }
                
                   

            
            }
            if (i==view.Count)
            {
                DataRow row = listBan[indexOfBan].NewRow();
                row["FoodName"] = foodName;
                row["Quality"] = 1;
                listBan[indexOfBan].Rows.Add(row);
            }

        }

        private void cbBoxBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = listBan[getIndexOfBan(cbBoxBan.Text)];

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count >= 0)
                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
        }
        
    }
}
