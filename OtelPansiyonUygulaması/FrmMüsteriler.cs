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
    public partial class FrmMüsteriler : Form
    {
        public FrmMüsteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AycicekPansiyon;Integrated Security=True");
        private void verilerigoster()
        {
            btngncl.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From MusteriEkle",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()) { 
            
           ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                btngncl.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();

        }

        private void FrmMüsteriler_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(btngncl.SelectedItems[0].SubItems[0].Text);
            txtad.Text = btngncl.SelectedItems[0].SubItems[1].Text;
            txtsoyad.Text = btngncl.SelectedItems[0].SubItems[2].Text;
            grpcinsiyet.Text = btngncl.SelectedItems[0].SubItems[3].Text;
            msktel.Text = btngncl.SelectedItems[0].SubItems[4].Text;
            txtmail.Text = btngncl.SelectedItems[0].SubItems[5].Text;
            txttc.Text = btngncl.SelectedItems[0].SubItems[6].Text;
            txtoda.Text = btngncl.SelectedItems[0].SubItems[7].Text;
            txtücret.Text = btngncl.SelectedItems[0].SubItems[8].Text;
            dtpgiris.Text = btngncl.SelectedItems[0].SubItems[9].Text;
            dtpcıkıs.Text = btngncl.SelectedItems[0].SubItems[10].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='"+txtad.Text+"',Soyadi='"+txtsoyad.Text+"',Cinsiyet='"+grpcinsiyet.Text+"',Telefon='"+msktel.Text+"',Mail='"+txtmail.Text+"',TC='"+txttc.Text+"',OdaNo='"+txtoda.Text+"',Ucret='"+txtücret.Text+"' where Musteriid="+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

        }


        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtoda.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtoda.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtoda.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtoda.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtoda.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtoda.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtoda.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtoda.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtoda.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }


        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsoyad.Clear();
            grpcinsiyet.Text = "";
            msktel.Clear();
            txtmail.Text = "";
            txttc.Clear();
            txtoda.Clear();
            txtücret.Clear();
            
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            btngncl.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From MusteriEkle where Adi like'%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                btngncl.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}

