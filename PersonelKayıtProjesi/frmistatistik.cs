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
using System.Data.SqlClient;

namespace PersonelKayıtProjesi
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6PHO5RCR;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private void frmistatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            //Toplam Personel Sayısı için:
            SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personel", baglanti);
            SqlDataReader rd1= komut1.ExecuteReader();
            while (rd1.Read())//rd1 komutu okuma işlemi yaptığı sürece null değerle karşılaşana kadar okur
            {
                lblToplamPersonel.Text=rd1[0].ToString();//0. indexteki veriyi alır,tek sütun olduğu için 0 kullanılır
            }
            baglanti.Close();
            //Evli Personel Sayısı için:
            baglanti.Open();
            SqlCommand komut2=new SqlCommand("SELECT COUNT (*)FROM Tbl_Personel WHERE PerDrum='True'", baglanti);
            SqlDataReader rd2=komut2.ExecuteReader();
            while (rd2.Read())
            {
                lblEvliPersonel.Text=rd2[0].ToString();
            }
            baglanti.Close();
            //Bekar Personel Sayısı için:
            baglanti.Open();
            SqlCommand komut3=new SqlCommand("SELECT COUNT (*)FROM Tbl_Personel WHERE PerDrum='False'", baglanti);
            SqlDataReader rd3=komut3.ExecuteReader();
            while (rd3.Read())
            {
                lblBekarPersonel.Text=rd3[0].ToString();
            }
            baglanti.Close();
            //Şehir Sayısı için:
            baglanti.Open();
            SqlCommand komut4=new SqlCommand("SELECT COUNT (DISTINCT PerSehir)FROM Tbl_Personel", baglanti);
            SqlDataReader rd4=komut4.ExecuteReader();
            while (rd4.Read())
            {
                lblsehirSayısı.Text=rd4[0].ToString();
            }
            baglanti.Close();
            //Toplam Maaş için:
            baglanti.Open();
            SqlCommand komut5= new SqlCommand("SELECT SUM (PerMaas)FROM Tbl_Personel", baglanti);
            SqlDataReader rd5=komut5.ExecuteReader();
            while (rd5.Read())
            {
                lblToplamMaas.Text=rd5[0].ToString();
            }
            baglanti.Close();
            //Ortalama Maaş için:
            baglanti.Open();
            SqlCommand komut6=new SqlCommand("SELECT AVG (PerMaas)FROM Tbl_Personel", baglanti);
            SqlDataReader rd6=komut6.ExecuteReader();
            while (rd6.Read())
            {
                lblOrtMaas.Text=rd6[0].ToString();
            }



            baglanti.Close();


        }
    }
}
