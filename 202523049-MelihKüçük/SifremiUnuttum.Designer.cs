
namespace _202523049_MelihKüçük
{
    partial class SifremiUnuttum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.btnLoginScreenClose = new System.Windows.Forms.Button();
            this.btnLoginScreenHide = new System.Windows.Forms.Button();
            this.labelgönderilecekmail = new System.Windows.Forms.Label();
            this.rJmailKontrol = new RJconpanents.RJtextBox();
            this.rjButtonGönder = new RJControls.RJConpanents.RJButton();
            this.rjButtonİptal = new RJControls.RJConpanents.RJButton();
            this.rJtextKod = new RJconpanents.RJtextBox();
            this.rjButtonKodOnayla = new RJControls.RJConpanents.RJButton();
            this.SuspendLayout();
            // 
            // btnLoginScreenClose
            // 
            this.btnLoginScreenClose.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginScreenClose.FlatAppearance.BorderSize = 0;
            this.btnLoginScreenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginScreenClose.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLoginScreenClose.Location = new System.Drawing.Point(538, 1);
            this.btnLoginScreenClose.Name = "btnLoginScreenClose";
            this.btnLoginScreenClose.Size = new System.Drawing.Size(45, 31);
            this.btnLoginScreenClose.TabIndex = 15;
            this.btnLoginScreenClose.Text = "X";
            this.btnLoginScreenClose.UseVisualStyleBackColor = false;
            this.btnLoginScreenClose.Click += new System.EventHandler(this.btnLoginScreenClose_Click);
            // 
            // btnLoginScreenHide
            // 
            this.btnLoginScreenHide.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginScreenHide.FlatAppearance.BorderSize = 0;
            this.btnLoginScreenHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginScreenHide.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLoginScreenHide.Location = new System.Drawing.Point(496, 1);
            this.btnLoginScreenHide.Name = "btnLoginScreenHide";
            this.btnLoginScreenHide.Size = new System.Drawing.Size(45, 31);
            this.btnLoginScreenHide.TabIndex = 16;
            this.btnLoginScreenHide.Text = "—";
            this.btnLoginScreenHide.UseVisualStyleBackColor = false;
            this.btnLoginScreenHide.Click += new System.EventHandler(this.btnLoginScreenHide_Click);
            // 
            // labelgönderilecekmail
            // 
            this.labelgönderilecekmail.AutoSize = true;
            this.labelgönderilecekmail.BackColor = System.Drawing.Color.Transparent;
            this.labelgönderilecekmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelgönderilecekmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelgönderilecekmail.Location = new System.Drawing.Point(286, 34);
            this.labelgönderilecekmail.Name = "labelgönderilecekmail";
            this.labelgönderilecekmail.Size = new System.Drawing.Size(164, 25);
            this.labelgönderilecekmail.TabIndex = 18;
            this.labelgönderilecekmail.Text = "Şifremi Unuttum";
            // 
            // rJmailKontrol
            // 
            this.rJmailKontrol.BackColor = System.Drawing.SystemColors.Window;
            this.rJmailKontrol.BorderColor = System.Drawing.Color.Crimson;
            this.rJmailKontrol.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJmailKontrol.BorderSize = 2;
            this.rJmailKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rJmailKontrol.ForeColor = System.Drawing.Color.DimGray;
            this.rJmailKontrol.Location = new System.Drawing.Point(248, 74);
            this.rJmailKontrol.Margin = new System.Windows.Forms.Padding(4);
            this.rJmailKontrol.MaxLength = 32767;
            this.rJmailKontrol.Multiline = false;
            this.rJmailKontrol.Name = "rJmailKontrol";
            this.rJmailKontrol.Padding = new System.Windows.Forms.Padding(7);
            this.rJmailKontrol.PasswordChar = false;
            this.rJmailKontrol.Size = new System.Drawing.Size(283, 31);
            this.rJmailKontrol.TabIndex = 19;
            this.rJmailKontrol.Texts = "E-posta adresinizi Girin";
            this.rJmailKontrol.UnderlinedStyle = false;
            this.rJmailKontrol.Click += new System.EventHandler(this.rJmailKontrol_Click);
            // 
            // rjButtonGönder
            // 
            this.rjButtonGönder.BackColor = System.Drawing.Color.Crimson;
            this.rjButtonGönder.BackGroundColor = System.Drawing.Color.Crimson;
            this.rjButtonGönder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonGönder.BorderRadius = 0;
            this.rjButtonGönder.BorderSize = 0;
            this.rjButtonGönder.FlatAppearance.BorderSize = 0;
            this.rjButtonGönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonGönder.ForeColor = System.Drawing.Color.White;
            this.rjButtonGönder.Location = new System.Drawing.Point(399, 112);
            this.rjButtonGönder.Name = "rjButtonGönder";
            this.rjButtonGönder.Size = new System.Drawing.Size(132, 31);
            this.rjButtonGönder.TabIndex = 21;
            this.rjButtonGönder.Text = "Doğrulama Kodu Gönder";
            this.rjButtonGönder.TextColor = System.Drawing.Color.White;
            this.rjButtonGönder.UseVisualStyleBackColor = false;
            this.rjButtonGönder.Click += new System.EventHandler(this.rjButtonGönder_Click);
            // 
            // rjButtonİptal
            // 
            this.rjButtonİptal.BackColor = System.Drawing.Color.Crimson;
            this.rjButtonİptal.BackGroundColor = System.Drawing.Color.Crimson;
            this.rjButtonİptal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonİptal.BorderRadius = 0;
            this.rjButtonİptal.BorderSize = 0;
            this.rjButtonİptal.FlatAppearance.BorderSize = 0;
            this.rjButtonİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonİptal.ForeColor = System.Drawing.Color.White;
            this.rjButtonİptal.Location = new System.Drawing.Point(248, 112);
            this.rjButtonİptal.Name = "rjButtonİptal";
            this.rjButtonİptal.Size = new System.Drawing.Size(132, 31);
            this.rjButtonİptal.TabIndex = 23;
            this.rjButtonİptal.Text = "İptal Et";
            this.rjButtonİptal.TextColor = System.Drawing.Color.White;
            this.rjButtonİptal.UseVisualStyleBackColor = false;
            this.rjButtonİptal.Click += new System.EventHandler(this.rjButtonİptal_Click);
            // 
            // rJtextKod
            // 
            this.rJtextKod.BackColor = System.Drawing.SystemColors.Window;
            this.rJtextKod.BorderColor = System.Drawing.Color.Crimson;
            this.rJtextKod.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJtextKod.BorderSize = 2;
            this.rJtextKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rJtextKod.ForeColor = System.Drawing.Color.DimGray;
            this.rJtextKod.Location = new System.Drawing.Point(248, 150);
            this.rJtextKod.Margin = new System.Windows.Forms.Padding(4);
            this.rJtextKod.MaxLength = 32767;
            this.rJtextKod.Multiline = false;
            this.rJtextKod.Name = "rJtextKod";
            this.rJtextKod.Padding = new System.Windows.Forms.Padding(7);
            this.rJtextKod.PasswordChar = false;
            this.rJtextKod.Size = new System.Drawing.Size(132, 31);
            this.rJtextKod.TabIndex = 24;
            this.rJtextKod.Texts = "Doğrulama Kodunu Girin";
            this.rJtextKod.UnderlinedStyle = false;
            this.rJtextKod.Visible = false;
            this.rJtextKod.Click += new System.EventHandler(this.rJtextKod_Click);
            // 
            // rjButtonKodOnayla
            // 
            this.rjButtonKodOnayla.BackColor = System.Drawing.Color.Crimson;
            this.rjButtonKodOnayla.BackGroundColor = System.Drawing.Color.Crimson;
            this.rjButtonKodOnayla.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonKodOnayla.BorderRadius = 0;
            this.rjButtonKodOnayla.BorderSize = 0;
            this.rjButtonKodOnayla.FlatAppearance.BorderSize = 0;
            this.rjButtonKodOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonKodOnayla.ForeColor = System.Drawing.Color.White;
            this.rjButtonKodOnayla.Location = new System.Drawing.Point(399, 150);
            this.rjButtonKodOnayla.Name = "rjButtonKodOnayla";
            this.rjButtonKodOnayla.Size = new System.Drawing.Size(132, 31);
            this.rjButtonKodOnayla.TabIndex = 25;
            this.rjButtonKodOnayla.Text = "Onayla";
            this.rjButtonKodOnayla.TextColor = System.Drawing.Color.White;
            this.rjButtonKodOnayla.UseVisualStyleBackColor = false;
            this.rjButtonKodOnayla.Visible = false;
            this.rjButtonKodOnayla.Click += new System.EventHandler(this.rjButtonKodOnayla_Click);
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 220);
            this.Controls.Add(this.rjButtonKodOnayla);
            this.Controls.Add(this.rJtextKod);
            this.Controls.Add(this.rjButtonİptal);
            this.Controls.Add(this.rjButtonGönder);
            this.Controls.Add(this.rJmailKontrol);
            this.Controls.Add(this.labelgönderilecekmail);
            this.Controls.Add(this.btnLoginScreenHide);
            this.Controls.Add(this.btnLoginScreenClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifremiUnuttum";
            this.Text = "LoginScreen";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginScreen_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoginScreenClose;
        private System.Windows.Forms.Button btnLoginScreenHide;
        private System.Windows.Forms.Label labelgönderilecekmail;
        private RJconpanents.RJtextBox rJmailKontrol;
        private RJControls.RJConpanents.RJButton rjButtonGönder;
        private RJControls.RJConpanents.RJButton rjButtonİptal;
        public RJconpanents.RJtextBox rJtextKod;
        public RJControls.RJConpanents.RJButton rjButtonKodOnayla;
    }
}