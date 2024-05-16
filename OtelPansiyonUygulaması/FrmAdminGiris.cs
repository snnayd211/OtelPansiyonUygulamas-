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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AycicekPansiyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * from AdminGiris where Kullanici=@Kullanici and Sifre=@Sifre";
                SqlParameter prm1 = new SqlParameter("Kullanici", textBox1.Text);
                SqlParameter prm2 = new SqlParameter("Sifre", textBox2.Text);
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if(dt.Rows.Count > 0 )
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                }

               
            }
            catch (Exception)
            {

                MessageBox.Show("Hatali Giriş");
            }
        }
    }
}
