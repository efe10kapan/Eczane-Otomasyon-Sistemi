using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
namespace eczaneuygulaması

{
    public partial class Form2 : Form
    {
        private void RoundCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)

        {
            // Beni Hatırla kontrolü
            if (!chkHatirla.Checked)
            {
                MessageBox.Show("Devam etmek için 'Beni Hatırla' kutusunu işaretleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Değerleri basitçe hardcoded olarak karşılaştıralım
            // Metin kutuları yerine doğrudan değerleri kontrol edelim

            // Sadece basit bir giriş yapalım - hemen kabul edelim
            MessageBox.Show("Giriş başarılı!");

            try
            {
                // Form3'ü açmayı deneyelim
                Form3 form3 = new Form3();
                form3.StartPosition = FormStartPosition.CenterScreen;
                form3.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Form3 ile ilgili bir sorun varsa bu mesaj görünecek
                MessageBox.Show($"Form3 açılırken hata: {ex.Message}\n\nDetay: {ex.StackTrace}",
                              "Form Açılma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RoundCorners(panel1, 25); // panel1 senin tasarımda eklediğin panelin adı
            panel1.Resize += (s, ev) => RoundCorners(panel1, 25); // boyut değişince yeniden uygular
        }
    }
        }
 