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
    public partial class KayıtOl : Form
    {
        bool formMoving = false;
        Point startPoint = new Point(0, 0);
        public static string MyUserSession = "";

        public KayıtOl()
        {
            InitializeComponent();
        }

        private void panelKayıtScreen_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelKayıtScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panelKayıtScreen_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }

        private void KayıtOl_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void KayıtOl_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void KayıtOl_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }

        private void KayıtOl_Load(object sender, EventArgs e)
        {
            lblProgram.ForeColor = ColorTranslator.FromHtml("#CF3D1E");
            rJKayıtSifretextBox.PasswordChar = true;
            rJGirisSifretextBox.PasswordChar = true;

            ToolTip toolTipEposta = new ToolTip()
            {
                AutoPopDelay = 1000,
                InitialDelay = 190,
                ReshowDelay = 250,

            };
            toolTipEposta.SetToolTip(rJMailtextBox, "Lütfen Sahil Güvenlik E-Postanızı Kullanın");

            // btnLoginScreenClose & btnLoginScreenHide
            btnLoginScreenClose.FlatAppearance.BorderSize = 0;
            btnLoginScreenHide.FlatAppearance.BorderSize = 0;

        }

        private void btnLoginScreenClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLoginScreenHide_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void KayıtButton_Click(object sender, EventArgs e)
        {
          
           
                
          
            
           
        
            VeriTabanı.KayıtEkle(rJKayıtUserNametextBox, rJMailtextBox, rJKayıtSifretextBox, rJTelefontextBox);
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            VeriTabanı.Login(this, rJGirisMailtextBox, rJGirisSifretextBox);
            
            CezaEkranı cezaEkranı = new CezaEkranı();
            MyUserSession = rJGirisMailtextBox.Texts;
            this.Hide();
            cezaEkranı.Show();
        }

      

        private void rJKayıtUserNametextBox_Click(object sender, EventArgs e)
        {
            //if (rJKayıtUserNametextBox.Texts == "Ad Soyad"  )
            //    rJKayıtUserNametextBox.Texts = string.Empty;
            //else if (rJKayıtUserNametextBox.Texts == string.Empty && rJKayıtUserNametextBox.Cursor) 
            //rJKayıtUserNametextBox.Texts = "Ad Soyad";
            rJKayıtUserNametextBox.Texts = string.Empty;
        }

        private void rJMailtextBox_Click(object sender, EventArgs e)
        {
            if (rJMailtextBox.Texts == "E-Posta")
                rJMailtextBox.Texts = string.Empty;
            else if (rJMailtextBox.Texts == string.Empty)
                rJMailtextBox.Texts = "E-Posta";
        }

        private void rJTelefontextBox_Click(object sender, EventArgs e)
        {
            if (rJTelefontextBox.Texts == "Telefon No")
                rJTelefontextBox.Texts = string.Empty;
            else if (rJTelefontextBox.Texts == string.Empty)
                rJTelefontextBox.Texts = "Telefon No";

        }

        private void rJKayıtSifretextBox_Click(object sender, EventArgs e)
        {
            if (rJKayıtSifretextBox.Texts == "Şifre")
                rJKayıtSifretextBox.Texts = string.Empty;
            else if (rJKayıtSifretextBox.Texts == string.Empty)
                rJKayıtSifretextBox.Texts = "Şifre";
        }

        private void rJGirisMailtextBox_Click(object sender, EventArgs e)
        {
            if (rJGirisMailtextBox.Texts == "E-Posta")
                rJGirisMailtextBox.Texts = string.Empty;
            else if (rJGirisMailtextBox.Texts == string.Empty)
                rJGirisMailtextBox.Texts = "E-Posta";
        }

        private void rJGirisSifretextBox_Click(object sender, EventArgs e)
        {
            if (rJGirisSifretextBox.Texts == "Şifre")
                rJGirisSifretextBox.Texts = string.Empty;
            else if (rJGirisSifretextBox.Texts == string.Empty)
                rJGirisSifretextBox.Texts = "Şifre";
        }

        private void rJKayıtUserNametextBox__TextChanged(object sender, EventArgs e)
        {
            if (rJTelefontextBox.Texts == "Ad Soyad")
                rJTelefontextBox.Texts = string.Empty;
            else if (rJTelefontextBox.Texts == string.Empty)
                rJTelefontextBox.Texts = "Ad Soyad";
        }

        private void linklblsifremiunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            this.Hide();
            sifremiUnuttum.Show();

        }

        private void linkLabelMisafir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AnaSorguSayfa anaSorguSayfa = new AnaSorguSayfa();
            this.Hide();
            anaSorguSayfa.Show();
        }
    }
    }
