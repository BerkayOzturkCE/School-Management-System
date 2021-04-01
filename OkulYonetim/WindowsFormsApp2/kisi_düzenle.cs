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
    public partial class kisi_düzenle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB_School.accdb");
        Bolum bolum = new Bolum();
        YntciAnaMenu anaMenu;
        int blmId=-1;
        public kisi_düzenle()
        {
            InitializeComponent();
        }

        private void kisi_düzenle_Load(object sender, EventArgs e)
        {
            text_yaz();
            timer1.Enabled = true;
            this.Text = "Okul Yönetim Sistemi";
        }

        public void veri_al(YntciAnaMenu anaMenu)
        {
            this.anaMenu = anaMenu;
        }
        private void geri_Click(object sender, EventArgs e)
        {
            anaMenu.Location = this.Location;
            anaMenu.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM Kisi WHERE numara='" + txtbxOgrNo.Text + "'", baglanti);
                OleDbDataAdapter adap = new OleDbDataAdapter(komut);
                DataTable data_table = new DataTable();
                adap.Fill(data_table);

                txbxism.Text = Convert.ToString(data_table.Rows[0]["isim"]);
                txbxsyism.Text = Convert.ToString(data_table.Rows[0]["soyisim"]);
                txtkimlik_no.Text = Convert.ToString(data_table.Rows[0]["kimlik_no"]);
                txtbxadrs.Text = Convert.ToString(data_table.Rows[0]["adres"]);
                txtbxemail.Text = Convert.ToString(data_table.Rows[0]["mail"]);
                txtbxtlfn.Text = Convert.ToString(data_table.Rows[0]["telefon"]);
                blmId = Convert.ToInt32(data_table.Rows[0]["bölüm_id"]);
                baglanti.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " hatası alındı");
                baglanti.Close();
                geri_Click(0, EventArgs.Empty);

            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                veri_al();
                bolum.setaktif_Kisi_sayi(bolum.getaktif_Kisi_sayi() - 1);
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("DELETE FROM Kisi WHERE numara='" + txtbxOgrNo.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                OleDbCommand guncelle = new OleDbCommand("UPDATE Bolum SET Aktif_kisi_sayi=" + bolum.getaktif_Kisi_sayi() + " " + "WHERE id=" + blmId , baglanti);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("işlem başarılı");
                geri_Click(0, e);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message+"hatası alındı");
                baglanti.Close();
                geri_Click(0, EventArgs.Empty);

            }
        }

        private void btnkyt_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("UPDATE Kisi SET isim='" + txbxism.Text + "', soyisim='" + txbxsyism.Text + "', kimlik_no='" + txtkimlik_no.Text +
                    "', adres='" + txtbxadrs.Text + "', telefon='" + txtbxtlfn.Text + "', mail='" + txtbxemail.Text + "'"+
                   " WHERE numara='" + txtbxOgrNo.Text + "'", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İşlem Başarılı");

            }
            catch (Exception hata) {
                MessageBox.Show(hata.Message + "hatası alındı");
                baglanti.Close();
                geri_Click(0, EventArgs.Empty);
            }
        }

        private void veri_al()
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Bolum WHERE id=" + blmId , baglanti);
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            DataTable data_table = new DataTable();
            adap.Fill(data_table);
            bolum.setaktif_Kisi_sayi(Convert.ToInt32(data_table.Rows[0]["Aktif_kisi_sayi"]));
        }

        private void text_yaz()
        {
            txbxism.Text = Localization.isim;
            txbxsyism.Text = Localization.soyisim;
            txtbxadrs.Text = Localization.adres;
            txtbxemail.Text = Localization.Email;
            txtbxOgrNo.Text = Localization.numara;
            txtbxtlfn.Text = Localization.telefon;
            txtkimlik_no.Text = Localization.id;
            btnkyt.Text = Localization.guncelle;
            BtnAra.Text = Localization.ara;
            BtnSil.Text = Localization.sil;
            geri.Text = Localization.geri;
            label1.Text = Localization.kisi_bilgileri;
            label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, 78);
        }
    }
}
