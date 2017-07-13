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
    public partial class 學生資料 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(@"Data Source=CR1-21;Initial Catalog=C:\USERS\III\DESKTOP\WINDOWSFORMSAPPLICATION便當訂購系統(9.78版)\MIDEDEMO.MDF;Integrated Security=True");
        List<object> change = new List<object>();
        public 學生資料()
        {
            InitializeComponent();
        }

        private void 學生資料_Load(object sender, EventArgs e)
        {
            顯示學生姓名();
           /* SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select distinct class from [t & s] ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox教室.Items.Add(string.Format("{0}", reader["class"]));
            }
            reader.Close();
            con.Close();*/

            /*scsb = new SqlConnectionStringBuilder();

            scsb.UserID = "";
            scsb.Password = "";

            scsb.DataSource = @"(LocalDB)\MSSQLLocalDB";
            scsb.AttachDBFilename = @"|DataDirectory|\midedemo.mdf";*/
        }
        public void 顯示學生姓名()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select StudentName from Student ";//模糊搜尋用like
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lb學生清單.Items.Add(reader[0].ToString());
            }
        }
        public void 顯示學生清單更新()
        {
            lb學生清單.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select StudentName from Student";//模糊搜尋用like
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lb學生清單.Items.Add(reader[0].ToString());
            }
        }

        /*  if (reader.Read())
          {
              tb店家代號.Text = string.Format("{0}", reader["shop_id"]);
              tb店名.Text = string.Format("{0}", reader["shop_name"]);
              tb店家地址.Text = string.Format("{0}", reader["shop_address"]);
              tb店家電話.Text = string.Format("{0}", reader["shop_tel"]);
          }*/

        private void btn新增學生資料_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "insert into Student values(@StudentID,@Gender,@Phone,@Classrom, @Birthday, @StudentName)";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@studentID", tb學生編號.Text.Trim()); 
            cmd.Parameters.AddWithValue("@Gender", tb性別.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", tb連絡電話.Text.Trim());//Trim去除空白字元
            cmd.Parameters.AddWithValue("@Classrom", tb教室.Text.Trim());
            cmd.Parameters.AddWithValue("@Birthday", tb生日.Text.Trim());
            cmd.Parameters.AddWithValue("@StudentName", tb學生姓名.Text.Trim());
          
            
            int rows = cmd.ExecuteNonQuery();
            顯示學生清單更新();
            con.Close();
            MessageBox.Show(string.Format("學生成員新增完畢,共影響{0}筆資料", rows));
        }

        private void btn刪除學生資料_Click(object sender, EventArgs e)
        {
            if (tb學生姓名.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from Student where StudentName = @StudentName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Student_StudentName", tb學生姓名.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(string.Format("學生成員刪除完畢,共影響{0}筆資料", rows));

                tb學生姓名.Text = "";
                tb教室.Text = "";
                tb學生編號.Text = "";
                tb連絡電話.Text = "";
                tb性別.Text = "";
                tb生日.Text = "";


            }
            else
            {
                MessageBox.Show("請輸入學生成員");
            }
        }

        private void btn學生資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select *from Student";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string str輸出 = "";
            int i = 0;

            while (reader.Read())//讀一筆往下跳一筆,用read方法讀資料
            {
                str輸出 += string.Format("{0},{1},{2},{3},{4},{5}\n",
                     reader["Classrom"], reader["StudentID"], reader["StudentName"], reader["Gender"], reader["Phone"], reader["Birthday"]);
                i += 1;
            }
            str輸出 += "學生資料筆數共:" + i.ToString();
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

        
        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.midedemoDataSet);

        }

        private void lb學生清單_SelectedIndexChanged_1(object sender, EventArgs e)//有問題
        {
            if (lb學生清單.SelectedIndex >= 0)
            {
                SqlConnection con2 = new SqlConnection(scsb.ToString());
                con2.Open();
                string strSQL2 = "select * from Student where StudentName=@selectStudentName ";
                // comboBox學生.Items.Clear();
                SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
                cmd2.Parameters.AddWithValue("@selectStudentName", lb學生清單.SelectedItem);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    tb教室.Text = string.Format("{0}", reader2["Classrom"]);
                    tb學生編號.Text = string.Format("{0}", reader2["StudentID"]);
                    tb學生姓名.Text = string.Format("{0}", reader2["StudentName"]);
                    tb性別.Text = string.Format("{0}", reader2["Gender"]);
                    tb連絡電話.Text = string.Format("{0}", reader2["Phone"]);
                    tb生日.Text = string.Format("{0}", reader2["Birthday"]);
                }
                reader2.Close();
                顯示學生清單更新();
                con2.Close();
            }
            else
            {

            }
        }

        private void btn修改學生資料_Click(object sender, EventArgs e)
        {
            if (tb學生姓名.Text.Length > 0 && tb學生編號.MaxLength > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update Student set  Gender=@性別,Classrom=@教室,Phone=@連絡電話,StudentName=@姓名,Birthday=@生日 where StudentID=@被改學生編號 ";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                //可以更動的資料
                cmd.Parameters.AddWithValue("@被改學生編號", tb學生編號.Text.Trim());
                cmd.Parameters.AddWithValue("@性別", tb性別.Text.Trim());
                cmd.Parameters.AddWithValue("@教室", tb教室.Text.Trim());
                cmd.Parameters.AddWithValue("@連絡電話", tb連絡電話.Text.Trim());
                cmd.Parameters.AddWithValue("@生日", tb生日.Text.Trim());
                cmd.Parameters.AddWithValue("@姓名", tb學生姓名.Text.Trim());                                          

                //原本對象的資料
                
                /*cmd.Parameters.AddWithValue("@被改性別", change[1].ToString());
                cmd.Parameters.AddWithValue("@被改連絡電話", change[2].ToString());
                cmd.Parameters.AddWithValue("@被改教室", change[3].ToString());
                cmd.Parameters.AddWithValue("@被改生日", change[4].ToString());
                cmd.Parameters.AddWithValue("@被改姓名", change[5].ToString());*/
              
               


                int rows = cmd.ExecuteNonQuery();
                con.Close();
                顯示學生清單更新();
                MessageBox.Show(string.Format("學生資料修改完畢,共影響{0}筆資料", rows));

                tb學生姓名.Text = "";
                tb學生編號.Text = "";
                tb教室.Text = "";
                tb性別.Text = "";
                tb連絡電話.Text = "";
                tb生日.Text = "";
            }
            else
            {
                MessageBox.Show("請選擇要修改的對象");
            }
        }
    }
}
