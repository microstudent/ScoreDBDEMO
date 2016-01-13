namespace DatabaseDemo
{
    partial class studentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_userinfo = new System.Windows.Forms.Button();
            this.bt_course = new System.Windows.Forms.Button();
            this.bt_class = new System.Windows.Forms.Button();
            this.bt_score = new System.Windows.Forms.Button();
            this.bt_modifypw = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(213, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生信息管理";
            // 
            // bt_userinfo
            // 
            this.bt_userinfo.Location = new System.Drawing.Point(29, 207);
            this.bt_userinfo.Name = "bt_userinfo";
            this.bt_userinfo.Size = new System.Drawing.Size(75, 23);
            this.bt_userinfo.TabIndex = 1;
            this.bt_userinfo.Text = "个人信息";
            this.bt_userinfo.UseVisualStyleBackColor = true;
            this.bt_userinfo.Click += new System.EventHandler(this.bt_userinfo_Click);
            // 
            // bt_course
            // 
            this.bt_course.Location = new System.Drawing.Point(119, 207);
            this.bt_course.Name = "bt_course";
            this.bt_course.Size = new System.Drawing.Size(75, 23);
            this.bt_course.TabIndex = 2;
            this.bt_course.Text = "课程查询";
            this.bt_course.UseVisualStyleBackColor = true;
            this.bt_course.Click += new System.EventHandler(this.bt_course_Click);
            // 
            // bt_class
            // 
            this.bt_class.Location = new System.Drawing.Point(209, 207);
            this.bt_class.Name = "bt_class";
            this.bt_class.Size = new System.Drawing.Size(75, 23);
            this.bt_class.TabIndex = 3;
            this.bt_class.Text = "班级开课";
            this.bt_class.UseVisualStyleBackColor = true;
            this.bt_class.Click += new System.EventHandler(this.bt_class_Click);
            // 
            // bt_score
            // 
            this.bt_score.Location = new System.Drawing.Point(299, 207);
            this.bt_score.Name = "bt_score";
            this.bt_score.Size = new System.Drawing.Size(75, 23);
            this.bt_score.TabIndex = 4;
            this.bt_score.Text = "成绩查询";
            this.bt_score.UseVisualStyleBackColor = true;
            this.bt_score.Click += new System.EventHandler(this.bt_score_Click);
            // 
            // bt_modifypw
            // 
            this.bt_modifypw.Location = new System.Drawing.Point(389, 207);
            this.bt_modifypw.Name = "bt_modifypw";
            this.bt_modifypw.Size = new System.Drawing.Size(75, 23);
            this.bt_modifypw.TabIndex = 5;
            this.bt_modifypw.Text = "修改密码";
            this.bt_modifypw.UseVisualStyleBackColor = true;
            this.bt_modifypw.Click += new System.EventHandler(this.bt_modifypw_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(479, 207);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(75, 23);
            this.bt_logout.TabIndex = 6;
            this.bt_logout.Text = "注销";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 269);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(577, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "学号：";
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 291);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.bt_modifypw);
            this.Controls.Add(this.bt_score);
            this.Controls.Add(this.bt_class);
            this.Controls.Add(this.bt_course);
            this.Controls.Add(this.bt_userinfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "studentForm";
            this.Text = "学生信息管理窗口";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_userinfo;
        private System.Windows.Forms.Button bt_course;
        private System.Windows.Forms.Button bt_class;
        private System.Windows.Forms.Button bt_score;
        private System.Windows.Forms.Button bt_modifypw;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}