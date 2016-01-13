namespace DatabaseDemo.Teacher
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_modifypw = new System.Windows.Forms.Button();
            this.bt_class = new System.Windows.Forms.Button();
            this.bt_course = new System.Windows.Forms.Button();
            this.bt_userinfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(544, 231);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(75, 23);
            this.bt_logout.TabIndex = 13;
            this.bt_logout.Text = "注销";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_modifypw
            // 
            this.bt_modifypw.Location = new System.Drawing.Point(454, 231);
            this.bt_modifypw.Name = "bt_modifypw";
            this.bt_modifypw.Size = new System.Drawing.Size(75, 23);
            this.bt_modifypw.TabIndex = 12;
            this.bt_modifypw.Text = "修改密码";
            this.bt_modifypw.UseVisualStyleBackColor = true;
            this.bt_modifypw.Click += new System.EventHandler(this.bt_modifypw_Click);
            // 
            // bt_class
            // 
            this.bt_class.Location = new System.Drawing.Point(241, 231);
            this.bt_class.Name = "bt_class";
            this.bt_class.Size = new System.Drawing.Size(75, 23);
            this.bt_class.TabIndex = 10;
            this.bt_class.Text = "平均成绩";
            this.bt_class.UseVisualStyleBackColor = true;
            this.bt_class.Click += new System.EventHandler(this.bt_class_Click);
            // 
            // bt_course
            // 
            this.bt_course.Location = new System.Drawing.Point(140, 231);
            this.bt_course.Name = "bt_course";
            this.bt_course.Size = new System.Drawing.Size(75, 23);
            this.bt_course.TabIndex = 9;
            this.bt_course.Text = "任课查询";
            this.bt_course.UseVisualStyleBackColor = true;
            this.bt_course.Click += new System.EventHandler(this.bt_course_Click);
            // 
            // bt_userinfo
            // 
            this.bt_userinfo.Location = new System.Drawing.Point(50, 231);
            this.bt_userinfo.Name = "bt_userinfo";
            this.bt_userinfo.Size = new System.Drawing.Size(75, 23);
            this.bt_userinfo.TabIndex = 8;
            this.bt_userinfo.Text = "个人信息";
            this.bt_userinfo.UseVisualStyleBackColor = true;
            this.bt_userinfo.Click += new System.EventHandler(this.bt_userinfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(254, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "教师信息管理";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "录入成绩";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 318);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "教师编号：";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 340);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.bt_modifypw);
            this.Controls.Add(this.bt_class);
            this.Controls.Add(this.bt_course);
            this.Controls.Add(this.bt_userinfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TeacherForm";
            this.Text = "教师信息窗口";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_modifypw;
        private System.Windows.Forms.Button bt_class;
        private System.Windows.Forms.Button bt_course;
        private System.Windows.Forms.Button bt_userinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}