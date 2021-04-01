using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Bolum
    {
        private int id;
        private String isim;
        private int kisi_sayi;
		private int aktif_kisi_sayi;
		private int ders_sayi;

		public int getId()
		{
			return id;
		}
		public void setId(int id)
		{
			this.id = id;
		}
		public String getIsim()
		{
			return isim;
		}
		public void setIsim(String isim)
		{
			this.isim = isim;
		}
		public int getKisi_sayi()
		{
			return kisi_sayi;
		}
		public void setKisi_sayi(int kisi_sayi)
		{
			this.kisi_sayi = kisi_sayi;
		}
		public int getDers_sayi()
		{
			return ders_sayi;
		}
		public void setDers_sayi(int ders_sayi)
		{
			this.ders_sayi = ders_sayi;
		}
		public int getaktif_Kisi_sayi()
		{
			return aktif_kisi_sayi;
		}
		public void setaktif_Kisi_sayi(int aktif_kisi_sayi)
		{
			this.aktif_kisi_sayi = aktif_kisi_sayi;
		}
	}
}
