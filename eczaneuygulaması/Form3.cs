using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eczaneuygulaması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void VerileriYukle()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hümeyra\source\repos\eczaneuygulaması\eczaneuygulaması\Database1.mdf;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ilaclar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // Diğer event'ler burada olabilir (btnEkle_Click gibi)
    
        private void IlacBilgisiekle()
        {
            // ... işlemler burada ...
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // İlac bilgilerini ekleyen metot çağrılıyor
            IlacBilgisiekle();

            // Renk animasyonu başlıyor
            btnkayıtekle.BackColor = Color.LightBlue;
            Refresh();

            System.Threading.Thread.Sleep(50);
            btnkayıtekle.BackColor = Color.DeepSkyBlue;
            Refresh();

            System.Threading.Thread.Sleep(50);
            btnkayıtekle.BackColor = Color.SteelBlue;
            Refresh();

            System.Threading.Thread.Sleep(50);
            btnkayıtekle.BackColor = Color.MediumSlateBlue;
            Refresh();

            // --- VERİTABANI İŞLEMİ ---
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hümeyra\source\repos\eczaneuygulaması\eczaneuygulaması\Database1.mdf;Integrated Security=True"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO ilaclar (ilackodu, ilacadi, firma, ksekli, fiyat, adet, barkodno, starih, recetedurumu) VALUES (@ilackod, @ilacadi, @firma, @ksekli, @fiyat, @adet, @barkodno, @starih, @recetedurumu)", conn);

                    // Uygun tür dönüşümleri
                    cmd.Parameters.AddWithValue("@ilackod", int.Parse(maskedtxtilackodu.Text));
                    cmd.Parameters.AddWithValue("@ilacadi", txtilacadi.Text);
                    cmd.Parameters.AddWithValue("@firma", txtüfirmasi.Text);
                    cmd.Parameters.AddWithValue("@ksekli", txtksekli.Text);
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtfiyat.Text));
                    cmd.Parameters.AddWithValue("@adet", int.Parse(txtkadet.Text));
                    cmd.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                    cmd.Parameters.AddWithValue("@starih", DateTime.Parse(txtsonktarihi.Text)); // Örn: 25.05.2025 formatı
                    if (rbreceteli.Checked)
                    {
                        cmd.Parameters.AddWithValue("@recetedurumu", "Reçeteli");
                    }
                    else if (rbrecetesiz.Checked)
                    {
                        cmd.Parameters.AddWithValue("@recetedurumu", "Reçetesiz");
                    }
                    else if (rbtum.Checked)
                    {
                        cmd.Parameters.AddWithValue("@recetedurumu", "Tüm İlaçlar");
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İlaç başarıyla kaydedildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }


            // Buton rengi işlem sonunda eski haline dönsün:
            btnkayıtekle.BackColor = Color.LightBlue; // veya SystemColors.Control

            // Tabloyu güncelle
            VerileriYukle();
        }
                                 
        private void IlacBilgileriniGuncelle()
        {
            // ... işlemler burada ...
        }
        private void button4_Click(object sender, EventArgs e)
        {
            {
                {
                    // İlacı güncelleyen metot çağrılıyor
                    IlacBilgileriniGuncelle();
                }
                // Butonun arka plan rengi LightBlue yapılıyor
                btngüncel.BackColor = Color.LightBlue;
                Refresh(); // Arayüz hemen güncelleniyor

                // Renk geçişleri: animasyon etkisi için
                System.Threading.Thread.Sleep(50);
                btngüncel.BackColor = Color.DeepSkyBlue;
                Refresh();

                System.Threading.Thread.Sleep(50);
                btngüncel.BackColor = Color.SteelBlue;
                Refresh();

                System.Threading.Thread.Sleep(50);
                btngüncel.BackColor = Color.MediumSlateBlue;
                Refresh();

                // Veritabanı bağlantısı oluşturuluyor
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hümeyra\source\repos\eczaneuygulaması\eczaneuygulaması\Database1.mdf;Integrated Security=True");

                // Bağlantı açılıyor
                conn.Open();

                // SQL UPDATE komutu hazırlanıyor
                SqlCommand cmd = new SqlCommand("UPDATE ilaclar SET ilacadi=@ilacadi, firma=@firma, ksekli=@ksekli, fiyat=@fiyat, adet=@adet, barkodno=@barkodno, starih=@starih, receteturu=@receteturu, recetedurumu=@recetedurumu WHERE ilackodu=@ilackodu", conn);

                // Parametreler ekleniyor
                cmd.Parameters.AddWithValue("@ilackodu", maskedtxtilackodu.Text);
                cmd.Parameters.AddWithValue("@ilacadi", txtilacadi.Text);
                cmd.Parameters.AddWithValue("@firma", txtüfirmasi.Text);
                cmd.Parameters.AddWithValue("@ksekli", txtksekli.Text);
                cmd.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
                cmd.Parameters.AddWithValue("@adet", txtkadet.Text);
                cmd.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                cmd.Parameters.AddWithValue("@starih", txtsonktarihi.Text);
                if (rbreceteli.Checked)
                {
                    cmd.Parameters.AddWithValue("@recetedurumu", "Reçeteli");
                }
                else if (rbrecetesiz.Checked)
                {
                    cmd.Parameters.AddWithValue("@recetedurumu", "Reçetesiz");
                }
                else if (rbtum.Checked)
                {
                    cmd.Parameters.AddWithValue("@recetedurumu", "Tüm İlaçlar");
                }
                

                // Komut çalıştırılıyor (veri güncelleniyor)
                cmd.ExecuteNonQuery();

                // Bağlantı kapatılıyor
                conn.Close();

                // Kullanıcıya bilgi mesajı gösteriliyor
                MessageBox.Show("Kayıt başarıyla güncellendi.");

                // Buton rengi işlem sonunda eski haline dönsün:
                btngüncel.BackColor = Color.LightBlue; // veya SystemColors.Control

                // Tabloyu güncelle
                VerileriYukle();

            }

        }
        private void btncıkıs_Click(object sender, EventArgs e)
        {
            {
                DialogResult cevap = MessageBox.Show(
                    "Çıkmak istediğinize emin misiniz?",
                    "Çıkış Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (cevap == DialogResult.Yes)
                {
                    Application.Exit(); // Uygulamayı tamamen kapatır
                }
                // Hayır seçildiyse hiçbir şey yapılmaz, Form3 açık kalır
            }

        }
        private void IlacBilgisinisil()
        {
            // ... işlemler burada ...
        }
        private void btnkayıtsil_Click(object sender, EventArgs e)
        {
            {
                {
                    // İlac bilgisini silen metot çağrılıyor
                    IlacBilgisinisil();
                }

                // 1. Buton rengi ilk haline ayarlanır
                btnkayıtsil.BackColor = Color.LightBlue;
                Refresh(); // Arayüzü hemen güncelle

                System.Threading.Thread.Sleep(50);
                btnkayıtsil.BackColor = Color.DeepSkyBlue;
                Refresh();

                System.Threading.Thread.Sleep(50);
                btnkayıtsil.BackColor = Color.SteelBlue;
                Refresh();

                System.Threading.Thread.Sleep(50);
                btnkayıtsil.BackColor = Color.MediumSlateBlue;
                Refresh();
            if (string.IsNullOrWhiteSpace(maskedtxtilackodu.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz ilacın kodunu girin veya tablodan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hümeyra\source\repos\eczaneuygulaması\eczaneuygulaması\Database1.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ilaclar WHERE ilackodu = @kod", conn);
                    cmd.Parameters.AddWithValue("@kod", maskedtxtilackodu.Text);
                    int etkilenen = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (etkilenen > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen ilaç koduna sahip bir kayıt bulunamadı.");
                    }
                }

                // Tabloyu güncelle
                VerileriYukle();

                // Buton rengi işlem sonunda eski haline dönsün:
                btnkayıtsil.BackColor = Color.LightBlue;
            }
        }

        }
        private void IlacBilgikaydıara()
        {
            // ... işlemler burada ...
        }
        private void btnkayıtara_Click(object sender, EventArgs e)
        {
            {
                {
                    {
                        // İlac bilgi kaydı arama metotu çağrılıyor
                        IlacBilgikaydıara();
                    }
                    // 1. Buton rengi ilk haline ayarlanır
                    btnkayıtara.BackColor = Color.LightBlue;
                    Refresh(); // Arayüzü hemen güncelle

                    System.Threading.Thread.Sleep(50);
                    btnkayıtara.BackColor = Color.DeepSkyBlue;
                    Refresh();

                    System.Threading.Thread.Sleep(50);
                    btnkayıtara.BackColor = Color.SteelBlue;
                    Refresh();

                    System.Threading.Thread.Sleep(50);
                    btnkayıtara.BackColor = Color.MediumSlateBlue;
                    Refresh();

                    {
                        if (string.IsNullOrWhiteSpace(maskedtxtilackodu.Text))
                        {
                            MessageBox.Show("Lütfen bir ilaç kodu giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hümeyra\source\repos\eczaneuygulaması\eczaneuygulaması\Database1.mdf;Integrated Security=True"))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("SELECT * FROM ilaclar WHERE ilackodu = @kod", conn);
                            cmd.Parameters.AddWithValue("@kod", maskedtxtilackodu.Text);

                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                txtsırano.Text = dr["Id"].ToString();
                                txtilacadi.Text = dr["ilacadi"].ToString();
                                txtüfirmasi.Text = dr["firma"].ToString();
                                txtksekli.Text = dr["ksekli"].ToString();
                                txtfiyat.Text = dr["fiyat"].ToString();
                                txtkadet.Text = dr["adet"].ToString();
                                txtbarkodno.Text = dr["barkodno"].ToString();
                                txtsonktarihi.Text = Convert.ToDateTime(dr["starih"]).ToString("yyyy-MM-dd");

                                int adet = Convert.ToInt32(dr["adet"]);
                                if (adet < 10)
                                {
                                    MessageBox.Show($"Bu ilacın stoğu azaldı: {adet} adet kaldı.", "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("İlaç bulunamadı.", "Sonuç Yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            dr.Close();
                            conn.Close();

                            // Buton rengi geri döner
                            System.Threading.Thread.Sleep(100);
                            btnkayıtara.BackColor = SystemColors.Control;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
               
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            {
                VerileriYukle(); // form açılınca tabloyu doldurur
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnfiltrele_Click(object sender, EventArgs e)
        {
            {
                string query = "";

                if (rbreceteli.Checked)
                {
                    query = "SELECT * FROM ilaclar WHERE receteDurumu = 'Reçeteli'";
                }
                else if (rbrecetesiz.Checked)
                {
                    query = "SELECT * FROM ilaclar WHERE receteDurumu = 'Reçetesiz'";
                }
                else if (rbtum.Checked)
                {
                    query = "SELECT * FROM ilaclar";
                }
                // Form4'yi oluştur ve göster
                Form4 form4 = new Form4();
                form4.Show();

                // Form3'i gizle
                this.Hide();
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hümeyra\source\repos\eczaneuygulaması\eczaneuygulaması\Database1.mdf;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();  
                dataGridView1.DataSource = dt;
            }
         }
        }
    }
