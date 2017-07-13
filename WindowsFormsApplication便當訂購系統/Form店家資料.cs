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

    public partial class Form店家資料 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(@"Data Source=CR1-21;Initial Catalog=C:\USERS\III\DESKTOP\WINDOWSFORMSAPPLICATION便當訂購系統(9.78版)\MIDEDEMO.MDF;Integrated Security=True");
        public Form店家資料()
        {
            InitializeComponent();
        }
        private void Form店家資料_Load_1(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.midedemoDataSet.Suppliers);
            cobox店家名字更新();
            顯示店家名字();
           // 顯示商品名稱();
            /*scsb = new SqlConnectionStringBuilder();

           scsb.UserID = "";
           scsb.Password = "";

           scsb.DataSource = @"(LocalDB)\MSSQLLocalDB";
           scsb.AttachDBFilename = @"|DataDirectory|\midedemo.mdf";
           scsb.IntegratedSecurity = true;*/
            //cobox店家名字更新();
            cobox店家名字.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select distinct CompanyName from [Suppliers] ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                

                if (reader["CompanyName"].ToString().Length > 0)
                {
                    cobox店家名字.Items.Add(string.Format("{0}", reader["CompanyName"].ToString()));
                }

            }
            reader.Close();
            con.Close();
        }
        public void 顯示店家名字()
        {
            
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select CompanyName from Suppliers";//模糊搜尋用like
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lb店家清單.Items.Add(reader[0].ToString());
            }
        }
        public void 顯示店家名字更新()
        {
            lb店家清單.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select CompanyName from Suppliers";//模糊搜尋用like
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lb店家清單.Items.Add(reader[0].ToString());
            }
        }
        public void 顯示商品名稱()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select ProductName from Product";//模糊搜尋用like
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lb商品清單.Items.Add(reader[0].ToString());
            }
        }
        public void 顯示商品名稱更新()
        {
            lb商品清單.Items.Clear();
           SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select ProductName from Product";//模糊搜尋用like
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lb商品清單.Items.Add(reader[0].ToString());
            }
        }

        private void btn新增店家_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "insert into Suppliers values(@SupplierID,@CompanyName, @Phone, @Address,@Comment)";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@CompanyName", cobox店家名字.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", tb連絡電話.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", tb店家地址.Text.Trim());
            cmd.Parameters.AddWithValue("@Comment", tb店家評價.Text.Trim());
            cmd.Parameters.AddWithValue("@SupplierID", cobox店家編號.Text.Trim());//Trim去除空白字元
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            顯示店家名字更新();
            MessageBox.Show(string.Format("店家新增完畢,共影響{0}筆資料", rows));
        }

        private void btn刪除店家_Click(object sender, EventArgs e)
        {
            if (cobox店家名字.Text.Length > 0 )
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from Suppliers where CompanyName = @CompanyName and PhoneNumber = @PhoneNumber";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@CompanyName", cobox店家名字.Text.Trim());
                cmd.Parameters.AddWithValue("@PhoneNumber", tb連絡電話.Text.Trim());
                cmd.Parameters.AddWithValue("@Comment", tb店家評價.Text.Trim());
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(string.Format("店家刪除完畢,共影響{0}筆資料", rows));
                顯示店家名字更新();
                cobox店家名字更新();

                cobox店家編號.Text = "";
                cobox店家名字.Text = "";
                tb連絡電話.Text = "";
                tb店家地址.Text = "";
                tb店家評價.Text = "";
            }
            else
            {
                MessageBox.Show("請選擇要刪除的店家");
            }
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.midedemoDataSet);

        }

        private void btn店家資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select *from Suppliers";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string str輸出 = "";
            int i = 0;

            while (reader.Read())//讀一筆往下跳一筆,用read方法讀資料
            {
                str輸出 += string.Format("{0},{1},{2},{3},{4}\n",
                    reader["CompanyName"], reader["Address"], reader["PhoneNumber"], reader["Comment"], reader["SupplierID"]);
                i += 1;
            }
            str輸出 += "資料筆數:" + i.ToString();
            reader.Close();
            con.Close();
            MessageBox.Show(str輸出);
        }

        private void btn新增產品_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "insert into Product values(@ProductID, @ProductName, @SupplierID,@Unitprice)";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ProductName", tb商品名稱.Text.Trim());
            cmd.Parameters.AddWithValue("@Unitprice", tb商品單價.Text.Trim());
            cmd.Parameters.AddWithValue("@ProductID", tb商品代號.Text.Trim());
            cmd.Parameters.AddWithValue("@SupplierID", tb店家編號.Text.Trim());
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            顯示商品名稱更新();
            MessageBox.Show(string.Format("商品新增完畢,共影響{0}筆資料", rows));
        }

        private void btn刪除商品_Click(object sender, EventArgs e)
        {
            if (tb商品名稱.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from Product where ProductName = @ProductName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ProductName", tb商品名稱.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                顯示商品名稱更新();
                MessageBox.Show(string.Format("商品刪除完畢,共影響{0}筆資料", rows));

                tb商品名稱.Text = "";
                tb商品單價.Text = "";
                tb商品代號.Text = "";
                tb店家編號.Text = "";


            }
            else
            {
                MessageBox.Show("請輸入商品名稱");
            }
        }

        private void btn商品資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select *from Product";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string str輸出 = "";
            int i = 0;

            while (reader.Read())//讀一筆往下跳一筆,用read方法讀資料
            {
                str輸出 += string.Format("{0},{1},{2}\n",
                    reader["ProductName"], reader["Unitprice"], reader["ProductID"], reader["SupplierID"]);
                i += 1;
            }
            str輸出 += "資料筆數:" + i.ToString();
            reader.Close();
            con.Close();
            MessageBox.Show(str輸出);
        }

        private void btn回訂購頁_Click(object sender, EventArgs e)
        {
            Form主頁 myForm主頁 = new Form主頁();
            this.Hide();
            myForm主頁.Show();
        }

        public void cobox店家名字更新()//有問題
        {
            cobox店家名字.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            string strSQL = "select CompanyName from Suppliers ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@CompanyName", cobox店家名字.Text.Trim());
           // cmd.Parameters.AddWithValue("@SupplierID", cobox店家編號.Text.Trim());
            SqlDataReader reader = cmd.ExecuteReader();
           

            while (reader.Read())
            {
                if (reader[0].ToString().Trim().Length >0)
                {
                    cobox店家名字.Items.Add(reader[0].ToString().Trim());
                }
                
            }

            con.Close();
        }


        private void cobox店家名字_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cobox店家名字更新();
            SqlConnection con2 = new SqlConnection(scsb.ToString());
            con2.Open();
            string strSQL2 = "select* from Suppliers where CompanyName = @selectCompanyName ";
            // comboBox學生.Items.Clear();
            SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
            cmd2.Parameters.AddWithValue("@selectCompanyName", cobox店家名字.SelectedItem);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                tb連絡電話.Text = string.Format("{0}", reader2["PhoneNumber"]);     
                cobox店家編號.Text = string.Format("{0}", reader2["SupplierID"]);
                
            }
            reader2.Close();
            con2.Close();

            
        }

        private void lb店家清單_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb商品清單.Items.Clear();
            if (lb店家清單.SelectedIndex >= 0)
            {
               // lb商品清單.Items.Clear();
                顯示商品名稱();
                SqlConnection con2 = new SqlConnection(scsb.ToString());
                con2.Open();
                string strSQL2 = "select * from Suppliers where CompanyName=@selectCompanyName";
                // comboBox學生.Items.Clear();
                SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
                cmd2.Parameters.AddWithValue("@selectCompanyName", lb店家清單.SelectedItem);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    cobox店家名字.Text = string.Format("{0}", reader2["CompanyName"]);
                    tb連絡電話.Text = string.Format("{0}", reader2["PhoneNumber"]);
                    tb店家地址.Text = string.Format("{0}", reader2["Address"]);
                    tb店家評價.Text = string.Format("{0}", reader2["Comment"]);
                    cobox店家編號.Text = string.Format("{0}", reader2["SupplierID"]);
                }
                
                reader2.Close();
                con2.Close();
            }
            else
            {

            }
        }

        private void lb商品清單_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb店家清單.SelectedIndex >= 0)
            {
                SqlConnection con2 = new SqlConnection(scsb.ToString());
                con2.Open();
                string strSQL2 = "select * from Product where ProductName=@selectProductName ";
                // comboBox學生.Items.Clear();
                SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
                cmd2.Parameters.AddWithValue("@selectProductName", lb商品清單.SelectedItem);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    tb商品名稱.Text = string.Format("{0}", reader2["ProductName"]);
                    tb商品單價.Text = string.Format("{0}", reader2["Unitprice"]);
                    tb商品代號.Text = string.Format("{0}", reader2["ProductID"]);
                    tb店家編號.Text = string.Format("{0}", reader2["SupplierID"]);
                }
                reader2.Close();
                con2.Close();
            }
            else
            {

            }
        }
        private void btn修改商品資訊_Click(object sender, EventArgs e)
        {
            if (tb商品名稱.Text.Length > 0 && tb商品代號.MaxLength > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update  Product set  ProductName=@商品名稱,Unitprice=@商品單價,SupplierID=@店家編號 where ProductID=@被改商品代號";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                //可以更動的資料
                cmd.Parameters.AddWithValue("@商品名稱", tb商品名稱.Text.Trim());
                cmd.Parameters.AddWithValue("@商品單價", tb商品單價.Text.Trim());
                cmd.Parameters.AddWithValue("@被改商品代號",tb商品代號.Text.Trim());
                cmd.Parameters.AddWithValue("@店家編號", tb店家編號.Text.Trim());



                int rows = cmd.ExecuteNonQuery();
                con.Close();
                顯示商品名稱更新();
                MessageBox.Show(string.Format("商品資料修改完畢,共影響{0}筆資料", rows));

                tb商品名稱.Text = "";
                tb商品代號.Text = "";
                tb店家編號.Text = "";
                tb商品單價.Text = "";

            }
            else
            {
                MessageBox.Show("請選擇要修改的店家");
            }
        }

        private void btn修改店家資訊_Click(object sender, EventArgs e)
        {
            if (cobox店家名字.SelectedIndex >= 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update Suppliers set CompanyName=@店家名字,PhoneNumber=@連絡電話,Address=@店家地址,Comment=@店家評價 where SupplierID=@被改店家編號";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                //可以更動的資料
                cmd.Parameters.AddWithValue("@被改店家編號", cobox店家編號.Text.Trim());
                cmd.Parameters.AddWithValue("@店家名字", cobox店家名字.Text.Trim());
                cmd.Parameters.AddWithValue("@連絡電話", tb連絡電話.Text.Trim());
                cmd.Parameters.AddWithValue("@店家地址", tb店家地址.Text.Trim());
                cmd.Parameters.AddWithValue("@店家評價", tb店家評價.Text.Trim());
                
              

                
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                顯示店家名字更新();
                MessageBox.Show(string.Format("店家資料修改完畢,共影響{0}筆資料", rows));

                cobox店家名字.Text = "";
                cobox店家編號.Text = "";
                tb連絡電話.Text = "";
                tb店家地址.Text = "";
                tb店家評價.Text = "";
               
            }
            else
            {
                MessageBox.Show("請選擇要修改的店家");
            }
        }
    }

       
    }

