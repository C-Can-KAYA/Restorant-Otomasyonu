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
    public partial class Siparisler : Form
    {
        public bool k = true;
        public static double tfiyat { get; set; }
        public Siparisler()
        {
            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {

            Anamenu ana = new Anamenu();
            ana.Visible = true;
            this.Visible = false;
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "0";
            comboBox1.Text = "0";
            textBox1.Text = "0.00";
            
            listView1.Columns[0].Width = 0;
            sil.Visible=false;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView2.FullRowSelect = true;
            listView2.View = View.Details;
            listView2.GridLines = true;

            listView3.FullRowSelect = true;
            listView3.View = View.Details;

            OleDbConnection baglanti1;
            OleDbDataAdapter adaptor1;
            OleDbCommand komut1;
            DataSet verikumesi1;
            OleDbDataReader asd1;
            baglanti1 = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            adaptor1 = new OleDbDataAdapter("Select * from kuryeler", baglanti1);
            verikumesi1 = new DataSet();
            komut1 = new OleDbCommand();
            baglanti1.Open();
            komut1.Connection = baglanti1;
            komut1.CommandText = "SELECT * FROM kuryeler";
            asd1= komut1.ExecuteReader();

            while (asd1.Read())
            {
                comboBox1.Items.Add(asd1["MotorNumarası"]);
                label1.Text = asd1["Beklemede"].ToString();
                if(label1.Text=="0")
                {
                    comboBox1.Items.Remove(asd1["MotorNumarası"]);
                }
            }

            baglanti1.Close();
            OleDbConnection baglanti;
            OleDbDataAdapter adaptor;
            OleDbCommand komut;
            DataSet verikumesi;
            OleDbDataReader asd;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            adaptor = new OleDbDataAdapter("Select * from masalar", baglanti);
            verikumesi = new DataSet();
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM masalar";
            asd = komut.ExecuteReader();

            while (asd.Read())
            {
                comboBox2.Items.Add(asd["MasaNumarasi"]);
            }

            baglanti1.Close();

            comboBox1.Visible = false;
            comboBox2.Visible = false;
            ekle.Visible = false;
        }

        private void kurye_Click(object sender, EventArgs e)
        {
            string kontrol=comboBox1.Items.Count.ToString();
            
            if (kontrol!="0")
            {
                if (listView2.Items.Count == 0)
                {
                    comboBox1.Visible = false;
                    ekle.Visible = false;
                }
                else
                {
                    comboBox1.Visible = true;
                    ekle.Visible = true;
                }
                k = false;
                comboBox1.Text = comboBox1.Items[0].ToString();
                comboBox2.Visible = false;
                OleDbConnection con;
                OleDbDataReader dr;
                OleDbCommand cmd;
                listView3.Items.Clear();
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                con.Open();
                cmd = new OleDbCommand("Select * From kuryeler", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MotorNumarası"].ToString());
                    item.SubItems.Add(dr["ToplamTutar"].ToString());

                    listView3.Items.Add(item);

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Kuryelerin hepsi yolda");
            }
        }

        private void masa_Click(object sender, EventArgs e)
        {
            textBox3.Text = listView2.Items.Count.ToString();
            string kontrol = comboBox2.Items.Count.ToString();
            if (kontrol != "0")
            {
                if (listView2.Items.Count == 0)
                {
                    comboBox2.Visible = false;
                    ekle.Visible = false;
                }
                else
                {
                    comboBox2.Visible = true;
                    ekle.Visible = true;
                }
            }
            k = true;
            comboBox2.Text = comboBox2.Items[0].ToString();
            comboBox1.Visible = false;


            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            listView3.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            con.Open();
            cmd = new OleDbCommand("Select * From masalar", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["MasaNumarasi"].ToString());
                item.SubItems.Add(dr["ToplamTutar"].ToString());

                listView3.Items.Add(item);

            }
            con.Close();

           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedIndex.ToString();
        }

        private void icecekler_Click(object sender, EventArgs e)
        {
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
        }
        adet ade = new adet();
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
           
            if (listView1.SelectedItems.Count > 0)
            {
                ade.ShowDialog();
                double toplam = (double.Parse(listView1.SelectedItems[0].SubItems[2].Text)) * (double.Parse(adet.sayi));
                tfiyat = tfiyat + toplam;
                textBox1.Text = tfiyat.ToString();
                string[] bilgiler = { listView1.SelectedItems[0].SubItems[0].Text, listView1.SelectedItems[0].SubItems[1].Text, adet.sayi, toplam.ToString("0.##") };
                listView2.Items.Add(new ListViewItem(bilgiler));
                
            }
           
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sil.Visible = true;
            if (listView2.SelectedItems.Count > 0)
            {

            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox3.Text) - (1)).ToString();
            if (textBox3.Text == "0")
            {
                ekle.Visible = false;
            }
            else
            {
                ekle.Visible = true;
            }
            tfiyat = tfiyat - (double.Parse(listView2.SelectedItems[0].SubItems[3].Text));
            listView2.Items.RemoveAt(listView2.SelectedItems[0].Index);
          
          textBox1.Text = tfiyat.ToString();

        }

        private void ekle_Click(object sender, EventArgs e)
        {

                if (k == true)
                {
                    textBox2.Text = "";
                    string kntrl = listView3.Items[comboBox2.SelectedIndex].SubItems[1].ToString();
                    kntrl = kntrl.Replace("ListViewSubItem: ", "");
                    kntrl = kntrl.Replace("{", "");
                    kntrl = kntrl.Replace("}", "");
                    textBox2.Text = kntrl;
                    textBox2.Text = ((decimal.Parse(kntrl)) + (decimal.Parse(textBox1.Text))).ToString();
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = baglanti;
                    cmd3.CommandText = "UPDATE masalar SET ToplamTutar='" + decimal.Parse(textBox2.Text) + "' WHERE MasaNumarasi=" + comboBox2.SelectedItem + "";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                    

                  OleDbConnection baglantii = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                    OleDbCommand cmd33 = new OleDbCommand();
                    cmd33.Connection = baglantii;
                    string ilk = "";
                    string iki = "";
                    string uc = "";
                    string combo = comboBox2.SelectedItem.ToString();
                    

                   for (int i = 0; i < listView2.Items.Count; i++)
			    {
                    combo = combo.Replace("System.Windows.Forms.ComboBox, Items.Count: ", "");
                    combo = combo.Replace("}", "");
                    ilk = listView2.Items[i].SubItems[1].ToString();
                    iki = listView2.Items[i].SubItems[2].ToString();
                    uc = listView2.Items[i].SubItems[3].ToString();
                       ilk=ilk.Replace("ListViewSubItem: {","");
                       ilk=ilk.Replace("}","");
                       iki=iki.Replace("ListViewSubItem: {","");
                       iki=iki.Replace("}","");
                       uc=uc.Replace("ListViewSubItem: {","");
                       uc=uc.Replace("}","");
                    cmd33.CommandText = "INSERT INTO masa" +combo+ "(yiyecekadi,adet,Fiyat) VALUES ('" + ilk + "','" + iki + "','" + uc + "')";
                   baglantii.Open();
                    cmd33.Connection = baglantii;   
                   cmd33.ExecuteNonQuery();
                   baglantii.Close();
                    }                  
                    MessageBox.Show("basariyla güncellendi");
                }
                else
                {
                    textBox2.Text = "";
                    string kntrl = listView3.Items[comboBox1.SelectedIndex].SubItems[1].ToString();
                    kntrl = kntrl.Replace("ListViewSubItem: ", "");
                    kntrl = kntrl.Replace("{", "");
                    kntrl = kntrl.Replace("}", "");
                    textBox2.Text = kntrl;
                    textBox2.Text = ((decimal.Parse(kntrl)) + (decimal.Parse(textBox1.Text))).ToString();
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = baglanti;
                    cmd3.CommandText = "UPDATE kuryeler SET ToplamTutar='" + decimal.Parse(textBox2.Text) + "' WHERE MotorNumarası=" + comboBox1.SelectedItem.ToString() + "";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayit basariyla güncellendi");

                    OleDbConnection baglantii = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                    OleDbCommand cmd33 = new OleDbCommand();
                    cmd33.Connection = baglantii;
                    string ilk = "";
                    string iki = "";
                    string uc = "";
                    string combo = comboBox1.SelectedItem.ToString();


                    for (int i = 0; i < listView2.Items.Count; i++)
                    {
                        combo = combo.Replace("System.Windows.Forms.ComboBox, Items.Count: ", "");
                        combo = combo.Replace("}", "");
                        ilk = listView2.Items[i].SubItems[1].ToString();
                        iki = listView2.Items[i].SubItems[2].ToString();
                        uc = listView2.Items[i].SubItems[3].ToString();
                        ilk = ilk.Replace("ListViewSubItem: {", "");
                        ilk = ilk.Replace("}", "");
                        iki = iki.Replace("ListViewSubItem: {", "");
                        iki = iki.Replace("}", "");
                        uc = uc.Replace("ListViewSubItem: {", "");
                        uc = uc.Replace("}", "");
                        cmd33.CommandText = "INSERT INTO kurye" + combo + "(yiyecekadi,adet,Fiyat) VALUES ('" + ilk + "','" + iki + "','" + uc + "')";
                        baglantii.Open();
                        cmd33.Connection = baglantii;
                        cmd33.ExecuteNonQuery();
                        baglantii.Close();
                    }  


                }
                int boyut = listView2.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    listView2.TopItem.Remove();
                }
                tfiyat = 0;
                textBox1.Text = "0.00";

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}
