using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教育系统.PRACTICE.Teaching
{
    public partial class Experiment_book : Form
    {
        private Experiment_list experiment;
        public Experiment_book()
        {
            InitializeComponent();
            experiment= new Experiment_list();
            experiment.TopLevel= false  ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
           panel2.Controls.Add(experiment);
            experiment.Show();
        }
    }
}
