using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication便當訂購系統
{
    public partial class Form主頁 : Form
    {
        
        int 訂購份數 = 0;
        int index = 0;
        int SupplierID = 0;
        int 數量 = 0;
        String[] array點餐者 = new string[10];
        String[] array產品名稱 = new string[10];
        int[] array數量 = new int[10];
        int[] array小計 = new int[10];
        List<object> 產品暫存 = new List<object>();//產品暫存為List
        //List<object> producttemp = new List<object>();


        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(@"Data Source=CR1-21;Initial Catalog=C:\USERS\III\DESKTOP\WINDOWSFORMSAPPLICATION便當訂購系統(9.78版)\MIDEDEMO.MDF;Integrated Security=True");
        public Form主頁()
        {
            InitializeComponent();
        }

        private void Form主頁_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            lv商品訂購清單.Columns.Add("目錄", 50, HorizontalAlignment.Center);
            lv商品訂購清單.Columns.Add("餐點名稱", 150, HorizontalAlignment.Center);
            lv商品訂購清單.Columns.Add("訂購人姓名", 100, HorizontalAlignment.Center);
            lv商品訂購清單.Columns.Add("價錢", 70, HorizontalAlignment.Center);
            lv商品訂購清單.Columns.Add("數量", 70, HorizontalAlignment.Center);
            lv商品訂購清單.Columns.Add("小計", 50, HorizontalAlignment.Center);



            SqlConnection con2 = new SqlConnection(scsb.ToString());
            con2.Open();
            string strSQL2 = "select StudentName from Student ";
            // comboBox學生.Items.Clear();
            SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
            //cmd2.Parameters.AddWithValue("@selectStudentName", clb訂購者.SelectedItem);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                clb訂購者.Items.Add(reader2[0].ToString());
            }
            reader2.Close();
            con2.Close();
            店家顯示();
            顯示值日生名字();
            
        }


        private void btn學生資料管理_Click(object sender, EventArgs e)
        {
            學生資料 myForm主頁 = new 學生資料();
            this.Hide();
            myForm主頁.Show();
        }

        private void btn店家資料管理_Click(object sender, EventArgs e)
        {
            Form店家資料 myForm主頁 = new Form店家資料();
            this.Hide();
            myForm主頁.Show();
        }

       

        public void cobox店家稱呼更新()
        {
            /*SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            string strSQL = "select * from Suppliers where 店家稱呼=@CompanyName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@CompanyName", cobox店家稱呼.Text.Trim());
      
            SqlDataReader reader = cmd.ExecuteReader();
            cobox店家稱呼.Items.Clear();

            while (reader.Read())
            {
                cobox店家稱呼.Items.Add(reader["CompanyName"].ToString().Trim());
                
            }

            con.Close();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();*/
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            string strSQL = "select DISTINCT CompanyName from Suppliers";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            cobox店家稱呼.BeginUpdate();
            cobox店家稱呼.Items.Clear();

            while (reader.Read())
            {
                cobox店家稱呼.Items.Add(reader["CompanyName"].ToString().Trim());
            }

            if (reader.Read())
            {
            }
            else
            {
                cobox店家稱呼.Text = "選擇訂購店家";
            }
            reader.Close();
            cobox店家稱呼.EndUpdate();
            con.Close();
        }
        public void 店家顯示()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            string strSQL = "select CompanyName from Suppliers ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@CompanyName", cobox店家稱呼.Text.Trim());

            SqlDataReader reader = cmd.ExecuteReader();
            cobox店家稱呼.Items.Clear();

            while (reader.Read())
            {
                cobox店家稱呼.Items.Add(reader["CompanyName"].ToString().Trim());

            }
            reader.Close();
            con.Close();
        }
        private void cobox店家稱呼_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            SupplierID = 0;
            int index = cobox店家稱呼.SelectedIndex;
            string strSQLindex = "select  * from  Suppliers where CompanyName = @Name";
            SqlCommand cmdindex = new SqlCommand(strSQLindex, con);
            cmdindex.Parameters.AddWithValue("@Name", cobox店家稱呼.Text.Trim());
            SqlDataReader reader = cmdindex.ExecuteReader();


            while (reader.Read())
            {
                SupplierID = int.Parse(reader["SupplierID"].ToString());
                tb連絡電話.Text = string.Format("{0}", reader["PhoneNumber"]);
            }

            reader.Close();
            con.Close();
            cobox店家稱呼.Enabled = false;
            產品目錄更新(SupplierID);
        }

        private void clb訂購者_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(scsb.ToString());
            con2.Open();
            string strSQL2 = "select * from Student where StudentName=@clb ";
            // comboBox學生.Items.Clear();
            SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
            cmd2.Parameters.AddWithValue("@clb", clb訂購者.SelectedItem.ToString());
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                clb訂購者.Items.Add(reader2[0].ToString());
            }
            reader2.Close();
            con2.Close();
        }

        private void btn加1_Click(object sender, EventArgs e)
        {
            訂購份數 += 1;
            btn加1.Enabled = true;
            tb訂購份數.Text = 訂購份數.ToString();
        }

        private void btn減1_Click(object sender, EventArgs e)
        {

            訂購份數 -= 1;

            if (訂購份數 < 0)
            {
                訂購份數 = 0;
                btn減1.Enabled = false;
            }

            tb訂購份數.Text = 訂購份數.ToString();
        }

        private void tb訂購份數_TextChanged(object sender, EventArgs e)
        {
            if (tb訂購份數.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tb訂購份數.Text, out 訂購份數);

                if (ifNum && 訂購份數 >= 0)
                {
                    //正確輸入;
                    btn減1.Enabled = true;
                }
                else
                {
                    //錯誤輸入;
                    MessageBox.Show("份數輸入錯誤", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb訂購份數.Text = "0";
                    訂購份數 = 0;
                }
            }
            else
            {
                訂購份數 = 0;
            }
        }
        public void 顯示值日生名字()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select StudentName from Student";//模糊搜尋用like
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cobox值日生.Items.Add(reader[0].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void cobox值日生_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Console.WriteLine("-----cobox值日生_SelectedIndexChanged-----" + cobox值日生.SelectedItem.ToString());

            SqlConnection con2 = new SqlConnection(scsb.ToString());
            con2.Open();
            string strSQL2 = "select Classrom from Student where StudentName = @cb ";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
            cmd2.Parameters.AddWithValue("@cb", cobox值日生.SelectedItem.ToString());
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                tb值日生教室.Text = string.Format("{0}", reader2["Classrom"].ToString());
            }
            reader2.Close();
            con2.Close();

        }


        public void 產品目錄更新(int SupplierID)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            string strSQL = "select * from Product where SupplierID = @產品ID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@產品ID", SupplierID);
            SqlDataReader reader = cmd.ExecuteReader();

            cobox訂購內容.BeginUpdate();
            cobox訂購內容.Items.Clear();

            while (reader.Read())
            {
                cobox訂購內容.Items.Add(reader["ProductName"].ToString().Trim());
                tb商品單價.Text = string.Format("{0}", reader["Unitprice"]);//無法與餐點內容價格連接
            }

            if (reader.Read())
            {
            }
            else
            {
                cobox訂購內容.Text = "選擇餐點內容";
            }
            reader.Close();
            cobox訂購內容.EndUpdate();
            con.Close();

        }

        private void cobox訂購內容_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            產品暫存.Clear();

            int index = cobox訂購內容.SelectedIndex;
            string strSQLindex = "select  * from Product where ProductName = @Name";
            SqlCommand cmdindex = new SqlCommand(strSQLindex, con);
            cmdindex.Parameters.AddWithValue("@Name", cobox訂購內容.Text.Trim());
            SqlDataReader reader = cmdindex.ExecuteReader();

            if (reader.Read())
            {
                tb商品單價.Text = string.Format("{0}", reader["Unitprice"]);
            }
            while (reader.Read())
            {
                產品暫存.Add(reader["ProductId"].ToString().Trim());
                產品暫存.Add(reader["ProductName"].ToString().Trim());
                產品暫存.Add(reader["Uniteprice"].ToString().Trim());
            }
            reader.Close();
            con.Close();
        }
        private void lv商品訂購清單_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv商品訂購清單.SelectedIndices != null && lv商品訂購清單.SelectedIndices.Count > 0)
            {
                index = lv商品訂購清單.SelectedItems[0].Index;
                ListView lvi = new ListView();

                tb訂購份數.Text = lv商品訂購清單.FocusedItem.SubItems[3].Text;
            }
            else
            {
                tb訂購份數.Text = "0";
                產品目錄更新(SupplierID);
            }
        }



        private void btn點餐確定_Click(object sender, EventArgs e)
        {
            if (int.Parse(tb訂購份數.Text) ==0)
            {
                MessageBox.Show("尚未選擇份數");
            }
            else
            {
                String temp = "";

                for (int i = 0; i < clb訂購者.Items.Count; i++)
                {
                    if (clb訂購者.GetItemChecked(i))
                    {
                        temp += "[" + clb訂購者.GetItemText(clb訂購者.Items[i] + "]");
                    }
                }



                數量 = 0;
                this.lv商品訂購清單.BeginUpdate();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (lv商品訂購清單.Items.Count + 1).ToString();
                lvi.SubItems.Add(cobox訂購內容.Text.Trim());
                lvi.SubItems.Add(temp.Trim());//訂購人姓名
                lvi.SubItems.Add(tb商品單價.Text.Trim());
                lvi.SubItems.Add(tb訂購份數.Text.Trim());
                int total = int.Parse(tb訂購份數.Text.Trim()) * int.Parse(tb商品單價.Text.Trim());//
                lvi.SubItems.Add(total.ToString());
                this.lv商品訂購清單.Items.Add(lvi);
                this.lv商品訂購清單.EndUpdate();
            }
            tb訂購份數.Text = "0";
            總額();
        }

        private void btn刪除點餐_Click(object sender, EventArgs e)//有問題
        {
            DialogResult R = MessageBox.Show("是否要刪除點餐項目", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.lv商品訂購清單.BeginUpdate();
            ListViewItem lvi = new ListViewItem();
            lv商品訂購清單.Items.RemoveAt(index);
            lvi.SubItems.RemoveAt(0);
            this.lv商品訂購清單.EndUpdate();
            總額();

        }

        public void 總額()
        {
            int total = 0;
            for (int i = 0; i < lv商品訂購清單.Items.Count; i++)
            {
                total += int.Parse(lv商品訂購清單.Items[i].SubItems[5].Text);

            }
            tb總額.Text = total.ToString();
        }

        private void btn送出訂單_Click(object sender, EventArgs e)//問題
        {
            DialogResult R = MessageBox.Show("是否確認送出訂購單", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            for (int i = 0; i < lv商品訂購清單.Items.Count; i++)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into [Order detail] (Classrom,SupplierName,StudentName,ProductName,Unitprice,Quantity,Sum,PhoneNumber,Orderdate) values(@Classrom,@SupplierName,@StudentName,@ProductName,@Unitprice,@Quantity,@Sum,@PhoneNumber,@Orderdate)";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                
                cmd.Parameters.AddWithValue("@Classrom", tb值日生教室.Text.Trim());
                cmd.Parameters.AddWithValue("@SupplierName", cobox店家稱呼.Text.Trim());//Trim去除空白字元
                cmd.Parameters.AddWithValue("@StudentName", cobox值日生.Text.Trim());
                cmd.Parameters.AddWithValue("@ProductName", cobox訂購內容.Text.Trim());
                cmd.Parameters.AddWithValue("@Unitprice", tb商品單價.Text.Trim());
                cmd.Parameters.AddWithValue("@Quantity", lv商品訂購清單.Items[i].SubItems[4].Text.Trim());//有問題
                cmd.Parameters.AddWithValue("@Sum", tb總額.Text.Trim());
                cmd.Parameters.AddWithValue("@PhoneNumber", tb連絡電話.Text.Trim());
                cmd.Parameters.AddWithValue("@Orderdate", DateTime.Now.ToShortDateString());


                int rows = cmd.ExecuteNonQuery();
                con.Close();
                
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb現在時間.Text = DateTime.Now.ToString();
        }
    }
}
