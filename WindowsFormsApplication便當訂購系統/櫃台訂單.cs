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
    public partial class 櫃台訂單 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(@"Data Source=CR1-21;Initial Catalog=C:\USERS\III\DESKTOP\WINDOWSFORMSAPPLICATION便當訂購系統(9.78版)\MIDEDEMO.MDF;Integrated Security=True");
        public 櫃台訂單()
        {
            InitializeComponent();
        }

       
        private void 櫃台訂單_Load(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();               
            string strSQLindex = "select * from [Order detail] where day(Orderdate)=day(getdate())";
            SqlCommand cmdindex = new SqlCommand(strSQLindex, con);
            SqlDataReader reader = cmdindex.ExecuteReader();

            while (reader.Read())
            {

                ListViewItem item = new ListViewItem(reader["OrderID"].ToString());
                item.SubItems.Add(reader["ProductName"].ToString());
                item.SubItems.Add(reader["Unitprice"].ToString());
                item.SubItems.Add(reader["Quantity"].ToString());
                item.SubItems.Add(reader["Orderdate"].ToString());
                item.SubItems.Add(reader["SupplierName"].ToString());
                item.SubItems.Add(reader["Sum"].ToString());
                item.SubItems.Add(reader["StudentName"].ToString());
                item.SubItems.Add(reader["PhoneNumber"].ToString());
              
                if (reader["Classrom"].ToString() == "1")
                {
                    listView1.Items.Add(item);
                    tb餐廳名稱1.Text = string.Format("{0}", reader["SupplierName"]);
                    tb連絡電話1.Text = string.Format("{0}", reader["PhoneNumber"]);
                    tb值日生1.Text= string.Format("{0}", reader["StudentName"]);
                    tb總金額1.Text= string.Format("{0}", reader["Sum"]);
                }
                if (reader["Classrom"].ToString() == "2")
                {
                    listView2.Items.Add(item);
                    tb餐廳名稱2.Text = string.Format("{0}", reader["SupplierName"]);
                    tb連絡電話2.Text = string.Format("{0}", reader["PhoneNumber"]);
                    tb值日生2.Text = string.Format("{0}", reader["StudentName"]);
                    tb總金額2.Text = string.Format("{0}", reader["Sum"]);
                }
                if (reader["Classrom"].ToString() == "3")
                {
                    listView3.Items.Add(item);
                    tb餐廳名稱3.Text = string.Format("{0}", reader["SupplierName"]);
                    tb連絡電話3.Text = string.Format("{0}", reader["PhoneNumber"]);
                    tb值日生3.Text = string.Format("{0}", reader["StudentName"]);
                    tb總金額3.Text = string.Format("{0}", reader["Sum"]);
                }
                if (reader["Classrom"].ToString() == "4")
                {
                    listView4.Items.Add(item);
                    tb餐廳名稱4.Text = string.Format("{0}", reader["SupplierName"]);
                    tb連絡電話4.Text = string.Format("{0}", reader["PhoneNumber"]);
                    tb值日生4.Text = string.Format("{0}", reader["StudentName"]);
                    tb總金額4.Text = string.Format("{0}", reader["Sum"]);
                }

            }
            reader.Close();
            con.Close();


        }

        private void btn修改訂單_Click(object sender, EventArgs e)
        {
            Form主頁 myForm主頁 = new Form主頁();
            this.Hide();
            myForm主頁.Show();
        }

        private void btn返回登入頁_Click(object sender, EventArgs e)
        {
            Form登入 myForm主頁 = new Form登入();
            this.Hide();
            myForm主頁.Show();
        }
    }
}
