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
    public partial class ScoreInputForm : Form
    {
        string username;

        SqlDataAdapter dataAdapter;
        SqlDataAdapter studyAdapter;
        DataTable dataTable = new DataTable();    //当前的表

        DataSet dataset = new DataSet();

        public ScoreInputForm(string username)
        {
            InitializeComponent();

            this.username = username;

            connectToServer();

            dataGridView1.DataSource = dataTable;
        }

        private void connectToServer()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();

                dataAdapter = new SqlDataAdapter("SELECT * from 学生成绩统计", conn);

                dataAdapter.Fill(dataTable);

                studyAdapter = new SqlDataAdapter("SELECT * FROM 学习",conn);
                studyAdapter.Fill(dataset,"学习");

                SqlCommandBuilder cmdBuilder1 = new SqlCommandBuilder(dataAdapter);
                SqlCommandBuilder cmdBuilder2 = new SqlCommandBuilder(studyAdapter);

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
            StringBuilder builder = new StringBuilder();
            int year = DateTime.Now.Year;
            builder.Append(year.ToString());
            builder.Append("/");
            builder.Append((year + 1).ToString());
            if(DateTime.Now.Month >=9|| DateTime.Now.Month <= 1)
            {
                builder.Append("(1)");
            }
            else
            {
                builder.Append("(2)");
            }

            string courseName = "",teacherName = "";
            SqlConnection conn = Connection.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from 课程 where 课程编号 = '"+tb_cono.Text+"'",conn);
                SqlDataReader reader =  cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    courseName = reader.GetString(1);
                    teacherName = reader.GetString(2);
                }
                else
                {
                    MessageBox.Show("课程号出错");
                }
                reader.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            try
            {
                DataRow row = dataset.Tables["学习"].NewRow();
                row["课程编号"] = tb_cono.Text;
                row["学生学号"] = tb_sno.Text;
                row["学期"] = builder.ToString();
                row["课程名称"] = courseName;
                row["成绩"] = tb_score.Text;
                row["教师姓名"] = teacherName;
                dataset.Tables[0].Rows.Add(row);
                studyAdapter.Update(dataset,"学习");
                MessageBox.Show("增加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("插入出错，请检查是否重复插入数据！");
            }
        }
    }
}
