using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Bai3
{
    public partial class Form3 : Form
    {
        private List<DataTable> listBan;
        MySqlConnection con;
        string conStr;
        MySqlCommand command;
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
            //Ket noi voi co so du lieu
            conStr = "server=localhost; database=nha_hang; port=3306; username=root; password=root";
            con = new MySqlConnection(conStr);
            try
            {
                con.Open();
                MessageBox.Show("Ban da ket noi thanh cong!");


            }
            catch (Exception)
            {
                MessageBox.Show("Khong the ket noi csdl");
                con.Dispose();

            }

            con.Close();

        }



        //Xu ly su kien click button
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            if (!cbBoxBan.Text.Equals(""))
            {
                if (true)
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

                    listBan[indexOfBan].Rows[i][1] = listBan[indexOfBan].Rows[i].Field<int>(1) + 1;
                    break;
                }




            }
            if (i == view.Count)
            {
                DataRow row = listBan[indexOfBan].NewRow();
                row["FoodName"] = foodName;
                row["Quality"] = 1;
                listBan[indexOfBan].Rows.Add(row);
            }

        }

        private string getNameOfBan(string nameBan)
        {
            switch (nameBan)
            {
                case "Bàn 1":
                    return "ban1";
                case "Bàn 2":
                    return "ban2";
                case "Bàn 3":
                    return "ban3";
                case "Bàn 4":
                    return "ban4";
                default:
                    return "Sai";
            }
        }
        private void cbBoxBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable temp = null;
            for (int i = 0; i < listBan.Count; i++)
            {
                temp = listBan[i];
                if (i != getIndexOfBan(cbBoxBan.Text))
                    temp.Clear();
            }
            //temp = listBan[getIndexOfBan(cbBoxBan.Text)];
            
            //string path = @".\" + cbBoxBan.Text + ".txt";
            //if (File.Exists(path))
            //{
            //    StreamReader sr = new StreamReader(path);
            //    string line, food, quality;
            //    int i = 0;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        food = line.Substring(0, line.IndexOf(","));
            //        quality = line.Substring(line.IndexOf(",") + 1);
            //        DataRow row = temp.NewRow();
            //        row[0] = food;
            //        row[1] = quality;
            //        temp.Rows.Add(row);
            //        i++;
            //    }
            //    sr.Close();
            //}
            //dataGridView.DataSource = temp;
            con.Open();
            command = con.CreateCommand();
            string nameBan=getNameOfBan(cbBoxBan.Text);
            string sqlQuery=String.Format("Select * from {0}", nameBan);
            command.CommandText = sqlQuery;
            MySqlDataReader reader = command.ExecuteReader();
            temp = listBan[getIndexOfBan(cbBoxBan.Text)];

            while (reader.Read())
            {
                DataRow row = temp.NewRow();
                row[0] = reader[0].ToString();
                row[1] = int.Parse(reader[1].ToString());
                temp.Rows.Add(row);
            }
            dataGridView.DataSource = temp;
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count >= 0)
            {
                DataTable temp = listBan[getIndexOfBan(cbBoxBan.Text)];
                for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                {
                    int index = dataGridView.SelectedRows[i].Index;
                    dataGridView.Rows.RemoveAt(index);
                    temp.Rows.RemoveAt(index);
                }
                
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //string path = @".\" + cbBoxBan.Text + ".txt";
            //StreamWriter sw = null;
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}
            //sw = File.CreateText(path);
            //DataTable temp = listBan[getIndexOfBan(cbBoxBan.Text)];
            //string xau="";
            //for (int i = 0; i < temp.Rows.Count; i++)
            //{
            //    xau += temp.Rows[i][0] + "," + temp.Rows[i][1];
            //    sw.WriteLine(xau);
            //    xau = "";
            //}
            //sw.Close();
            con.Open();
            string sqlQuery=string.Format("Truncate Table {0}", getNameOfBan(cbBoxBan.Text));
            command.CommandText = sqlQuery;
            command.ExecuteNonQuery();
            //Doc du lieu ta datatable vao csdl
            DataTable temp = listBan[getIndexOfBan(cbBoxBan.Text)];
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                sqlQuery = string.Format("Insert Into {0}(FoodName, Quality) Values ('{1}', '{2}')", getNameOfBan(cbBoxBan.Text),
                    temp.Rows[i][0], temp.Rows[i][1]);
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Ban da dat hang thanh cong");
        }

    }
}
