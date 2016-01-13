namespace DatabaseDemo.administrator
{
    partial class AdminForm
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
            this.bt_student = new System.Windows.Forms.Button();
            this.bt_teacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(494, 163);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(75, 23);
            this.bt_logout.TabIndex = 13;
            this.bt_logout.Text = "注销";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_modifypw
            // 
            this.bt_modifypw.Location = new System.Drawing.Point(344, 163);
            this.bt_modifypw.Name = "bt_modifypw";
            this.bt_modifypw.Size = new System.Drawing.Size(75, 23);
            this.bt_modifypw.TabIndex = 12;
            this.bt_modifypw.Text = "修改密码";
            this.bt_modifypw.UseVisualStyleBackColor = true;
            this.bt_modifypw.Click += new System.EventHandler(this.bt_modifypw_Click);
            // 
            // bt_student
            // 
            this.bt_student.Location = new System.Drawing.Point(194, 163);
            this.bt_student.Name = "bt_student";
            this.bt_student.Size = new System.Drawing.Size(75, 23);
            this.bt_student.TabIndex = 9;
            this.bt_student.Text = "管理学生";
            this.bt_student.UseVisualStyleBackColor = true;
            this.bt_student.Click += new System.EventHandler(this.bt_student_Click);
            // 
            // bt_teacher
            // 
            this.bt_teacher.Location = new System.Drawing.Point(44, 163);
            this.bt_teacher.Name = "bt_teacher";
            this.bt_teacher.Size = new System.Drawing.Size(75, 23);
            this.bt_teacher.TabIndex = 8;
            this.bt_teacher.Text = "管理教师";
            this.bt_teacher.UseVisualStyleBackColor = true;
            this.bt_teacher.Click += new System.EventHandler(this.bt_teacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(220, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "管理员维护系统";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 200);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(594, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label
            // 
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 17);
            this.label.Text = "管理员编号 :";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 222);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.bt_modifypw);
            this.Controls.Add(this.bt_student);
            this.Controls.Add(this.bt_teacher);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "管理员信息窗口";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_modifypw;
        private System.Windows.Forms.Button bt_student;
        private System.Windows.Forms.Button bt_teacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label;
    }
}