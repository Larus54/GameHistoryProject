using GameHistoryProject.Panel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V120.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GameHistoryProject
{
    public partial class frmmain : Form
    {
        private string tokenapi;
        private string username;
        private string client_id;

        private Point mouseDownLocation;
         
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
            


        public frmmain(string tokenapi, string username, string client_id)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.tokenapi = tokenapi;
            this.username = username;
            this.client_id = client_id;
            lbluser.Text = username;
            this.tokenapi = "Bearer " + tokenapi;

            if(username == "admin")
            {
                lbltitle.Text = "Admin";
            }

            pnlNavIndicator.Height =btnlibrary.Height;
            pnlNavIndicator.Top = btnlibrary.Top;
            pnlNavIndicator.Left =btnlibrary.Left;
            ButtonColorReset(btnlibrary);

            lblTabTitle.Text = "Library";
            this.pnlMain.Controls.Clear();
            frmLibrary frmLibrary = new frmLibrary(tokenapi, username, client_id) { Dock = DockStyle.Fill, TopLevel=false, TopMost=true};
            this.pnlMain.Controls.Add(frmLibrary);
            frmLibrary.Show();

            lblstatussuccess.Text = "✔ - [Search] Online";
            lblstatussuccess.ForeColor = Color.Green;

        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(31, 27, 48);
            Color btncolor = Color.FromArgb(26, 23, 40);
            btnlibrary.BackColor = btncolor;
            btnTabSearch.BackColor = btncolor;
            btnsettings.BackColor = btncolor;

            button.BackColor = activeColor;
            
        }

        private void btnlibrary_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnlibrary.Height;
            pnlNavIndicator.Top = btnlibrary.Top;
            pnlNavIndicator.Left = btnlibrary.Left;
            ButtonColorReset(btnlibrary);

            lblTabTitle.Text = "Libreria";
            this.pnlMain.Controls.Clear();
            frmLibrary frmLibrary = new frmLibrary(tokenapi,username,client_id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlMain.Controls.Add(frmLibrary);
            frmLibrary.Show();
        }

        private void btnTabSearch_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnTabSearch.Height;
            pnlNavIndicator.Top = btnTabSearch.Top;
            pnlNavIndicator.Left = btnTabSearch.Left;
            ButtonColorReset(btnTabSearch);

            lblTabTitle.Text = "Ricerca";
            this.pnlMain.Controls.Clear();
            frmSearch frmSearch = new frmSearch(tokenapi, username, client_id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlMain.Controls.Add(frmSearch);
            frmSearch.Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            //TODO: Menu impostazioni
            pnlNavIndicator.Height = btnsettings.Height;
            pnlNavIndicator.Top = btnsettings.Top;
            pnlNavIndicator.Left = btnsettings.Left;
            ButtonColorReset(btnsettings);

            lblTabTitle.Text = "Ricerca";
        }

        private void pnlTopbar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }

        private void pnlTopbar_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point newLocation = new Point(
                    this.Location.X + (e.Location.X - mouseDownLocation.X),
                    this.Location.Y + (e.Location.Y - mouseDownLocation.Y)
                 );

                newLocation.X = Math.Max(0, newLocation.X);
                newLocation.Y = Math.Max(0, newLocation.Y);


                this.Location = newLocation;


            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
