using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教育系统.DESKTOP.weekday;

namespace 教育系统
{
    public partial class Desktop : Form
    {
        private Information information;
        private Message Message;
        private Announcement Announcement;
        private Password Password;
        private Weekday Weekday;
        private string[] AnnountMess = { "已收公告", "已收留言" };
        private string[] personInformation = { "修改个人信息", "修改密码" };
        private string[] edycationW = { "教学周历查看" };
        public Desktop()
        {
            InitializeComponent();
            information = new Information();
            Message= new Message();
            Announcement= new Announcement();
            Password= new Password();
            Weekday= new Weekday();
            Announcement.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(Announcement);
            Announcement.Show();
            this.Dock= DockStyle.Fill;
          
            this.listBox1.Items.AddRange(AnnountMess);
            
            this.listBox2.Items.AddRange(personInformation);
            
            this.listBox3.Items.AddRange(edycationW);
        }

        private void Desktop_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.listBox2.Items.Clear();
            this.listBox2.Items.AddRange(personInformation);
            this.listBox3.Items.Clear();
            this.listBox3.Items.AddRange(edycationW);


            if (listBox1.SelectedItem.ToString()=="已收公告")
            {
                Announcement.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Announcement);
                Announcement.Show();
            }
            if (listBox1.SelectedItem.ToString() == "已收留言")
            {
                Message.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Message);
                Message.Show();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(AnnountMess);
            this.listBox3.Items.Clear();
            this.listBox3.Items.AddRange(edycationW);


            if (listBox2.SelectedItem.ToString() == "修改个人信息")
            {
                information.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(information);
                information.Show();
            }
            if (listBox2.SelectedItem.ToString() == "修改密码")
            {
                Password.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Password);
                Password.Show();
            }
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(AnnountMess);
            this.listBox2.Items.Clear();
            this.listBox2.Items.AddRange(personInformation);


            
                Weekday.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Weekday);
                Weekday.Show();
           
        }
    }
}
