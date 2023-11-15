using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教育系统.ASSESS
{
    public partial class StudentAssess : Form
    {
        private string[] assess = { "学生评价" };
        public StudentAssess()
        {
            InitializeComponent();
            this.listBox1.Items.AddRange(assess);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
