using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
//BU FORMDA HATA VAR??GERİ DÖN
namespace PersonelKayıtProjesi
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
            this.Load += FrmGrafikler_Load; // Load olayını burada bağlıyoruz
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6PHO5RCR;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT PerSehir, COUNT(*) FROM Tbl_Personel GROUP BY PerSehir", baglanti);
            SqlDataReader gr = komut.ExecuteReader();

            while (gr.Read())
            {
                // MessageBox.Show($"{gr[0]} - {gr[1]}"); // doğruladıktan sonra kaldırın
                chart1.Series["Sehirler"].Points.AddXY(gr[0].ToString(), Convert.ToInt32(gr[1]));
            }

            gr.Close();      // reader kapatıldı
            baglanti.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }
    }
}