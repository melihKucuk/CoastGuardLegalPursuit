
namespace _202523049_MelihKüçük
{
    partial class AnaSorguSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSorguSayfa));
            this.dataGridViewAllList = new System.Windows.Forms.DataGridView();
            this.btnSorguScreenHide = new System.Windows.Forms.Button();
            this.btnSorguScreenClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rJSearchtextBox1 = new RJconpanents.RJtextBox();
            this.buttonCezaEkranınaDön = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFİndirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAllList
            // 
            this.dataGridViewAllList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAllList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllList.Location = new System.Drawing.Point(15, 62);
            this.dataGridViewAllList.Name = "dataGridViewAllList";
            this.dataGridViewAllList.Size = new System.Drawing.Size(933, 390);
            this.dataGridViewAllList.TabIndex = 3;
            this.dataGridViewAllList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllList_CellDoubleClick);
            // 
            // btnSorguScreenHide
            // 
            this.btnSorguScreenHide.BackColor = System.Drawing.Color.Transparent;
            this.btnSorguScreenHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorguScreenHide.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSorguScreenHide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSorguScreenHide.Location = new System.Drawing.Point(884, 1);
            this.btnSorguScreenHide.Name = "btnSorguScreenHide";
            this.btnSorguScreenHide.Size = new System.Drawing.Size(45, 31);
            this.btnSorguScreenHide.TabIndex = 31;
            this.btnSorguScreenHide.Text = "—";
            this.btnSorguScreenHide.UseVisualStyleBackColor = false;
            this.btnSorguScreenHide.Click += new System.EventHandler(this.btnSorguScreenHide_Click);
            // 
            // btnSorguScreenClose
            // 
            this.btnSorguScreenClose.BackColor = System.Drawing.Color.Transparent;
            this.btnSorguScreenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorguScreenClose.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSorguScreenClose.Location = new System.Drawing.Point(929, 1);
            this.btnSorguScreenClose.Name = "btnSorguScreenClose";
            this.btnSorguScreenClose.Size = new System.Drawing.Size(45, 31);
            this.btnSorguScreenClose.TabIndex = 30;
            this.btnSorguScreenClose.Text = "X";
            this.btnSorguScreenClose.UseVisualStyleBackColor = false;
            this.btnSorguScreenClose.Click += new System.EventHandler(this.btnSorguScreenClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // rJSearchtextBox1
            // 
            this.rJSearchtextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rJSearchtextBox1.BorderColor = System.Drawing.Color.DimGray;
            this.rJSearchtextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJSearchtextBox1.BorderSize = 2;
            this.rJSearchtextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rJSearchtextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rJSearchtextBox1.Location = new System.Drawing.Point(303, 13);
            this.rJSearchtextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rJSearchtextBox1.MaxLength = 32767;
            this.rJSearchtextBox1.Multiline = false;
            this.rJSearchtextBox1.Name = "rJSearchtextBox1";
            this.rJSearchtextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rJSearchtextBox1.PasswordChar = false;
            this.rJSearchtextBox1.Size = new System.Drawing.Size(394, 31);
            this.rJSearchtextBox1.TabIndex = 33;
            this.rJSearchtextBox1.Texts = "";
            this.rJSearchtextBox1.UnderlinedStyle = false;
            this.rJSearchtextBox1._TextChanged += new System.EventHandler(this.rJSearchtextBox1__TextChanged);
            // 
            // buttonCezaEkranınaDön
            // 
            this.buttonCezaEkranınaDön.BackColor = System.Drawing.Color.Transparent;
            this.buttonCezaEkranınaDön.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCezaEkranınaDön.BackgroundImage")));
            this.buttonCezaEkranınaDön.FlatAppearance.BorderSize = 0;
            this.buttonCezaEkranınaDön.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCezaEkranınaDön.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonCezaEkranınaDön.Location = new System.Drawing.Point(839, 1);
            this.buttonCezaEkranınaDön.Name = "buttonCezaEkranınaDön";
            this.buttonCezaEkranınaDön.Size = new System.Drawing.Size(45, 31);
            this.buttonCezaEkranınaDön.TabIndex = 42;
            this.buttonCezaEkranınaDön.Text = "📝";
            this.buttonCezaEkranınaDön.UseVisualStyleBackColor = false;
            this.buttonCezaEkranınaDön.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyalarToolStripMenuItem
            // 
            this.dosyalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFİndirToolStripMenuItem});
            this.dosyalarToolStripMenuItem.Name = "dosyalarToolStripMenuItem";
            this.dosyalarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.dosyalarToolStripMenuItem.Text = "Dosyalar";
            // 
            // pDFİndirToolStripMenuItem
            // 
            this.pDFİndirToolStripMenuItem.Name = "pDFİndirToolStripMenuItem";
            this.pDFİndirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pDFİndirToolStripMenuItem.Text = "PDF İndir";
            this.pDFİndirToolStripMenuItem.Click += new System.EventHandler(this.pDFİndirToolStripMenuItem_Click);
            // 
            // AnaSorguSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 475);
            this.Controls.Add(this.buttonCezaEkranınaDön);
            this.Controls.Add(this.rJSearchtextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSorguScreenHide);
            this.Controls.Add(this.btnSorguScreenClose);
            this.Controls.Add(this.dataGridViewAllList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaSorguSayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaSorguSayfa_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnaSorguSayfa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnaSorguSayfa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AnaSorguSayfa_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAllList;
        private System.Windows.Forms.Button btnSorguScreenHide;
        private System.Windows.Forms.Button btnSorguScreenClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJconpanents.RJtextBox rJSearchtextBox1;
        private System.Windows.Forms.Button buttonCezaEkranınaDön;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFİndirToolStripMenuItem;
    }
}

