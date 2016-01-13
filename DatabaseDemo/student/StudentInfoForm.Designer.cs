namespace DatabaseDemo
{
    partial class StudentInfoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_sno = new System.Windows.Forms.TextBox();
            this.tb_classno = new System.Windows.Forms.TextBox();
            this.tb_source = new System.Windows.Forms.TextBox();
            this.tb_xuefen = new System.Windows.Forms.TextBox();
            this.bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "年龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "学号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "班级编号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "生源地：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "已修学分：";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(127, 57);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(100, 21);
            this.tb_name.TabIndex = 6;
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(127, 103);
            this.tb_age.Name = "tb_age";
            this.tb_age.ReadOnly = true;
            this.tb_age.Size = new System.Drawing.Size(100, 21);
            this.tb_age.TabIndex = 7;
            // 
            // tb_sno
            // 
            this.tb_sno.Location = new System.Drawing.Point(127, 149);
            this.tb_sno.Name = "tb_sno";
            this.tb_sno.ReadOnly = true;
            this.tb_sno.Size = new System.Drawing.Size(100, 21);
            this.tb_sno.TabIndex = 8;
            // 
            // tb_classno
            // 
            this.tb_classno.Location = new System.Drawing.Point(127, 195);
            this.tb_classno.Name = "tb_classno";
            this.tb_classno.ReadOnly = true;
            this.tb_classno.Size = new System.Drawing.Size(100, 21);
            this.tb_classno.TabIndex = 9;
            // 
            // tb_source
            // 
            this.tb_source.Location = new System.Drawing.Point(127, 241);
            this.tb_source.Name = "tb_source";
            this.tb_source.ReadOnly = true;
            this.tb_source.Size = new System.Drawing.Size(100, 21);
            this.tb_source.TabIndex = 10;
            // 
            // tb_xuefen
            // 
            this.tb_xuefen.Location = new System.Drawing.Point(127, 287);
            this.tb_xuefen.Name = "tb_xuefen";
            this.tb_xuefen.ReadOnly = true;
            this.tb_xuefen.Size = new System.Drawing.Size(100, 21);
            this.tb_xuefen.TabIndex = 11;
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(264, 326);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(75, 23);
            this.bt.TabIndex = 12;
            this.bt.Text = "确定";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 361);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.tb_xuefen);
            this.Controls.Add(this.tb_source);
            this.Controls.Add(this.tb_classno);
            this.Controls.Add(this.tb_sno);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentInfoForm";
            this.Text = "学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.TextBox tb_sno;
        private System.Windows.Forms.TextBox tb_classno;
        private System.Windows.Forms.TextBox tb_source;
        private System.Windows.Forms.TextBox tb_xuefen;
        private System.Windows.Forms.Button bt;
    }
}