namespace 教育系统
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem_desktop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_academicgrade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_develop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Exam = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_practice = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_evaluate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_main = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_desktop,
            this.MenuItem_academicgrade,
            this.MenuItem_develop,
            this.MenuItem_Exam,
            this.MenuItem_practice,
            this.MenuItem_evaluate,
            this.MenuItem_main});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1111, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem_desktop
            // 
            this.MenuItem_desktop.Name = "MenuItem_desktop";
            this.MenuItem_desktop.Size = new System.Drawing.Size(83, 24);
            this.MenuItem_desktop.Text = "我的桌面";
            this.MenuItem_desktop.Click += new System.EventHandler(this.MenuItem_desktop_Click);
            // 
            // MenuItem_academicgrade
            // 
            this.MenuItem_academicgrade.Name = "MenuItem_academicgrade";
            this.MenuItem_academicgrade.Size = new System.Drawing.Size(83, 24);
            this.MenuItem_academicgrade.Text = "学籍成绩";
            this.MenuItem_academicgrade.Click += new System.EventHandler(this.MenuItem_academicgrade_Click);
            // 
            // MenuItem_develop
            // 
            this.MenuItem_develop.Name = "MenuItem_develop";
            this.MenuItem_develop.Size = new System.Drawing.Size(83, 24);
            this.MenuItem_develop.Text = "培养管理";
            this.MenuItem_develop.Click += new System.EventHandler(this.MenuItem_develop_Click);
            // 
            // MenuItem_Exam
            // 
            this.MenuItem_Exam.Name = "MenuItem_Exam";
            this.MenuItem_Exam.Size = new System.Drawing.Size(83, 24);
            this.MenuItem_Exam.Text = "考试报名";
            this.MenuItem_Exam.Click += new System.EventHandler(this.MenuItem_Exam_Click);
            // 
            // MenuItem_practice
            // 
            this.MenuItem_practice.Name = "MenuItem_practice";
            this.MenuItem_practice.Size = new System.Drawing.Size(83, 24);
            this.MenuItem_practice.Text = "实践环节";
            this.MenuItem_practice.Click += new System.EventHandler(this.MenuItem_practice_Click);
            // 
            // MenuItem_evaluate
            // 
            this.MenuItem_evaluate.Name = "MenuItem_evaluate";
            this.MenuItem_evaluate.Size = new System.Drawing.Size(83, 24);
            this.MenuItem_evaluate.Text = "教学评价";
            this.MenuItem_evaluate.Click += new System.EventHandler(this.MenuItem_evaluate_Click);
            // 
            // MenuItem_main
            // 
            this.MenuItem_main.Name = "MenuItem_main";
            this.MenuItem_main.Size = new System.Drawing.Size(53, 24);
            this.MenuItem_main.Text = "首页";
            this.MenuItem_main.Click += new System.EventHandler(this.MenuItem_main_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 668);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1111, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(204, 20);
            this.toolStripStatusLabel1.Text = "本系统等你多时了啊哈哈哈哈";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(848, 20);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(45, 20);
            this.toolStripStatusLabel3.Text = "TIME";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 619);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "首页";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_desktop;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_academicgrade;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_develop;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exam;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_practice;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_evaluate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_main;
    }
}