using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教育系统
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < 90)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X , pictureBox1.Location.Y+1);
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(true)
            {
                timer1.Start();
                textBox1.Visible= false;
                textBox2.Visible= false;
                comboBox1.Visible= false;
                button1.Visible= false;
                button2.Visible= false;
                label1.Visible= false;
                label2.Visible= false;
                label3.Visible= false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text=null; textBox2.Text=null;
            comboBox1.Text=null;

        }
    }
}
