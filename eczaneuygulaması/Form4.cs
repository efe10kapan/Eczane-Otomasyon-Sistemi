using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eczaneuygulaması
{
    public partial class Form4: Form
    {
        decimal indirimCarpani = 1; // Başta indirim yok

        private void ToplamTutarGuncelle()
        {
            // Sabit fiyatlar
            decimal fiyat = 90;

            // Seçilen adetler
            int adetBilaxen = Convert.ToInt32(cmbBilaxen.SelectedItem ?? "0");
            int adetAvmigren = Convert.ToInt32(cmbAvmigren.SelectedItem ?? "0");
            int adetMajezik = Convert.ToInt32(cmbMajezik.SelectedItem ?? "0");
            int adetKaterin = Convert.ToInt32(cmbKaterin.SelectedItem ?? "0");
            int adetBevit = Convert.ToInt32(cmbBevit.SelectedItem ?? "0");
            int adetParol = Convert.ToInt32(cmbParol.SelectedItem ?? "0");

            // Toplam hesapla
            decimal toplamTutar = (adetBilaxen + adetAvmigren + adetMajezik +
                                   adetKaterin + adetBevit + adetParol) * fiyat * indirimCarpani;

            txtNakit.Text = toplamTutar.ToString("0.00") + " TL";
        }

        // Tüm ComboBox'lar için aynı metodu çağır
        private void cmbBilaxen_SelectedIndexChanged(object sender, EventArgs e) => ToplamTutarGuncelle();
        private void cmbAvmigren_SelectedIndexChanged(object sender, EventArgs e) => ToplamTutarGuncelle();
        private void cmbMajezik_SelectedIndexChanged(object sender, EventArgs e) => ToplamTutarGuncelle();
        private void cmbKaterin_SelectedIndexChanged(object sender, EventArgs e) => ToplamTutarGuncelle();
        private void cmbBevit_SelectedIndexChanged(object sender, EventArgs e) => ToplamTutarGuncelle();
        private void cmbParol_SelectedIndexChanged(object sender, EventArgs e) => ToplamTutarGuncelle();

        public Form4()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form5'yi oluştur ve göster
            Form5 form5 = new Form5();
            form5.Show();

            // Form4'i gizle
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrWhiteSpace(txtNakit.Text))
                {
                    MessageBox.Show("Ödeme başarılı bir şekilde tamamlanmıştır.\nİyi Günler Dileriz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen önce ilaç ve adet seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (txtNakit.Text.EndsWith("TL"))
                {
                    string sadeceSayi = txtNakit.Text.Replace("TL", "").Trim();
                    if (decimal.TryParse(sadeceSayi, out decimal tutar))
                    {
                        decimal indirimliTutar = tutar / 2;
                        txtNakit.Text = indirimliTutar.ToString("0.00") + " TL";
                    }
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
