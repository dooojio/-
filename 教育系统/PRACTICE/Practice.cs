using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教育系统.PRACTICE.Internship;
using 教育系统.PRACTICE.NewCredit;
using 教育系统.PRACTICE.Teaching;

namespace 教育系统.PRACTICE
{
    
    public partial class Practice : Form
    {
        private Experiment_book experiment;
        private Experiment_list experiment_List;
        private INternship Internship;
        private PracticeGrade PracticeGrade;
        private Apply apply;
        private Select Selectselect;
        private Iinfoemation Iinfoemation;
        private string[] teaching = { "实验预约管理", "开放实习预约", "临床实习成绩" };
        private string[] newcredit = { "创新学分申报", "创新学分查询" };
        private string[] internship = { "实习信息查询" };
        public Practice()
        {
            InitializeComponent();
            experiment= new Experiment_book();
            experiment_List = new Experiment_list();
            Internship=new INternship();
            PracticeGrade=new PracticeGrade();
            apply=new Apply();
            Selectselect=new Select();
            Iinfoemation=new Iinfoemation();
            experiment.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(experiment);
            experiment.Show();
            this.Dock = DockStyle.Fill;

            this.listBox1.Items.AddRange(teaching);

            this.listBox2.Items.AddRange(newcredit);

            this.listBox3.Items.AddRange(internship);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            this.listBox2.Items.AddRange(newcredit);
            this.listBox3.Items.Clear();
            this.listBox3.Items.AddRange(internship);


            if (listBox1.SelectedItem.ToString() == "实验预约管理")
            {
                experiment.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(experiment);
                experiment.Show();
                
            }
            if (listBox1.SelectedItem.ToString() == "开放实习预约")
            {
                Internship.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Internship);
                Internship.Show();
            }
            if (listBox1.SelectedItem.ToString() == "临床实习成绩")
            {
                PracticeGrade.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(PracticeGrade);
                PracticeGrade.Show();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox3.Items.Clear();
            this.listBox3.Items.AddRange(internship);
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(teaching);
            if (listBox2.SelectedItem.ToString() == "创新学分申报")
            {
                apply.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(apply);
                apply.Show();
            }
            if (listBox2.SelectedItem.ToString() == "创新学分查询")
            {
                Selectselect.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Selectselect);
                Selectselect.Show();
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            this.listBox2.Items.AddRange(newcredit);
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(teaching);

            Iinfoemation.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(Iinfoemation);
            Iinfoemation.Show();
            
        }
    }
}
