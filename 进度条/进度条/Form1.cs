using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 进度条
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            labvalue.Text = progressBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = progressBar1.Value -progressBar1.Step;
            
            if(value >= progressBar1.Minimum)
            {
                progressBar1.Value = value;
                labvalue.Text = progressBar1.Value.ToString();
            }
        }
    }
}
