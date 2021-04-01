using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Yeni_Kayit : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB_School.accdb");
        YntciAnaMenu yntcianamenu;
        Bolum bolum=new Bolum();
        int kntrl = 0;
        public Yeni_Kayit()
        {
            InitializeComponent();
        }

        private void Ogr_Kayit_Load(object sender, EventArgs e)
        {
            text_yaz();
            BackgroundImageLayout = ImageLayout.Stretch;
            sql_veri_al();
            timer1.Enabled = true;
            this.Text = "Okul Yönetim Sistemi";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");
        }
        public void veri_al(YntciAnaMenu yntcinamenu)
        {
            this.yntcianamenu = yntcinamenu;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            yntcianamenu.Location = this.Location;
            yntcianamenu.Show();
            this.Close();
        }

        private void btnkyt_Click(object sender, EventArgs e)
        {
            kntrl = 0;
            try {
                kontrol();
                if (kntrl == 1) { return; }
                baglanti.Open();
                Kisi ogr = new Kisi();
                ogr.setKimlikNo(txtkimlik_no.Text);
                ogr.setIsim(txbxism.Text);
                ogr.setSoyisim(txbxsyism.Text);
                ogr.setSifre(txtbxsfr.Text);
                ogr.setAdres(txtbxadrs.Text);
                ogr.setDogum_trh(dateTimePicker1.Text);
                ogr.setMail(txtbxemail.Text);
                ogr.setTelefon(txtbxtlfn.Text);
                bolum_id_al(ogr);
                ogr_numara_belirle(ogr);

                if (rb_erkk.Checked)
                {
                    ogr.setCinsiyet("Erkek");
                }else if (rb_kdn.Checked)
                {
                    ogr.setCinsiyet("Kadın");
                }
                if (rb_ogr.Checked)
                {
                    ogr.setUnvan("Ogrenci");
                }else if (rb_ytkili.Checked)
                {
                    ogr.setUnvan("Yetkili");
                }

                OleDbCommand komut = new OleDbCommand("INSERT INTO Kisi(kimlik_no,isim,soyisim,sifre,numara,adres,dogum_tarihi,"+
                    "mail,telefon,cinsiyet,unvan,ders_sayi,bölüm_id)"+
                    " VALUES (@ogr_kimlik,@ogr_isim,@ogr_soyisim,@ogr_sifre,@ogr_numara,@ogr_adres,@ogr_dogumtrh,@ogr_mail,"+
                    "@ogr_tlfn,@cinsiyet,@unvan,0,@bolum_id)", baglanti);
                komut.Parameters.AddWithValue("@ogr_kimlik", ogr.getKimlikNo());
                komut.Parameters.AddWithValue("@ogr_isim", ogr.getIsim());
                komut.Parameters.AddWithValue("@ogr_soyisim", ogr.getSoyisim());
                komut.Parameters.AddWithValue("@ogr_sifre", ogr.getSifre());
                komut.Parameters.AddWithValue("@ogr_numara", ogr.getNumara());
                komut.Parameters.AddWithValue("@ogr_adres", ogr.getAdres());
                komut.Parameters.AddWithValue("@ogr_dogumtrh", ogr.getDogum_trh());
                komut.Parameters.AddWithValue("@ogr_mail", ogr.getMail());
                komut.Parameters.AddWithValue("@ogr_tlfn", ogr.getTelefon());
                komut.Parameters.AddWithValue("@cinsiyet", ogr.getCinsiyet());
                komut.Parameters.AddWithValue("@unvan", ogr.getUnvan());
                komut.Parameters.AddWithValue("@bolum_id", ogr.getBolum_id());

                komut.ExecuteNonQuery();
                OleDbCommand guncelle = new OleDbCommand("UPDATE Bolum SET kisi_sayi="+bolum.getKisi_sayi()+", "+"Aktif_kisi_sayi=" + bolum.getaktif_Kisi_sayi()+" "+"WHERE isim="+"'"+bolum.getIsim()+"'",baglanti);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla kaydedildi");
                geri_Click(0, EventArgs.Empty);
            }
            catch (System.IndexOutOfRangeException) 
              {
                MessageBox.Show("Bölüm seçmediniz\nLütfen tekrar deneyin!!!");
                baglanti.Close();
                return;
              }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Girdiğiniz Kimlik No Kayıtlı\nLütfen tekrar deneyin!!!");
                baglanti.Close();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata alındı");
                baglanti.Close();
                return;
            }
        }

        private void sql_veri_al()
        {
            try {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT isim FROM Bolum", baglanti);
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            DataTable data_table = new DataTable();
            adap.Fill(data_table);

            for (int i = 0; i < data_table.Rows.Count; i++)
            {
                cmbxblm.Items.Add(data_table.Rows[i]["isim"]);
            }
            baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanından veriler alınamadı!!");
                baglanti.Close();
                geri_Click(0, EventArgs.Empty);
                
            }
        }

        private void bolum_id_al(Kisi ogr)
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Bolum WHERE isim='" + cmbxblm.Text + "'", baglanti);
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            DataTable data_table = new DataTable();
            adap.Fill(data_table);
            bolum.setId(Convert.ToInt32(data_table.Rows[0]["id"]));
            bolum.setIsim(Convert.ToString(data_table.Rows[0]["isim"]));
            bolum.setDers_sayi(Convert.ToInt32(data_table.Rows[0]["ders_sayi"]));
            bolum.setKisi_sayi(Convert.ToInt32(data_table.Rows[0]["kisi_sayi"]));
            bolum.setaktif_Kisi_sayi(Convert.ToInt32(data_table.Rows[0]["Aktif_kisi_sayi"]));
            ogr.setBolum_id(bolum.getId());

        }

         private void ogr_numara_belirle(Kisi ogr)
          {
            bolum.setKisi_sayi(bolum.getKisi_sayi() + 1);
            bolum.setaktif_Kisi_sayi(bolum.getaktif_Kisi_sayi() + 1);
            string fmt = "0000.##";
            String numara = DateTime.Now.Year.ToString();
            numara += ogr.getBolum_id().ToString();
            numara += bolum.getKisi_sayi().ToString(fmt);
            ogr.setNumara(numara);
          }
        private void kontrol()
        {
            if (txtkimlik_no.TextLength < 11||txtkimlik_no.TextLength>11)
            {
                MessageBox.Show("kimlik numarası 11 haneli olmalı!");
                kntrl = 1;
            }
            if (txtbxtlfn.TextLength < 10 || txtbxtlfn.TextLength > 11)
            {
                MessageBox.Show("telefon numarası 10 veya 11 haneli olmalı !");
                kntrl = 1;
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
            cmbxblm.Text = Localization.bolum;
            btnkyt.Text = Localization.kaydet;
            geri.Text = Localization.geri;
            rb_erkk.Text = Localization.erkek;
            rb_kdn.Text = Localization.kdn;
            rb_ogr.Text = Localization.ogr;
            rb_ytkili.Text = Localization.yntc;
            gbunvan.Text = Localization.unvan;
            gbcinsiyet.Text = Localization.Cinsiyet;
            label1.Text = Localization.yenikyt;
            label1.Location = new Point((this.Size.Height - label1.Size.Height) / 2, 69);

        }


    }

}
