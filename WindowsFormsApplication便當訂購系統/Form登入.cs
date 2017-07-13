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
   

    public partial class Form登入 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(@"Data Source=CR1-21;Initial Catalog=C:\USERS\III\DESKTOP\WINDOWSFORMSAPPLICATION便當訂購系統(9.78版)\MIDEDEMO.MDF;Integrated Security=True");
        public Form登入()
        {
            InitializeComponent();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            string str帳號 = "";
            string str密碼 = "";
            string str訊息 = "";

            str帳號 = tb帳號.Text;
            str密碼 = tb密碼.Text;

            string strUser1 = "student";
            string strPassword = "1234";
            string strUser2 = "counter";
            string strPassword2 = "1234";



            if ((str帳號 == "") || (str密碼 == ""))
            {
                str訊息 = "帳號密碼請勿空白";
            }
            else
            {
                if ((str帳號 == strUser1) && (str密碼 == strPassword))
                {
                    //比對成功
                    str訊息 = str訊息 + "歡迎使用本系統\n";

                    Form主頁 myForm主頁 = new Form主頁();
                    this.Hide();
                    myForm主頁.Show();

                }


                else
                {
                    //比對失敗
                    if (str帳號 != strUser1)
                    {
                        str訊息 += "您登入的帳號有誤";
                    }
                    else
                    {
                        str訊息 += "您輸入的密碼有誤";
                    }
                }
                if ((str帳號 == strUser2) && (str密碼 == strPassword2))
                {
                    //比對成功
                    str訊息 = str訊息 + "歡迎使用本系統\n";

                    櫃台訂單 myForm主頁1 = new 櫃台訂單();
                    this.Hide();
                    myForm主頁1.Show();
                }
                else
                {
                    if (str帳號 != strUser2)
                    {
                        str訊息 += "您登入的帳號有誤";
                    }
                    else
                    {
                        str訊息 += "您輸入的密碼有誤";
                    }
                }
            }
            lbl訊息.Text = str訊息;
        }

        private void btn重置_Click(object sender, EventArgs e)
        {
            tb帳號.Text = "";
            tb密碼.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb帳號.Text = "student";
            tb密碼.Text = "1234";
        }

        private void Form登入_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb時間.Text = DateTime.Now.ToString();
        }
    }
   
}
