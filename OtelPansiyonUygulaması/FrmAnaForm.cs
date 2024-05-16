using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelPansiyonUygulaması
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle ekle = new FrmMusteriEkle();
            ekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOdalar oda = new FrmOdalar();
            oda.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMüsteriler fr = new FrmMüsteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayçiçeği Pansiyon Kayıt Uygulaması");
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar gr = new FrmStoklar();
            gr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRadio radio = new FrmRadio();
            radio.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmGazeteler gazete = new FrmGazeteler();
            gazete.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle guncel = new FrmSifreGuncelle();
            guncel.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajlar msj = new FrmMesajlar();
            msj.Show();
        }
    }
}
