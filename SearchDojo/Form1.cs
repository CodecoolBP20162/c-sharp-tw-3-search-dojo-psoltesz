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
                MatchCollection m = r.Matches(textBox1.Text);
                string result = "";
                foreach (Match item in m)
                {
                    result += item.Groups[1].ToString();
                }
                textBox2.Text = result;
            }
            catch { MessageBox.Show("Something went wrong. Please try again."); };
        }
    }
}
