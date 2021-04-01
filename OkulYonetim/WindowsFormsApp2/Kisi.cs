using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Kisi
    {
		private String kimlik_no;
		private String isim;
		private String soyisim;
		private String sifre;
		private String numara;
		private String adres;
		private String cinsiyet;
		private String dogum_trh;
		private String mail;
		private String telefon;
		private String unvan;
		private int bolum_id;
		private int ders_sayi;
		private Ders[] dersler;


		public String getKimlikNo()
		{
			return kimlik_no;
		}
		public void setKimlikNo(String kimlik_no)
		{
			this.kimlik_no = kimlik_no;
		}

		public String getIsim()
		{
			return isim;
		}
		public void setIsim(String isim)
		{
			this.isim = isim;
		}
		public String getSoyisim()
		{
			return soyisim;
		}
		public void setSoyisim(String soyisim)
		{
			this.soyisim = soyisim;
		}
		public String getSifre()
		{
			return sifre;
		}
		public void setSifre(String sifre)
		{
			this.sifre = sifre;
		}
		public string getNumara()
		{
			return numara;
		}
		public void setNumara(string numara)
		{
			this.numara = numara;
		}
		public string getAdres()
		{
			return adres;
		}
		public void setAdres(string adres)
		{
			this.adres = adres;
		}
		public string getCinsiyet()
		{
			return cinsiyet;
		}
		public void setCinsiyet(string cinsiyet)
		{
			this.cinsiyet = cinsiyet;
		}
		public string getDogum_trh()
		{
			return dogum_trh;
		}
		public void setDogum_trh(string dogum_trh)
		{
			this.dogum_trh = dogum_trh;
		}
		public int getDers_sayi()
		{
			return ders_sayi;
		}
		public void setDers_sayi(int ders_sayi)
		{
			this.ders_sayi = ders_sayi;
		}

		public String getMail()
		{
			return mail;
		}
		public void setMail(String mail)
		{
			this.mail = mail;
		}
		public String getTelefon()
		{
			return telefon;
		}
		public void setTelefon(String telefon)
		{
			this.telefon = telefon;
		}
		public String getUnvan()
		{
			return unvan;
		}
		public void setUnvan(String unvan)
		{
			this.unvan = unvan;
		}
		public int getBolum_id()
		{
			return bolum_id;
		}
		public void setBolum_id(int bolum_id)
		{
			this.bolum_id = bolum_id;
		}

		public void setDers_ekle(int dersler)
		{
			this.dersler = new Ders[ders_sayi];
		}

	}
}
