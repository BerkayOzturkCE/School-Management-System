using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class YntciAnaMenu : Form
    {
        Giris giris;
        int sayac = 0;
       public int sDil;
        public YntciAnaMenu()
        {
            InitializeComponent();
        }
        public void veri_al(Giris giris, int sDil)
        {
            this.giris = giris;
            this.sDil = sDil;
        }

        private void YntciAnaMenu_Load(object sender, EventArgs e)
        {
            text_yaz();
            timer1.Enabled = true;
            comboBox1.Items.Add("Türkçe");
            comboBox1.Items.Add("English");
            if (sDil == 0)
            {
                comboBox1.SelectedIndex = 0;
                pictureBox1.Image = Resource1.turkishflag;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
                pictureBox1.Image = Resource1.abdflag;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Icon = Resource1.Icon1;
            this.Text = "Okul Yönetim Sistemi";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");
        }

        public void text_yaz()
        {
            kişiEkle.Text = Localization.yenikyt;
            kisidznle.Text = Localization.kisidznle;
            kisileriListele.Text = Localization.kisilst;
            dersVeyaBölümEkle.Text = Localization.ders_blm_ekle;
            dersVeyaBölümduzenle.Text = Localization.ders_blm_dznle;
            dersleriListele.Text = Localization.derslist;
            bölümleriListele.Text = Localization.blmlist;
            notGirisi.Text = Localization.notgrs;
            geri.Text = Localization.geri;
            dersVeyaBölümEkle.Text = Localization.ders_blm_ekle;
     
            label1.Text = Localization.yntcpanel;
            label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, 74);
        }

    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Türkçe")
            {
                Localization.Culture = new CultureInfo("");
                pictureBox1.Image = Resource1.turkishflag;
                sDil = 0;
                giris.sDil = 0;
            }
            else
            {
                Localization.Culture = new CultureInfo("en-US");
                pictureBox1.Image = Resource1.abdflag;
                sDil = 1;
                giris.sDil = 1;


            }
            text_yaz();
            giris.text_yaz();
        }

        private void kişiEkle_Click(object sender, EventArgs e)
        {
            Yeni_Kayit ogr_kayit = new Yeni_Kayit();
            ogr_kayit.BackgroundImage = this.BackgroundImage;
            ogr_kayit.veri_al(this);
            ogr_kayit.Show();
            ogr_kayit.Location = this.Location;
            this.Hide();
        }

        private void kisidznle_Click(object sender, EventArgs e)
        {
            kisi_düzenle dznle = new kisi_düzenle();
            dznle.BackgroundImage = this.BackgroundImage;
            dznle.veri_al(this);
            dznle.Show();
            dznle.Location = this.Location;
            this.Hide();
        }

        private void kisileriListele_Click(object sender, EventArgs e)
        {
            yazdir yzdr = new yazdir();
            yzdr.BackgroundImage = this.BackgroundImage;
            yzdr.veri_al(this, 1);
            yzdr.Show();
            yzdr.Location = this.Location;
            this.Hide();
        }

        private void dersVeyaBölümEkle_Click(object sender, EventArgs e)
        {
            Ders_Bolum_ekle DB_ekle = new Ders_Bolum_ekle();
            DB_ekle.BackgroundImage = this.BackgroundImage;
            DB_ekle.veri_al(this);
            DB_ekle.Show();
            DB_ekle.Location = this.Location;
            this.Hide();
        }

        private void dersleriListele_Click(object sender, EventArgs e)
        {

            yazdir yzdr = new yazdir();
            yzdr.BackgroundImage = this.BackgroundImage;

            yzdr.veri_al(this, 3);
            yzdr.Show();
            yzdr.Location = this.Location;
            this.Hide();
        }

        private void bölümleriListele_Click(object sender, EventArgs e)
        {
            yazdir yzdr = new yazdir();
            yzdr.BackgroundImage = this.BackgroundImage;
            yzdr.veri_al(this, 2);
            yzdr.Show();
            yzdr.Location = this.Location;
            this.Hide();
        }

        private void dersVeyaBölümduzenle_Click(object sender, EventArgs e)
        {
            D_B_duzenle dznle = new D_B_duzenle();
            dznle.BackgroundImage = this.BackgroundImage;
            dznle.veri_al(this);
            dznle.Show();
            dznle.Location = this.Location;
            this.Hide();
        }

        private void notGirisi_Click(object sender, EventArgs e)
        {
            Not_ekle not = new Not_ekle();
            not.BackgroundImage = this.BackgroundImage;
            not.veri_al(this);
            not.Show();
            not.Location = this.Location;
            this.Hide();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            giris.Location = this.Location;
            giris.BackgroundImage = this.BackgroundImage;
            giris.text_yaz();
            giris.Show();
            this.Close();
        }
    }

}