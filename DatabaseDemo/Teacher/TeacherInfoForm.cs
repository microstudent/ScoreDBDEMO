using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDemo.Teacher
{
    public partial class TeacherInfoForm : Form
    {
        string username;

        public TeacherInfoForm(string username)
        {
            InitializeComponent();
            this.username = username;
            init();
        }


        public void init()
        {
            connectToServer(username);
            bt.Focus();
        }


        private void connectToServer(string username)
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();

                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM 教师 WHERE 教师编号= '" + username + "'");

                SqlCommand cmd = new SqlCommand(builder.ToString(), conn);

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                tb_age.Text = reader.GetInt32(3).ToString();
                tb_name.Text = reader.GetString(1);
                tb_jobtitle.Text = reader.GetString(4);
                tb_phone.Text = reader.GetString(5);
                tb_sex.Text = reader.GetString(2);
                tb_tno.Text = reader.GetString(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("连接至服务器失败，请检查连接！错误：" + e.ToString(), "错误");
            }
            finally
            {
                conn.Close();
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
