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
using System.Globalization;

namespace WindowsFormsApp2
{
    public partial class Giris : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB_School.accdb");
        public int sDil=0;
        public Giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text_yaz(); 
            BackgroundImageLayout = ImageLayout.Stretch;
            timer1.Enabled = true;
            this.Text = "Okul Yönetim Sistemi";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");
        }




        private void btnOgrSfrAl_Click(object sender, EventArgs e)
        {
            Sifreunuttum sifreunuttum = new Sifreunuttum();
            sifreunuttum.Show();
            sifreunuttum.veri_al(this);
            sifreunuttum.Location = this.Location;
            this.Hide();
        }

        private void btnYntcSfrAl_Click(object sender, EventArgs e)
        {
            Sifreunuttum sifreunuttum = new Sifreunuttum();
            sifreunuttum.Show();
            sifreunuttum.veri_al(this);
            sifreunuttum.Location = this.Location;
            this.Hide();
        }

        private void checkbxytk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxytk.Checked)
            {
                txtBoxYntcsfr.PasswordChar = '*';
            }
            else
            {
                txtBoxYntcsfr.PasswordChar = '\0';

            }
        }

        private void checkbxogr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxogr.Checked)
            {
                txtBoxOgrsfr.PasswordChar = '*';
            }
            else
            {
                txtBoxOgrsfr.PasswordChar = '\0';

            }
        }
        private int kontrol()
        {
            int kontrol = 0;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT sifre FROM Kisi WHERE numara='"+txtBoxOgrGrs.Text+ "' AND  unvan='Ogrenci'", baglanti);
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            DataTable data_table = new DataTable();
            adap.Fill(data_table);
            String sifre = Convert.ToString(data_table.Rows[0]["sifre"]);
            if (sifre.Equals(txtBoxOgrsfr.Text))
            {
                kontrol = 1;
            }
            else
            {
                kontrol = 0;
            }
            baglanti.Close();
            return kontrol;
        }

        private int kontrol2()
        {
            int kontrol = 0;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT sifre FROM Kisi WHERE numara='" + txtBoxYntcGrs.Text + "' AND  unvan='Yetkili'", baglanti);
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            DataTable data_table = new DataTable();
            adap.Fill(data_table);
            String sifre = Convert.ToString(data_table.Rows[0]["sifre"]);
            if (sifre.Equals(txtBoxYntcsfr.Text))
            {
                kontrol = 1;
            }
            else
            {
                kontrol = 0;
            }
            baglanti.Close();
            return kontrol;
        }

        public void text_yaz()
        {
            txtBoxOgrGrs.Text = Localization.numara;
            txtBoxYntcGrs.Text = Localization.numara;
            txtBoxOgrsfr.Text = Localization.sifre;
            txtBoxYntcsfr.Text = Localization.sifre;
            btnOgrGrs.Text = Localization.giris;
            btnYntciGiris.Text = Localization.giris;
            btnYntcSfrAl.Text = Localization.sifremiunuttum;
            btnOgrSfrAl.Text = Localization.sifremiunuttum;
            label3.Text = Localization.ogr_grs;
            label4.Text = Localization.ytkl_grs;
            label3.Location = new Point((panel1.Width - label3.Size.Width) / 2, 30);
            label4.Location = new Point((panel2.Width - label4.Size.Width) / 2, 30);
            checkbxogr.Text = Localization.sfr_gzl;
            checkbxytk.Text = Localization.sfr_gzl;
        }

        private void btnYntciGiris_Click_1(object sender, EventArgs e)
        {
            try
            {
                int durum;
                if (txtBoxYntcGrs.Text.Equals("admin") && txtBoxYntcsfr.Text.Equals("admin"))
                {
                    durum = 1;
                }
                else
                {
                    durum = kontrol2();
                }

                if (durum == 1)
                {
                    YntciAnaMenu Yntcmenu = new YntciAnaMenu();
                    Yntcmenu.veri_al(this, sDil);
                    Yntcmenu.text_yaz();
                    Yntcmenu.Location = this.Location;

                    this.Hide();
                    Yntcmenu.Show();
                    text_yaz();
                }
                else
                {
                    MessageBox.Show("hatalı şifre veya numara");
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(" kullanıcı bulunamadı!");
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

        private void btnOgrGrs_Click_1(object sender, EventArgs e)
        {
            try
            {
                int durum;
                if (txtBoxOgrGrs.Text.Equals("admin") && txtBoxOgrsfr.Text.Equals("admin"))
                {
                    durum = 1;
                }
                else
                {
                    durum = kontrol();
                }

                if (durum == 1)
                {
                    OgrAnaMenu Ogrmenu = new OgrAnaMenu();
                    Ogrmenu.veri_al(this, txtBoxOgrGrs.Text, sDil);
                    Ogrmenu.text_yaz();
                    Ogrmenu.Show();
                    Ogrmenu.Location = this.Location;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("hatalı şifre veya numara");
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(" kullanıcı bulunamadı!");
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
    }
}
