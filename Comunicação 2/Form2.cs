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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox3.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text);
            listBox2.Items.Add(DateTime.Now.Date.ToShortDateString());
            listBox2.Items.Add(DateTime.Now.TimeOfDay.ToString());
        }
    }
}
