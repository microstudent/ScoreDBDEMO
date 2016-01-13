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
    public partial class AvgScoreForm : Form
    {

        DataTable dataTable = new DataTable();
        SqlDataAdapter dataAdapter;
        string username;

        public AvgScoreForm(string username)
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
                builder.Append("SELECT 每门课程平均成绩.* FROM 每门课程平均成绩,授课 ");
                builder.Append("where 每门课程平均成绩.课程编号 = 授课.课程编号 and ");
                builder.Append("授课.教师编号 = '" + username + "'");
                dataAdapter = new SqlDataAdapter(builder.ToString(), conn);

                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
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
            DialogResult = DialogResult.OK;
        }
    }
}
