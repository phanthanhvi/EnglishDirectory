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
    public partial class Fruits : Form
    {
        public Fruits()
        {
            InitializeComponent();
        }
        int dem = 0;
        string[] txt = {"tocirpa","odacova","ananab","seirreb","surtic","nairud","avaug","iwwik","emil",
        "eehcyl","niradnam","ayapap","raep","niatnalp","emop","otamot"};
        string[] s = {"apricot","avocado","banana","berries","citrus","durian","guava","kiwi","lime","lychee",
        "mandarin","papaya","pear","plantain","pome","tomato"};
        private void Fruits_Load(object sender, EventArgs e)
        {
            go.Enabled = false;
            panel1.BackColor = Color.Transparent;
            pnl.BackColor = Color.Transparent;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text != "")
                go.Enabled = true;
            else
                go.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txt1.Text = string.Concat(txt1.Text, b.Text);
            b.Enabled = false;
        }

        private void go_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (String.Compare(txt1.Text, s[i], true) == 0 || String.Compare(txt1.Text, txt[i], true) == 0)
                {
                    switch (i)
                    {

                        case 0:
                            label1.Visible = false;
                            btn6.BackColor = Color.DeepPink;
                            btn16.BackColor = Color.DeepPink;
                            btn26.BackColor = Color.DeepPink;
                            btn36.BackColor = Color.DeepPink;
                            btn46.BackColor = Color.DeepPink;
                            btn56.BackColor = Color.DeepPink;
                            btn66.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 1:
                            label2.Visible = false;
                            btn13.BackColor = Color.DeepPink;
                            btn24.BackColor = Color.DeepPink;
                            btn35.BackColor = Color.DeepPink;
                            btn46.BackColor = Color.DeepPink;
                            btn57.BackColor = Color.DeepPink;
                            btn68.BackColor = Color.DeepPink;
                            btn79.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 2:
                            label3.Visible = false;
                            btn41.BackColor = Color.DeepPink;
                            btn52.BackColor = Color.DeepPink;
                            btn63.BackColor = Color.DeepPink;
                            btn74.BackColor = Color.DeepPink;
                            btn85.BackColor = Color.DeepPink;
                            btn96.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 3:
                            label4.Visible = false;
                            btn4.BackColor = Color.DeepPink;
                            btn15.BackColor = Color.DeepPink;
                            btn26.BackColor = Color.DeepPink;
                            btn37.BackColor = Color.DeepPink;
                            btn48.BackColor = Color.DeepPink;
                            btn59.BackColor = Color.DeepPink;
                            btn70.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 4:
                            label5.Visible = false;
                            btn33.BackColor = Color.DeepPink;
                            btn44.BackColor = Color.DeepPink;
                            btn55.BackColor = Color.DeepPink;
                            btn66.BackColor = Color.DeepPink;
                            btn77.BackColor = Color.DeepPink;
                            btn88.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 5:
                            label6.Visible = false;
                            btn34.BackColor = Color.DeepPink;
                            btn35.BackColor = Color.DeepPink;
                            btn36.BackColor = Color.DeepPink;
                            btn37.BackColor = Color.DeepPink;
                            btn38.BackColor = Color.DeepPink;
                            btn39.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 6:
                            label7.Visible = false;
                            btn94.BackColor = Color.DeepPink;
                            btn84.BackColor = Color.DeepPink;
                            btn74.BackColor = Color.DeepPink;
                            btn64.BackColor = Color.DeepPink;
                            btn54.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 7:
                            label8.Visible = false;
                            btn75.BackColor = Color.DeepPink;
                            btn76.BackColor = Color.DeepPink;
                            btn77.BackColor = Color.DeepPink;
                            btn78.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 8:
                            label9.Visible = false;
                            btn10.BackColor = Color.DeepPink;
                            btn9.BackColor = Color.DeepPink;
                            btn8.BackColor = Color.DeepPink;
                            btn7.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 9:
                            label10.Visible = false;
                            btn10.BackColor = Color.DeepPink;
                            btn20.BackColor = Color.DeepPink;
                            btn30.BackColor = Color.DeepPink;
                            btn40.BackColor = Color.DeepPink;
                            btn50.BackColor = Color.DeepPink;
                            btn60.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 10:
                            label11.Visible = false;
                            btn21.BackColor = Color.DeepPink;
                            btn22.BackColor = Color.DeepPink;
                            btn23.BackColor = Color.DeepPink;
                            btn24.BackColor = Color.DeepPink;
                            btn25.BackColor = Color.DeepPink;
                            btn26.BackColor = Color.DeepPink;
                            btn27.BackColor = Color.DeepPink;
                            btn28.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 11:
                            label12.Visible = false;
                            btn93.BackColor = Color.DeepPink;
                            btn94.BackColor = Color.DeepPink;
                            btn95.BackColor = Color.DeepPink;
                            btn96.BackColor = Color.DeepPink;
                            btn97.BackColor = Color.DeepPink;
                            btn98.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 12:
                            label13.Visible = false;
                            btn99.BackColor = Color.DeepPink;
                            btn89.BackColor = Color.DeepPink;
                            btn79.BackColor = Color.DeepPink;
                            btn69.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 13:
                            label14.Visible = false;
                            btn2.BackColor = Color.DeepPink;
                            btn12.BackColor = Color.DeepPink;
                            btn22.BackColor = Color.DeepPink;
                            btn32.BackColor = Color.DeepPink;
                            btn42.BackColor = Color.DeepPink;
                            btn52.BackColor = Color.DeepPink;
                            btn62.BackColor = Color.DeepPink;
                            btn72.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 14:
                            label15.Visible = false;
                            btn1.BackColor = Color.DeepPink;
                            btn11.BackColor = Color.DeepPink;
                            btn21.BackColor = Color.DeepPink;
                            btn31.BackColor = Color.DeepPink;
                            dem++;
                            break;
                        case 15:
                            label16.Visible = false;
                            btn47.BackColor = Color.DeepPink;
                            btn56.BackColor = Color.DeepPink;
                            btn65.BackColor = Color.DeepPink;
                            btn74.BackColor = Color.DeepPink;
                            btn83.BackColor = Color.DeepPink;
                            btn92.BackColor = Color.DeepPink;
                            dem++;
                            break;

                    }
                }

            }
            txt1.Text = "";
            ketthuc();
            click1lan();
        }



        public void click1lan()
        {
            btn1.Enabled = true;
            btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true; btn5.Enabled = true; btn6.Enabled = true;
            btn7.Enabled = true; btn8.Enabled = true; btn9.Enabled = true; btn10.Enabled = true; btn11.Enabled = true;
            btn12.Enabled = true; btn13.Enabled = true; btn14.Enabled = true; btn15.Enabled = true; btn16.Enabled = true;
            btn17.Enabled = true; btn18.Enabled = true; btn19.Enabled = true; btn20.Enabled = true; btn21.Enabled = true;
            btn22.Enabled = true; btn23.Enabled = true; btn24.Enabled = true; btn25.Enabled = true; btn26.Enabled = true;
            btn27.Enabled = true; btn28.Enabled = true; btn29.Enabled = true; btn30.Enabled = true; btn31.Enabled = true;
            btn32.Enabled = true; btn33.Enabled = true;
            btn34.Enabled = true; btn35.Enabled = true; btn36.Enabled = true; btn37.Enabled = true; btn38.Enabled = true;
            btn39.Enabled = true; btn40.Enabled = true; btn41.Enabled = true;
            btn42.Enabled = true; btn43.Enabled = true; btn44.Enabled = true; btn45.Enabled = true; btn46.Enabled = true;
            btn47.Enabled = true; btn48.Enabled = true; btn49.Enabled = true; btn50.Enabled = true; btn51.Enabled = true;
            btn52.Enabled = true; btn53.Enabled = true; btn54.Enabled = true; btn55.Enabled = true; btn56.Enabled = true;
            btn57.Enabled = true; btn58.Enabled = true; btn59.Enabled = true; btn60.Enabled = true; btn61.Enabled = true;
            btn62.Enabled = true; btn63.Enabled = true; btn64.Enabled = true; btn65.Enabled = true; btn66.Enabled = true;
            btn67.Enabled = true; btn68.Enabled = true; btn69.Enabled = true; btn70.Enabled = true; btn71.Enabled = true;
            btn72.Enabled = true; btn73.Enabled = true; btn74.Enabled = true; btn75.Enabled = true; btn76.Enabled = true;
            btn77.Enabled = true; btn78.Enabled = true; btn79.Enabled = true; btn80.Enabled = true; btn81.Enabled = true;
            btn82.Enabled = true; btn83.Enabled = true; btn84.Enabled = true; btn85.Enabled = true; btn86.Enabled = true;
            btn87.Enabled = true; btn88.Enabled = true; btn89.Enabled = true; btn90.Enabled = true; btn91.Enabled = true;
            btn92.Enabled = true; btn93.Enabled = true; btn94.Enabled = true; btn95.Enabled = true; btn96.Enabled = true;
            btn97.Enabled = true; btn98.Enabled = true; btn99.Enabled = true; btn100.Enabled = true;


        }



        protected void ketthuc()
        {
            if (dem == 16)
            {
                String a = "";
                String b = "";
                panel1.Visible = false;
                txt1.Visible = false;
                go.Visible = false;
                timer1.Stop();
                a = lbPhut.Text;
                b = lbGiay.Text;
                DialogResult d = MessageBox.Show("Chúc Mừng bạn đã chiến thắng với thời gian là : " + a + " phút " + b + " giây ", "Thông báo ", MessageBoxButtons.OK);
            }


        }

        private void Fruits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void Fruits_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Trở về form trước", "Thông Báo", MessageBoxButtons.YesNo);
            if (d == DialogResult.No)
            {

                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(lbPhut.Text);
            int b = Int32.Parse(lbGiay.Text);
            b++;
            if (b > 59)
            {
                b = 0;
                a++;
            }
            if (b < 10)
                lbGiay.Text = "0" + b;
            else
                lbGiay.Text = b + "";
            if (a < 10)
                lbPhut.Text = "0" + a;
            else
                lbPhut.Text = a + "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
