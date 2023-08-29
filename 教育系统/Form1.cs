using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教育系统.PRACTICE;

namespace 教育系统
{
    public partial class Form1 : Form
    {
        private Desktop desktop;
        private AcademicGrade AcademicGrade;
        private Home Home;
        private Practice Practice;
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
            timer1.Start();
            desktop=new Desktop();
            AcademicGrade= new AcademicGrade();
            Home= new Home();
            Practice= new Practice();
            Home.TopLevel= false;
            panel1.Controls.Add(Home);
            Home.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
        }

        private void MenuItem_desktop_Click(object sender, EventArgs e)
        {
            desktop.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(desktop);
            desktop.Show();
        }

        private void MenuItem_academicgrade_Click(object sender, EventArgs e)
        {
            AcademicGrade.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(AcademicGrade);
            AcademicGrade.Show();
        }

        private void MenuItem_main_Click(object sender, EventArgs e)
        {
            Home.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(Home);
            Home.Show();
        }

        private void MenuItem_practice_Click(object sender, EventArgs e)
        {
            Practice.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(Practice);
            Practice.Show();
        }
    }
}
