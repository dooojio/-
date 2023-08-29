using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教育系统.AcademicTranscript.Grade;
using 教育系统.DESKTOP.weekday;

namespace 教育系统
{
   
    public partial class Home : Form
    {
        private Course Course;
        private Weekday Weekday;
        private Message Message;
        private Announcement Announcement;
        public Home()
        {
            InitializeComponent();
            Weekday=new Weekday();
            Course=new Course();
           
            Message=new Message();
            Announcement=new Announcement();
            this.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Course.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Weekday.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Message.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Announcement.Show();
        }
    }
}
