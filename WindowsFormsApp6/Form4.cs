using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DateTime = new DateTime();
            Type type01 = typeof(DateTime);
            foreach (PropertyInfo t in type01.GetProperties())

                textBox.SelectedText = ($"{t.PropertyType}: {t.Name}");
        }
    }
}
