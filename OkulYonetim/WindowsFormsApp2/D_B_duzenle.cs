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
   
    public partial class D_B_duzenle : Form
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB_School.accdb");

        YntciAnaMenu anamenu;
        int blm_id, ders_sayi;
        public D_B_duzenle()
        {
            InitializeComponent();
        }

        private void D_B_duzenle_Load(object sender, EventArgs e)
        {
            text_yaz();
            timer1.Enabled = true;
            this.Text = "Okul Yönetim Sistemi";

        }

        public void veri_al(YntciAnaMenu anamenu)
        {
            this.anamenu = anamenu;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            anamenu.Location = this.Location;
            anamenu.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_Ders.Checked) {
                    txtKredi.Enabled = true;
                    txtAkts.Enabled = true;
                    txtid.Enabled = false;
                    baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM Bolum_dersleri WHERE id="+txtid.Text, baglanti);
                OleDbDataAdapter adap = new OleDbDataAdapter(komut);
                DataTable data_table = new DataTable();
                adap.Fill(data_table);

                txtIsim.Text = data_table.Rows[0]["isim"].ToString();
                txtAkts.Text = Convert.ToString(data_table.Rows[0]["akts"]);
                txtKredi.Text = Convert.ToString(data_table.Rows[0]["kredi"]);
                blm_id = Convert.ToInt32(data_table.Rows[0]["bolum_id"]);
                }
                else
                {
                    txtKredi.Enabled = false;
                    txtAkts.Enabled = false;
                    txtid.Enabled = false;
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("SELECT * FROM Bolum WHERE id=" + txtid.Text, baglanti);
                    OleDbDataAdapter adap = new OleDbDataAdapter(komut);
                    DataTable data_table = new DataTable();
                    adap.Fill(data_table);
                    txtIsim.Text = data_table.Rows[0]["isim"].ToString();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " hatası alındı");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_Ders.Checked) { 
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("UPDATE Bolum_dersleri SET isim='" + txtIsim.Text + "', kredi='" + txtKredi.Text + "', akts='" + txtAkts.Text + "' WHERE id="+Convert.ToInt32(txtid.Text), baglanti);
                komut.ExecuteNonQuery();
                    MessageBox.Show("işlem başarılı");
                }
                else
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("UPDATE Bolum SET isim='" + txtIsim.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("işlem başarılı");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + "hatası alındı");
                ;
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          try
            {
                if (rdb_Ders.Checked) {
                    veri_al();
                    ders_sayi--;
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("DELETE FROM Bolum_dersleri WHERE id="+txtid.Text, baglanti);
                    komut.ExecuteNonQuery();
                    OleDbCommand guncelle = new OleDbCommand("UPDATE Bolum SET ders_sayi=" + ders_sayi + " " + "WHERE id=" + blm_id, baglanti);
                    guncelle.ExecuteNonQuery();
                    OleDbCommand komut2 = new OleDbCommand("DELETE FROM Ders WHERE ders_id=" + txtid.Text, baglanti);
                    komut2.ExecuteNonQuery();
                MessageBox.Show("işlem başarılı");
                btngeri_Click(0, e);
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("DELETE FROM Bolum WHERE id=" + txtid.Text, baglanti);
                komut.ExecuteNonQuery();
                OleDbCommand komut2 = new OleDbCommand("DELETE FROM Bolum_dersleri WHERE bolum_id=" + txtid.Text, baglanti);
                komut2.ExecuteNonQuery();
                veri_sil();
                OleDbCommand komut3 = new OleDbCommand("DELETE FROM Kisi WHERE bölüm_id=" + txtid.Text, baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("işlem başarılı");
                btngeri_Click(0, e);
            }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + "hatası alındı");
                
                btngeri_Click(0, EventArgs.Empty);

            }
            finally
            {
                baglanti.Close();
            }
        }

        private void veri_al()
        {
            OleDbCommand komut = new OleDbCommand("SELECT ders_sayi FROM Bolum WHERE id=" + blm_id, baglanti);
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            DataTable data_table = new DataTable();
            adap.Fill(data_table);
            ders_sayi = Convert.ToInt32(data_table.Rows[0]["ders_sayi"]);
        }

        private void veri_sil()
        {
            OleDbCommand komut = new OleDbCommand("SELECT numara FROM Kisi WHERE bölüm_id=" + Convert.ToInt32(txtid.Text), baglanti);
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            DataTable data_table = new DataTable();
            adap.Fill(data_table);
            for(int i=0; i< data_table.Rows.Count; i++)
            {
                OleDbCommand komut2 = new OleDbCommand("DELETE FROM Ders WHERE ogrenci_id='" + data_table.Rows[i]["numara"].ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
            }
        }

        private void text_yaz()
        {
            txtid.Text = Localization.id_gir;
            txtIsim.Text = Localization.isim;
            txtKredi.Text = Localization.kredi;
            btngeri.Text = Localization.geri;
            btnkaydet.Text = Localization.kaydet;
            button1.Text = Localization.ara;
            button2.Text = Localization.sil;
            rdbBlm.Text = Localization.bolum;
            rdb_Ders.Text = Localization.ders;
            label1.Text = Localization.ders_blm_dznle;
            label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, 74);

        }
    }
}
