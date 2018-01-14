namespace PoopEmoji
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblPoop = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblPaste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPoop
            // 
            this.lblPoop.AutoSize = true;
            this.lblPoop.Location = new System.Drawing.Point(12, 41);
            this.lblPoop.Name = "lblPoop";
            this.lblPoop.Size = new System.Drawing.Size(95, 13);
            this.lblPoop.TabIndex = 1;
            this.lblPoop.Text = "How many poops?";
            this.lblPoop.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 102);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(158, 92);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBox1_Validating);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(12, 200);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(158, 42);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "Paste + Enter will trigger when you click outside this form";
            // 
            // lblPaste
            // 
            this.lblPaste.AutoSize = true;
            this.lblPaste.Enabled = false;
            this.lblPaste.Location = new System.Drawing.Point(33, 77);
            this.lblPaste.Name = "lblPaste";
            this.lblPaste.Size = new System.Drawing.Size(0, 13);
            this.lblPaste.TabIndex = 5;
            this.lblPaste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 246);
            this.Controls.Add(this.lblPaste);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPoop);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Poop Spammer";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.Form1_Validating);
            this.Validated += new System.EventHandler(this.Form1_Validated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblPoop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        internal System.Windows.Forms.Label lblPaste;
    }
}

