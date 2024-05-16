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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AycicekPansiyon;Integrated Security=True");

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Btnoda101_Click(object sender, EventArgs e)
        {
            txtoda.Text = "101";
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Oda101(Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda102_Click(object sender, EventArgs e)
        {
            txtoda.Text = "102";
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Oda102(Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();

        }

        private void Btnoda103_Click(object sender, EventArgs e)
        {
            txtoda.Text = "103";
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Oda103(Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda104_Click(object sender, EventArgs e)
        {
            txtoda.Text = "104";
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Oda104(Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda105_Click(object sender, EventArgs e)
        {
            txtoda.Text = "105";
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Oda105(Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda106_Click(object sender, EventArgs e)
        {
            txtoda.Text = "106";
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Oda106(Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda107_Click(object sender, EventArgs e)
        {
            txtoda.Text = "107";
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Oda107(Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda108_Click(object sender, EventArgs e)
        {
            txtoda.Text = "108";
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Oda108(Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda109_Click(object sender, EventArgs e)
        {
            txtoda.Text = "109";
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("insert into Oda109(Adi,Soyadi) values ('" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btndolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Odalar Dolu Olanları Gösterir");
        }

        private void Btnbos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Odalar Boş Odaları Gösterir");
        }

        private void dtpcıkıs_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dtpgiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpcıkıs.Text);

            TimeSpan sonuc;
            sonuc = BuyukTarih - KucukTarih;
            label11.Text = sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label11.Text) * 50;
            txtücret.Text = Ucret.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)" +
                " values('" + txtad.Text + "','" + txtsoyad.Text + "','" + grpcinsiyet.Text+"','"+msktel.Text+"','"+txtmail.Text+"','"+txttc.Text+"','"+txtoda.Text+"','"+txtücret.Text+"','"+dtpgiris.Value.ToString("yyyy-MM-dd")+"','"+dtpcıkıs.Value.ToString("yyyy-MM-dd") +"' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Oda101", baglanti);
            SqlDataReader oku1 = komut.ExecuteReader();

            while (oku1.Read())
            {
                Btnoda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda101.Text != "101")
            {
                Btnoda101.BackColor = Color.Red;
                Btnoda101.Enabled = false;
            }
            //ODA 102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                Btnoda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda102.Text != "102")
            {
                Btnoda102.BackColor = Color.Red;
                Btnoda102.Enabled = false;
            }
            //ODA 103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                Btnoda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda103.Text != "103")
            {
                Btnoda103.BackColor = Color.Red;
                Btnoda103.Enabled = false;
            }
            //oda 104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                Btnoda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda104.Text != "104")
            {
                Btnoda104.BackColor = Color.Red;
                Btnoda104.Enabled = false;
            }
            //ODA 105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                Btnoda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda105.Text != "105")
            {
                Btnoda105.BackColor = Color.Red;
                Btnoda105.Enabled = false;
            }
            //oda 106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                Btnoda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda106.Text != "106")
            {
                Btnoda106.BackColor = Color.Red;
                Btnoda106.Enabled = false;
            }
            // ODA 107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                Btnoda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda107.Text != "107")
            {
                Btnoda107.BackColor = Color.Red;
                Btnoda107.Enabled = false;
            }
            // ODA 108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                Btnoda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda108.Text != "108")
            {
                Btnoda108.BackColor = Color.Red;
                Btnoda108.Enabled = false;
            }
            // ODA 109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                Btnoda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda109.Text != "109")
            {
                Btnoda109.BackColor = Color.Red;
                Btnoda109.Enabled = false;
            }
        }
    }
}
