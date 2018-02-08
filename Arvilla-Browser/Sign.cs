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
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "arvin" && textBoxPass.Text == "123")
            {
                //Form1 frm1 = new Form1();
                //frm1.signInToolStripMenuItem.Enabled = true;
                MessageBox.Show("Thanks for sign in", "thank");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Signu su = new Signu();
            su.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBoxPass.PasswordChar = '\0';
            }
            if (checkBox1.Checked == false)
            {
                textBoxPass.PasswordChar = '*';
            }

        }
    }
}
