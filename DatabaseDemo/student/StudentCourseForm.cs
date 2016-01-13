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
    public partial class StudentCourseForm : Form
    {
        string username;
        DataSet dataset;
        DataTable dt;
        SqlDataAdapter dataAdapter;

        public StudentCourseForm(string username)
        {
            this.username = username;
            InitializeComponent();
            init();
        }

        public void init()
        {
            dataset = new DataSet();
            connectToServer();
            dataGridView1.DataSource = dt;

        }

        private void connectToServer()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();


                StringBuilder builder = new StringBuilder();
                builder.Append("select 课程.* from 课程,学习 where 学习.学生学号 = '"+username+"' and 学习.课程编号 = 课程.课程编号");
                dataAdapter = new SqlDataAdapter(builder.ToString(), conn);

                dataAdapter.Fill(dataset);
                dt = dataset.Tables[0];
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
