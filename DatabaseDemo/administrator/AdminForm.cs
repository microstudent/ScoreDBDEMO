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

namespace DatabaseDemo.administrator
{
    public partial class AdminForm : Form
    {
        string username;

        public AdminForm(string username)
        {
            InitializeComponent();
            this.username = username;
            label.Text += username;
        }

        private void bt_teacher_Click(object sender, EventArgs e)
        {
            TeacherManagerForm form = new TeacherManagerForm(username);
            form.ShowDialog();
        }

        private void bt_student_Click(object sender, EventArgs e)
        {
            StudentManagerForm form = new StudentManagerForm(username);
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
