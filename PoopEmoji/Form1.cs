using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoopEmoji
{
    public partial class Form1 : Form
    {
       // internal Label lbl = Form1.ActiveForm.lblPoop.text;
        public Form1()
        {
            InitializeComponent();
        }
        int p = 0;
        public void button1_Click(object sender, EventArgs e)
        {
            //Poop(1);
            //lblPoop.Text = Poop(2);
            //textBox1.Text = Poop(2);
            
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
            // char c = '\uD83D\uDCA9';
            //char c = feffd83ddca9;
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
            SendKeys.Send("^{v}");

        }

        private void Form1_Validated(object sender, EventArgs e)
        {
            SendKeys.Send("^{v}");
        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Validating(object sender, CancelEventArgs e)
        {
            PoopKeys();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            PoopKeys();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            PoopKeys();
        }

        private static void PoopKeys()
        {
            SendKeys.Send("^{v}");
            SendKeys.Send("{ENTER}");
        }
    }
}
