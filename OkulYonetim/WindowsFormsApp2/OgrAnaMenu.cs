using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class OgrAnaMenu : Form
    {
        Giris giris;
        String ogr_no;
        int sayac = 0;
        public int sDil;
        public OgrAnaMenu()
        {
            InitializeComponent();
        }

        private void OgrAnaMenu_Load(object sender, EventArgs e)
        {
            text_yaz();
            timer1.Enabled = true;
            comboBox1.Items.Add("Türkçe");
            comboBox1.Items.Add("English");
            if (sDil==0) {  
                comboBox1.SelectedIndex = 0;
                pictureBox3.Image = Resource1.turkishflag;
            }
            else {
                comboBox1.SelectedIndex = 1;
                pictureBox3.Image = Resource1.abdflag;
            }
          
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Icon = Resource1.Icon1;
            this.Text = "Okul Yönetim Sistemi";


        }


        public void veri_al(Giris giris, String ogr_no, int sDil)
        {
            this.giris = giris;
            this.ogr_no = ogr_no;
            this.sDil = sDil;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");

        }



     

        public void text_yaz()
        {

            notlar.Text = Localization.notlar;
            kisisel.Text = Localization.kisisel_bilgiler;
            ders_kayit.Text = Localization.ders_kaydı;
            geri.Text = Localization.geri;
            label1.Text = Localization.ogrpanel;
            label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, 74);
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Türkçe")
            {
                Localization.Culture = new CultureInfo("");
                pictureBox3.Image = Resource1.turkishflag;
                sDil = 0;
                giris.sDil = 0;
            }
            else
            {
                Localization.Culture = new CultureInfo("en-US");
                pictureBox3.Image = Resource1.abdflag;
                sDil = 1;
                giris.sDil = 1;


            }
            giris.text_yaz();
            text_yaz();
        }

        private void notlar_Click_1(object sender, EventArgs e)
        {
            Notlar not = new Notlar();
            not.BackgroundImage = this.BackgroundImage;
            not.Location = this.Location;
            not.veri_al(this, ogr_no);
            not.Show();
            this.Hide();
        }

        private void kisisel_Click_1(object sender, EventArgs e)
        {
            Kisisel_bilgiler kisisel = new Kisisel_bilgiler();
            kisisel.BackgroundImage = this.BackgroundImage;
            kisisel.veri_al(this, ogr_no);
            kisisel.Show();
            kisisel.Location = this.Location;
            this.Hide();
        }

        private void ders_kayit_Click_1(object sender, EventArgs e)
        {
            Ders_kaydi kayıt = new Ders_kaydi();
            kayıt.BackgroundImage = this.BackgroundImage;
            kayıt.veri_al(this, ogr_no);
            kayıt.Show();
            kayıt.Location = this.Location;
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
