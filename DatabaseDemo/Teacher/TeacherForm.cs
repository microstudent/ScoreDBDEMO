using DatabaseDemo.student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDemo.Teacher
{
    public partial class TeacherForm : Form
    {
        string username;
        public TeacherForm(string username)
        {
            InitializeComponent();
            this.username = username;
            toolStripStatusLabel1.Text += username;
        }

        private void bt_userinfo_Click(object sender, EventArgs e)
        {
            TeacherInfoForm form = new TeacherInfoForm(username);
            form.ShowDialog();
        }

        private void bt_course_Click(object sender, EventArgs e)
        {
            TeacherCourseForm form = new TeacherCourseForm(username);
            form.ShowDialog();

        }

        private void bt_class_Click(object sender, EventArgs e)
        {
            AvgScoreForm form = new AvgScoreForm(username);
            form.ShowDialog();
        }

        private void bt_modifypw_Click(object sender, EventArgs e)
        {
            ModifyPwForm form = new ModifyPwForm();
            form.ShowDialog();
        }


        private void bt_logout_Click(object sender, EventArgs e)
        {
            Thread ShowMainThread = new Thread(
                new ThreadStart(delegate { System.Windows.Forms.Application.Run(new LoginForm()); }));
            ShowMainThread.SetApartmentState(ApartmentState.STA);
            ShowMainThread.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScoreInputForm form = new ScoreInputForm(username);
            form.ShowDialog();
        }
    }
}
