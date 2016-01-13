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

namespace DatabaseDemo
{
    public partial class studentForm : Form
    {
        string username;
        public studentForm(string username)
        {
            InitializeComponent();
            this.username = username;
            toolStripStatusLabel1.Text += username;
        }

        private void bt_userinfo_Click(object sender, EventArgs e)
        {
            StudentInfoForm form = new StudentInfoForm(username);
            form.ShowDialog();
        }

        private void bt_course_Click(object sender, EventArgs e)
        {
            StudentCourseForm form = new StudentCourseForm(username);
            form.ShowDialog();
        }

        private void bt_class_Click(object sender, EventArgs e)
        {
            ClassCourseForm form = new ClassCourseForm();
            form.ShowDialog();
        }

        private void bt_score_Click(object sender, EventArgs e)
        {
            ScoreForm form = new ScoreForm(username);

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
    }
}
