using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace 教育系统
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txb_name.Text))
            {
                MessageBox.Show("用户账号不能为空！");
            }
            if (string.IsNullOrWhiteSpace(this.txb_password.Text))
            {
                MessageBox.Show("用户密码不能为空！");
            }
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected = sqlHelper.QuickSubmit
                ("INSERT tb_User(No,Password)" +
                    $"VALUES('{this.txb_name.Text}','{this.txb_password.Text}')");
            if (rowAffected==1)
            {
                MessageBox.Show("注册成功！");
                this.Hide();
                login login= new login();
                login.Show();
            }
            if (rowAffected == 0)
            {
                MessageBox.Show("注册失败！");
            }
        }

       
    }
}
