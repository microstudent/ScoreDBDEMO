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

namespace DatabaseDemo
{
    public partial class StudentInfoForm : Form
    {
        string username;

        public StudentInfoForm(string username)
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

        private void bt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void connectToServer(string username)
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();


                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM 学生 WHERE 学生学号= '" + username + "'");

                SqlCommand cmd = new SqlCommand(builder.ToString(), conn);

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                tb_sno.Text = reader.GetString(0);
                tb_name.Text = reader.GetString(1);
                tb_source.Text = reader.GetString(4);
                tb_age.Text = reader.GetInt32(3).ToString();
                tb_classno.Text = reader.GetString(6);
                tb_xuefen.Text = reader.GetInt32(5).ToString();
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
    }
}
