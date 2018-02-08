using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arvilla_Browser
{
    public partial class Url : Form
    {
        public Url()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //if (textBox1.Text != "www." + textBox1.Text + ".com")
                //{
                //    textBox1.Text = "www." + textBox1.Text + ".com";
                //}
                //if (textBox1.Text != "www." + textBox1.Text)
                //{
                // textBox1.Text = "www." + textBox1.Text;
                //}
                //Form1 frm1 = new Form1();
                //frm1.textBox1.Text = this.textBox1.Text;
                Properties.Settings.Default.url = textBox1.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            catch
            {
                MessageBox.Show("The field is blank");
            }
        }

        private void Url_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.text = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void Url_Load(object sender, EventArgs e)
        {
           textBox1.Text = Properties.Settings.Default.text;
        }

        private void Url_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                textBox1.Text = "www." + textBox1.Text + ".com";
                //Properties.Settings.Default.text = textBox1.Text;
                //Properties.Settings.Default.Save();
                //this.Close();
            }
        }
    }
}

