using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameTiengAnhDienTu;
using Demo2808;
using TimChu;

namespace EnglishDirectory
{
    public partial class ChooseGame : Form
    {
        private bool isCollapsedGame1 = true;
        private bool isCollapsedGame2 = true;
        private bool isCollapsedGame3 = true;
        public ChooseGame()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsedGame1 == true)
            {
                pnGame1.Width += 20;
                if (pnGame1.Size == pnGame1.MaximumSize)
                {
                    timer1.Stop();
                }
            }
            else
            {
                pnGame1.Width -= 20;
                if (pnGame1.Size == pnGame1.MinimumSize)
                {
                    timer1.Stop();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsedGame2)
            {
                pnGame2.Width += 20;
                if (pnGame2.Size == pnGame2.MaximumSize)
                {
                    timer2.Stop();
                }
            }
            else
            {
                pnGame2.Width -= 20;
                if (pnGame2.Size == pnGame2.MinimumSize)
                {
                    timer2.Stop();

                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsedGame3)
            {
                pnGame3.Width += 20;
                if (pnGame3.Size == pnGame3.MaximumSize)
                {
                    timer3.Stop();

                }
            }
            else
            {
                pnGame3.Width -= 20;
                if (pnGame3.Size == pnGame3.MinimumSize)
                {
                    timer3.Stop();

                }
            }
        }

        private void btnGame1_MouseHover(object sender, EventArgs e)
        {
            timer1.Start();
            isCollapsedGame1 = true;
        }

        private void btnGame1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
            isCollapsedGame1 = false;
        }

        private void btnGame2_MouseHover(object sender, EventArgs e)
        {
            timer2.Start();
            isCollapsedGame2 = true;
        }

        private void btnGame2_MouseLeave(object sender, EventArgs e)
        {
            timer2.Start();
            isCollapsedGame2 = false;
        }

        private void btnGame3_MouseHover(object sender, EventArgs e)
        {
            timer3.Start();
            isCollapsedGame3 = true;
        }

        private void btnGame3_MouseLeave(object sender, EventArgs e)
        {
            timer3.Start();
            isCollapsedGame3 = false;
        }
        private void btnGame2_Click(object sender, EventArgs e)
        {
            openChildForm(new WordFillGame());
        }
        public void openChildForm(Form childForm)
        {
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnGame1_Click(object sender, EventArgs e)
        {
            openChildForm(new TrangChu());
        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }
    }
}
