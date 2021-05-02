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
    public partial class Mutfak : Form
    {
        public Mutfak()
        {
            InitializeComponent();
        }

        private void Mutfak_Load(object sender, EventArgs e)
        {
            listView1.Visible = false;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.GridLines = true;



            listView1.Visible = false;


            ekle.Visible = false;
            guncelle.Visible = false;
            sil.Visible = false;


            t_tur.Visible = false;
            tur.Visible = false;

            fiyat.Visible = false;
            t_fiyat.Visible = false;

        }

        private void geri_Click(object sender, EventArgs e)
        {
            Anamenu ana = new Anamenu();
            ana.Visible = true;
            this.Visible = false;
        }



        private void icecekler_Click(object sender, EventArgs e)
        {
            listView1.Columns[1].Text = "İçecekler";
            tur.Text = "İçecek Adı";
            listView1.Visible = true;


            ekle.Visible = true;
            guncelle.Visible = true;
            sil.Visible = true ;


            t_tur.Visible = true;
            tur.Visible = true;

            fiyat.Visible = true;
            t_fiyat.Visible = true;
            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            listView1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            con.Open();
            cmd = new OleDbCommand("Select * From icecekler", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Id"].ToString());
                item.SubItems.Add(dr["Icecek"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView1.Items.Add(item);
            }
            con.Close();
        }

        private void corbalar_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            listView1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            con.Open();
            cmd = new OleDbCommand("Select * From corbalar", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Id"].ToString());
                item.SubItems.Add(dr["Corba"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView1.Items.Add(item);
            }
            con.Close();
            listView1.Columns[1].Text = "Çorbalar";
            tur.Text = "Çorba Adı";
            listView1.Visible = true;


            ekle.Visible = true;
            guncelle.Visible = true;
            sil.Visible = true;


            t_tur.Visible = true;
            tur.Visible = true;

            fiyat.Visible = true;
            t_fiyat.Visible = true;
        }

        private void anayemekler_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            listView1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            con.Open();
            cmd = new OleDbCommand("Select * From anayemekler", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Id"].ToString());
                item.SubItems.Add(dr["Anayemek"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView1.Items.Add(item);
            }
            con.Close();
            listView1.Columns[1].Text = "Anayemekler";
            tur.Text = "Ana Yemek Adı";
            listView1.Visible = true;


            ekle.Visible = true;
            guncelle.Visible = true;
            sil.Visible = true;


            t_tur.Visible = true;
            tur.Visible = true;

            fiyat.Visible = true;
            t_fiyat.Visible = true;
        }

        private void arasıcaklar_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            listView1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            con.Open();
            cmd = new OleDbCommand("Select * From arasıcaklar", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Id"].ToString());
                item.SubItems.Add(dr["Arasıcak"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView1.Items.Add(item);
            }
            con.Close();
            listView1.Columns[1].Text = "Arasıcaklar";
            tur.Text = "Ara Sıcak Adı";
            listView1.Visible = true;


            ekle.Visible = true;
            guncelle.Visible = true;
            sil.Visible = true;


            t_tur.Visible = true;
            tur.Visible = true;

            fiyat.Visible = true;
            t_fiyat.Visible = true;
        }

        private void tatlilar_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            listView1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            con.Open();
            cmd = new OleDbCommand("Select * From tatlılar", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Id"].ToString());
                item.SubItems.Add(dr["Tatlı"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView1.Items.Add(item);
            }
            con.Close();
            listView1.Columns[1].Text = "Tatlılar";
            tur.Text = "Tatlı Adı";
            listView1.Visible = true;


            ekle.Visible = true;
            guncelle.Visible = true;
            sil.Visible = true;


            t_tur.Visible = true;
            tur.Visible = true;

            fiyat.Visible = true;
            t_fiyat.Visible = true;
        }

        private void salatalar_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            listView1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            con.Open();
            cmd = new OleDbCommand("Select * From salatalar", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Id"].ToString());
                item.SubItems.Add(dr["Salatalar"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView1.Items.Add(item);
            }
            con.Close();
            listView1.Columns[1].Text = "Salatalar";
            tur.Text = "Salata Adı";
            listView1.Visible = true;


            ekle.Visible = true;
            guncelle.Visible = true;
            sil.Visible = true;


            t_tur.Visible = true;
            tur.Visible = true;

            fiyat.Visible = true;
            t_fiyat.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                id.Text = listView1.SelectedItems[0].SubItems[0].Text;
                t_tur.Text = listView1.SelectedItems[0].SubItems[1].Text;
                t_fiyat.Text = listView1.SelectedItems[0].SubItems[2].Text;

            }
            
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if(listView1.Columns[1].Text == "Çorbalar")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "INSERT INTO corbalar(corba,Fiyat) VALUES ('" + t_tur.Text + "','" + t_fiyat.Text + "')";
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
                cmd = new OleDbCommand("Select * From corbalar", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["corba"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();


                MessageBox.Show("Kayit basariyla eklendi");
            }
            else if(listView1.Columns[1].Text == "İçecekler")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "INSERT INTO icecekler(Icecek,Fiyat) VALUES ('" + t_tur.Text + "','" + t_fiyat.Text + "')";
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
                cmd = new OleDbCommand("Select * From icecekler", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["Icecek"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();


                MessageBox.Show("Kayit basariyla eklendi");
            }
            else if(listView1.Columns[1].Text == "Anayemekler")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "INSERT INTO anayemekler(Anayemek,Fiyat) VALUES ('" + t_tur.Text + "','" + t_fiyat.Text + "')";
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
                cmd = new OleDbCommand("Select * From anayemekler", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["Anayemek"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();


                MessageBox.Show("Kayit basariyla eklendi");
            }
            else if(listView1.Columns[1].Text == "Arasıcaklar")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "INSERT INTO Arasıcaklar(Arasıcak,Fiyat) VALUES ('" + t_tur.Text + "','" + t_fiyat.Text + "')";
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
                cmd = new OleDbCommand("Select * From Arasıcaklar", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["Arasıcak"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();


                MessageBox.Show("Kayit basariyla eklendi");
            }
            else if(listView1.Columns[1].Text == "Tatlılar")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "INSERT INTO Tatlılar(Tatlı,Fiyat) VALUES ('" + t_tur.Text + "','" + t_fiyat.Text + "')";
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
                cmd = new OleDbCommand("Select * From Tatlılar", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["Tatlı"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();


                MessageBox.Show("Kayit basariyla eklendi");
            }
            else if(listView1.Columns[1].Text == "Salatalar")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "INSERT INTO salatalar(Salatalar,Fiyat) VALUES ('" + t_tur.Text + "','" + t_fiyat.Text + "')";
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
                cmd = new OleDbCommand("Select * From salatalar", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["Salatalar"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();


                MessageBox.Show("Kayit basariyla eklendi");
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Columns[1].Text == "Çorbalar")
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = baglanti;
                    int a = giris.personelid;
                    cmd3.CommandText = "UPDATE corbalar SET corba='" + t_tur.Text + "' , Fiyat='" + t_fiyat.Text + "' WHERE Id=" + id.Text + "";

                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayit basariyla güncellendi");
                    listView1.SelectedItems[0].SubItems[1].Text = t_tur.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = t_fiyat.Text;
                }
                else if (listView1.Columns[1].Text == "İçecekler")
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = baglanti;
                    cmd3.CommandText = "UPDATE icecekler SET Icecek='" + t_tur.Text + "' , Fiyat='" + t_fiyat.Text + "' WHERE Id=" + id.Text + "";

                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayit basariyla güncellendi");
                    listView1.SelectedItems[0].SubItems[1].Text = t_tur.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = t_fiyat.Text;
                }
                else if (listView1.Columns[1].Text == "Anayemekler")
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = baglanti;
                    int a = giris.personelid;
                    cmd3.CommandText = "UPDATE anayemekler SET Anayemek='" + t_tur.Text + "' , Fiyat='" + t_fiyat.Text + "' WHERE Id=" + id.Text + "";

                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayit basariyla güncellendi");
                    listView1.SelectedItems[0].SubItems[1].Text = t_tur.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = t_fiyat.Text;
                }
                else if (listView1.Columns[1].Text == "Arasıcaklar")
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = baglanti;
                    int a = giris.personelid;
                    cmd3.CommandText = "UPDATE arasıcaklar SET Arasıcak='" + t_tur.Text + "' , Fiyat='" + t_fiyat.Text + "' WHERE Id=" + id.Text + "";

                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayit basariyla güncellendi");
                    listView1.SelectedItems[0].SubItems[1].Text = t_tur.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = t_fiyat.Text;
                }
                else if (listView1.Columns[1].Text == "Tatlılar")
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = baglanti;
                    int a = giris.personelid;
                    cmd3.CommandText = "UPDATE tatlılar SET Tatlı='" + t_tur.Text + "' , Fiyat='" + t_fiyat.Text + "' WHERE Id=" + id.Text + "";

                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayit basariyla güncellendi");
                    listView1.SelectedItems[0].SubItems[1].Text = t_tur.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = t_fiyat.Text;
                }
                else if (listView1.Columns[1].Text == "Salatalar")
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = baglanti;
                    int a = giris.personelid;
                    cmd3.CommandText = "UPDATE salatalar SET Salatalar='" + t_tur.Text + "' , Fiyat='" + t_fiyat.Text + "' WHERE Id=" + id.Text + "";

                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayit basariyla güncellendi");
                    listView1.SelectedItems[0].SubItems[1].Text = t_tur.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = t_fiyat.Text;
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show("Lütfen Listeden Seçim Yapınız");
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (listView1.Columns[1].Text == "Çorbalar")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "delete from corbalar where Id=" + id.Text + "";
                listView1.Items.Remove(listView1.SelectedItems[0]);

                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayit basariyla silindi");
            }
            else if (listView1.Columns[1].Text == "İçecekler")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "delete from icecekler where Id=" + id.Text + "";
                listView1.Items.Remove(listView1.SelectedItems[0]);

                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayit basariyla silindi");
            }
            else if (listView1.Columns[1].Text == "Anayemekler")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "delete from anayemekler where Id=" + id.Text + "";
                listView1.Items.Remove(listView1.SelectedItems[0]);

                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayit basariyla silindi");
            }
            else if (listView1.Columns[1].Text == "Arasıcaklar")
            {
                
                                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "delete from Arasıcaklar where Id=" + id.Text + "";
                listView1.Items.Remove(listView1.SelectedItems[0]);

                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayit basariyla silindi");

            }
            else if (listView1.Columns[1].Text == "Tatlılar")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "delete from Tatlılar where Id=" + id.Text + "";
                listView1.Items.Remove(listView1.SelectedItems[0]);

                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayit basariyla silindi");
            }
            else if (listView1.Columns[1].Text == "Salatalar")
            {
                                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                int a = giris.personelid;
                cmd3.CommandText = "delete from salatalar where Id=" + id.Text + "";
                listView1.Items.Remove(listView1.SelectedItems[0]);

                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayit basariyla silindi");
                
            }
        }
    }
}
