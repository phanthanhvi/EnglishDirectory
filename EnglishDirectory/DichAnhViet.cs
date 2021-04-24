using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

namespace EnglishDirectory
{
    public partial class DichAnhViet : UserControl
    {
        string[] arrNghia;
        SpVoice voice = new SpVoice();
        string[] arrTu;
        public DichAnhViet()
        {
            InitializeComponent();
            arrTu = System.IO.File.ReadAllLines("english.txt");
            
            string content;
            content = System.IO.File.ReadAllText("anhviet109K.txt");

            arrNghia = content.Split(new char[] { '@' });
            SetDataToCollection();
        }
        private void SetDataToCollection()
        {
            
            AutoCompleteStringCollection auto1 = new AutoCompleteStringCollection();
            auto1.AddRange(arrTu);


            txtNhapTu.AutoCompleteCustomSource = auto1;
        }


        private void DichTu()
        {
            int i = Array.IndexOf(arrTu, txtNhapTu.Text);
            if (i < 0)
            {
                rtbTu.Text = "\nKhông có từ này";
            }
            else
            {
                rtbTu.Text = "\n"+arrNghia[i + 1];
            }
        }
        private void DichVanBan()
        {
            try
            {
                if (txtNhapVB.Text == "")
                {
                    rtbVB.Text = "";
                }
                else
                {
                    TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                    client = new TranslatorService.LanguageServiceClient();
                    rtbVB.Text = "\n" + client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", txtNhapVB.Text, "", "vi");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnDich_Click(object sender, EventArgs e)
        {
            DichTu();
        }

        private void btnPhat_Click(object sender, EventArgs e)
        {
            voice.Speak(txtNhapTu.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        

        private void txtNhapVB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DichVanBan();
            }
        }

        private void btnDichVB_Click(object sender, EventArgs e)
        {
            DichVanBan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNhapTu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DichTu();
            }
        }

        private void btnCopyVB_Click(object sender, EventArgs e)
        {
            if(rtbVB.Text !="")
            {
                System.Windows.Forms.Clipboard.SetText(rtbVB.Text);
            }    
            else
            {
                System.Windows.Forms.Clipboard.SetText(" ");
            }    
            
        }

    }
}
