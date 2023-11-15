using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教育系统.AcademicTranscript.academic;
using 教育系统.AcademicTranscript.Grade;
using 教育系统.ASSESS;
using 教育系统.DESKTOP.weekday;
using 教育系统.Develop;
using 教育系统.Develop.project;
using 教育系统.Develop.SelectLesson;
using 教育系统.PRACTICE.NewCredit;

namespace 教育系统
{

    public partial class Home : Form
    {
        private Course Course;
        private Weekday Weekday;
        private Message Message;
        private Announcement Announcement;
        private ImplementationPlan ImplementationPlan;
        private SelectLEsson SelectLEsson;
        private AcademicGrade AcademicGrade;
        private Card Card;
        private Apply Apply;
        private DevelopP DevelopP;
        private StudentAssess StudentAssess;
        public Home()
        {
            InitializeComponent();
            Weekday = new Weekday();
            Course = new Course();

            Message = new Message();
            Announcement = new Announcement();
            ImplementationPlan= new ImplementationPlan();
            SelectLEsson=new SelectLEsson();
            AcademicGrade=new AcademicGrade();
            Card=new Card();
            Apply=new Apply();
            StudentAssess=new StudentAssess();
            DevelopP=new DevelopP();
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

        private void btn_plan_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImplementationPlan.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectLEsson.Show();
        }

        private void btn_grade_Click(object sender, EventArgs e)
        {
            this
                .Hide();
            AcademicGrade.Show();
        }

        private void btn_card_Click(object sender, EventArgs e)
        {
            this.Hide();
            Card.Show();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apply.Show();
        }

        private void btn_develop_Click(object sender, EventArgs e)
        {
            this.Hide();
            DevelopP.Show();
        }

        private void btn_assess_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAssess.Show();
        }
    }
}