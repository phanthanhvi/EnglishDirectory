using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishDirectory
{
    public partial class ClosingForm : Form
    {
        public ClosingForm()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainForm.Form_1.Enabled = true;
            this.Close();
        }
        public void ShowForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BringToFront();
            this.Show();
            MainForm.Form_1.Enabled = false;
        }

    }
}
