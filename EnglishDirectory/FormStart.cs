using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.Resources;
namespace Demo2808
{
    public partial class FormStart : Form
    {
        SoundPlayer music = new SoundPlayer();
        SoundPlayer music3 = new SoundPlayer();
        List<int> MyList = new List<int>();
        Button bt = new Button();
        private int dem = 0; // biến đếm quản lý tạo câu hỏi
        private int diem = 0; // điểm số
        private int counter; // biến đếm thời gian
        //Kiểm tra button nào được click
        private bool click = false;
        //Kiểm tra button click làm điều kiện để chóp đán án đúng
        private bool AA = false;
        private bool BB = false;
        private bool CC = false;
        private bool DD = false;
        private bool ngoiSao = false;
        //Kiểm tra game đã over chưa
        private bool over = false;
        // phương thức đổi màu gọi timer
        private void DoiMau()
        {
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }
        //phương thức tạo câu hỏi
        private void TaoCauHoi()
        {
            btC.FlatAppearance.BorderSize = 1;
            btC.FlatAppearance.BorderColor = Color.White;
            btA.FlatAppearance.BorderSize = 1;
            btA.FlatAppearance.BorderColor = Color.White;
            btD.FlatAppearance.BorderSize = 1;
            btB.FlatAppearance.BorderSize = 1;
            btD.FlatAppearance.BorderColor = Color.White;
            btB.FlatAppearance.BorderColor = Color.White;
            if (ngoiSao == true)
            {
                lbCauHoi.BackColor = Color.FromArgb(255, 193, 0);
            }
            else
            {
                lbCauHoi.BackColor = Color.White;
            }
            if (diem == 200)
            {
                GameWin();
            }
            else
            {
                music.SoundLocation = @"ResourceTracNghiem\TT_30s.wav";
                music.Play();
                counter = int.Parse(lbTime.Text);
                dem++;
                timer1.Enabled = true;
                btNext.Enabled = false;
                btA.Enabled = true;
                btB.Enabled = true;
                btC.Enabled = true;
                btD.Enabled = true;
                lbYKien.Text = "";
                Random rand = new Random();
                string[] lines = File.ReadAllLines(@"ResourceTracNghiem\CauHoi1.txt");//đọc tất cả các dòng trong file
                int temp = rand.Next(0, 30);// random câu hỏi
                //vòng lặp kiểm tra kiểm tra giá trị random có bị trùng lập hay không
                for (int j = 0; j < MyList.Count; j++)
                {
                    while (MyList.Contains(temp) == true)
                    {
                        temp = rand.Next(0, 30);
                    }
                }
                MyList.Add(temp);// lưu giá trị random vào danh sách
                //sinh ra câu hỏi ngẫu nhiên
                for (int i = 0; i < lines.Length; i++)//duyệt mỗi dòng
                {
                    if (i == temp)// random 1 dòng ngẫu nhiên
                    {
                        string[] values = lines[i].Split(',');// tại dòng đó cắt chuỗi thành các chuỗi con lưu vào mảng values
                        lbCauHoi.Text = values[0]; //hiển thị lên Question
                        btA.Text = values[1];
                        btB.Text = values[2];
                        btC.Text = values[3];
                        btD.Text = values[4];
                        bt.Text = values[5];
                    }
                }
            }
        }
        //random ngẫu nhiên các chuỗi khi người dùng trả lời đúng
        private void ThongBaoDung()
        {
            btLucky.Enabled = true;
            SoundPlayer music1 = new SoundPlayer();
            music1.SoundLocation = @"ResourceTracNghiem\VĐ_câu_đúng_2020.wav";
            music1.Play();
            Random rand = new Random();
            string[] nhanxet = { "Excellent!!!", "Very good!", "Good!!!", "Correct!" };
            int viTri = rand.Next(0, 3);
            lbYKien.Text = nhanxet[viTri];
            btA.Enabled = false;
            btB.Enabled = false;
            btC.Enabled = false;
            btD.Enabled = false;
        }

