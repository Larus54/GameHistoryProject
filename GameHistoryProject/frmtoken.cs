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
            txttoken.MaxLength = 6;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txttoken.Text.Length == 6)
            {
                token = txttoken.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblstringupdate.Text = "Codice non valido, deve essere di 6 numeri";
            }
            
        }

        private void txttoken_TextChanged(object sender, EventArgs e)
        {
            string allowedChars = "0123456789";
            string newText = "";

            foreach(char c in txttoken.Text)
            {
                if(allowedChars.Contains(c))
                {
                    newText += c;
                }
            }

            txttoken.Text = newText;
        }
    }
}
