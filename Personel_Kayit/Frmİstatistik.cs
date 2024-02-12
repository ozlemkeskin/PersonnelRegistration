using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-J20VECQT\\SQLEXPRESS01;Initial Catalog=personelveritabani;Integrated Security=True;");

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            // Toplam personel Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())// dr1 komutu okuma işlemi yaptığı müddetçe en son  satırla karşılaşana kadar.
            {
                LblToplamPersonel.Text = dr1[0].ToString();
            }
            
            baglanti.Close();

            // Evli Personel Sayısı

            baglanti.Open();
           SqlCommand komut2 = new SqlCommand("Select count (*) From Tbl_Personel where PerDurum=1", baglanti);
          
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvliPersonel.Text= dr2[0].ToString();

            }
            baglanti.Close();

            // Bekar Personel Sayısı

            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select count (*) From Tbl_Personel where PerDurum=0", baglanti);
            SqlDataReader dr3 = komut2.ExecuteReader();
            while (dr3.Read())
            {
                LblBekarPersonel.Text = dr3[0].ToString();
            }

            baglanti.Close();

            // Şehir Sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select Count (distinct(PerSehir)) From Tbl_Personel" , baglanti);
            SqlDataReader dr4= komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblSehirSayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Toplam maaş
            baglanti.Open ();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr5=komut5.ExecuteReader();
            while (dr5.Read())
            { 
                LblToplamMaas.Text= dr5[0].ToString();    
            }
            baglanti.Close ();

            //Ortalama Maaş
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select Avg(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr6=komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblOrtalamaMaas.Text = dr6[0].ToString();
            }
            baglanti.Close();



        }




    }
}