        private void TimeOut()
        {
            over = true;
            string s = String.Format("Score is {0}!!!", diem);
            if (MessageBox.Show("Time out..." + s + "Are you start again???", "Game over...", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
            else
                this.Close();
        }
        private void GameWin()
        {
            if (dem == 20 && MessageBox.Show("You are excellent. Your scores is 200", "Are you win!!!", MessageBoxButtons.OK) == DialogResult.OK)
            {
                Close();
            }
        }
        private void GameOver()
        {
            over = true;
            string s = String.Format("Score is {0}!!!",diem);
            if (MessageBox.Show("Incorrect!!!" + s + "Thank you", "Game over...", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
                
            }
            else
                this.Close();
        }
        //người dùng trả lời sai game kết thúc
        private void ThongBaoSai()
        {
                SoundPlayer music1 = new SoundPlayer();
                music1.SoundLocation = @"ResourceTracNghiem\VĐ_câu_sai_2020.wav";
                music1.Play();
                diem += 0;
                lbScore.Text = diem.ToString();
                lbYKien.Text = "Incorrect!!!";
                GameOver();
        }
        public FormStart()
        {
            InitializeComponent();
        }
        private void FormStart_Load(object sender, EventArgs e)
        {
            over = false;
            bt1.Enabled = false;
            bt2.Enabled = false;
            bt3.Enabled = false;
            bt4.Enabled = false;
            bt5.Enabled = false;
            bt6.Enabled = false;
            bt7.Enabled = false;
            bt8.Enabled = false;
            bt9.Enabled = false;
            bt10.Enabled = false;
            bt11.Enabled = false;
            bt12.Enabled = false;
            bt13.Enabled = false;
            bt14.Enabled = false;
            bt15.Enabled = false;
            bt16.Enabled = false;
            bt17.Enabled = false;
            bt18.Enabled = false;
            bt19.Enabled = false;
            bt20.Enabled = false;
            btNext.Enabled = false;
            TaoCauHoi();
        }
        private void Question()
        {
            if (dem <= 20)
            {
                if (bt1.Text == dem.ToString())
                {
                    bt1.BackColor = Color.Red;
                }
                if (bt2.Text == dem.ToString())
                {
                    bt2.BackColor =  Color.Red;
                }
                if (bt3.Text == dem.ToString())
                {
                    bt3.BackColor = Color.Red;
                }
                if (bt4.Text == dem.ToString())
                {
                    bt4.BackColor = Color.Red;
                }
                if (bt5.Text == dem.ToString())
                {
                    bt5.BackColor = Color.Red;
                }
                if (bt6.Text == dem.ToString())
                {
                    bt6.BackColor = Color.Red;
                }
                if (bt7.Text == dem.ToString())
                {
                    bt7.BackColor = Color.Red;
                }
                if (bt8.Text == dem.ToString())
                {
                    bt8.BackColor = Color.Red;
                }
                if (bt9.Text == dem.ToString())
                {
                    bt9.BackColor = Color.Red;
                }
                if (bt10.Text == dem.ToString())
                {
                    bt10.BackColor = Color.Red;
                }
                if (bt11.Text == dem.ToString())
                {
                    bt11.BackColor = Color.Red;
                }
                if (bt12.Text == dem.ToString())
                {
                    bt12.BackColor = Color.Red;
                }
                if (bt13.Text == dem.ToString())
                {
                    bt13.BackColor = Color.Red;
                }
                if (bt14.Text == dem.ToString())
                {
                    bt14.BackColor = Color.Red;
                }
                if (bt15.Text == dem.ToString())
                {
                    bt15.BackColor = Color.Red;
                }
                if (bt16.Text == dem.ToString())
                {
                    bt16.BackColor = Color.Red;
                }
                if (bt17.Text == dem.ToString())
                {
                    bt17.BackColor = Color.Red;
                }
                if (bt18.Text == dem.ToString())
                {
                    bt18.BackColor = Color.Red;
                }
                if (bt19.Text == dem.ToString())
                {
                    bt19.BackColor = Color.Red;
                }
                if (bt20.Text == dem.ToString())
                {
                    bt20.BackColor = Color.Red;
                }
            }
        }
        //Cấu trúc chung của sự kiện các button click
        // Khi click vào button bất kì thì thời gian sẽ dừng lại, button được chọn sẽ tô màu xanh, đáp án đúng tô vàng, sai tô đỏ
        // Nếu hủy button sẽ trở về màu bình thường , thời gian tiếp tục chạy
        // Khi chọn button đáp án bất kì thì button Next mới cho phép thực hiện
        // Trả lời đúng được cộng điểm, trả lời sai gameover
        //ý tưởng: so sánh giá trị button câu hỏi sau đó kiểm tra với biến đếm. nếu trả lời đúng thì button sẽ tô vàng
        private void btA_Click(object sender, EventArgs e)
        {
            click = true;
            music.Stop();
            timer1.Enabled = false;
            btNext.Enabled = true;
            btA.BackColor = Color.Blue;
            if (MessageBox.Show("Are you sure with this answer?", "Note", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (btA.Text == bt.Text)
                {
                    AA = true;
                    DoiMau();
                    if (ngoiSao == true)
                    {
                        diem += 20;
                        ngoiSao = false;
                    }
                    else
                        diem += 10; 
                    lbScore.Text = diem.ToString();
                    ThongBaoDung();
                    btA.BackColor = Color.FromArgb(255, 193, 0);
                    btA.FlatAppearance.BorderSize = 1;
                    btA.FlatAppearance.BorderColor = Color.Black;
                    Question();
                }
                else
                {
                    btA.BackColor = Color.FromArgb(53, 45, 125);
                    if (ngoiSao == true)
                        diem -= 20;
                    ThongBaoSai();
                }
            }
            else
            {
                AA = false;
                click = false;
                music.Play();
                timer1.Enabled = true;
                btNext.Enabled = false;
                btA.BackColor = Color.White;
            }
            ngoiSao = false;
        }
        private void btB_Click(object sender, EventArgs e)
        {
            click = true;
            music.Stop();
            timer1.Enabled = false;
            btNext.Enabled = true;
            btB.BackColor = Color.Blue;
            if (MessageBox.Show("Are you sure with this answer??", "Note", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (btB.Text == bt.Text)
                {
                    BB = true;
                    DoiMau();
                    if (ngoiSao == true)
                    {
                        diem += 20;
                        ngoiSao = false;
                    }
                    else
                        diem += 10; ;
                    lbScore.Text = diem.ToString();
                    btB.BackColor = Color.FromArgb(255, 193, 0);
                    btB.FlatAppearance.BorderSize = 1;
                    btB.FlatAppearance.BorderColor = Color.Black;
                    ThongBaoDung();
                    Question();
                }
                else
                {
                    if (ngoiSao == true)
                        diem -= 20;
                    btB.BackColor = Color.FromArgb(53, 45, 125);
                    ThongBaoSai();
                }
            }
            else
            {
                BB = false;
                click = false;
                music.Play();
                timer1.Enabled = true;
                btNext.Enabled = false;
                btB.BackColor = Color.White;
            }
            ngoiSao = false;
        }
        private void btC_Click(object sender, EventArgs e)
        {
            click = true;
            music.Stop();
            timer1.Enabled = false;
            btNext.Enabled = true;
            btC.BackColor = Color.Blue;
            if (MessageBox.Show("Are you sure with this answer??", "Note", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (btC.Text == bt.Text)
                {
                    CC = true;
                    DoiMau();
                    if (ngoiSao == true)
                    {
                        diem += 20;
                        ngoiSao = false;
                    }
                    else
                        diem += 10; 
                    lbScore.Text = diem.ToString();
                    btC.BackColor = Color.FromArgb(255, 193, 0);
                    btC.FlatAppearance.BorderSize = 1;
                    btC.FlatAppearance.BorderColor = Color.Black;
                    ThongBaoDung();
                    Question();
                }
                else
                {
                    if (ngoiSao == true)
                        diem -= 20;
                    btC.BackColor = Color.FromArgb(53, 45, 125);
                    ThongBaoSai();
                }
            }
            else
            {
                CC = false;
                click = false;
                music.Play();
                timer1.Enabled = true;
                btNext.Enabled = false;
                btC.BackColor = Color.White;
            }
            ngoiSao = false;
        }
        private void btD_Click(object sender, EventArgs e)
        {
            click = true;
            music.Stop();
            timer1.Enabled = false;
            btNext.Enabled = true;
            btD.BackColor = Color.Blue;
            if (MessageBox.Show("Are you sure with this answer?", "Note", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (btD.Text == bt.Text)
                {
                    DD = true;
                    DoiMau();
                    if (ngoiSao == true)
                    {
                        diem += 20;
                        ngoiSao = false;
                    }
                    else
                        diem += 10;
                    lbScore.Text = diem.ToString();
                    btD.BackColor = Color.FromArgb(255, 193, 0);
                    btD.FlatAppearance.BorderSize = 1;
                    btD.FlatAppearance.BorderColor = Color.Black;
                    ThongBaoDung();
                    Question();
                }
                else
                {
                    if (ngoiSao == true)
                        diem -= 20;
                    btD.BackColor = Color.FromArgb(53, 45, 125);
                    ThongBaoSai();
                }
            }
            else
            {
                DD = false;
                click = false;
                music.Play();
                timer1.Enabled = true;
                btNext.Enabled = false;
                btD.BackColor = Color.White;
            }
            ngoiSao = false;
        }
        //quyền trợ giúp bỏ qua một câu hỏi
         //ý tưởng: gọi hàm tạo câu hỏi, sau đó vô hiệu hóa button trợ giúp
        private void btQua_Click(object sender, EventArgs e)
        {
            lbTime.Text = "30";
            TaoCauHoi();
            dem--;// giảm biến đếm vì khi bỏ qua câu hỏi, sẽ tạo ra câu hỏi mới dẫn đến tăng thêm 1 giá trị của biến đếm
            btQua.Enabled = false;
        }
        //quyền trợ giúp 50/50
        //ý tưởng: so sánh đáp án với giá trị trong các button, loại trừ các đáp án sai, sau đó vô hiệu hóa trợ giúp bằng giá trị flase của enable
        private void bt50_Click(object sender, EventArgs e)
        {
            bt50.Enabled = false;
            if (btA.Text == bt.Text)
            {
                btC.Text = "";
                btC.Enabled = false;
                btB.Text = "";
                btB.Enabled = false;
            }
            if (btB.Text == bt.Text)
            {
                btA.Text = "";
                btA.Enabled = false;
                btC.Text = "";
                btC.Enabled = false;
            }
            if (btC.Text == bt.Text)
            {
                btA.Text = "";
                btA.Enabled = false;
                btD.Text = "";
                btD.Enabled = false;
            }
            if (btD.Text == bt.Text)
            {
                btB.Text = "";
                btB.Enabled = false;
                btD.Text = "";
                btD.Enabled = false;
            }
        }
        private void btBackForm_Click(object sender, EventArgs e)
        {
            music.Stop();
            this.Close();
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            music3.Stop();
             btLucky.Enabled = false;
             lbTime.Text = "30";
             btA.BackColor = Color.White;
             btB.BackColor = Color.White;
             btC.BackColor = Color.White;
             btD.BackColor = Color.White;
             TaoCauHoi();
             AA = BB = CC = DD = false;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            music.Stop();
            if (over==false&& dem < 20 && MessageBox.Show("You have not completed the test ???", "Are you close???", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            counter = counter - 1;
            lbTime.Text = counter.ToString();
            if (counter == 0)
            {
                timer1.Stop();
                music.Stop();
                TimeOut();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (AA == true) 
                btA.BackColor = Color.Red;
            if (BB == true)
                btB.BackColor = Color.Red;
            if (CC == true)
                btC.BackColor = Color.Red;
            if (DD == true)
                btD.BackColor = Color.Red;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (AA == true)
                btA.BackColor = Color.Blue;
            if (BB == true)
                btB.BackColor = Color.Blue;
            if (CC == true)
                btC.BackColor = Color.Blue;
            if (DD == true)
                btD.BackColor = Color.Blue;
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (AA == true)
                btA.BackColor = Color.Yellow;
            if (BB == true)
                btB.BackColor = Color.Yellow;
            if (CC == true)
                btC.BackColor = Color.Yellow;
            if (DD == true)
                btD.BackColor = Color.Yellow;
        }
        private void btLucky_Click(object sender, EventArgs e)
        {
            music3.SoundLocation = @"ResourceTracNghiem\VĐ_ngôi_sao (online-audio-converter.com).wav";
            music3.Play();
            ngoiSao = true;
        }

      


    }
}
