using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace Arvilla_Browser
{
    public partial class Arvilla : Form
    {
        public Arvilla()
        {
            InitializeComponent();
        }
        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sign s = new Sign();
            s.ShowDialog();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private object webBrowser1()
        {
            throw new NotImplementedException();
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser2.GoSearch();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser2.GoHome();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser2.Stop();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser2.ShowPrintDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser2.ShowPageSetupDialog();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser2.ShowSaveAsDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            this.ForeColor = c.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            this.BackColor = c.Color;
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            this.Font = dlg.Font;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser2.Document.ExecCommand("Cut", false, null);
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser2.Document.ExecCommand("Copy", false, null);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser2.Document.ExecCommand("Paste", false, null);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String source = ("source.txt");
            StreamWriter writer = File.CreateText(source);
            writer.Write(webBrowser2.DocumentText);
            writer.Close();
            Process.Start("notepad.exe", source);
        }

        private void fullScreenF5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Calc.exe");
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("mailto:arvin.kanani.84@gmail.com");
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendar cln = new Calendar();
            cln.ShowDialog();
        }

        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("sol.exe");
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yahooMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "www.yahoo.com";
            webBrowser2.Navigate("https://login.yahoo.com/config/login_verify2?&.src=ym");
        }

        private void solitaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help he = new Help();
            he.ShowDialog();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    webBrowser2.Navigate(textBox1.Text);
            }
            if (e.Control && e.KeyCode == Keys.Enter)
            {

                textBox1.Text = "www." + textBox1.Text + ".com";
                webBrowser2.Navigate(textBox1.Text);
            }
        }

        private void Arvilla_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.back = this.BackColor;
            Properties.Settings.Default.fore = this.ForeColor;
            Properties.Settings.Default.fo = this.Font;
            Properties.Settings.Default.Save();
        }

        private void Arvilla_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.back;
            this.ForeColor = Properties.Settings.Default.fore;
            this.Font = Properties.Settings.Default.fo;
            textBox1.Text = Properties.Settings.Default.url;
            webBrowser2.Navigate(textBox1.Text);
            button2.Enabled = false;
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Url u = new Url();
            u.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = " " + webBrowser2.DocumentTitle;
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Down D = new Down();
            D.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            webBrowser2.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
        }

        private void webBrowser1_FileDownload(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "use://Ping" || textBox1.Text == "U**P")
            {
                textBox1.Text = "";
                Ping pi = new Ping();
                pi.ShowDialog();
            }
            if (textBox1.Text == "go:Back" || textBox1.Text == "go:B")
            {
                textBox1.Text = "";
                webBrowser2.GoBack();
            }
            if (textBox1.Text == "go:Refresh" || textBox1.Text == "go:R")
            {
                textBox1.Text = "";
                webBrowser2.Refresh();
            }
            if (textBox1.Text == "go:Forward" || textBox1.Text == "go:F")
            {
                textBox1.Text = "";
                webBrowser2.GoForward();
            }
            if (textBox1.Text == "go:Stop" || textBox1.Text == "go:S")
            {
                textBox1.Text = "";
                webBrowser2.Stop();
            }
            if (textBox1.Text == "go:Home" || textBox1.Text == "go:H")
            {
                textBox1.Text = "";
                webBrowser2.GoHome();
            }
            if (textBox1.Text == "go:Search" || textBox1.Text == "go:E")
            {
                textBox1.Text = "";
                webBrowser2.GoSearch();
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ping p = new Ping();
            p.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter URl first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                listBox1.Items.Add(textBox1.Text);
        }

        private void bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Text;
            webBrowser2.Navigate(textBox1.Text);

        }

        private void Arvilla_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            webBrowser2.Document.ExecCommand("SelectAll", true, null);
        }
    }
}
