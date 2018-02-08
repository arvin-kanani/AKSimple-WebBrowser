using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;


namespace Arvilla_Browser
{
    public partial class Ping : Form
    {
        public Ping()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hostname = textBox1.Text;
            int timeout = 10000;
            Ping ping = new Ping();
            try
            {
                PingReply pingreply = ping.Send(hostname, timeout);
                if (pingreply.Status == IPStatus.Success)
                {
                    label2.Text = ("Address:" + pingreply.Address);
                    label3.Text = ("status:" + pingreply.Status);
                    label4.Text = ("Round trip time:" + pingreply.RoundtripTime);
                }
            }
            catch
            {
                MessageBox.Show("Error in connection or the field is blank");
            }
        }
        private PingReply Send(string hostname, int timeout)
        {
            throw new NotImplementedException();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                textBox1.Text = "www." + textBox1.Text + ".com";
            }
        }
    }
}
