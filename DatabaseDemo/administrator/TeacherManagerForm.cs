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
    public partial class TeacherManagerForm : Form
    {
        string username;

        SqlDataAdapter dataAdapter;
        DataTable dataTable = new DataTable();    //当前的表

        public TeacherManagerForm(string username) 
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
                dataAdapter = new SqlDataAdapter("SELECT * from 教师", conn);

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
                row["教师编号"] = tb_tno.Text;
                row["教师姓名"] = tb_name.Text;
                row["教师性别"] = tb_sex.Text;
                row["教师年龄"] = Convert.ToInt32(tb_age.Text);
                row["职称"] = tb_jobtitle.Text;
                row["联系电话"] = tb_phone.Text;
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
