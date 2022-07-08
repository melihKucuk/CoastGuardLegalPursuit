using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202523049_MelihKüçük
{
    
    public partial class CezaEkranı : Form
        
    {
        bool formMoving = false;
        Point startPoint = new Point(0, 0);
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static DataSet ds;
        public static string conAdress = @"Data Source=DESKTOP-NC4RCNO\SQLEXPRESS;Initial Catalog=DenemeOlay;Integrated Security=True";
        int toplamTutar = 0;

        public  int ToplamTutar
        { 
            get => toplamTutar;
            set 
            {
                toplamTutar = value;

                label1.Text = toplamTutar.ToString();

            }
        }

        public CezaEkranı()
        {
            InitializeComponent();
        }

        private void CezaEkranı_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            //fill
            //this.kabahatNiteligiTableAdapter.AnaKabahat(this.denemeOlayDataSet.KabahatNiteligi);
            VeriTabanı.CezaAnaGridDoldur(dataGridView1, "SELECT Id, OlayId, NoteId, Text, ParaCezası, KabahatLevel, AnaKabahatId FROM dbo.KabahatNiteligi WHERE KabahatLevel = 1 OR AnaKabahatId IS NULL");
            //datagridview1
            labelAsker.Text = KayıtOl.MyUserSession;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[3].Width = 585;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dataGridView1.RowCount > 0 && dataGridView1.ColumnCount > 0)
            {
                dataGridView1.CurrentCell = this.dataGridView1[3, 4];
                this.dataGridView1.CurrentCell.Selected = false;
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            var id = (int)dataGridView1.Rows[chosen].Cells[0].Value;
            DatagridDoldurCezaSecimEkranı(id);

            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[3].Width = 600;

            //if (dataGridView2.RowCount > 0 && dataGridView2.ColumnCount > 0)
            //{
            //    dataGridView2.CurrentCell = this.dataGridView2[0, 1];
            //    this.dataGridView2.CurrentCell.Selected = false;
            //}



        }

        public void DatagridDoldurCezaSecimEkranı(int id)
        {
            var sql = string.Format("SELECT TOP (1000) [Id] ,[OlayId] ,[NoteId] ,[Text] ,[ParaCezası] ,[KabahatLevel] ,[AnaKabahatId] FROM [DenemeOlay].[dbo].[KabahatNiteligi] WHERE KabahatLevel=0 and AnaKabahatId={0}", id);
            con = new SqlConnection(conAdress);
            da = new SqlDataAdapter(sql, conAdress);
            ds = new DataSet(); try
            {
                con.Open(); da.Fill(ds, sql);
                dataGridView2.DataSource = ds.Tables[sql];
            }
            catch (InvalidOperationException ex)
            { MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); throw; }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); throw; }
            finally { con.Close(); }
        }

        private void btnLoginScreenHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnLoginScreenClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kabahatNiteligiTableAdapter.FillBy3(this.denemeOlayDataSet.KabahatNiteligi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //label_itemid_show.Text = ItemTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            //text_itemname.Text = ItemTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            //text_itemprice.Text = ItemTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            //text_itemstock.Text = ItemTable.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        void cezaVeriCekme(DataGridView cezadataları, DataGridView cezadataları2, int secilenCeza, bool who)
        {

            if (who)
            {
                YazılanCezalar.Items.Add(cezadataları.Rows[secilenCeza].Cells[3].Value.ToString());
                YazılanCezalar.Items.Add(cezadataları.Rows[secilenCeza].Cells[4].Value.ToString());
                ToplamTutar += Convert.ToInt32(cezadataları.Rows[secilenCeza].Cells[4].Value.ToString());
                //lblToplamCezaTutarı.Text = toplamTutar.ToString().Substring(0, toplamTutar.Length - 1).ToString(); 
            }
            else
            {
                YazılanCezalar.Items.Add(cezadataları2.Rows[secilenCeza].Cells[3].Value.ToString());
                YazılanCezalar.Items.Add(cezadataları2.Rows[secilenCeza].Cells[4].Value.ToString());
                ToplamTutar += Convert.ToInt32(cezadataları.Rows[secilenCeza].Cells[4].Value);
                
            }
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilenCeza = dataGridView1.SelectedCells[0].RowIndex;
            cezaVeriCekme(dataGridView1, dataGridView2, secilenCeza, true);



        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilenCeza = dataGridView2.SelectedCells[0].RowIndex;
            cezaVeriCekme(dataGridView1, dataGridView2, secilenCeza, false);
        }

        private void rjButtonSorguEkranı_Click(object sender, EventArgs e)
        {
            AnaSorguSayfa anaSorguSayfa = new AnaSorguSayfa();
            this.Hide();
            anaSorguSayfa.Show();
        }

        private void rJTXTCezaYazılan_Click(object sender, EventArgs e)
        {
            if (rJTXTCezaYazılan.Texts == "Ad Soyad")
                rJTXTCezaYazılan.Texts = string.Empty;
            else if (rJTXTCezaYazılan.Texts == string.Empty)
                rJTXTCezaYazılan.Texts = "Ad Soyad";
        }

        private void rJtextBoxBotnumber_Click(object sender, EventArgs e)
        {
            if (rJtextBoxBotnumber.Texts == "Bot Numarası")
                rJtextBoxBotnumber.Texts = string.Empty;
            else if (rJtextBoxBotnumber.Texts == string.Empty)
                rJtextBoxBotnumber.Texts = "Bot Numarası";
        }

        private void rjButtonCezaKes_Click(object sender, EventArgs e)
        {
            
            if (YazılanCezalar.Items.Count > 0)
            {
                MessageBox.Show("Cezai işlem başarılı bir şekilde uygulandı.");
                //Tutanak tutanak = new Tutanak();
                //this.Hide();
                //Tutanak.Show();
            }
            else
            {
                MessageBox.Show("Hiç bir cezai işlem yapılamadı. Lütfen işleminizi tekrar kontrol ediniz.");
            }
            VeriTabanı.CezaEkle(rJtextBoxBotnumber,rJTXTCezaYazılan, label1 ,dateTimePicker1);
            //con = new SqlConnection(con);
            //string sql = "update AnaSorguCezaDetay set CezaTutari=@CezaTutari where BotNumarasi=@BotNumarasi";
            //cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@username", MyUserSession);
            //cmd.Parameters.AddWithValue("CezaTarihi", dateTimePicker1);
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = sql;
            //cmd.ExecuteNonQuery();
            //con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CezaEkranı_MouseMove(object sender, MouseEventArgs e)
        {
           
                if (formMoving)
                {
                    Point p = PointToScreen(e.Location);
                    Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
                }
            
        }

        private void CezaEkranı_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void CezaEkranı_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }

        private void lblToplamCezaTutarı_Click(object sender, EventArgs e)
        {

        }
    }
}
