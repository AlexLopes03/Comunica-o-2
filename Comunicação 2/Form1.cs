using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comunicação_2
{
    public partial class Form1 : Form
    {
        private object textBox3;
        private object listBox2;

        public object DataTime { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 OutroForm = new Form2();
            OutroForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            
    }
    }
}
