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

namespace DatabaseDemo.student
{
    public partial class ModifyPwForm : Form
    {
        SqlDataAdapter stuAdapter, teacherAdapter, adminAdapter;

        DataSet dataset = new DataSet();

        public ModifyPwForm()
        {
            InitializeComponent();
            connectToServer();
        }

        private void connectToServer()
        {
            SqlConnection conn = Connection.getConnection();

            try
            {
                conn.Open();
                stuAdapter = new SqlDataAdapter("SELECT * from 学生账号", conn);
                teacherAdapter = new SqlDataAdapter("SELECT * from 教师账号", conn);
                adminAdapter = new SqlDataAdapter("SELECT * from 管理员账号", conn);

                stuAdapter.Fill(dataset, "student");
                teacherAdapter.Fill(dataset, "teacher");
                adminAdapter.Fill(dataset, "admin");

                SqlCommandBuilder cmdBuilder1 = new SqlCommandBuilder(stuAdapter);
                SqlCommandBuilder cmdBuilder2 = new SqlCommandBuilder(adminAdapter);
                SqlCommandBuilder cmdBuilder3 = new SqlCommandBuilder(teacherAdapter);

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
            if (!check())
            {
                MessageBox.Show("两次密码不一样，请检查");
            }
            DataRow[] rows;
            switch (comboBox1.Text)
            {
                case "学生":
                    rows = dataset.Tables["student"].Select("学生编号 = '" + tb_username.Text + "'");
                    if (rows.Count() == 1)
                    {
                        if (string.Compare(rows[0]["密码"].ToString(), tb_oldpw.Text) == 0)
                        {
                            rows[0]["密码"] = tb_newpw2.Text;
                            stuAdapter.Update(dataset, "student");

                            MessageBox.Show("修改成功");
                        }
                        else
                        {
                            MessageBox.Show("旧密码输入错误");
                        }
                    }
                    else
                    {
                        MessageBox.Show("无此用户名");
                    }
                    break;
                case "教师":
                    rows = dataset.Tables["teacher"].Select("教师编号 = '" + tb_username.Text + "'");
                    if (rows.Count() == 1)
                    {
                        if (string.Compare(rows[0]["密码"].ToString(), tb_oldpw.Text) == 0)
                        {
                            rows[0]["密码"] = tb_newpw2.Text;
                            teacherAdapter.Update(dataset, "teacher");

                            MessageBox.Show("修改成功");
                        }
                        else
                        {
                            MessageBox.Show("旧密码输入错误");
                        }
                    }
                    else
                    {
                        MessageBox.Show("无此用户名");
                    }
                    break;
                case "管理员":
                    rows = dataset.Tables["admin"].Select("管理员编号 = '" + tb_username.Text + "'");
                    if (rows.Count() == 1)
                    {
                        if (string.Compare(rows[0]["密码"].ToString(), tb_oldpw.Text) == 0)
                        {
                            rows[0]["密码"] = tb_newpw2.Text;
                            adminAdapter.Update(dataset, "admin");

                            MessageBox.Show("修改成功");
                        }
                        else
                        {
                            MessageBox.Show("旧密码输入错误");
                        }
                    }
                    else
                    {
                        MessageBox.Show("无此用户名");
                    }
                    break;
            }           

        }

        private bool check()
        {
            if (string.Compare(tb_newpw.Text, tb_newpw2.Text) != 0)
            {
                return false;
            }
            return true;
        }
    }
}
