using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Resources;
using EnglishDirectory;
namespace Demo2808
{
    public partial class TrangChu : Form
    {
        SoundPlayer music = new SoundPlayer();
        public TrangChu()
        {
            InitializeComponent();
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            music.Stop();
            if (MessageBox.Show("Are you ready???", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormStart f = new FormStart();
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                openChildForm(f);
                //f.Show();
                //this.Hide();
            }
        }
        private void f_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you stop???", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            music.SoundLocation = @"ResourceTracNghiem\VĐ_lên_sân_khấu_2013-14 (online-audio-converter.com).wav";
            music.Play();
        }

        private void labelEllipse1_Click(object sender, EventArgs e)
        {

        }

        private void btExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = label2.Text.Substring(1) + label2.Text.Substring(0, 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HuongDan f = new HuongDan();
            f.FormClosed += new FormClosedEventHandler(f_FormClosed);
            openChildForm(f);
            //this.Hide();
        }
        public void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
