using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHistoryProject.retexturing
{
    public class RoundedTextBox : TextBox
    {
        private const int WM_PAINT = 0xF;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT && !BorderStyle.Equals(BorderStyle.None)) 
            {
                using (var graphics = CreateGraphics())
                using (var pen = new Pen(BorderColor, BorderWidth))
                {
                    graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
                }
            }
        }

        public Color BorderColor { get; set; } = Color.Black;
        public int BorderWidth { get; set; } = 1;


        public RoundedTextBox()
        {
            BorderStyle = BorderStyle.None;
        }
    }
}
