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
    public partial class TeacherCourseForm : Form
    {

        DataTable dataTable = new DataTable();
        SqlDataAdapter dataAdapter;
        string username;

        public TeacherCourseForm(string username)
        {
            InitializeComponent();
            this.username = username;
            init();
        }

        private void init()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();


                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM 教师任课查询 where ");
                builder.Append("教师编号 = '" + username + "' and 学期 LIKE '"+comboBox1.Text+"%'");
                dataAdapter = new SqlDataAdapter(builder.ToString(), conn);

                dataAdapter.Fill(dataTable);

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
            dataTable.Clear();
            init();
            dataGridView1.DataSource = dataTable;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
