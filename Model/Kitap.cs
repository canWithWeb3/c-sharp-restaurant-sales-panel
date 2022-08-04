using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Model
{
    public class Kitap
    {
        public int kitapId { get; set; }
        public string kitapİsim { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDili { get; set; }
        public string yayinEvi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfaSayisi { get; set; }
        public int basimYili { get; set; }

        public Kitap()
        {

        }

        public Kitap(int kitapId, string kitapİsim, string kitapYazar, string kitapDili, string yayinEvi, string tur, int adet, int sayfaSayisi, int basimYili)
        {
            this.kitapId = kitapId;
            this.kitapİsim = kitapİsim;
            this.kitapYazar = kitapYazar;
            this.kitapDili = kitapDili;
            this.yayinEvi = yayinEvi;
            this.tur = tur;
            this.adet = adet;
            this.sayfaSayisi = sayfaSayisi;
            this.basimYili = basimYili;
        }

        public int getKitapId()
        {
            return this.kitapId;
        }

        public string getKitapİsim()
        {
            return this.kitapİsim;
        }

        public string getKitapYazar()
        {
            return this.kitapYazar;
        }

        public string getKitapDili()
        {
            return this.kitapDili;
        }

        public string getYayinEvi()
        {
            return this.yayinEvi;
        }

        public string getKitapTur()
        {
            return this.tur;
        }

        public int getKitapAdet()
        {
            return this.adet;
        }

        public int getKitapSayfaSayisi()
        {
            return this.sayfaSayisi;
        }

        public int getBasimYili()
        {
            return this.basimYili;
        }






























    }
}
