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
    public partial class Notlar : Form
    {
        DataTable table = new DataTable();
        OgrAnaMenu anamenu;
        String numara;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB_School.accdb");

        public Notlar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh.mm.ss tt");
        }

        private void Notlar_Load(object sender, EventArgs e)
        {
            text_yaz();
            timer1.Enabled = true;
            table.Columns.Add("ders_id", typeof(int));
            table.Columns.Add("isim", typeof(string));
            table.Columns.Add("vize", typeof(int));
            table.Columns.Add("final", typeof(int));
            database_Verial();
            this.Text = "Okul Yönetim Sistemi";
        }
        public void veri_al(OgrAnaMenu anamenu, String numara)
        {
            this.anamenu = anamenu;
            this.numara = numara;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            anamenu.Location = this.Location;
            anamenu.Show();
            this.Hide();
        }
        private void database_Verial()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM  Ders WHERE ogrenci_id='" + numara + "'", baglanti);
                OleDbDataAdapter adap = new OleDbDataAdapter(komut);
                DataTable data_table = new DataTable();
                adap.Fill(data_table);
                for (int i = 0; i < data_table.Rows.Count; i++) {
                    int ders_id = Convert.ToInt32(data_table.Rows[i]["ders_id"]);
                    int vize = Convert.ToInt32(data_table.Rows[i]["vize"]);
                    int final = Convert.ToInt32(data_table.Rows[i]["final"]);
                    

                    OleDbCommand komut2 = new OleDbCommand("SELECT isim FROM Bolum_dersleri WHERE id=" + ders_id , baglanti);
                    OleDbDataAdapter adap2 = new OleDbDataAdapter(komut2);
                    DataTable data_table2 = new DataTable();
                    adap2.Fill(data_table2);
                    String isim = data_table2.Rows[0][0].ToString();
                    table.Rows.Add(ders_id, isim, vize, final);
                    
                }
                dataGridView1.DataSource = table;

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
        private void text_yaz()
        {
            btngeri.Text = Localization.geri;
            label1.Text = Localization.notlar;
            label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, 74);

        }
    }
}
