using LibraryProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciAdi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";

            kullaniciAdi = txt_kullaniciAdi.Text;
            sifre = txt_sifre.Text;
            bool isExist = false;

            foreach(Kisi kisi in kisilerim)
            {
                if(kullaniciAdi==kisi.getKullaniciAdi() && sifre == kisi.getSifre() && kisi.getYetki()=="admin")
                {
                    AdminSayfası adminSayfası = new AdminSayfası(kisilerim,kitaplarim);
                    adminSayfası.Show();
                    this.Hide();

                    isExist = true;
                    break;
                }
                else if(kullaniciAdi == kisi.getKullaniciAdi() && sifre == kisi.getSifre() && kisi.getYetki() == "üye")
                {
                    ÜyeSayfası üyeSayfasi = new ÜyeSayfası();
                    üyeSayfasi.Show();
                    this.Hide();

                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                MessageBox.Show("Bir hata oluştu", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1, "Enes", "Bayram", DateTime.Now, "enes", "1", "üye"));
            kisilerim.Add(new Kisi(3, "Can", "Oğuzorhan", DateTime.Now, "can", "2", "admin"));
            kisilerim.Add(new Kisi(3, "Aylin", "Çamur", DateTime.Now, "aylin", "3", "üye"));

            kitaplarim.Add(new Kitap(1, "İçimizdeki Şeytan", "Sebahattin Yakup", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
            kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayınları", "Roman", 300, 758, 2018));
            kitaplarim.Add(new Kitap(3, "Uçurtma Avcısı", "Khaled", "Almanca", "İletişim Yayınları", "Roman", 275, 378, 2020));
        }
    }
}
