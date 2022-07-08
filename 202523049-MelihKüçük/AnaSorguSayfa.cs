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
    public partial class AnaSorguSayfa : Form
    {
        bool formMoving = false;
        Point startPoint = new Point(0, 0);
        public AnaSorguSayfa()
        {
            InitializeComponent();
        }

        private void AnaSorguSayfa_Load(object sender, EventArgs e)
        {
            //GridFull
            //VeriTabanı.GridDoldur(dataGridViewAllList);
            //dataGridViewAllList
            dataGridViewAllList.AllowUserToAddRows = false;
            dataGridViewAllList.ReadOnly = true;
            dataGridViewAllList.AllowUserToResizeColumns = false;
            VeriTabanı.CezaAnaGridDoldur(dataGridViewAllList, "select * from AnaSorguCezaDetay");
            dataGridViewAllList.Columns[0].Visible = false;
            dataGridViewAllList.Columns[1].Visible = false;
            dataGridViewAllList.Columns[2].Width = 233;
            dataGridViewAllList.Columns[3].Width = 233;
            dataGridViewAllList.Columns[4].Width = 233;
            dataGridViewAllList.Columns[5].Width = 233;
            ToolTip toolTipCezaEkranıDön = new ToolTip()
            {
                

            };
            toolTipCezaEkranıDön.SetToolTip(buttonCezaEkranınaDön, "Ceza Ekranını Açmak İçin Tıklayınız.");

        }   

        

        private void dataGridViewAllList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridViewAllList.SelectedCells[0].RowIndex;


        }

        private void btnSorguScreenHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSorguScreenClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void rJSearchtextBox1__TextChanged(object sender, EventArgs e)
        {
            VeriTabanı.AnaSorguSearch(dataGridViewAllList, rJSearchtextBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CezaEkranı cezaekranı = new CezaEkranı();
            this.Hide();
            cezaekranı.Show();
            
        }

        private void AnaSorguSayfa_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }

        private void AnaSorguSayfa_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void AnaSorguSayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void pDFİndirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeriTabanı.pdf(dataGridViewAllList, "Ceza Liste");
        }
    }
}
