using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EnglishDirectory
{
    public partial class RoundRTBox : RichTextBox
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );
        public RoundRTBox()
        {
            InitializeComponent();
            this.Size = new Size(323, 209);
            this.SelectAll();
            this.SelectionIndent += 15;//play with this values to match yours
            this.SelectionRightIndent += 15;//this too
            this.SelectionLength = 0;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 323, 209, 40, 40));
        }
    }
}
