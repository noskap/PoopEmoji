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

        public void button1_Click(object sender, EventArgs e)
        {
            //Poop(1);
            //lblPoop.Text = Poop(2);
            //textBox1.Text = Poop(2);
            int p = 0;
            try
            {
                p = Convert.ToInt32(textBox1.Text);
            }
            catch(Exception ex)
            {
                p = 1;
            }
            richTextBox1.Text = Poop(p);
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
    }
}
