using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace testSqiurel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text += "FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion + Environment.NewLine;
            textBox1.Text += "FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion + Environment.NewLine;

            


        }
    }
}
