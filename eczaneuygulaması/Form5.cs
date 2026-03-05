using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Data.SqlClient;

namespace eczaneuygulaması
{
    public partial class Form5 : Form
{    public Form5()
    {
        InitializeComponent();
        
        // Chart kontrolünün temel özelliklerini ayarla
        chart1.Dock = DockStyle.Fill;
        chart1.BackColor = Color.WhiteSmoke;
    }
   
    private void Form5_Load(object sender, EventArgs e)
    {
        // Form yüklendiğinde grafiği göster
        GrafikGoster();
    }

    private void GrafikGoster()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hümeyra\source\repos\eczaneuygulaması\eczaneuygulaması\Database1.mdf;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand cmdReceteli = new SqlCommand("SELECT SUM(adet) FROM ilaclar WHERE recetedurumu = 'Reçeteli'", conn);
                object receteliObj = cmdReceteli.ExecuteScalar();
                int receteliAdet = receteliObj != DBNull.Value ? Convert.ToInt32(receteliObj) : 0;

                SqlCommand cmdRecetesiz = new SqlCommand("SELECT SUM(adet) FROM ilaclar WHERE recetedurumu = 'Reçetesiz'", conn);
                object recetesizObj = cmdRecetesiz.ExecuteScalar();
                int recetesizAdet = recetesizObj != DBNull.Value ? Convert.ToInt32(recetesizObj) : 0;

                chart1.Series.Clear();
                chart1.Titles.Clear();

                // Chart başlığını ayarla
                Title title = new Title();
                title.Text = "Stok Dağılımı (Reçeteli / Reçetesiz)";
                title.Font = new Font("Arial", 12, FontStyle.Bold);
                chart1.Titles.Add(title);

                // Yeni seri oluştur
                Series seri = new Series("Stok");
                seri.ChartType = SeriesChartType.Pie;
                
                // Veri noktalarını ekle ve renkleri ayarla
                DataPoint p1 = new DataPoint();
                p1.SetValueXY("Reçeteli", receteliAdet);
                p1.Color = Color.LightBlue;
                seri.Points.Add(p1);

                DataPoint p2 = new DataPoint();
                p2.SetValueXY("Reçetesiz", recetesizAdet);
                p2.Color = Color.LightGreen;
                seri.Points.Add(p2);

                // Seriyi charta ekle
                chart1.Series.Add(seri);

                // Pasta grafiği ayarları
                chart1.Series["Stok"]["PieLabelStyle"] = "Outside";
                chart1.Series["Stok"].Label = "#PERCENT{P0}";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Grafik oluşturulurken bir hata oluştu: " + ex.Message);
        }
    }
}
}