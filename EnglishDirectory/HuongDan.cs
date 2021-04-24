using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2808
{
    public partial class HuongDan : Form
    {
        public HuongDan()
        {
            InitializeComponent();
        }

      

        private void btBackForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("Multiple"))
                textBox1.Text = " Trò chơi trắc nghiệm có 20 câu hỏi ngẫu nhiên. \n Mỗi câu hỏi có 30s để suy nghĩ và trả lời.\nMỗi câu trả lời đúng được cộng 10 điểm. Trả lời sai trò chơi sẽ kết thúc.\nTrong quá trình chơi, người chơi có hai sự trợ giúp:\n+ Giảm đi hai phương án sai.\n+ Bỏ qua một câu hỏi.\nNgoài ra từ câu hỏi số 1 trở đi, người chơi còn có thể đặt ngôi sao may mắn trước khi qua câu hỏi kế tiếp. Mỗi câu trả lời đúng có ngôi sao sẽ được cộng 10 điểm.\nGood luck!!! ";
        }
    }
}
