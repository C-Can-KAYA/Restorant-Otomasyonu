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
    public partial class giris : Form
    {
      Anamenu ana = new Anamenu();
        public giris()
        
        {
            InitializeComponent();
            
        }
        OleDbConnection baglanti;
        OleDbDataAdapter adaptor;
        OleDbCommand komut;
        DataSet verikumesi;
        OleDbDataReader dr;
          
        
        public static string personeladi { get; set; }
        public static string personelyetki { get; set; }
        public static int personelid { get; set; }
        public static string kullaniciadi { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar='*';
            comboBox2.Visible = false;
           comboBox3.Visible = false;
            label3.Visible = false;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            adaptor = new OleDbDataAdapter("Select * from personel_genel_bilgi", baglanti);
            verikumesi = new DataSet();
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM personel_genel_bilgi";
            dr = komut.ExecuteReader();
           
            while (dr.Read())
            {
               comboBox1.Items.Add(dr["KullaniciAdi"]);
               comboBox2.Items.Add(dr["YetkiSeviyesi"]);
               comboBox3.Items.Add(dr["Adi"]);
               comboBox4.Items.Add(dr["Id"]);
            }
            
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
            
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "SELECT * FROM personel_genel_bilgi where KullaniciAdi='" + comboBox1.Text.ToString() + "' AND Sifre='" + textBox1.Text + "'";
                    dr = komut.ExecuteReader();
            string kontrol=dr.Read().ToString();
                        if (kontrol=="True")
                        {
                            comboBox3.SelectedIndex = comboBox1.SelectedIndex;
                            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
                            comboBox4.SelectedIndex = comboBox1.SelectedIndex;
                            personeladi = comboBox3.Text;
                            personelyetki = comboBox2.Text;
                            personelid = Convert.ToInt16(comboBox4.Text);
                            kullaniciadi = comboBox1.Text;

                           this.Visible = false;
                           ana.Show();
                            baglanti.Close();


                        }
                        else
                        {
                            
                            label2.Visible = false;
                            label3.Visible = true;
                            baglanti.Close();
                        }

                        

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            label2.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            label2.Visible = true;
        }



    }
}
