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
        bool poopedFlag = true;
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) > 999)
                {
                    p = 1;
                    MessageBox.Show("Please don't go higher than 999.");
                }
                else
                {
                    p = Convert.ToInt32(textBox1.Text);
                }

            }
            catch(Exception ex)
            {
                p = 1;
            }
            richTextBox1.Text = Poop(p);
            Clipboard.SetText(Poop(p));
            lblPaste.Text = p.ToString() + " Poop(s) copied to clipboard!";
            poopedFlag = false;
        }
        static string po = "💩";
        static string c; 
        protected static string Poop(int k)
        {
            var d = c;
            for (int i = 1; i < k; i++)
            {
                d += "\n"+c;
            }
            return d.ToString();
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

        internal void PoopKeys()
        {
            if (!poopedFlag)
            {
                SendKeys.Send("^{v}");
                SendKeys.Send("{ENTER}");
                poopedFlag = true;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            //change label here
            po = textBox2.Text;
            lblPoop.Text = "How many " + po + "'s?";
            button1.Text =  "Let there be " + po;
            c = textBox2.Text;
        }
    }
}
