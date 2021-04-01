using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class Not_ekle : Form
    {
        YntciAnaMenu anamenu;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB_School.accdb");

        public Not_ekle()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");
        }

        private void Not_ekle_Load(object sender, EventArgs e)
        {
            text_yaz();
            timer1.Enabled = true;
            this.Text = "Okul Yönetim Sistemi";
        }
        public void veri_al(YntciAnaMenu anamenu)
        {
            this.anamenu = anamenu;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            anamenu.Location = this.Location;
            anamenu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM Kisi WHERE numara='" + txtnum.Text + "'", baglanti);
                OleDbDataAdapter adap = new OleDbDataAdapter(komut);
                DataTable data_table = new DataTable();
                adap.Fill(data_table);

                txtisim.Text = Convert.ToString(data_table.Rows[0]["isim"]);
                txtsyisim.Text = Convert.ToString(data_table.Rows[0]["soyisim"]);
                DB_veri_al();
                MessageBox.Show("işlem başarılı");

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

        private void btnkyt_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut2 = new OleDbCommand("SELECT * FROM Bolum_dersleri WHERE isim='" + comboBox1.Text+"'", baglanti);
                OleDbDataAdapter adap2 = new OleDbDataAdapter(komut2);
                DataTable data_table2 = new DataTable();
                adap2.Fill(data_table2);
                int dersid = Convert.ToInt32(data_table2.Rows[0]["id"]);
                OleDbCommand guncelle = new OleDbCommand("UPDATE Ders SET vize='" + txtvize.Text+"', final='"+txtfinal.Text+"'" + " " + "WHERE ders_id=" + dersid, baglanti);
                guncelle.ExecuteNonQuery();
                MessageBox.Show("işlem başarılı");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata + " hatası alındı!");
            }
            finally {
                baglanti.Close();
            }
        }
        private void DB_veri_al()
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Ders WHERE ogrenci_id='" + txtnum.Text + "'", baglanti);
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            DataTable data_table = new DataTable();
            adap.Fill(data_table);
            for(int i = 0; i < data_table.Rows.Count; i++)
            {
               int drsid = Convert.ToInt32(data_table.Rows[i]["ders_id"]);
                OleDbCommand komut2 = new OleDbCommand("SELECT * FROM Bolum_dersleri WHERE id=" + drsid, baglanti);
                OleDbDataAdapter adap2 = new OleDbDataAdapter(komut2);
                DataTable data_table2 = new DataTable();
                adap2.Fill(data_table2);
                comboBox1.Items.Add(data_table2.Rows[0]["isim"]);
            }

        }

        private void text_yaz()
        {
            txtisim.Text = Localization.isim;
            txtsyisim.Text = Localization.soyisim;
            txtnum.Text = Localization.numara;
            txtfinal.Text = Localization.final;
            txtvize.Text = Localization.vize;
            btnkyt.Text = Localization.kaydet;
            geri.Text = Localization.geri;
            button1.Text = Localization.ara;
            comboBox1.Text = Localization.ders;
            label1.Text = Localization.notgrs;
            label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, 74);

        }
    }
}
