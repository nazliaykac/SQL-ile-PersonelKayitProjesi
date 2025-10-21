using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System .Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;


namespace PersonelKayıtProjesi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6PHO5RCR;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void temizle()
        {
            textid.Text = "";
            textad.Text = "";
            textBoxsoy.Text = "";
            comboBox1.Text = "";
            textBoxmaas.Text = "";
            textBoxmeslk.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textad.Focus();

        }
        private void btnliste_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Personel", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnkydt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Personel (PerAd, PerSoyad,PerSehir,PerMaas,PerMeslek,PerDrum) VALUES (@p1, @p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", textad.Text);
            komut.Parameters.AddWithValue("@p2", textBoxsoy.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4", textBoxmaas.Text);
            komut.Parameters.AddWithValue("@p5", textBoxmeslk.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel başarıyla eklendi.");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Personel where PerID=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", textid.Text);
            komutsil.ExecuteNonQuery();//komutu çalıştırabilmek için
            MessageBox.Show("Kayıt Silindi");
            baglanti.Close();

        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;//seçilen hücreler içerisinde 0. noktanın satır indexi
            textid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            //listedeki elemana tıkladığımızda texte yazdırabilme işlemi

            textad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxsoy.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            textBoxmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            textBoxmeslk.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();






        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btngüncel_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            bool durum = bool.Parse(label8.Text);

            SqlCommand komutgüncelle = new SqlCommand("Update Tbl_Personel set PerAd=@A1, PerSoyAd=@a2,PerSehir=@a3,PerMaas=@a4,PerDrum=@a5,PerMeslek=@a6 where PerID=@a7 ", baglanti);
            komutgüncelle.Parameters.AddWithValue("@a1", textad.Text);
            komutgüncelle.Parameters.AddWithValue("@a2", textBoxsoy.Text);
            komutgüncelle.Parameters.AddWithValue("@a3", comboBox1.Text);
            komutgüncelle.Parameters.AddWithValue("@a4", textBoxmaas.Text);
            komutgüncelle.Parameters.AddWithValue("@a5", durum);

            komutgüncelle.Parameters.AddWithValue("@a6", textBoxmeslk.Text);
            komutgüncelle.Parameters.AddWithValue("@a7", textid.Text);

            komutgüncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Yapıldı");
        }

        private void btnistatis_Click(object sender, EventArgs e)
        {
            frmistatistik fr = new frmistatistik();
            fr.Show();
        }

        private void btngrfk_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmG = new FrmGrafikler();
            frmG.Show();
        }
    }
}
    
    
