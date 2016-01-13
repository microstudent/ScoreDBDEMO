using DatabaseDemo.administrator;
using DatabaseDemo.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDemo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            cb_userType.SelectedIndex = 0;
            
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            login(tb_username.Text, tb_password.Text);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login(string username, string pw)
        {
            SqlConnectionStringBuilder sqlbuilder = new SqlConnectionStringBuilder();
            sqlbuilder.DataSource = "localhost";
            sqlbuilder.InitialCatalog = "scoreDB";   //数据库名
            sqlbuilder.IntegratedSecurity = true;

            using (SqlConnection connection = new SqlConnection())
            {
                try
                {
                    connection.ConnectionString = sqlbuilder.ConnectionString;
                    connection.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show("连接至服务器失败，请检查连接.\n" + e.ToString(), "连接错误");
                }

                if (connection.State != ConnectionState.Open)
                {
                    MessageBox.Show("连接至服务器失败，请检查连接.", "连接错误");
                    return;
                }


                StringBuilder builder = new StringBuilder();
                builder.Append("select * from "+cb_userType.Text+"账号 where "+cb_userType.Text+"编号 = ");
                builder.Append("@users_name ");
                builder.Append("and 密码 = ");
                builder.Append("@users_pw");
                SqlParameter para1 = new SqlParameter("@users_name", SqlDbType.Char);
                SqlParameter para2 = new SqlParameter("@users_pw", SqlDbType.Char);

                para1.Value = username;
                para2.Value = pw;

                SqlCommand cmd = new SqlCommand(builder.ToString(), connection);

                cmd.Parameters.Add(para1);
                cmd.Parameters.Add(para2);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    showForm(username);
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "错误");
                }
            }
        }

        private void showForm(string username)
        {
            if(cb_userType.SelectedIndex == 0)
            {
                //学生
                Thread ShowMainThread = new Thread(new ThreadStart(delegate { System.Windows.Forms.Application.Run(new studentForm(username)); }));
                ShowMainThread.SetApartmentState(ApartmentState.STA);
                ShowMainThread.Start();
                this.Close();
            }
            else
            {
                if(cb_userType.SelectedIndex == 1)
                {
                    //教师
                    Thread ShowMainThread = new Thread(new ThreadStart(delegate { System.Windows.Forms.Application.Run(new TeacherForm(username)); }));
                    ShowMainThread.SetApartmentState(ApartmentState.STA);
                    ShowMainThread.Start();
                    this.Close();
                }
                else
                {
                    //管理员
                    Thread ShowMainThread = new Thread(new ThreadStart(delegate { System.Windows.Forms.Application.Run(new AdminForm(username)); }));
                    ShowMainThread.SetApartmentState(ApartmentState.STA);
                    ShowMainThread.Start();
                    this.Close();
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tb_username.Focus();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            tb_username.Focus();
        }

        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tb_password.Focus();
            }
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bt_login.PerformClick();
            }
        }
    }
}
