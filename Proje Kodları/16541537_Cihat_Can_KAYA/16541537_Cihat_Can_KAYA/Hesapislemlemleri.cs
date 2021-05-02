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
    public partial class Hesapislemlemleri : Form
    {
        public static int gecis { get; set; }
        public static string trh { get; set; }
        public Hesapislemlemleri()
        {
            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Anamenu ana = new Anamenu();
            ana.Visible = true;
            this.Visible = false;
        }

        private void Hesapislemlemleri_Load(object sender, EventArgs e)
        {
            gecis = 0;
            listView1.Columns[3].Width = 0;
            ms1.Visible = false;
            ms2.Visible = false;
            ms3.Visible = false;
            ms4.Visible = false;
            ms5.Visible = false;
            ms6.Visible = false;
            OleDbConnection baglanti;
            OleDbDataAdapter adaptor;
            OleDbCommand komut;
            DataSet verikumesi;
            OleDbDataReader asd;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            adaptor = new OleDbDataAdapter("Select * from masalar", baglanti);
            verikumesi = new DataSet();
            OleDbDataReader dr;
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM masalar";
            asd = komut.ExecuteReader();
            while (asd.Read())
            {
                comboBox1.Items.Add(asd["MasaNumarasi"]);
                ListViewItem item = new ListViewItem(asd["MasaNumarasi"].ToString());
                item.SubItems.Add(asd["ToplamTutar"].ToString());

                listView2.Items.Add(item);
                
            }

            baglanti.Close();
            comboBox1.Text = comboBox1.Items[0].ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            gecis = 1;
            Kuryeler kurye = new Kuryeler();
            kurye.Visible = true;
            this.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int boyut = listView1.Items.Count;
            for (int i = 0; i < boyut; i++)
            {
                listView1.TopItem.Remove();
            }
            string cb1=comboBox1.SelectedText;
            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            if(comboBox1.SelectedItem.ToString()=="1")
            {
                string bir = listView2.Items[0].SubItems[1].ToString();
                bir = bir.Replace("ListViewSubItem: {", "");
                bir = bir.Replace("}", "");
                textBox1.Text = bir;
                ms1.Visible = true;
                ms2.Visible = false;
                ms3.Visible = false;
                ms4.Visible = false;
                ms5.Visible = false;
                ms6.Visible = false;
                cmd = new OleDbCommand("Select * From masa1", con);
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                    item.SubItems.Add(dr["adet"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());
                    item.SubItems.Add(dr["Id"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();
                if (textBox1.Text == "0,00")
                {
                    button1.Visible = false;
                    MessageBox.Show("Masa " + comboBox1.SelectedItem.ToString() + " boş");
                }
                else
                {
                    button1.Visible = true;
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "2")
            {
                int boyut1 = listView1.Items.Count;
                for (int i = 0; i < boyut1; i++)
                {
                    listView1.TopItem.Remove();
                }
                string bir = listView2.Items[1].SubItems[1].ToString();
                bir = bir.Replace("ListViewSubItem: {", "");
                bir = bir.Replace("}", "");
                textBox1.Text = bir;
                ms1.Visible = false;
                ms2.Visible = true;
                ms3.Visible = false;
                ms4.Visible = false;
                ms5.Visible = false;
                ms6.Visible = false;
                cmd = new OleDbCommand("Select * From masa2", con);
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                    item.SubItems.Add(dr["adet"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());
                    item.SubItems.Add(dr["Id"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();
                if (textBox1.Text == "0,00")
                {
                    button1.Visible = false;
                    MessageBox.Show("Masa " + comboBox1.SelectedItem.ToString() + " boş");
                }
                else
                {
                    button1.Visible = true;
                }
            }
            else if (comboBox1.SelectedItem.ToString()=="3")
            {
                string bir = listView2.Items[2].SubItems[1].ToString();
                bir = bir.Replace("ListViewSubItem: {", "");
                bir = bir.Replace("}", "");
                textBox1.Text = bir;
                ms1.Visible = false;
                ms2.Visible = false;
                ms3.Visible = true;
                ms4.Visible = false;
                ms5.Visible = false;
                ms6.Visible = false;
                cmd = new OleDbCommand("Select * From masa3", con);
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                    item.SubItems.Add(dr["adet"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());
                    item.SubItems.Add(dr["Id"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();
                if (textBox1.Text == "0,00")
                {
                    button1.Visible = false;
                    MessageBox.Show("Masa " + comboBox1.SelectedItem.ToString() + " boş");
                }
                else
                {
                    button1.Visible = true;
                }
            }
            else if(comboBox1.SelectedItem.ToString()=="4")
            {
                int boyut1 = listView1.Items.Count;
                for (int i = 0; i < boyut1; i++)
                {
                    listView1.TopItem.Remove();
                }
                string bir = listView2.Items[3].SubItems[1].ToString();
                bir = bir.Replace("ListViewSubItem: {", "");
                bir = bir.Replace("}", "");
                textBox1.Text = bir;
                ms1.Visible = false;
                ms2.Visible = false;
                ms3.Visible = false;
                ms4.Visible = true;
                ms5.Visible = false;
                ms6.Visible = false;

                cmd = new OleDbCommand("Select * From masa4", con);
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                    item.SubItems.Add(dr["adet"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());
                    item.SubItems.Add(dr["Id"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();
                if (textBox1.Text == "0,00")
                {
                    button1.Visible = false;
                    MessageBox.Show("Masa " + comboBox1.SelectedItem.ToString() + " boş");
                }
                else
                {
                    button1.Visible = true;
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "5")
            {
                int boyut1 = listView1.Items.Count;
                for (int i = 0; i < boyut1; i++)
                {
                    listView1.TopItem.Remove();
                }
                string bir = listView2.Items[4].SubItems[1].ToString();
                bir = bir.Replace("ListViewSubItem: {", "");
                bir = bir.Replace("}", "");
                textBox1.Text = bir;
                ms1.Visible = false;
                ms2.Visible = false;
                ms3.Visible = false;
                ms4.Visible = false;
                ms5.Visible = true;
                ms6.Visible = false;
                cmd = new OleDbCommand("Select * From masa5", con);
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                    item.SubItems.Add(dr["adet"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());
                    item.SubItems.Add(dr["Id"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();
                if (textBox1.Text == "0,00")
                {
                    button1.Visible = false;
                    MessageBox.Show("Masa " + comboBox1.SelectedItem.ToString() + " boş");
                }
                else
                {
                    button1.Visible = true;
                }

            }
            else
            {

                int boyut1 = listView1.Items.Count;
                for (int i = 0; i < boyut1; i++)
                {
                    listView1.TopItem.Remove();
                }
                string bir = listView2.Items[5].SubItems[1].ToString();
                bir = bir.Replace("ListViewSubItem: {", "");
                bir = bir.Replace("}", "");
                textBox1.Text = bir;
                ms1.Visible = false;
                ms2.Visible = false;
                ms3.Visible = false;
                ms4.Visible = false;
                ms5.Visible = false;
                ms6.Visible = true;
                cmd = new OleDbCommand("Select * From masa6", con);
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                    item.SubItems.Add(dr["adet"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());
                    item.SubItems.Add(dr["Id"].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();
                if (textBox1.Text == "0,00")
                {
                    button1.Visible = false;
                    MessageBox.Show("Masa " + comboBox1.SelectedItem.ToString() + " boş");
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yil.Text = DateTime.Now.Year.ToString();
            ay.Text = DateTime.Now.Month.ToString();
            gun.Text = DateTime.Now.Day.ToString();
            saat.Text = DateTime.Now.Hour.ToString();
            dakika.Text = DateTime.Now.Minute.ToString();
            trh = yil.Text + "/" + ay.Text + "/" + gun.Text + "/" + saat.Text + "/" + dakika.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            int boyut;
            boyut = listView2.Items.Count;
            for (int i = 0; i < boyut; i++)
            {
                listView2.TopItem.Remove();
            }
            string cb1 = comboBox1.SelectedText;


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
              
                ListViewItem item = new ListViewItem(asd["MasaNumarasi"].ToString());
                item.SubItems.Add(asd["ToplamTutar"].ToString());

                listView2.Items.Add(item);

            }

            baglanti.Close();

            if(comboBox1.SelectedItem.ToString()=="1")
            {
                boyut = listView1.Items.Count;
                string id = "1";
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                cmd3.CommandText = "UPDATE masalar SET ToplamTutar='" + 0 + "' WHERE MasaNumarasi=" + id + "";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                string masa = "masa1";
                string hesap = textBox1.Text;
                int boy = listView1.Items.Count;
                for (int i = 0; i < boy; i++)
                {
                    cmd3.CommandText = "INSERT INTO hesap(Tarih,KuryeVeyaMasa,ToplamTutar) VALUES ('" + trh + "','" + masa + "','" + hesap + "')";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }

                string ata = "";
                boyut = listView1.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    ata = listView1.Items[i].SubItems[3].ToString();
                    ata = ata.Replace("ListViewSubItem: ", "");
                    ata = ata.Replace("{", "");
                    ata = ata.Replace("}", "");
                    cmd3.CommandText = "delete from masa1 where Id=" + ata + "";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Masa1 Hesap Ödendi");
                for (int i = 0; i < boyut; i++)
                {
                    listView1.TopItem.Remove();
                }
                boyut = listView2.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    listView2.TopItem.Remove();
                }
                adaptor = new OleDbDataAdapter("Select * from masalar", baglanti);
                verikumesi = new DataSet();
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM masalar";
                asd = komut.ExecuteReader();
                while (asd.Read())
                {

                    ListViewItem item = new ListViewItem(asd["MasaNumarasi"].ToString());
                    item.SubItems.Add(asd["ToplamTutar"].ToString());

                    listView2.Items.Add(item);

                }

                baglanti.Close();
                textBox1.Text = "0,00";
                button1.Visible = false;
            }
            else if(comboBox1.SelectedItem.ToString()=="2")
            {
                boyut = listView1.Items.Count;
                string id = "2";
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                cmd3.CommandText = "UPDATE masalar SET ToplamTutar='" + 0 + "' WHERE MasaNumarasi=" + id + "";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                string masa = "masa2";
                string hesap = textBox1.Text;
                int boy = listView1.Items.Count;
                for (int i = 0; i < boy; i++)
                {
                    cmd3.CommandText = "INSERT INTO hesap(Tarih,KuryeVeyaMasa,ToplamTutar) VALUES ('" + trh + "','" + masa + "','" + hesap + "')";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }

                string ata = "";
                boyut = listView1.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    ata = listView1.Items[i].SubItems[3].ToString();
                    ata = ata.Replace("ListViewSubItem: ", "");
                    ata = ata.Replace("{", "");
                    ata = ata.Replace("}", "");
                    cmd3.CommandText = "delete from masa2 where Id=" + ata + "";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Masa2 Hesap Ödendi");
                for (int i = 0; i < boyut; i++)
                {
                    listView1.TopItem.Remove();
                }
                boyut = listView2.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    listView2.TopItem.Remove();
                }
                adaptor = new OleDbDataAdapter("Select * from masalar", baglanti);
                verikumesi = new DataSet();
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM masalar";
                asd = komut.ExecuteReader();
                while (asd.Read())
                {

                    ListViewItem item = new ListViewItem(asd["MasaNumarasi"].ToString());
                    item.SubItems.Add(asd["ToplamTutar"].ToString());

                    listView2.Items.Add(item);

                }

                baglanti.Close();
                textBox1.Text = "0,00";
                button1.Visible = false;
            }
            else if(comboBox1.SelectedItem.ToString()=="3")
            {
                boyut = listView1.Items.Count;
                string id = "3";
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                cmd3.CommandText = "UPDATE masalar SET ToplamTutar='" + 0 + "' WHERE MasaNumarasi=" + id + "";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                string masa = "masa3";
                string hesap = textBox1.Text;
                int boy = listView1.Items.Count;
                for (int i = 0; i < boy; i++)
                {
                    cmd3.CommandText = "INSERT INTO hesap(Tarih,KuryeVeyaMasa,ToplamTutar) VALUES ('" + trh + "','" + masa + "','" + hesap + "')";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }

                string ata = "";
                boyut = listView1.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    ata = listView1.Items[i].SubItems[3].ToString();
                    ata = ata.Replace("ListViewSubItem: ", "");
                    ata = ata.Replace("{", "");
                    ata = ata.Replace("}", "");
                    cmd3.CommandText = "delete from masa3 where Id=" + ata + "";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Masa3 Hesap Ödendi");
                for (int i = 0; i < boyut; i++)
                {
                    listView1.TopItem.Remove();
                }
                boyut = listView2.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    listView2.TopItem.Remove();
                }
                adaptor = new OleDbDataAdapter("Select * from masalar", baglanti);
                verikumesi = new DataSet();
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM masalar";
                asd = komut.ExecuteReader();
                while (asd.Read())
                {

                    ListViewItem item = new ListViewItem(asd["MasaNumarasi"].ToString());
                    item.SubItems.Add(asd["ToplamTutar"].ToString());

                    listView2.Items.Add(item);

                }

                baglanti.Close();
                textBox1.Text = "0,00";
                button1.Visible = false;
            }
            else if(comboBox1.SelectedItem.ToString()=="4")
            {
                boyut = listView1.Items.Count;
                string id = "4";
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                cmd3.CommandText = "UPDATE masalar SET ToplamTutar='" + 0 + "' WHERE MasaNumarasi=" + id + "";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                string masa = "masa4";
                string hesap = textBox1.Text;
                int boy = listView1.Items.Count;
                for (int i = 0; i < boy; i++)
                {
                    cmd3.CommandText = "INSERT INTO hesap(Tarih,KuryeVeyaMasa,ToplamTutar) VALUES ('" + trh + "','" + masa + "','" + hesap + "')";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }

                string ata = "";
                boyut = listView1.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    ata = listView1.Items[i].SubItems[3].ToString();
                    ata = ata.Replace("ListViewSubItem: ", "");
                    ata = ata.Replace("{", "");
                    ata = ata.Replace("}", "");
                    cmd3.CommandText = "delete from masa4 where Id=" + ata + "";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Masa4 Hesap Ödendi");
                for (int i = 0; i < boyut; i++)
                {
                    listView1.TopItem.Remove();
                }
                boyut = listView2.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    listView2.TopItem.Remove();
                }
                adaptor = new OleDbDataAdapter("Select * from masalar", baglanti);
                verikumesi = new DataSet();
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM masalar";
                asd = komut.ExecuteReader();
                while (asd.Read())
                {

                    ListViewItem item = new ListViewItem(asd["MasaNumarasi"].ToString());
                    item.SubItems.Add(asd["ToplamTutar"].ToString());

                    listView2.Items.Add(item);

                }

                baglanti.Close();
                textBox1.Text = "0,00";
                button1.Visible = false;
            }
            else if(comboBox1.SelectedItem.ToString()=="5")
            {
                boyut = listView1.Items.Count;
                string id = "5";
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                cmd3.CommandText = "UPDATE masalar SET ToplamTutar='" + 0 + "' WHERE MasaNumarasi=" + id + "";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                string masa = "masa5";
                string hesap = textBox1.Text;
                int boy = listView1.Items.Count;
                for (int i = 0; i < boy; i++)
                {
                    cmd3.CommandText = "INSERT INTO hesap(Tarih,KuryeVeyaMasa,ToplamTutar) VALUES ('" + trh + "','" + masa + "','" + hesap + "')";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }

                string ata = "";
                boyut = listView1.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    ata = listView1.Items[i].SubItems[3].ToString();
                    ata = ata.Replace("ListViewSubItem: ", "");
                    ata = ata.Replace("{", "");
                    ata = ata.Replace("}", "");
                    cmd3.CommandText = "delete from masa5 where Id=" + ata + "";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Masa5 Hesap Ödendi");
                for (int i = 0; i < boyut; i++)
                {
                    listView1.TopItem.Remove();
                }
                boyut = listView2.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    listView2.TopItem.Remove();
                }
                adaptor = new OleDbDataAdapter("Select * from masalar", baglanti);
                verikumesi = new DataSet();
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM masalar";
                asd = komut.ExecuteReader();
                while (asd.Read())
                {

                    ListViewItem item = new ListViewItem(asd["MasaNumarasi"].ToString());
                    item.SubItems.Add(asd["ToplamTutar"].ToString());

                    listView2.Items.Add(item);

                }

                baglanti.Close();
                textBox1.Text = "0,00";
                button1.Visible = false;
            }
            else
            {
                boyut = listView1.Items.Count;
                string id = "6";
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                cmd3.CommandText = "UPDATE masalar SET ToplamTutar='" + 0 + "' WHERE MasaNumarasi=" + id + "";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                string masa = "masa6";
                string hesap = textBox1.Text;
                int boy = listView1.Items.Count;
                for (int i = 0; i < boy; i++)
                {
                    cmd3.CommandText = "INSERT INTO hesap(Tarih,KuryeVeyaMasa,ToplamTutar) VALUES ('" + trh + "','" + masa + "','" + hesap + "')";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }

                string ata = "";
                boyut = listView1.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    ata = listView1.Items[i].SubItems[3].ToString();
                    ata = ata.Replace("ListViewSubItem: ", "");
                    ata = ata.Replace("{", "");
                    ata = ata.Replace("}", "");
                    cmd3.CommandText = "delete from masa6 where Id=" + ata + "";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Masa6 Hesap Ödendi");
                for (int i = 0; i < boyut; i++)
                {
                    listView1.TopItem.Remove();
                }
                boyut = listView2.Items.Count;
                for (int i = 0; i < boyut; i++)
                {
                    listView2.TopItem.Remove();
                }
                adaptor = new OleDbDataAdapter("Select * from masalar", baglanti);
                verikumesi = new DataSet();
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM masalar";
                asd = komut.ExecuteReader();
                while (asd.Read())
                {

                    ListViewItem item = new ListViewItem(asd["MasaNumarasi"].ToString());
                    item.SubItems.Add(asd["ToplamTutar"].ToString());

                    listView2.Items.Add(item);

                }

                baglanti.Close();
                textBox1.Text = "0,00";
                button1.Visible = false;
            }
            int boyut1 = listView1.Items.Count;
            for (int i = 0; i < boyut1; i++)
            {
                listView1.TopItem.Remove();
            }
        }
    }
}
