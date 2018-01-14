using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Date: 14-Jan-2018
//Purpose: Poop emoji spammer
//Author: Tom Broadwood
namespace PoopEmoji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Focus();
        }
        int p = 0;
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                p = Convert.ToInt32(textBox1.Text);
            }
            catch(Exception ex)
            {
                p = 1;
            }
            richTextBox1.Text = Poop(p);
            Clipboard.SetText(Poop(p));
            lblPaste.Text = p.ToString() + " Poop(s) copied to clipboard!";
        }
        protected static string Poop(int k)
        {
            var c = "💩";
            for (int i = 1; i < k; i++)
            {
                c += "\n💩";
            }
            return c.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            

        }

        private void Form1_Validated(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Validating(object sender, CancelEventArgs e)
        {
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            PoopKeys();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
        }

        private static void PoopKeys()
        {
            SendKeys.Send("^{v}");
            SendKeys.Send("{ENTER}");
        }
    }
}
