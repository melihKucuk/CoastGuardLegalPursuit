
namespace _202523049_MelihKüçük
{
    partial class CezaEkranı
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CezaEkranı));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olayIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paraCezasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kabahatLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anaKabahatIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kabahatNiteligiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denemeOlayDataSet = new _202523049_MelihKüçük.DenemeOlayDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnLoginScreenHide = new System.Windows.Forms.Button();
            this.btnLoginScreenClose = new System.Windows.Forms.Button();
            this.kabahatNiteligiTableAdapter = new _202523049_MelihKüçük.DenemeOlayDataSetTableAdapters.KabahatNiteligiTableAdapter();
            this.lblToplamTutarText = new System.Windows.Forms.Label();
            this.rjButtonCezaKes = new RJControls.RJConpanents.RJButton();
            this.YazılanCezalar = new System.Windows.Forms.ListBox();
            this.rJTXTCezaYazılan = new RJconpanents.RJtextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelAsker = new System.Windows.Forms.Label();
            this.rjButtonSorguEkranı = new RJControls.RJConpanents.RJButton();
            this.rJtextBoxBotnumber = new RJconpanents.RJtextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kabahatNiteligiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeOlayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.olayIdDataGridViewTextBoxColumn,
            this.noteIdDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.paraCezasıDataGridViewTextBoxColumn,
            this.kabahatLevelDataGridViewTextBoxColumn,
            this.anaKabahatIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kabahatNiteligiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // olayIdDataGridViewTextBoxColumn
            // 
            this.olayIdDataGridViewTextBoxColumn.DataPropertyName = "OlayId";
            this.olayIdDataGridViewTextBoxColumn.HeaderText = "OlayId";
            this.olayIdDataGridViewTextBoxColumn.Name = "olayIdDataGridViewTextBoxColumn";
            // 
            // noteIdDataGridViewTextBoxColumn
            // 
            this.noteIdDataGridViewTextBoxColumn.DataPropertyName = "NoteId";
            this.noteIdDataGridViewTextBoxColumn.HeaderText = "NoteId";
            this.noteIdDataGridViewTextBoxColumn.Name = "noteIdDataGridViewTextBoxColumn";
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // paraCezasıDataGridViewTextBoxColumn
            // 
            this.paraCezasıDataGridViewTextBoxColumn.DataPropertyName = "ParaCezası";
            this.paraCezasıDataGridViewTextBoxColumn.HeaderText = "ParaCezası";
            this.paraCezasıDataGridViewTextBoxColumn.Name = "paraCezasıDataGridViewTextBoxColumn";
            // 
            // kabahatLevelDataGridViewTextBoxColumn
            // 
            this.kabahatLevelDataGridViewTextBoxColumn.DataPropertyName = "KabahatLevel";
            this.kabahatLevelDataGridViewTextBoxColumn.HeaderText = "KabahatLevel";
            this.kabahatLevelDataGridViewTextBoxColumn.Name = "kabahatLevelDataGridViewTextBoxColumn";
            // 
            // anaKabahatIdDataGridViewTextBoxColumn
            // 
            this.anaKabahatIdDataGridViewTextBoxColumn.DataPropertyName = "AnaKabahatId";
            this.anaKabahatIdDataGridViewTextBoxColumn.HeaderText = "AnaKabahatId";
            this.anaKabahatIdDataGridViewTextBoxColumn.Name = "anaKabahatIdDataGridViewTextBoxColumn";
            // 
            // kabahatNiteligiBindingSource
            // 
            this.kabahatNiteligiBindingSource.DataMember = "KabahatNiteligi";
            this.kabahatNiteligiBindingSource.DataSource = this.denemeOlayDataSet;
            // 
            // denemeOlayDataSet
            // 
            this.denemeOlayDataSet.DataSetName = "DenemeOlayDataSet";
            this.denemeOlayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(30, 356);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(746, 110);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // btnLoginScreenHide
            // 
            this.btnLoginScreenHide.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginScreenHide.FlatAppearance.BorderSize = 0;
            this.btnLoginScreenHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginScreenHide.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLoginScreenHide.Location = new System.Drawing.Point(1060, 0);
            this.btnLoginScreenHide.Name = "btnLoginScreenHide";
            this.btnLoginScreenHide.Size = new System.Drawing.Size(45, 30);
            this.btnLoginScreenHide.TabIndex = 31;
            this.btnLoginScreenHide.Text = "—";
            this.btnLoginScreenHide.UseVisualStyleBackColor = false;
            this.btnLoginScreenHide.Click += new System.EventHandler(this.btnLoginScreenHide_Click);
            // 
            // btnLoginScreenClose
            // 
            this.btnLoginScreenClose.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginScreenClose.FlatAppearance.BorderSize = 0;
            this.btnLoginScreenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginScreenClose.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLoginScreenClose.Location = new System.Drawing.Point(1105, 0);
            this.btnLoginScreenClose.Name = "btnLoginScreenClose";
            this.btnLoginScreenClose.Size = new System.Drawing.Size(45, 30);
            this.btnLoginScreenClose.TabIndex = 30;
            this.btnLoginScreenClose.Text = "X";
            this.btnLoginScreenClose.UseVisualStyleBackColor = false;
            this.btnLoginScreenClose.Click += new System.EventHandler(this.btnLoginScreenClose_Click);
            // 
            // kabahatNiteligiTableAdapter
            // 
            this.kabahatNiteligiTableAdapter.ClearBeforeFill = true;
            // 
            // lblToplamTutarText
            // 
            this.lblToplamTutarText.AutoSize = true;
            this.lblToplamTutarText.BackColor = System.Drawing.Color.White;
            this.lblToplamTutarText.Location = new System.Drawing.Point(977, 401);
            this.lblToplamTutarText.Name = "lblToplamTutarText";
            this.lblToplamTutarText.Size = new System.Drawing.Size(105, 13);
            this.lblToplamTutarText.TabIndex = 32;
            this.lblToplamTutarText.Text = "Toplam Ceza Tutarı :";
            // 
            // rjButtonCezaKes
            // 
            this.rjButtonCezaKes.BackColor = System.Drawing.Color.DimGray;
            this.rjButtonCezaKes.BackGroundColor = System.Drawing.Color.DimGray;
            this.rjButtonCezaKes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonCezaKes.BorderRadius = 20;
            this.rjButtonCezaKes.BorderSize = 0;
            this.rjButtonCezaKes.FlatAppearance.BorderSize = 0;
            this.rjButtonCezaKes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonCezaKes.ForeColor = System.Drawing.Color.White;
            this.rjButtonCezaKes.Location = new System.Drawing.Point(979, 420);
            this.rjButtonCezaKes.Name = "rjButtonCezaKes";
            this.rjButtonCezaKes.Size = new System.Drawing.Size(144, 40);
            this.rjButtonCezaKes.TabIndex = 33;
            this.rjButtonCezaKes.Text = "Ceza Kes";
            this.rjButtonCezaKes.TextColor = System.Drawing.Color.White;
            this.rjButtonCezaKes.UseVisualStyleBackColor = false;
            this.rjButtonCezaKes.Click += new System.EventHandler(this.rjButtonCezaKes_Click);
            // 
            // YazılanCezalar
            // 
            this.YazılanCezalar.BackColor = System.Drawing.Color.White;
            this.YazılanCezalar.FormattingEnabled = true;
            this.YazılanCezalar.Location = new System.Drawing.Point(799, 34);
            this.YazılanCezalar.Name = "YazılanCezalar";
            this.YazılanCezalar.Size = new System.Drawing.Size(324, 290);
            this.YazılanCezalar.TabIndex = 35;
            this.YazılanCezalar.Tag = "";
            // 
            // rJTXTCezaYazılan
            // 
            this.rJTXTCezaYazılan.BackColor = System.Drawing.SystemColors.Window;
            this.rJTXTCezaYazılan.BorderColor = System.Drawing.Color.DimGray;
            this.rJTXTCezaYazılan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJTXTCezaYazılan.BorderSize = 2;
            this.rJTXTCezaYazılan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rJTXTCezaYazılan.ForeColor = System.Drawing.Color.DimGray;
            this.rJTXTCezaYazılan.Location = new System.Drawing.Point(799, 356);
            this.rJTXTCezaYazılan.Margin = new System.Windows.Forms.Padding(4);
            this.rJTXTCezaYazılan.MaxLength = 32767;
            this.rJTXTCezaYazılan.Multiline = false;
            this.rJTXTCezaYazılan.Name = "rJTXTCezaYazılan";
            this.rJTXTCezaYazılan.Padding = new System.Windows.Forms.Padding(7);
            this.rJTXTCezaYazılan.PasswordChar = false;
            this.rJTXTCezaYazılan.Size = new System.Drawing.Size(144, 31);
            this.rJTXTCezaYazılan.TabIndex = 36;
            this.rJTXTCezaYazılan.Texts = "Ad Soyad";
            this.rJTXTCezaYazılan.UnderlinedStyle = false;
            this.rJTXTCezaYazılan.Click += new System.EventHandler(this.rJTXTCezaYazılan_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(799, 394);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // labelAsker
            // 
            this.labelAsker.BackColor = System.Drawing.Color.Transparent;
            this.labelAsker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAsker.Location = new System.Drawing.Point(26, 4);
            this.labelAsker.Name = "labelAsker";
            this.labelAsker.Size = new System.Drawing.Size(93, 23);
            this.labelAsker.TabIndex = 39;
            this.labelAsker.Text = "Hoşgeldin ";
            // 
            // rjButtonSorguEkranı
            // 
            this.rjButtonSorguEkranı.BackColor = System.Drawing.Color.DimGray;
            this.rjButtonSorguEkranı.BackGroundColor = System.Drawing.Color.DimGray;
            this.rjButtonSorguEkranı.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonSorguEkranı.BorderRadius = 20;
            this.rjButtonSorguEkranı.BorderSize = 0;
            this.rjButtonSorguEkranı.FlatAppearance.BorderSize = 0;
            this.rjButtonSorguEkranı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonSorguEkranı.ForeColor = System.Drawing.Color.White;
            this.rjButtonSorguEkranı.Location = new System.Drawing.Point(799, 426);
            this.rjButtonSorguEkranı.Name = "rjButtonSorguEkranı";
            this.rjButtonSorguEkranı.Size = new System.Drawing.Size(144, 40);
            this.rjButtonSorguEkranı.TabIndex = 40;
            this.rjButtonSorguEkranı.Text = "Sorgu Ekranına Dön";
            this.rjButtonSorguEkranı.TextColor = System.Drawing.Color.White;
            this.rjButtonSorguEkranı.UseVisualStyleBackColor = false;
            this.rjButtonSorguEkranı.Click += new System.EventHandler(this.rjButtonSorguEkranı_Click);
            // 
            // rJtextBoxBotnumber
            // 
            this.rJtextBoxBotnumber.BackColor = System.Drawing.SystemColors.Window;
            this.rJtextBoxBotnumber.BorderColor = System.Drawing.Color.DimGray;
            this.rJtextBoxBotnumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJtextBoxBotnumber.BorderSize = 2;
            this.rJtextBoxBotnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rJtextBoxBotnumber.ForeColor = System.Drawing.Color.DimGray;
            this.rJtextBoxBotnumber.Location = new System.Drawing.Point(979, 356);
            this.rJtextBoxBotnumber.Margin = new System.Windows.Forms.Padding(4);
            this.rJtextBoxBotnumber.MaxLength = 32767;
            this.rJtextBoxBotnumber.Multiline = false;
            this.rJtextBoxBotnumber.Name = "rJtextBoxBotnumber";
            this.rJtextBoxBotnumber.Padding = new System.Windows.Forms.Padding(7);
            this.rJtextBoxBotnumber.PasswordChar = false;
            this.rJtextBoxBotnumber.Size = new System.Drawing.Size(144, 31);
            this.rJtextBoxBotnumber.TabIndex = 37;
            this.rJtextBoxBotnumber.Texts = "Bot Numarası";
            this.rJtextBoxBotnumber.UnderlinedStyle = false;
            this.rJtextBoxBotnumber.Click += new System.EventHandler(this.rJtextBoxBotnumber_Click);
            // 
            // labelusername
            // 
            this.labelusername.BackColor = System.Drawing.Color.Transparent;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelusername.Location = new System.Drawing.Point(125, 4);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(263, 23);
            this.labelusername.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1088, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "label1";
            // 
            // CezaEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.rjButtonSorguEkranı);
            this.Controls.Add(this.labelAsker);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rJtextBoxBotnumber);
            this.Controls.Add(this.rJTXTCezaYazılan);
            this.Controls.Add(this.YazılanCezalar);
            this.Controls.Add(this.rjButtonCezaKes);
            this.Controls.Add(this.lblToplamTutarText);
            this.Controls.Add(this.btnLoginScreenHide);
            this.Controls.Add(this.btnLoginScreenClose);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CezaEkranı";
            this.Text = "Ceza Ekranı";
            this.Load += new System.EventHandler(this.CezaEkranı_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CezaEkranı_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CezaEkranı_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CezaEkranı_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kabahatNiteligiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeOlayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DenemeOlayDataSet denemeOlayDataSet;
        private System.Windows.Forms.BindingSource kabahatNiteligiBindingSource;
        private DenemeOlayDataSetTableAdapters.KabahatNiteligiTableAdapter kabahatNiteligiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olayIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paraCezasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kabahatLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anaKabahatIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLoginScreenHide;
        private System.Windows.Forms.Button btnLoginScreenClose;
        private System.Windows.Forms.Label lblToplamTutarText;
        private RJControls.RJConpanents.RJButton rjButtonCezaKes;
        private System.Windows.Forms.ListBox YazılanCezalar;
        private RJconpanents.RJtextBox rJTXTCezaYazılan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelAsker;
        private RJControls.RJConpanents.RJButton rjButtonSorguEkranı;
        private RJconpanents.RJtextBox rJtextBoxBotnumber;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label label1;
    }
}