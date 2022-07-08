using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RJControls.RJConpanents;

namespace _202523049_MelihKüçük
{
    public partial class SifremiUnuttum : Form
    {

        bool formMoving = false;
        Point startPoint = new Point(0, 0);

        public SifremiUnuttum()
        {

            InitializeComponent();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
       

        private void LoginScreen_Load(object sender, EventArgs e)
        {

            rjButtonİptal.BackColor = ColorTranslator.FromHtml("#EE1B24");
            //rJtextBox1.BorderColor=ColorTranslator.FromHtml("#EE1B24");
            //rJtextBox2.BorderColor = ColorTranslator.FromHtml("#EE1B24");
            //this.BackColor = ColorTranslator.FromHtml("#34699a");

            //LOGİN SAYFASINDAKİ SEKME KAPAMA AÇMA
            ToolTip toolTipHomePageClose = new ToolTip()
            {
                InitialDelay = 200,
                ReshowDelay = 300,
                AutoPopDelay = 2000
            };
            toolTipHomePageClose.SetToolTip(btnLoginScreenClose, "Çıkış");

            btnLoginScreenClose.FlatAppearance.BorderSize = 0;
            btnLoginScreenClose.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#EE1B24");
            //
            //btnHomePageHide
            //
            ToolTip toolTipHomePageHide = new ToolTip()
            {
                InitialDelay = 200,
                ReshowDelay = 300,
                AutoPopDelay = 2000
            };
            toolTipHomePageHide.SetToolTip(btnLoginScreenHide, "Küçült");

            btnLoginScreenHide.FlatAppearance.BorderSize = 0;
            btnLoginScreenHide.FlatAppearance.MouseOverBackColor = Color.Gray;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rJtextBox1_Click(object sender, EventArgs e)
        {
            if (rJmailKontrol.Texts == "Kullanıcı Adı")
                rJmailKontrol.Texts = string.Empty;
            else if (rJmailKontrol.Texts == string.Empty)
                rJmailKontrol.Texts = "Kullanıcı Adı";

        }

        private void LoginScreen_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void LoginScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void LoginScreen_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }





        private void btnLoginScreenClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLoginScreenHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rjButtonGönder_Click(object sender, EventArgs e)
        {
            VeriTabanı.Eposta(rJmailKontrol);

            if (VeriTabanı.gonderildimi == true)
            {
                rjButtonKodOnayla.Visible = true;
                rJtextKod.Visible = true;
            }
        }

        private void rjButtonKodOnayla_Click(object sender, EventArgs e)
        {
            if (rJtextKod.Texts == VeriTabanı.sıfırlamaKodu.ToString())
            {
                this.Hide();
                YeniSifre yeniSifre = new YeniSifre();
                yeniSifre.Show();
            }
        }

        private void rJmailKontrol_Click(object sender, EventArgs e)
        {
          
                 if (rJmailKontrol.Texts == " E - posta adresinizi Girin")
                rJmailKontrol.Texts = string.Empty;
            else if (rJmailKontrol.Texts == string.Empty)
                rJmailKontrol.Texts = " E - posta adresinizi Girin";
        }

        private void rJtextKod_Click(object sender, EventArgs e)
        {
           
                if (rJtextKod.Texts == "  Doğrulama Kodunu Girin")
                rJtextKod.Texts = string.Empty;
            else if (rJtextKod.Texts == string.Empty)
                rJtextKod.Texts = "  Doğrulama Kodunu Girin";
        }

        private void rjButtonİptal_Click(object sender, EventArgs e)
        {
            KayıtOl kayıtOl = new KayıtOl();
            this.Hide();
            kayıtOl.Show();
        }
    }
    }

