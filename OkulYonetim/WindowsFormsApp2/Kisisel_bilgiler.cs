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

namespace WindowsFormsApp2
{
  
    public partial class Kisisel_bilgiler : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB_School.accdb");

        OgrAnaMenu anamenu;
        String ogr_no;
        public Kisisel_bilgiler()
        {
            InitializeComponent();
        }
        private void Kisisel_bilgiler_Load(object sender, EventArgs e)
        {
            text_yaz();
            timer1.Enabled = true;
            sql_veriAl();
            this.Text = "Okul Yönetim Sistemi";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");

        }
        public void veri_al(OgrAnaMenu anamenu, String ogr_no)
        {
            this.anamenu = anamenu;
            this.ogr_no = ogr_no;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            anamenu.Location = this.Location;
            anamenu.Show();
            this.Close();
        }

        private void btnkyt_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("UPDATE Kisi SET isim='" + txbxism.Text + "', soyisim='" + txbxsyism.Text + "', kimlik_no='" + txtkimlik_no.Text +
                    "', adres='" + txtbxadrs.Text + "', telefon='" + txtbxtlfn.Text + "', mail='" + txtbxemail.Text + "', sifre='"+txtbxsfr.Text+"'"+
                   " WHERE numara='" + ogr_no + "'", baglanti);
                MessageBox.Show("İşlem başarılı...");
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + "hatası alındı");
                baglanti.Close();
                geri_Click(0, EventArgs.Empty);
            }
        }
        
        private void sql_veriAl()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM Kisi WHERE numara='" + ogr_no + "'", baglanti);
                OleDbDataAdapter adap = new OleDbDataAdapter(komut);
                DataTable data_table = new DataTable();
                adap.Fill(data_table);
                txbxism.Text = Convert.ToString(data_table.Rows[0]["isim"]);
                txbxsyism.Text = Convert.ToString(data_table.Rows[0]["soyisim"]);
                txtbxsfr.Text = Convert.ToString(data_table.Rows[0]["sifre"]);

                txtkimlik_no.Text = Convert.ToString(data_table.Rows[0]["kimlik_no"]);
                txtbxadrs.Text = Convert.ToString(data_table.Rows[0]["adres"]);
                txtbxemail.Text = Convert.ToString(data_table.Rows[0]["mail"]);
                txtbxtlfn.Text = Convert.ToString(data_table.Rows[0]["telefon"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanından veriler alınamadı!!");
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void text_yaz()
        {
            txbxism.Text = Localization.isim;
            txbxsyism.Text = Localization.soyisim;
            txtbxadrs.Text = Localization.adres;
            txtbxemail.Text = Localization.Email;
            txtbxsfr.Text = Localization.sifre;
            txtbxtlfn.Text = Localization.telefon;
            txtkimlik_no.Text = Localization.id;
            btnkyt.Text = Localization.kaydet;
            geri.Text = Localization.geri;
            label1.Text = Localization.kisisel_bilgiler;
            label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, 74);

        }
    }
}
