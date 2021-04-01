using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class Ders_Bolum_ekle : Form
    {
        YntciAnaMenu anamenu=new YntciAnaMenu();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB_School.accdb");
        Bolum bolum = new Bolum();
        public Ders_Bolum_ekle()
        {
            InitializeComponent();
        }
        private void Ders_Bolum_ekle_Load(object sender, EventArgs e)
        {
            text_yaz();
            sql_veri_al();
            timer1.Enabled = true;
            this.Text = "Okul Yönetim Sistemi";

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");
        }

        public void veri_al(YntciAnaMenu anamenu)
        {
            this.anamenu = anamenu;
        }

        private void rdb_Ders_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Ders.Checked)
            {
                txtAkts.Enabled = true;
                txtKredi.Enabled = true;
                cmbxbolum.Enabled = true;
            }
            else
            {

                txtKredi.Enabled = false;
                txtAkts.Enabled = false;
                cmbxbolum.Enabled = false;
            }

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            anamenu.Location = this.Location;
            anamenu.Show();
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try { 
            baglanti.Open();
            if (rdb_Ders.Checked)
            {
                Ders ders = new Ders();
                ders.setIsim(txtIsim.Text);
                ders.setKredi(Convert.ToInt32(txtKredi.Text));
                ders.setAkts(Convert.ToInt32(txtAkts.Text));
                bolum_id_al(ders);
                OleDbCommand komut = new OleDbCommand("INSERT INTO Bolum_dersleri(isim,kredi,akts,bolum_id) Values(@isim,@akts,@kredi,@bolum_id)", baglanti);
                komut.Parameters.AddWithValue("@isim", ders.getIsim());
                komut.Parameters.AddWithValue("@kredi", ders.getKredi());
                komut.Parameters.AddWithValue("@akts", ders.getAkts());
                komut.Parameters.AddWithValue("@bolum_id", ders.getBolum_id());
                komut.ExecuteNonQuery();
                bolum.setDers_sayi(bolum.getDers_sayi() + 1);
                OleDbCommand guncelle = new OleDbCommand("UPDATE Bolum SET ders_sayi=" + bolum.getDers_sayi() +" "+"WHERE isim=" + "'" + bolum.getIsim() + "'", baglanti);
                guncelle.ExecuteNonQuery();
            }
            else
            {
                Bolum bolum = new Bolum();
                bolum.setIsim(txtIsim.Text);
                OleDbCommand komut = new OleDbCommand("INSERT INTO Bolum(isim,ders_sayi,kisi_sayi,Aktif_kisi_sayi) Values(@isim,0,0,0)", baglanti);
                komut.Parameters.AddWithValue("@isim", bolum.getIsim());
                komut.ExecuteNonQuery();

            }
                baglanti.Close();
                MessageBox.Show("Başarıyla Kaydedildi");
                btngeri_Click(0,e);

            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Bir hata alındı Girdiğiniz bilgileri kontrol edin");
                return;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Kredi ve Akts yi rakamlarla yazınız");
                return;
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Lütfen heryeri doldurun veya geçerli bir isim girin");
                return;
            }
            finally { baglanti.Close(); }
        }
        private void sql_veri_al()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT isim FROM Bolum", baglanti);
                OleDbDataAdapter adap = new OleDbDataAdapter(komut);
                DataTable data_table = new DataTable();
                adap.Fill(data_table);

                for (int i = 0; i < data_table.Rows.Count; i++)
                {
                    cmbxbolum.Items.Add(data_table.Rows[i]["isim"]);
                }
               
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
        private void bolum_id_al(Ders ders)
        {
            try { 
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Bolum WHERE isim='" + cmbxbolum.Text + "'", baglanti);
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            DataTable data_table = new DataTable();
            adap.Fill(data_table);
            bolum.setId(Convert.ToInt32(data_table.Rows[0]["id"]));
            bolum.setIsim(Convert.ToString(data_table.Rows[0]["isim"]));
            bolum.setDers_sayi(Convert.ToInt32(data_table.Rows[0]["ders_sayi"]));
            bolum.setKisi_sayi(Convert.ToInt32(data_table.Rows[0]["kisi_sayi"]));
            ders.setBolum_id(bolum.getId());
        }
            catch (Exception)
            {
                MessageBox.Show("Veritabanından veriler alınamadı!!");
            }
  
        }

        private void text_yaz()
        {
            txtIsim.Text = Localization.isim;
            txtKredi.Text = Localization.kredi;
            btngeri.Text = Localization.geri;
            btnkaydet.Text = Localization.kaydet;
            rdbBlm.Text = Localization.bolum;
            rdb_Ders.Text = Localization.ders;
            label1.Text = Localization.ders_blm_ekle;
            label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, 74);

        }

 
    }
}
