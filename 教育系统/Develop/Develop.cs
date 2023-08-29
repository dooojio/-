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

namespace 教育系统.Develop
{
    public partial class Develop : Form
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
        private string[] textbook = { "" };
        public Develop()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
