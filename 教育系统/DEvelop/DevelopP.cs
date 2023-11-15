using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教育系统.Develop.curriculum;
using 教育系统.Develop.Option;
using 教育系统.Develop.project;
using 教育系统.Develop.SelectLesson;
using 教育系统.Develop.TextBook;
using 教育系统.PRACTICE.Teaching;

namespace 教育系统.Develop
{
    public partial class DevelopP : Form
    {
        private ClassRoom ClassRoomroom;
        private ClassTable ClassTable;
        private Course Course;
        private EX_TABLE EX_TABLE;
        private TeachTable TeachTable;
        private Term Term;
        private ApplyOption ApplyOption;
        private Guidance Guidance;
        private ImplementationPlan ImplementationPlan;
        private ViewTeachingProgress ViewTeachingProgress;
        private All All;
        private BorrowClass BorrowClass;
        private Center Center;
        private Pre_S Pre_S;
        private ScoreAll ScoreAll;
        private SelectLEsson selectLesson;
        private TeachProgress TeachProgress;
        private Accounts Accounts;
        private SelectTextbook SelectTextbook;
        private SolicitSubscriptions SolicitSubscriptions;
        private string[] develop = { "指导培养方案", "教学进程查看", "执行计划" };
        private string[] table = { "学期理论课表", "实验课表查询", "班级课表查询", "教师课表查询" ,"课程课表查询"};
        private string[] selectlesson = { "查询选课课程", "学生选课中心", "学生预选管理", "教室借用申请", "教学进度表", "教学进度汇总", "学生选修情况" };
        private string[] textbook = { "学生教材选用","教材账目信息","教材征订" };
        private string[] option = { "辅修报名" };
        public DevelopP()
        {
            InitializeComponent();
            ClassRoomroom = new ClassRoom();
            ClassTable=new ClassTable();
            Course=new Course();
            EX_TABLE=new EX_TABLE();
            TeachTable=new TeachTable();
            Term=new Term();
            ApplyOption=new ApplyOption();
            Guidance=new Guidance();
            ImplementationPlan=new ImplementationPlan();
            ViewTeachingProgress=new ViewTeachingProgress();
            All=new All();
            BorrowClass=new BorrowClass();
            Center=new Center();
            Pre_S=new Pre_S();
            ScoreAll=new ScoreAll();
            selectLesson=new SelectLEsson();
            TeachProgress=new TeachProgress();
            Accounts=new Accounts();
            selectLesson=new SelectLEsson();
            SolicitSubscriptions=new SolicitSubscriptions();
            SelectTextbook=new SelectTextbook();
            this.Dock= DockStyle.Fill;
            listBox1.Items.AddRange(develop);
            listBox2.Items.AddRange(table);
            listBox3.Items.AddRange(selectlesson);
            listBox4.Items.AddRange(textbook);
            listBox5.Items.AddRange(option);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            this.listBox2.Items.AddRange(table);
            this.listBox3.Items.Clear();
            this.listBox3.Items.AddRange(selectlesson);
            listBox4.Items.Clear();
            listBox4.Items.AddRange(textbook);
            listBox5.Items.Clear();
            listBox5.Items.AddRange(option);


            if (listBox1.SelectedItem.ToString() == "指导培养方案")
            {
                Guidance.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Guidance);
                Guidance.Show();

            }
            if (listBox1.SelectedItem.ToString() == "执行计划")
            {
                ImplementationPlan .TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(ImplementationPlan);
                ImplementationPlan.Show();

            }
            if (listBox1.SelectedItem.ToString() == "教学进程查看")
            {
                ViewTeachingProgress.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(ViewTeachingProgress);
                ViewTeachingProgress.Show();

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(develop);
            listBox3.Items.Clear();
            listBox3.Items.AddRange(selectlesson);
            listBox4.Items.Clear();
            listBox4.Items.AddRange(textbook);
            listBox5.Items.Clear();
            listBox5.Items.AddRange(option);
            if (listBox2.SelectedItem.ToString() == "学期理论课表")
            {
                Term.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Term);
                Term.Show();

            }
            if (listBox2.SelectedItem.ToString() == "实验课表查询")
            {
                EX_TABLE.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(EX_TABLE);
                EX_TABLE.Show();

            }
            if (listBox2.SelectedItem.ToString() == "班级课表查询")
            {
                ClassTable.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(ClassTable);
                ClassTable.Show();

            }
            if (listBox2.SelectedItem.ToString() == "教师课表查询")
            {
                TeachTable.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(TeachTable);
                TeachTable.Show();

            }
            if (listBox2.SelectedItem.ToString() == "教室课表查询")
            {
                ClassRoomroom.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(ClassRoomroom);
                ClassRoomroom.Show();
            }
            if (listBox2.SelectedItem.ToString() == "课程课表查询")
            {
                Course.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Course);
                Course.Show();

            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(develop);
            listBox2.Items.Clear();
            listBox2.Items.AddRange(table);
            listBox4.Items.Clear();
            listBox4.Items.AddRange(textbook);
            listBox5.Items.Clear();
            listBox5.Items.AddRange(option);
            if (listBox3.SelectedItem.ToString() == "查询选课课程")
            {
                selectLesson.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(selectLesson);
                selectLesson.Show();      

            }
            if (listBox3.SelectedItem.ToString() == "学生选课中心")
            {
                Center.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Center);
                Center.Show();

            }
            if (listBox3.SelectedItem.ToString() == "学生预选管理")
            {
                Pre_S.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Pre_S);
                Pre_S.Show();

            }
            if (listBox3.SelectedItem.ToString() == "教室借用申请")
            {
                BorrowClass.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(BorrowClass);
                BorrowClass.Show();

            }
            if (listBox3.SelectedItem.ToString() == "教学进度表")
            {
                TeachProgress.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(TeachProgress);
                TeachProgress.Show();

            }
            if (listBox3.SelectedItem.ToString() == "教学进度汇总")
            {
                All.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(All);
                All.Show();

            }
            if (listBox3.SelectedItem.ToString() == "学生修读情况")
            {
                ScoreAll.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(ScoreAll);
                ScoreAll.Show();

            }




        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox1.Items.AddRange(develop);
            listBox2.Items.Clear();
            listBox2.Items.AddRange(table);
            listBox3.Items.Clear();
            listBox3.Items.AddRange(selectlesson);
            listBox5.Items.Clear();
            listBox5.Items.AddRange(option);
            if (listBox4.SelectedItem.ToString() == "学生教材选用")
            {
                SelectTextbook.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(SelectTextbook);
                SelectTextbook.Show();

            }
            if (listBox4.SelectedItem.ToString() == "教材账目信息")
            {
                Accounts.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Accounts);
                Accounts.Show();

            }
            if (listBox4.SelectedItem.ToString() == "教材征订")
            {
                SolicitSubscriptions.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(SolicitSubscriptions);
                SolicitSubscriptions.Show();

            }



        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(develop);
            listBox2.Items.Clear();
            listBox2.Items.AddRange(table);
            listBox4.Items.Clear();
            listBox4.Items.AddRange(textbook);
            listBox3.Items.Clear();
            listBox3.Items.AddRange(selectlesson);
            if (listBox1.SelectedItem.ToString() == "辅修报名")
            {
                ApplyOption.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Course);
                ApplyOption.Show();

            }

        }
    }
}
