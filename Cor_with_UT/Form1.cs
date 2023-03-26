using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cor_with_UT
{
    public partial class Form1 : Form
    {
        Handler_ Filter1 = new Is_this_question_normal();
        Handler_ Filter2 = new FromAtoM();
        Handler_ Filter3 = new FromNtoZ();

        public Form1()
        {
            Filter1.setNext(Filter2);
            Filter2.setNext(Filter3);
            InitializeComponent();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Filter1.request(textBox1.Text));
        }
    }
}
