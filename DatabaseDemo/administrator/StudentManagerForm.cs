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

namespace DatabaseDemo.administrator
{
    public partial class StudentManagerForm : Form
    {
        string username;

        SqlDataAdapter dataAdapter;
        DataTable dataTable = new DataTable();    //当前的表

        public StudentManagerForm(string username)
        {
            InitializeComponent();

            this.username = username;

            connectToServer();

            dataGridView1.DataSource = dataTable.Clone();
        }


        private void connectToServer()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from 学生", conn);

                dataAdapter.Fill(dataTable);
                SqlCommandBuilder cmdBuilder1 = new SqlCommandBuilder(dataAdapter);
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
            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = dataTable.NewRow();
                row["学生学号"] = tb_sno.Text;
                row["学生姓名"] = tb_name.Text;
                row["学生性别"] = tb_sex.Text;
                row["学生年龄"] = Convert.ToInt32(tb_age.Text);
                row["生源所在地"] = tb_source.Text;
                row["班级编号"] = tb_classno.Text;
                dataTable.Rows.Add(row);
                dataAdapter.Update(dataTable);
                MessageBox.Show("增加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(dataTable);
                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
