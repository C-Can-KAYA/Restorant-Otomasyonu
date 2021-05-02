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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti;
            OleDbDataAdapter adaptor;
            OleDbCommand komut;
            DataSet verikumesi;
            OleDbDataReader asd;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            adaptor = new OleDbDataAdapter("Select * from yetkiseviyesi", baglanti);
            verikumesi = new DataSet();
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM yetkiseviyesi";
            asd = komut.ExecuteReader();

            while (asd.Read())
            {
                seviye.Items.Add(asd["yetkiseviyesi"]);
            }

            baglanti.Close();
            listView1.GridLines = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            guncelle.Visible = false;
            ekle.Visible = false;
            sil.Visible = false;

            ad.Visible = false;
            soyad.Visible = false;
            sifre.Visible = false;
            k_adi.Visible = false;
            seviye.Visible = false;

            listView1.Visible = false;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.GridLines = true;
            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            listView1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            con.Open();
            cmd = new OleDbCommand("Select * From personel_genel_bilgi", con);
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Id"].ToString());
                item.SubItems.Add(dr["Adi"].ToString());
                item.SubItems.Add(dr["Soyadi"].ToString());
                item.SubItems.Add(dr["KullaniciAdi"].ToString());
                item.SubItems.Add(dr["Sifre"].ToString());
                item.SubItems.Add(dr["YetkiSeviyesi"].ToString());
                listView1.Items.Add(item);
            }
            listView1.Columns[0].Width = 0;
            listView1.Columns[4].Width = 0;
            con.Close();


        }

        private void geri_Click(object sender, EventArgs e)
        {
            Anamenu ana = new Anamenu();
            ana.Visible = true;
            this.Visible = false;
        }

        private void personel_ekle_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;



            ad.Visible = true;
            soyad.Visible = true;
            sifre.Visible = true;
            k_adi.Visible = true;
            seviye.Visible = true;
            ekle.Visible = true;
            guncelle.Visible = false;
            sil.Visible = false;

            ad.Text = "";
            soyad.Text = "";
            sifre.Text = "";
            k_adi.Text = "";
            
        }

        private void personel_guncelle_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;



            ad.Visible = true;
            soyad.Visible = true;
            sifre.Visible = true;
            k_adi.Visible = true;
            seviye.Visible = true;
            ekle.Visible = false;
            guncelle.Visible = true;
            sil.Visible = false;
        }

        private void personel_sil_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;



            ad.Visible = false;
            soyad.Visible = false;
            sifre.Visible = false;
            k_adi.Visible = false;
            seviye.Visible = false;
            ekle.Visible = false;
            guncelle.Visible = false;
            sil.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ad.Text = listView1.SelectedItems[0].SubItems[1].Text;
                soyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
                k_adi.Text = listView1.SelectedItems[0].SubItems[3].Text;
                sifre.Text = listView1.SelectedItems[0].SubItems[4].Text;

                
                seviye.Text = listView1.SelectedItems[0].SubItems[5].Text;
                id.Text = listView1.SelectedItems[0].SubItems[0].Text;
                if(seviye.Text=="İşyeri Sahibi")
                {
                    sifre.Visible = false;
                }
                else
                {
                    sifre.Visible = true;
                }

            }

            

        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            int a = giris.personelid;
            cmd3.CommandText = "UPDATE personel_genel_bilgi SET YetkiSeviyesi='" + seviye.Text + "' , Adi='" + ad.Text + "',Soyadi='" + soyad.Text + "' , KullaniciAdi='" + k_adi.Text + "', Sifre='" + sifre.Text + "' WHERE Id=" + id.Text + "";
            baglanti.Open();
            cmd3.Connection = baglanti;
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit basariyla güncellendi");
            listView1.SelectedItems[0].SubItems[1].Text = ad.Text;
            listView1.SelectedItems[0].SubItems[2].Text = soyad.Text;
            listView1.SelectedItems[0].SubItems[3].Text = k_adi.Text;
            listView1.SelectedItems[0].SubItems[4].Text = sifre.Text;
            listView1.SelectedItems[0].SubItems[5].Text = seviye.Text;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            int a = giris.personelid;
            cmd3.CommandText = "delete from personel_genel_bilgi where Id=" + id.Text + "";
            listView1.Items.Remove(listView1.SelectedItems[0]);

            baglanti.Open();
            cmd3.Connection = baglanti;
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit basariyla silindi");
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            int a = giris.personelid;
            cmd3.CommandText = "INSERT INTO personel_genel_bilgi(YetkiSeviyesi,Adi,soyadi,KullaniciAdi,Sifre) VALUES ('" + seviye.Text + "','" + ad.Text + "','" + soyad.Text + "','" + k_adi.Text + "','" + sifre.Text + "')";
            baglanti.Open();
            cmd3.Connection = baglanti;
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            listView1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            con.Open();
            cmd = new OleDbCommand("Select * From personel_genel_bilgi", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Id"].ToString());
                item.SubItems.Add(dr["Adi"].ToString());
                item.SubItems.Add(dr["Soyadi"].ToString());
                item.SubItems.Add(dr["KullaniciAdi"].ToString());
                item.SubItems.Add(dr["Sifre"].ToString());
                item.SubItems.Add(dr["YetkiSeviyesi"].ToString());
                listView1.Items.Add(item);
            }
            con.Close();

            
            MessageBox.Show("Kayit basariyla eklendi");
        }



        private void seviye_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void k_adi_TextChanged(object sender, EventArgs e)
        {

        }

        private void soyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
