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
    public partial class MainForm : Form
    {
        Form game = new ChooseGame();
        Form trans = new ChooseTranslate();
        Form info = new Info();
        Form home = new Home();
        public static Form Form_1 = new MainForm();
        bool drag = false;
        Point start_point = new Point(0, 0);
        Control choose = new ChooseTranslate();
        public MainForm()
        {
            InitializeComponent();
            Form_1 = this;
            openChildForm(home);
        }

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void pnHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);

            }
        }

        private void pnHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }


        private void btnDirectory_Click(object sender, EventArgs e)
        {
            openChildForm(trans);
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(home);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            openChildForm(info);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;
            ClosingForm closing = new ClosingForm();
            closing.ShowForm();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            openChildForm(game);
        }
        private void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
