using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教育系统.Develop.project;
using 教育系统.Exam.Grade;
using 教育系统.Exam.Graduation;
using 教育系统.Exam.myApply;
using 教育系统.Exam.myExam;

namespace 教育系统.Exam
{
    public partial class ExamApply : Form
    {
        private Clear Clear;
        private Makeup Makeup;
        private MakeUpApply MakeUpApply;
        private Social Social;
        private Report Report;
        private SelectQuestion SelectQuestion;
        private Delay Delay;
        private EXception Exception;
        private Exemption Exemption;
        private ArrangeForExam ArrangeForExamArr;
        private MiddleExam MiddleExam;
        private PreExam PreExam;
        private string[] myapply = { "缓考申请", "免考申请", "免修申请" };
        private string[] myexam = { "考试安排查询", "半期考试查询", "提前考试查询" };
        private string[] grade = { "社会考试报名", "补考报名", "清考报名", "补重修报名选课" };
        private string[] graduation = { "学生选题", "毕业报告" };
        public ExamApply()
        {
            InitializeComponent();
            Clear= new Clear();
            Makeup= new Makeup();
            MakeUpApply=new MakeUpApply();
            Social= new Social();
            Report= new Report();
            SelectQuestion= new SelectQuestion();
            Delay= new Delay();
            Exception= new EXception();
            Exemption= new Exemption();
            ArrangeForExamArr=new ArrangeForExam(); 
            MiddleExam=new MiddleExam();
            PreExam=new PreExam();
            this.Dock = DockStyle.Fill;
            listBox1.Items.AddRange(myapply);
            listBox2.Items.AddRange(myexam);
            listBox3.Items.AddRange(grade);
            listBox4.Items.AddRange(graduation);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(myexam);
            listBox3.Items.Clear();
            listBox3.Items.AddRange(grade);
            listBox4.Items.Clear();
            listBox4.Items.AddRange(graduation);
            if (listBox1.SelectedItem.ToString() == "缓考申请")
            {
                Delay.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Delay);
                Delay.Show();

            }
            if (listBox1.SelectedItem.ToString() == "免考申请")
            {
                Exception.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Exception);
                Exception.Show();

            }
            if (listBox1.SelectedItem.ToString() == "免修申请")
            {
                Exemption.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Exemption);
                Exemption.Show();

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(myapply);
            listBox3.Items.Clear();
            listBox3.Items.AddRange(grade);
            listBox4.Items.Clear();
            listBox4.Items.AddRange(graduation);
            if (listBox2.SelectedItem.ToString() == "考试安排查询")
            {
                ArrangeForExamArr.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(ArrangeForExamArr);
                ArrangeForExamArr.Show();

            }
            if (listBox2.SelectedItem.ToString() == "半期考试查询")
            {
                MiddleExam.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(MiddleExam);
                MiddleExam.Show();

            }
            if (listBox2.SelectedItem.ToString() == "提前考试查询")
            {
                PreExam.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(PreExam);
                PreExam.Show();

            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(myexam);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(myapply);
            listBox4.Items.Clear();
            listBox4.Items.AddRange(graduation);
                if (listBox3.SelectedItem.ToString() == "社会考试报名")
            {
                Social.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Social);
                Social.Show();

            }
            if (listBox3.SelectedItem.ToString() == "补考报名")
            {
                Makeup.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Makeup);
                Makeup.Show();

            }
            if (listBox3.SelectedItem.ToString() == "清考报名")
            {
                Clear.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Clear);
                Clear.Show();

            }
            if (listBox3.SelectedItem.ToString() == "补重修报名选课")
            {
                MakeUpApply.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(MakeUpApply);
                MakeUpApply.Show();

            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(myexam);
            listBox3.Items.Clear();
            listBox3.Items.AddRange(grade);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(myapply);
            if (listBox4.SelectedItem.ToString() == "学生选题")
            {
                SelectQuestion.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(SelectQuestion);
                SelectQuestion.Show();

            }
            if (listBox4.SelectedItem.ToString() == "毕业报告")
            {
                Report.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Report);
                Report.Show();

            }
        }
    }
}
