using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教育系统.AcademicTranscript.academic;
using 教育系统.AcademicTranscript.Grade;

namespace 教育系统
{
    public partial class AcademicGrade : Form
    {
        private ApplyExchange ApplyExchange;
        private Card card;
        private ExchangeElect ExchangeElect;
        private ExchangeGrade ExchangeGrade;
        private ProfessionalDiversion ProfessionalDiversion;
        private Course Course;
        private Rank Rank;
        private string[] academic = {"学籍卡片","专业分流","申请交换生","交换生成绩","交换生选课"};
        private string[] Grade = {"课程成绩查询","等级考试查询" };
        public AcademicGrade()
        {
            InitializeComponent();
            ApplyExchange= new ApplyExchange();
            card = new Card();
            ExchangeGrade= new ExchangeGrade();
            ExchangeElect = new ExchangeElect();
            ProfessionalDiversion= new ProfessionalDiversion();
            Course= new Course();
            Rank= new Rank();
                this.Dock = DockStyle.Fill;
            ApplyExchange.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(ApplyExchange);
            ApplyExchange.Show();
            this.listBox1.Items.AddRange(academic);
            this.listBox2.Items.AddRange(Grade);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            this.listBox2.Items.AddRange(Grade);
            


            if (listBox1.SelectedItem.ToString() == "申请交换生")
            {
                ApplyExchange.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(ApplyExchange);
                ApplyExchange.Show();
            }
            if (listBox1.SelectedItem.ToString() == "专业分流")
            {
                ProfessionalDiversion.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(ProfessionalDiversion);
                ProfessionalDiversion.Show();
            }
            if (listBox1.SelectedItem.ToString() == "学籍卡片")
            {
                card.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(card);
                card.Show();
            }
            if (listBox1.SelectedItem.ToString() == "交换生成绩")
            {
                ExchangeGrade.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(ExchangeGrade);
                ExchangeGrade.Show();
            }
            if (listBox1.SelectedItem.ToString() == "交换生选课")
            {
                ExchangeElect.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(ExchangeElect);
                ExchangeElect.Show();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(academic);
            if (listBox2.SelectedItem.ToString() == "课程成绩查询")
            {
                Course.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Course);
                Course.Show();
            }
            if (listBox2.SelectedItem.ToString() == "等级成绩查询")
            {
                Rank.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Rank);
                Rank.Show();
            }
        }
    }
}
