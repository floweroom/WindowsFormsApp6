using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            List<Student> list = new List<Student>();
            StreamReader sr = new StreamReader("students.txt");
            while (!sr.EndOfStream)
            {
                string[] words = sr.ReadLine().Split(' ');

                Student student1 = new Student();
                student1.LastName = words[1];
                student1.FirstName = words[2];
                student1.University = words[3];
                student1.Faculty = words[4];
                student1.Course = words[5];
                student1.Age = int.Parse(words[6]);
                student1.Group = int.Parse(words[7]); ;
                student1.Department = int.Parse(words[8]); ;
                student1.City = words[9];
                list.Add(student1);
                sr.Close();
            }
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Student>));
            using (Stream stream = new FileStream("fileName", FileMode.Create, FileAccess.Write))
            {
                xmlser.Serialize(stream, list);

            }
        }
    }
}
