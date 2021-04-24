using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimChu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        String s = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            //int value = 0;
            //value++;
            Random rand = new Random();
            Color mau = Color.FromArgb(0,191,rand.Next(100,255));
            label1.ForeColor = mau;
            //if (value == 250) value = 0;
            lb2.Text =  lb2.Text.Substring(1) + lb2.Text.Substring(0,1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            

        }
        private void Form2_Click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            s = b.Text ;
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            // formm can chuyển.
            if (s == "Animals")
            {
                Form1 f = new Form1();
                openChildForm(f);
            }
            // test cac form khac
            if (s == "Computer")
            {
                Computer f3 = new Computer();
                openChildForm(f3);
            }
            if(s == "Fruits")
            {
                Fruits f4 = new Fruits();
                openChildForm(f4);
            }
            if(s == "Country")
            {
                Country f5 = new Country();
                openChildForm(f5);
            }
        }
        public void openChildForm(Form childForm)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
