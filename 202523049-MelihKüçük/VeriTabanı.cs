using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using RJControls.RJConpanents;
using RJconpanents;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace _202523049_MelihKüçük
{
    class VeriTabanı
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static SqlCommand cmd;
        static DataSet ds;
        public static bool gonderildimi;
        public static int sıfırlananID;
        public static int sıfırlamaKodu;

        public static string Adress = @"Data Source=DESKTOP-NC4RCNO\SQLEXPRESS;Initial Catalog=DenemeOlay;Integrated Security=True";

        public static int Kod()
        {
            Random rastgele = new Random();

            return rastgele.Next(100000, 999999);
        }

        public static void Eposta(RJtextBox mail)
        {
            con = new SqlConnection(Adress);
            bool sayıcı = true;
            string posta;

            con.Open();

            string sql = "MailVarmi";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eposta", SqlDbType.NVarChar, 50).Value = $"{mail.Texts}";
            SqlDataReader drMail = cmd.ExecuteReader();
            if (drMail.HasRows)
                while (drMail.Read() && sayıcı)
                {
                    sayıcı = false;
                    posta = drMail[2].ToString();
                    sıfırlananID = Convert.ToInt32(drMail[0]);
                    MailDogrulama(posta);

                    gonderildimi = true;
                    MessageBox.Show("gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // degisicek
                }
            else
                MessageBox.Show("E-Mail Adresi Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void CezaAnaGridDoldur(DataGridView gridm, string selectSorgu)
        {
            con = new SqlConnection(Adress);
            con.Open();

            da = new SqlDataAdapter(selectSorgu, con);
            ds = new DataSet();
            da.Fill(ds, selectSorgu);
            gridm.DataSource = ds.Tables[selectSorgu];
            con.Close();
        }
        public static bool BaglantiDurum()
        {
            using (con = new SqlConnection(Adress))
            {
                try
                {
                    con.Open();

                    return true;
                }
                catch (SqlException exp)
                {

                    return false;
                }
            }
        }
        public static void MailDogrulama(string toWho, string subject = "Güvenlik Kodu")
        {
            sıfırlamaKodu = Kod();
            string gövde = "Şifre Sıfırlama Kodu: " + sıfırlamaKodu.ToString();

            Encoding encoding = Encoding.UTF8;

            MailAddress mailadres = new MailAddress(toWho, toWho, encoding);
            MailAddress anaMail = new MailAddress("companydirectsy@gmail.com", "Sahil Güvenlik", encoding);

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = anaMail;
            mailMessage.Bcc.Add(mailadres);
            mailMessage.Subject = subject;
            mailMessage.Body = gövde;
            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.sendgrid.net", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("apikey", "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");
            smtpClient.EnableSsl = false;
            smtpClient.Send(mailMessage);
        }
        public static void Login(Form login, RJtextBox eposta, RJtextBox Sifre)
        {

            con = new SqlConnection(Adress);
            con.Open();
            string sql = "Giris";

            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eposta", SqlDbType.NVarChar, 50).Value = eposta.Texts;
            cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar, 50).Value = Sifre.Texts;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                login.Hide();
                AnaSorguSayfa form = new AnaSorguSayfa();
                form.Show();
            }
            else if (dr.Read())
            {
                login.Hide();
                CezaEkranı form = new CezaEkranı();
                form.Show();
            }
            else
                
            con.Close();
        }
        public static void KayıtEkle(RJtextBox adsoyad, RJtextBox eposta, RJtextBox sifre, RJtextBox telefonno)
        {
            con = new SqlConnection(Adress);


            if (KayıtKontrol(eposta))
            {
                con.Open();
                string sql = "KayıtOl";

                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@eposta", SqlDbType.NVarChar, 50).Value = eposta.Texts;
                cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar, 50).Value = MD5(sifre.Texts);
                cmd.Parameters.Add("@telefonno", SqlDbType.NVarChar, 50).Value = telefonno.Texts;
                cmd.Parameters.Add("@adSoyad", SqlDbType.NVarChar, 50).Value = adsoyad.Texts;
                cmd.ExecuteNonQuery();
                MessageBox.Show("kayıt olundu");
            }
            else
                MessageBox.Show("Zaten" + eposta.Text + " epostalı kişi sisteme kayıtlı!");
            con.Close();
        }
        public static void SifreGuncelle(RJtextBox sifre)
        {
            con = new SqlConnection(Adress);
            con.Open();

            string sql = "SifreGuncelle";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = sıfırlananID;
            cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar, 50).Value = sifre.Texts;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sifre Guncellendi");


        }
        public static bool KayıtKontrol(RJtextBox eposta)
        {
            con = new SqlConnection(Adress);
            con.Open();

            string sql = "KayıtKontrol";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eposta", SqlDbType.NVarChar, 50).Value = eposta.Texts;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                con.Close();
                return false;
            }
            else
            {
                dr.Close();
                con.Close();
                return true;
            }


        }
        public static void AnaSorguSearch(DataGridView gridm, RJtextBox aramaTxt)
        {
            SqlCommand cmd2 = new SqlCommand("select * from AnaSorguCezaDetay WHERE  CezayiKesen like '" + aramaTxt.Texts + "%' or CezaKimeKesildi like '" + aramaTxt.Texts + "%' or BotNumarasi like '" + aramaTxt.Texts + "%'", con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            gridm.DataSource = ds2.Tables[0];
        }
        static string MD5(string rawData)
        {
            MD5 MD5Encrypting = new MD5CryptoServiceProvider();
            byte[] bytes = MD5Encrypting.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in bytes)
                stringBuilder.Append(item.ToString("x2"));

            return stringBuilder.ToString();
        }
        public static void pdf(DataGridView gridm, string filename)
        {
           
            
                PdfPTable pdfPTable;
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, "windows-1254", BaseFont.EMBEDDED);


                pdfPTable = new PdfPTable(gridm.Columns.Count - 2);
                pdfPTable.DefaultCell.Padding = 3;
                pdfPTable.WidthPercentage = 100;
                pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPTable.DefaultCell.BorderWidth = 1;

                Font text = new Font(bf, 10, Font.NORMAL);

                //Add Header
                foreach (DataGridViewColumn column in gridm.Columns)
                {


                    if (column.HeaderText != "Id" && column.HeaderText != "CezayiKesen")
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240)
                        };
                        pdfPTable.AddCell(cell);
                    }

                }

                //Add datarow
                foreach (DataGridViewRow row in gridm.Rows)
                    foreach (DataGridViewCell cell in row.Cells)
                        if (cell.ColumnIndex != 0 && cell.ColumnIndex != 1)
                            pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));


                var saveFileDialoge = new SaveFileDialog();
                saveFileDialoge.FileName = filename;
                saveFileDialoge.DefaultExt = ".PDF";

                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFileDialoge.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10F, 10F, 10F, 0F);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(pdfPTable);
                        pdfdoc.Close();
                        stream.Close();
                    }
                }

            }

        //public static void Register(TextBox username, TextBox password)
        //{
        //    con = new SqlConnection(Adress  );
        //    con.Open();
        //    string sql = "INSERT INTO tbl_SGK (tckimlikno,sifre) VALUES (@tckimlikno,@sifre)";
        //    cmd = new SqlCommand(sql, con);
        //    cmd.Parameters.AddWithValue("@tckimlikno", username.Text);
        //    cmd.Parameters.AddWithValue("@sifre", password.Text);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    MessageBox.Show("Kayıt Yapıldı");



            //}
            public static void CezaEkle(RJtextBox BotnNumarası, RJtextBox JTXTCezaYazılan, Label label1, DateTimePicker dateTimePicker)
            {
                con = new SqlConnection(Adress);
                con.Open();
                string sql = "CezaEkle";

                //dateTimePicker.CustomFormat = "yyyy-mm-dd";
                DateTime.Now.ToString("yyyy/mm/dd HH:mm:ss");

                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CezayiKesen", SqlDbType.NVarChar, 50).Value = "";
                cmd.Parameters.Add("@CezaTutari", SqlDbType.Int).Value = Convert.ToInt32(label1.Text);
                cmd.Parameters.Add("@BotNumarasi", SqlDbType.NVarChar, 50).Value = BotnNumarası.Texts;
                cmd.Parameters.Add("@CezaKimeKesildi", SqlDbType.NVarChar, 50).Value = JTXTCezaYazılan.Texts;

                cmd.ExecuteNonQuery();



                con.Close();
            }
        
    }
}