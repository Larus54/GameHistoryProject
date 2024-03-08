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
    public partial class frmtoken : Form
    {
        public string token { get; private set; }
        public frmtoken()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            token = txttoken.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
