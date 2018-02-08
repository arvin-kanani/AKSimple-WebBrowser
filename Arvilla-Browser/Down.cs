using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Arvilla_Browser
{
    public partial class Down : Form
    {
        public Down()
        {
            InitializeComponent();
        }
        WebClient wc = new WebClient();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
                if (textBoxU.TextLength == 0 || textBoxS.TextLength == 0) MessageBox.Show("These fields are blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Uri imguri = new Uri(textBoxU.Text);
                    wc.DownloadFileAsync(imguri, textBoxS.Text);
                }
            }
            catch
            {
                MessageBox.Show("Error in download", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                    private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Finish", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != "") textBoxS.Text = folderBrowserDialog1.SelectedPath + "\\Download." + textBoxU.Text.Substring(textBoxU.TextLength - 3, 3);
        }
    }
}
