﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHistoryProject.Panel
{
    public partial class frmLibrary : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public frmLibrary(string token, string username, string client_id)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            pnlNavIndicator.Top = btnBak.Top;
            pnlNavIndicator.Left = btnBak.Left;
            ButtonColorReset(btnBak);

        }

        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(31, 27, 48);
            Color btncolor = Color.FromArgb(26, 23, 40);
            btnBak.BackColor = btncolor;
            btnFavourite.BackColor = btncolor;
            btnWIP.BackColor = btncolor;

            button.BackColor = activeColor;

        }

        private void btnBak_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Top = btnBak.Top;
            pnlNavIndicator.Left = btnBak.Left;
            ButtonColorReset(btnBak);
        }

        private void btnFavourite_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnFavourite.Height;
            pnlNavIndicator.Top = btnFavourite.Top;
            pnlNavIndicator.Left = btnFavourite.Left;
            ButtonColorReset(btnFavourite);
        }
    }
}
