using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Model
{
    public class Kisi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }


        public Kisi()
        {

        }

        public Kisi(int id, string isim, string soyisim, DateTime olusturmaTarih, string kullaniciAdi, string sifre, string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmaTarih = olusturmaTarih;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.yetki = yetki;
        }

        //id
        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }
        //isim
        public void setIsım(string isim)
        {
            this.isim = isim;
        }

        public string getIsım()
        {
            return this.isim;
        }

        public void setSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }

        public string getSoyisim()
        {
            return this.soyisim;
        }

        public void setOlusturmaTarih(DateTime olusturmaTarih)
        {
            this.olusturmaTarih = olusturmaTarih;
        }

        public DateTime getOlusturmaTarih()
        {
            return this.olusturmaTarih;
        }

        public void setKullaniciAdi(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }

        public string getKullaniciAdi()
        {
            return this.kullaniciAdi;
        }

        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }

        public string getSifre()
        {
            return this.sifre;
        }

        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }

        public string getYetki()
        {
            return this.yetki;
        }


        public override string ToString()
        {
            return $"İsin - Soyisim : {this.isim} ${this.soyisim}";
        }

    }
}
