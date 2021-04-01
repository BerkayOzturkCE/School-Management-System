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
    public partial class Ders_kaydi : Form
    {    
        DataTable table = new DataTable();
        OgrAnaMenu anamenu;
        String numara;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB_School.accdb");

        public Ders_kaydi()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");
        }

        private void Ders_kaydi_Load(object sender, EventArgs e)
        {
            text_yaz();
            timer1.Enabled = true;
            DB_Verial(); 
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("isim", typeof(string));
            table.Columns.Add("kredi", typeof(int));
            table.Columns.Add("akts", typeof(int));
            this.Text = "Okul Yönetim Sistemi";
        }
        public void veri_al(OgrAnaMenu anamenu, String numara)
        {
            this.anamenu = anamenu;
            this.numara = numara;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            anamenu.Location = this.Location;
            anamenu.Show();
            this.Close();
        }
        private void DB_Verial()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komutogr = new OleDbCommand("SELECT bölüm_id FROM  Kisi WHERE numara='"+numara+"'", baglanti);
                OleDbDataAdapter adap = new OleDbDataAdapter(komutogr);
                DataTable data_table = new DataTable();
                adap.Fill(data_table);
                int blm_id = Convert.ToInt32(data_table.Rows[0][0]);

                OleDbCommand komut = new OleDbCommand("SELECT id, isim, kredi, akts FROM  Bolum_dersleri WHERE bolum_id=" + blm_id, baglanti);
                OleDbDataAdapter adap2 = new OleDbDataAdapter(komut);
                DataTable data_table2 = new DataTable();

                adap2.Fill(data_table2);

                for (int i = 0; i < data_table2.Rows.Count; i++)
                {
                    dataGridView1.DataSource = data_table2;
                    
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata+" hatası alındı!!");
            }
            finally
            {
                baglanti.Close();
            }

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            int id = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            int kntrl = Kontrol(id);
            if (kntrl == 1) { 
            String isim = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            int kredi = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[2].Value);
            int akts = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[3].Value);
            table.Rows.Add(id, isim, kredi, akts);
            dataGridView2.DataSource = table;
            }
            else
            {
                MessageBox.Show("aynı dersi lütfen eklemeyin!");
            }



        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView2.SelectedCells[0].RowIndex;
            dataGridView2.Rows.RemoveAt(secilen);
            dataGridView2.Refresh();

        }

        private void btnkyt_Click(object sender, EventArgs e)
        {
            try
            { 
            baglanti.Open();
            for (int i = 0; i < dataGridView2.Rows.Count-1; i++) {
                int dersid = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                int vize = 0, final = 0;
                OleDbCommand komut = new OleDbCommand("INSERT INTO Ders(ogrenci_id,ders_id,vize,final) Values(@ogrenci_id,@ders_id,@vize,@final)", baglanti);
                komut.Parameters.AddWithValue("@ogrenci_id", numara);
                komut.Parameters.AddWithValue("@ders_id", dersid);
                komut.Parameters.AddWithValue("@vize", vize);
                komut.Parameters.AddWithValue("@final", final);
                komut.ExecuteNonQuery();

                }
             MessageBox.Show("Başarıyla kaydedildi...");

            }
            catch(Exception hata)
            {
                MessageBox.Show(hata + " hatası alındı!");
            }
            finally
            {
                baglanti.Close();
                geri_Click(3, e);

            }
        }

        private int Kontrol(int id)
        {
            for(int i=0; i < dataGridView2.Rows.Count; i++)
            {
                if(Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value) == id)
                {
                    return 0;
                }
            }
            return 1;
        }

        private void text_yaz()
        {
            btnkyt.Text = Localization.kaydet;
            geri.Text = Localization.geri;
            label1.Text = Localization.ders_kaydı;
            label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, 74);

        }


    }

}
