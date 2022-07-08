using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202523049_MelihKüçük
{
    public partial class YeniSifre : Form
    {
        public YeniSifre()
        {
            InitializeComponent();
        }

        private void rjButtonYeniSifreOnay_Click(object sender, EventArgs e)
        {

            VeriTabanı.SifreGuncelle(rJYeniSifre);
            KayıtOl kayıtOl = new KayıtOl();
            this.Hide();
            kayıtOl.Show();


        }

        //private void btnLoginScreenClose_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        //    if (result == DialogResult.Yes)
        //        Application.Exit();
        //}

        //private void btnLoginScreenHide_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        private void btnLoginScreenClose_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLoginScreenHide_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
