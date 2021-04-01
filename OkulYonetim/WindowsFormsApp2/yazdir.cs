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
    public partial class yazdir : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB_School.accdb");

        YntciAnaMenu anamenu;
        int gosterilecek;

        public yazdir()
        {
            InitializeComponent();
        }


        private void yazdir_Load(object sender, EventArgs e)
        {
            btngeri.Text = Localization.geri;
            timer1.Enabled = true;
            this.Text = "Okul Yönetim Sistemi";
            if (gosterilecek == 1)
            {
                kisileri_goster();
                
                
            }
            else if(gosterilecek==2)
            {
                Bolum_goster();
                dGwogr.Width = 550;
                dGwogr.Location=new Point(55,34);
            }
            else {
                Ders_goster();
                dGwogr.Width = 550;
                dGwogr.Location = new Point(55, 34);
            }



        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");

        }
        public void veri_al(YntciAnaMenu anamenu, int sayi)
        {
            this.anamenu = anamenu;
            this.gosterilecek = sayi;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            anamenu.Location = this.Location;
            anamenu.Show();
            this.Close();
        }

        private void kaydeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btngeri_Click(1, e);
        }
        private void kisileri_goster()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM Kisi", baglanti);
                OleDbDataAdapter adap = new OleDbDataAdapter(komut);
                DataTable data_table = new DataTable();
                adap.Fill(data_table);

                for (int i = 0; i < data_table.Rows.Count; i++)
                {
                    dGwogr.DataSource = data_table;
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

        private void Bolum_goster()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM  Bolum", baglanti);
                OleDbDataAdapter adap = new OleDbDataAdapter(komut);
                DataTable data_table = new DataTable();
                adap.Fill(data_table);

                for (int i = 0; i < data_table.Rows.Count; i++)
                {
                    dGwogr.DataSource = data_table;
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

        private void Ders_goster()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM  Bolum_dersleri", baglanti);
                OleDbDataAdapter adap = new OleDbDataAdapter(komut);
                DataTable data_table = new DataTable();
                adap.Fill(data_table);

                for (int i = 0; i < data_table.Rows.Count; i++)
                {
                    dGwogr.DataSource = data_table;
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

    }
}
