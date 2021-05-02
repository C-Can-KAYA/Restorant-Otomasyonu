using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _16541537_Cihat_Can_KAYA
{

    public partial class Ayar : Form
    {
       // Ayarlar ayar=new Ayarlar;
        public Ayar()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti =new OleDbConnection("Provider=Microsoft.ACE.Oledb.16.0; Data Source=restaurant_veritabani.mdb");
   
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
           sifre.PasswordChar = '*';
            kullanici.Text = giris.kullaniciadi;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            int a = giris.personelid;
            cmd3.CommandText = "UPDATE personel_genel_bilgi SET KullaniciAdi='" + kullanici.Text + "' , Sifre='" + sifre.Text + "' WHERE Id="+a+"";
            baglanti.Open();
            cmd3.Connection = baglanti;
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit basariyla güncellendi"); 
        }
    }
}
