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
    public partial class AdminSayfası : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;
        public AdminSayfası(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void groupBox_uyeİslemleri_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminSayfası_Load(object sender, EventArgs e)
        {
            foreach(Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(
                    kisi.getId(), 
                    kisi.getIsım(), 
                    kisi.getSoyisim(), 
                    kisi.getOlusturmaTarih(), 
                    kisi.getKullaniciAdi(), 
                    kisi.getSifre(), 
                    kisi.getYetki()
                );
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (
                txt_kitapId.Text != "" &&
                txt_isim.Text != "" &&
                txt_soyisim.Text != "" &&
                maskedTextBox1.Text != "" &&
                txt_kullaniciAdi.Text != "" &&
                txt_kitapTur.Text != "" &&
                txt_yetki.Text != ""
               )
            {
                dataGridView1.Rows.Add(
                    Convert.ToInt32(txt_kitapId.Text),
                    txt_isim.Text,
                    txt_soyisim.Text,
                    maskedTextBox1.Text,
                    txt_kullaniciAdi.Text,
                    txt_kitapTur.Text,
                    txt_yetki.Text
                );
            }
            else
            {
                MessageBox.Show("Bütün kutuları doldurmadınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void textleriDoldur()
        {
            txt_kitapId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_kitapTur.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_kitapId.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string olusturmaTarih = maskedTextBox1.Text;
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_kitapTur.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, olusturmaTarih, kullaniciAdi, sifre, yetki);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBox_uyeİslemleri.Controls.Count; i++)
            {
                if(groupBox_uyeİslemleri.Controls[i] is TextBox || groupBox_uyeİslemleri.Controls[i] is MaskedTextBox)
                {
                    groupBox_uyeİslemleri.Controls[i].Text = string.Empty;
                }
            }
        }
    }
}
