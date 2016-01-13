using DatabaseDemo.administrator;
using DatabaseDemo.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new studentForm("3113001234"));
            //Application.Run(new TeacherForm("t01"));
            //Application.Run(new AdminForm("admin"));
        }
    }
}
