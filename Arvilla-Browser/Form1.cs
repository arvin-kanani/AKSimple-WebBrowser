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
            textBoxUrl.Text = "www.yahoo.com";
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
            textBoxUrl.Text = Properties.Settings.Default.url;
            webBrowser2.Navigate(textBoxUrl.Text);
            buttonBack.Enabled = false;
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowDialog Default_Url Form
            Url u = new Url();
            u.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //textBoxUrlCaption = Caption of the webBrowser2 url
            textBoxUrlCaption.Text = " " + webBrowser2.DocumentTitle;
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowDialog Download form
            Down D = new Down();
            D.ShowDialog();
        }
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
        }

        private void webBrowser1_FileDownload(object sender, EventArgs e)
        {
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

        }

        private void bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if bookmark button click then:
            textBoxUrl.Text = listBoxBookmark.Text;
            //WebBrowser2 url = textBoxUrl.text
            webBrowser2.Navigate(textBoxUrl.Text);
        }

        private void Arvilla_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //When Delete key click:
            if (e.KeyCode == Keys.Delete)
            {
                //remove choosed list box item
                listBoxBookmark.Items.RemoveAt(listBoxBookmark.SelectedIndex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //exit from application
            Application.Exit();
        }

        private void selectAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //select all the webbrowser page
            webBrowser2.Document.ExecCommand("SelectAll", true, null);
        }

        private void textBoxUrl_ImeModeChanged(object sender, EventArgs e)
        {
        }

        private void textBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            //When Enter key click:
            if (e.KeyCode == Keys.Enter)
            {
                //WebBrowser2 url = textBoxUrl.text
                webBrowser2.Navigate(textBoxUrl.Text);
            }
            //When Control + Enter key click:
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                textBoxUrl.Text = "www." + textBoxUrl.Text + ".com";
                //WebBrowser2 url = textBoxUrl.text
                webBrowser2.Navigate(textBoxUrl.Text);
            }
        }

        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {
            //some conditional phrases:
            if (textBoxUrl.Text == "use://Ping" || textBoxUrl.Text == "U**P")
            {
                textBoxUrl.Text = "";
                Ping pi = new Ping();
                pi.ShowDialog();
            }
            if (textBoxUrl.Text == "go:Back" || textBoxUrl.Text == "go:B")
            {
                textBoxUrl.Text = "";
                webBrowser2.GoBack();
            }
            if (textBoxUrl.Text == "go:Refresh" || textBoxUrl.Text == "go:R")
            {
                textBoxUrl.Text = "";
                webBrowser2.Refresh();
            }
            if (textBoxUrl.Text == "go:Forward" || textBoxUrl.Text == "go:F")
            {
                textBoxUrl.Text = "";
                webBrowser2.GoForward();
            }
            if (textBoxUrl.Text == "go:Stop" || textBoxUrl.Text == "go:S")
            {
                textBoxUrl.Text = "";
                webBrowser2.Stop();
            }
            if (textBoxUrl.Text == "go:Home" || textBoxUrl.Text == "go:H")
            {
                textBoxUrl.Text = "";
                webBrowser2.GoHome();
            }
            if (textBoxUrl.Text == "go:Search" || textBoxUrl.Text == "go:E")
            {
                textBoxUrl.Text = "";
                webBrowser2.GoSearch();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            //ButtonBack = Enable
            buttonBack.Enabled = true;
            webBrowser2.GoForward();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            //ShowDialog Ping form
            Ping p = new Ping();
            p.ShowDialog();
        }

        private void buttonBookmark_Click(object sender, EventArgs e)
        {
            //avoid from runtime error in the bookmark
            if (textBoxUrl.Text == "")
            {
                MessageBox.Show("Enter URl first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                listBoxBookmark.Items.Add(textBoxUrl.Text);
        }
    }
}
