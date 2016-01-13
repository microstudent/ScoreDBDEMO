using System;
using System.Collections;
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
    public partial class ClassCourseForm : Form
    {
        DataTable dataTable = new DataTable();
        SqlDataAdapter dataAdapter;

        public ClassCourseForm()
        {
            InitializeComponent();

            init();
        }

        private void init()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();


                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM 课程");
                dataAdapter = new SqlDataAdapter(builder.ToString(), conn);

                dataAdapter.Fill(dataTable);

                ArrayList cnoList = new ArrayList();
                foreach(DataRow row in dataTable.Rows)
                {
                    cnoList.Add(row["课程编号"]);
                }
                comboBox1.DataSource = cnoList;
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

        private void select(string cno)
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();

                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM 课程 Where ");
                builder.Append(" 课程编号 = '" + comboBox1.Text + "'");
                SqlDataAdapter da = new SqlDataAdapter(builder.ToString(), conn);

                dataTable.Clear();

                da.Fill(dataTable);
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
            select(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
