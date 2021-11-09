using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 F = new Form4();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form5 F = new Form5();
            F.Show();
        }
    }

}
