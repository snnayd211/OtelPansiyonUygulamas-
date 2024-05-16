using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OtelPansiyonUygulaması
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AycicekPansiyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
           personel = Convert.ToInt32(txtpersonelbilgi.Text);
           lblpersonel.Text = (personel * 1500).ToString();

            int sonuc;
            sonuc=Convert.ToInt32(lblkasatop.Text)-(Convert.ToInt32(lblpersonel.Text)+Convert.ToInt32(lblgıda.Text)+Convert.ToInt32(lblicecek.Text)+Convert.ToInt32(lblatıs.Text)+Convert.ToInt32(lblelek.Text)+Convert.ToInt32(lblsu.Text)+Convert.ToInt32(lblint.Text));
            lblsonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            // KASADAKİ TOPLAM TUTAR
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                lblkasatop.Text = oku["toplam"].ToString();
            }
            baglanti.Close();
            // Gıda Giderleri
            baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("select sum(Gıda) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = kmt2.ExecuteReader();
            while (oku2.Read())
            {
                lblgıda.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();
            //İcecekler
            baglanti.Open();
            SqlCommand kmt3 = new SqlCommand("select sum(İcecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = kmt3.ExecuteReader();
            while (oku3.Read())
            {
                lblicecek.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();
            //Cerezler
            baglanti.Open();
            SqlCommand kmt4 = new SqlCommand("select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = kmt4.ExecuteReader();
            while (oku4.Read())
            {
                lblatıs.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            //ELEKTRİK
            baglanti.Open();
            SqlCommand kmt5 = new SqlCommand("select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = kmt5.ExecuteReader();
            while (oku5.Read())
            {
                lblelek.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();
            //Su
            baglanti.Open();
            SqlCommand kmt6 = new SqlCommand("select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = kmt6.ExecuteReader();
            while (oku6.Read())
            {
                lblsu.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();
            // İNTERNET
            baglanti.Open();
            SqlCommand kmt7 = new SqlCommand("select sum(İnternet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = kmt7.ExecuteReader();
            while (oku7.Read())
            {
                lblint.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();
           

        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
