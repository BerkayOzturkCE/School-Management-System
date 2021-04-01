using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Ders
    {
        private int id;
        private string isim;
        private int kredi;
        private int akts;
		private int vize;
		private int final;
        private String ogr_id;
        private int bolum_id;

		public int getId()
		{
			return id;
		}
		public void setId(int id)
		{
			this.id = id;
		}
		public string getIsim()
		{
			return isim;
		}
		public void setIsim(string isim)
		{
			this.isim = isim;
		}
		public int getKredi()
		{
			return kredi;
		}
		public void setKredi(int kredi)
		{
			this.kredi = kredi;
		}
		public int getAkts()
		{
			return akts;
		}
		public void setAkts(int akts)
		{
			this.akts = akts;
		}
		public String getOgr_id()
		{
			return ogr_id;
		}
		public void setOgr_id(String ogr_id)
		{
			this.ogr_id = ogr_id;
		}
		public int getBolum_id()
		{
			return bolum_id;
		}
		public int getVize()
		{
			return vize;
		}
		public void setVize(int vize)
		{
			this.vize = vize;
		}
		public int getFinal()
		{
			return final;
		}
		public void setFinal(int final)
		{
			this.final = final;
		}
		public void setBolum_id(int bolum_id)
		{
			this.bolum_id = bolum_id;
		}

	}
}
