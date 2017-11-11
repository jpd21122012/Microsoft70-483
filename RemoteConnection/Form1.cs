using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void RecoverData(string url)
        {
            WebClient webClient = new WebClient();
            Stream stream =webClient.OpenRead(url);
            StreamReader reader = new StreamReader(stream);
            string response=reader.ReadToEnd();
            reader.Close();
            rtbResult.Text = response;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            RecoverData(tbURL.Text);
        }
    }
}
