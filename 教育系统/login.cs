using SmartLinli.DatabaseDevelopement;
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
        private Form1 Form1;
        public login()
        {
            InitializeComponent();
            Form1= new Form1();
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
            if (string.IsNullOrWhiteSpace(this.txb_number.Text))
            {
                MessageBox.Show("用户账号不能为空！");
            }
            if (string.IsNullOrWhiteSpace(this.txb_password.Text))
            {
                MessageBox.Show("用户密码不能为空！");
            }
            SqlHelper sqlHelper = new SqlHelper();
            int COUNT = sqlHelper.QuickReturn<int>
                ($@"SELECT 1 
					FROM tb_User
					WHERE No='{this.txb_number.Text.Trim()}' AND Password='{this.txb_password.Text.Trim()}'");
            if (COUNT == 1)
                
            {
                MessageBox.Show("登录成功！");
                if (true)
                {
                    timer1.Start();
                    txb_number.Visible = false;
                    txb_password.Visible = false;

                    btn_login.Visible = false;

                    lbl_number.Visible = false;
                    label2.Visible = false;

                }
                this.Hide();
                Form1.Show();
            }
            if (COUNT == 0)
            {
                MessageBox.Show("登录失败！");
                this.txb_password.Focus();
                this.txb_password.SelectAll();
            }
            
        }

        

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }
    }
}
