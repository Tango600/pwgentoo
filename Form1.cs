using System;
using PasswUtils;
using System.Windows.Forms;

namespace pwgentoo
{
    public partial class Form1 : Form
    {
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddPassword()
        {
            string pass = PasswordUtils.GenerateStrongPass(Convert.ToInt32(edPasswordLen.Text), chUsePunktuation.Checked, chUseEntropy.Checked);
            if (chStrongly.Checked)
            {
                pass += " " + Convert.ToString(PasswordUtils.TestPasswordWeak(pass, ""));
            }
            moPasswords.Text += pass + Environment.NewLine;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (chClear.Checked)
                moPasswords.Clear();
            i = Convert.ToInt32(edCountPosswords.Text);
            moPasswords.Text += "----------" + Environment.NewLine;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                AddPassword();
                i--;
            }
            else
                timer1.Enabled = false;
        }
    }
}
