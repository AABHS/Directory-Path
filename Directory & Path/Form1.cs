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

namespace Directory___Path
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Dirctory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            path();
        }



        private void Dirctory()
        {
            string A = textBox1.Text;
            string directory = A;
            listView1.Items.Clear();
            string[] dires = Directory.GetDirectories(directory);
            foreach (string dir in dires)
            {
                listView1.Items.Add(Path.GetFileName(dir));
            }
        }
        private void path()
        {
            string A = textBox1.Text;
            string directory = A;
            listView1.Items.Clear();
            string[] files = Directory.GetFiles(directory);
            foreach (string file in files)
            {
                listView1.Items.Add(Path.GetFileName(file));
            }
        }


    }
}
