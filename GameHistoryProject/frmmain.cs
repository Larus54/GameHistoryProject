using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHistoryProject
{
    public partial class frmmain : Form
    {

        public frmmain(string tokenapi, string username)
        {
            InitializeComponent();
            lblusernamae.Text += username;
            lblstatus.Text = "online";
            lblstatus.ForeColor = Color.Green;
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void frmmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
