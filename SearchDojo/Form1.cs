using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SearchDojo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = textBox3.Text;
            try
            {
                Regex r = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                Match m = r.Match(textBox1.Text);
                textBox2.Text = m.Groups[1].ToString();
            }
            catch { MessageBox.Show("Something went wrong. Please try again."); };
        }
    }
}
