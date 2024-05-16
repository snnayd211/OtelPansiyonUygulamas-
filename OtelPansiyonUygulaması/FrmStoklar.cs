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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AycicekPansiyon;Integrated Security=True");
        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("Select * from Stoklar", baglanti);
            SqlDataReader rdr = kmt.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rdr["Gıda"].ToString();
                ekle.SubItems.Add(rdr["İcecek"].ToString());
                ekle.SubItems.Add(rdr["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        
        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("Select * from Faturalar", baglanti);
            SqlDataReader rdr2 = kmt2.ExecuteReader();
            while (rdr2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rdr2["Elektrik"].ToString();
                ekle.SubItems.Add(rdr2["Su"].ToString());
                ekle.SubItems.Add(rdr2["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }
        
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar (Gıda,İcecek,Cerezler) values('" + txtgıda.Text + "','" + txticecek.Text + "','" + txtatıs.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
            
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void btnkaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar (Elektrik,Su,İnternet) values('" + txtel.Text + "','" + txtsu.Text + "','" + txtint.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
