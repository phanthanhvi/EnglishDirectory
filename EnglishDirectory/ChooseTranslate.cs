using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishDirectory
{
    public partial class ChooseTranslate : Form
    {
        Control av = new DichAnhViet();
        Control va = new DichVietAnh();
        public ChooseTranslate()
        {
            InitializeComponent();
        }

        private void btnAV_Click(object sender, EventArgs e)
        {
            openChildForm(av);
        }
        private void openChildForm(Control childForm)
        {
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnVA_Click(object sender, EventArgs e)
        {
            openChildForm(va);
        }
    }
}
