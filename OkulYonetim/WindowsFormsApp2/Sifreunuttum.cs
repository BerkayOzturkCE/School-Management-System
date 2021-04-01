using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;


namespace WindowsFormsApp2
{
    public partial class Sifreunuttum : Form
    {
        Giris giris;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB_School.accdb");
        String Sifre;
        public Sifreunuttum()
        {
            InitializeComponent();
        }

        private void Sifreunuttum_Load(object sender, EventArgs e)
        {
            text_yaz();
            timer1.Enabled = true;
            this.Icon = Resource1.Icon1;
            this.Text = "Okul Yönetim Sistemi";

        }

        private void geri_Click(object sender, EventArgs e)
        {
             giris.Location = this.Location;
             giris.Show();
             this.Close();
        }
        public void veri_al(Giris giris)
        {
            this.giris = giris;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komutogr = new OleDbCommand("SELECT * FROM  Kisi WHERE mail='" + txtmail.Text + "'", baglanti);
                OleDbDataAdapter adap = new OleDbDataAdapter(komutogr);
                DataTable data_table = new DataTable();
                adap.Fill(data_table);
                String mailadres = data_table.Rows[0]["mail"].ToString();
                String numara = data_table.Rows[0]["numara"].ToString();

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("okulyonetimi@outlook.com");
                mail.To.Add(mailadres);
                
                mail.Subject = "Yeni Sifre";
                yeni_sifre();
                String mesaj =  "yeni şifreniz: " + Sifre;
                mail.Body = mesaj;
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("okulyonetimi@outlook.com", "1905ztrk");
                istemci.Port = 587;
                istemci.Host = "smtp.live.com";
                istemci.EnableSsl = true;
                istemci.Send(mail);

                OleDbCommand komut2 = new OleDbCommand("UPDATE Kisi SET sifre='" + Sifre + "'  WHERE numara='" + numara + "'", baglanti);
                
                komut2.ExecuteNonQuery();


            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Mail adresi kayıtlı değil!");

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata + " hatası alındı!");
            }
            
            finally
            {
                baglanti.Close();
            }
        }

        private void yeni_sifre()
        {
            Random random = new Random();
            for(int i = 0; i < 12; i++)
            {
                Sifre += Convert.ToChar(random.Next(47, 91));
            }
        }


        public void text_yaz()
        {
            txtmail.Text = Localization.mail_adresi_gir;
            button1.Text = Localization.mail_gonder;
            geri.Text = Localization.geri;
            label1.Text = Localization.sifremiunuttum;
            label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, 60);

        }
    }
}
