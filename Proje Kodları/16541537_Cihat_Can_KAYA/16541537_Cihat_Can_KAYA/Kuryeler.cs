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
    public partial class Kuryeler : Form
    {
        public static string tarih{get; set;}
        public Kuryeler()
        {
            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            if (Hesapislemlemleri.gecis == 1)
            {
                Hesapislemlemleri he = new Hesapislemlemleri();
                he.Visible = true;
                this.Visible = false;
            }
            else
            {
                Anamenu ana = new Anamenu();
                ana.Visible = true;
                this.Visible = false;
            }
        }

        private void Kuryeler_Load(object sender, EventArgs e)
        {
            listView1.Columns[3].Width = 0;
            listView2.Columns[3].Width = 0;
            listView3.Columns[3].Width = 0;
            listView4.Columns[3].Width = 0;
            timer1.Enabled = true;
            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            listView1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            con.Open();
            cmd = new OleDbCommand("Select * From kurye1", con);
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
            con.Open();
            cmd = new OleDbCommand("Select * From kurye2", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                item.SubItems.Add(dr["adet"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());
                item.SubItems.Add(dr["Id"].ToString());

                listView2.Items.Add(item);
            }
            con.Close();
            con.Open();
            cmd = new OleDbCommand("Select * From kurye3", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                item.SubItems.Add(dr["adet"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());
                item.SubItems.Add(dr["Id"].ToString());

                listView3.Items.Add(item);
            }
            con.Close();
            con.Open();
            cmd = new OleDbCommand("Select * From kurye4", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                item.SubItems.Add(dr["adet"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());
                item.SubItems.Add(dr["Id"].ToString());

                listView4.Items.Add(item);
            }
            con.Close();
            con.Open();
            cmd = new OleDbCommand("Select * From kuryeler", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr["MotorNumarası"].ToString());
                item.SubItems.Add(dr["Beklemede"].ToString());
                item.SubItems.Add(dr["ToplamTutar"].ToString());

                listView5.Items.Add(item);
            }
            con.Close();
            string bir=listView5.Items[0].SubItems[2].ToString();
            bir = bir.Replace("ListViewSubItem: {", "");
            bir = bir.Replace("}", "");
            string iki = listView5.Items[1].SubItems[2].ToString();
            iki = iki.Replace("ListViewSubItem: {", "");
            iki = iki.Replace("}", "");
            string uc = listView5.Items[2].SubItems[2].ToString();
            uc = uc.Replace("ListViewSubItem: {", "");
            uc = uc.Replace("}", "");
            string dort = listView5.Items[3].SubItems[2].ToString();
            dort = dort.Replace("ListViewSubItem: {", "");
            dort = dort.Replace("}", "");
            string bbir = listView5.Items[0].SubItems[1].ToString();
            bbir = bbir.Replace("ListViewSubItem: {", "");
            bbir = bbir.Replace("}", "");
            string biki = listView5.Items[1].SubItems[1].ToString();
            biki = biki.Replace("ListViewSubItem: {", "");
            biki = biki.Replace("}", "");
            string buc = listView5.Items[2].SubItems[1].ToString();
            buc = buc.Replace("ListViewSubItem: {", "");
            buc = buc.Replace("}", "");
            string bdort = listView5.Items[3].SubItems[1].ToString();
            bdort = bdort.Replace("ListViewSubItem: {", "");
            bdort = bdort.Replace("}", "");
            textBox1.Text = bir;
            textBox2.Text = iki;
            textBox3.Text = uc;
            textBox4.Text = dort;
            if(bbir=="0")
            {
                listView1.BackColor = Color.Gray;
                button9.Visible=false;
                button10.Visible=true;

            }
            else
            {
                button9.Visible=true;
                button10.Visible=false;
                listView1.BackColor = Color.White;
            }
            if (biki == "0")
            {
                listView2.BackColor = Color.Gray;
                button12.Visible=false;
                button11.Visible = true;
            }
            else
            {
                button12.Visible = true;
                button11.Visible = false;
                listView2.BackColor = Color.White;
            }
            if (buc == "0")
            {
                button14.Visible = false;
                button13.Visible = true;
                listView3.BackColor = Color.Gray;
            }
            else
            {
                button14.Visible = true;
                button13.Visible = false;
                listView3.BackColor = Color.White;
            }
            if (bdort == "0")
            {
                button16.Visible = false;
                button15.Visible = true;
                listView4.BackColor = Color.Gray;
            }
            else
            {
                button16.Visible = true;
                button15.Visible = false;
                listView4.BackColor = Color.White;
            }
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button10.Visible = true;
            string id = "1";
            string bekle = "0";
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            int a = giris.personelid;
            cmd3.CommandText = "UPDATE kuryeler SET Beklemede='" + bekle + "' WHERE MotorNumarası=" + id + "";
            baglanti.Open();
            cmd3.Connection = baglanti;
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Siparişler yola çıktı");
            listView1.BackColor = Color.Gray;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int boyut = listView1.Items.Count;
            button10.Visible = false;
            button9.Visible = true;
            string id = "1";
            string bekle = "1";
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            cmd3.CommandText = "UPDATE kuryeler SET Beklemede='" + bekle + "',ToplamTutar='" + 0 + "' WHERE MotorNumarası=" + id + "";
            baglanti.Open();
            cmd3.Connection = baglanti;
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            string kurye = "kurye1";
            string hesap = textBox1.Text;
            for (int i = 0; i < boyut; i++)
            {
                cmd3.CommandText = "INSERT INTO hesap(Tarih,KuryeVeyaMasa,ToplamTutar) VALUES ('" + tarih + "','" + kurye + "','" + hesap + "')";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
            }
           
            
            string ata = "";
            for (int i = 0; i < boyut; i++)
            {
                ata = listView1.Items[i].SubItems[3].ToString();
                ata = ata.Replace("ListViewSubItem: ", "");
                ata = ata.Replace("{", "");
                ata = ata.Replace("}", "");
                cmd3.CommandText = "delete from kurye1 where Id=" + ata + "";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show("Kurye geri döndü");
            listView1.BackColor = Color.White;
            for (int i = 0; i < boyut; i++)
            {
                listView1.TopItem.Remove();
            }
            textBox1.Text = "0,00";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
            button11.Visible = true;
            string id = "2";
            string bekle = "0";
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            int a = giris.personelid;
            cmd3.CommandText = "UPDATE kuryeler SET Beklemede='" + bekle + "' WHERE MotorNumarası=" + id + "";
            baglanti.Open();
            cmd3.Connection = baglanti;
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Siparişler yola çıktı");
            listView2.BackColor = Color.Gray;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int boyut = listView2.Items.Count;
            button11.Visible = false;
            button12.Visible = true;
            string id = "2";
            string bekle = "1";
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            int a = giris.personelid;
            cmd3.CommandText = "UPDATE kuryeler SET Beklemede='" + bekle + "',ToplamTutar='" + 0 + "' WHERE MotorNumarası=" + id + "";
            baglanti.Open();
            cmd3.Connection = baglanti;
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            string kurye = "kurye2";
            string hesap = textBox2.Text;
            for (int i = 0; i < boyut; i++)
            {
                cmd3.CommandText = "INSERT INTO hesap(Tarih,KuryeVeyaMasa,ToplamTutar) VALUES ('" + tarih + "','" + kurye + "','" + hesap + "')";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
            }

            string ata = "";
            for (int i = 0; i < boyut; i++)
            {
                ata = listView2.Items[i].SubItems[3].ToString();
                ata = ata.Replace("ListViewSubItem: ", "");
                ata = ata.Replace("{", "");
                ata = ata.Replace("}", "");
                cmd3.CommandText = "delete from kurye2 where Id=" + ata + "";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show("Kurye geri döndü");
            listView2.BackColor = Color.White;
            for (int i = 0; i < boyut; i++)
            {
                listView2.TopItem.Remove();
            }
            textBox2.Text = "0,00";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
            button13.Visible = true;
            string id = "3";
            string bekle = "0";
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            int a = giris.personelid;
            cmd3.CommandText = "UPDATE kuryeler SET Beklemede='" + bekle + "' WHERE MotorNumarası=" + id + "";
            baglanti.Open();
            cmd3.Connection = baglanti;
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Siparişler yola çıktı");
            listView3.BackColor = Color.Gray;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int boyut = listView3.Items.Count;
            button13.Visible = false;
            button14.Visible = true;
            string id = "3";
            string bekle = "1";
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            int a = giris.personelid;
            cmd3.CommandText = "UPDATE kuryeler SET Beklemede='" + bekle + "',ToplamTutar='" + 0 + "' WHERE MotorNumarası=" + id + "";
            baglanti.Open();
            cmd3.Connection = baglanti;
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            string kurye = "kurye3";
            string hesap = textBox3.Text;
            for (int i = 0; i < boyut; i++)
            {
                cmd3.CommandText = "INSERT INTO hesap(Tarih,KuryeVeyaMasa,ToplamTutar) VALUES ('" + tarih + "','" + kurye + "','" + hesap + "')";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
            }

            string ata = "";
            for (int i = 0; i < boyut; i++)
            {
                ata = listView3.Items[i].SubItems[3].ToString();
                ata = ata.Replace("ListViewSubItem: ", "");
                ata = ata.Replace("{", "");
                ata = ata.Replace("}", "");
                cmd3.CommandText = "delete from kurye3 where Id=" + ata + "";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show("Kurye geri döndü");
            listView3.BackColor = Color.White;
            for (int i = 0; i < boyut; i++)
            {
                listView3.TopItem.Remove();
            }
            textBox3.Text = "0,00";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Visible = false;
            button15.Visible = true;
            string id = "4";
            string bekle = "0";
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglanti;
            int a = giris.personelid;
            cmd3.CommandText = "UPDATE kuryeler SET Beklemede='" + bekle + "' WHERE MotorNumarası=" + id + "";
            baglanti.Open();
            cmd3.Connection = baglanti;
            cmd3.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Siparişler yola çıktı");
            listView4.BackColor = Color.Gray;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            button16.Visible = true;
            int boyut = listView4.Items.Count;
                string id = "4";
                string bekle = "1";
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = baglanti;
                cmd3.CommandText = "UPDATE kuryeler SET Beklemede='" + bekle + "',ToplamTutar='" + 0 + "' WHERE MotorNumarası=" + id + "";
                baglanti.Open();
                cmd3.Connection = baglanti;
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                string kurye = "kurye4";
                string hesap = textBox4.Text;
                for (int i = 0; i < boyut; i++)
                {
                    cmd3.CommandText = "INSERT INTO hesap(Tarih,KuryeVeyaMasa,ToplamTutar) VALUES ('" + tarih + "','" + kurye + "','" + hesap + "')";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }

                string ata = "";
                for (int i = 0; i < boyut; i++)
                {
                    ata = listView4.Items[i].SubItems[3].ToString();
                    ata = ata.Replace("ListViewSubItem: ", "");
                    ata = ata.Replace("{", "");
                    ata = ata.Replace("}", "");
                    cmd3.CommandText = "delete from kurye4 where Id=" +ata  + "";
                    baglanti.Open();
                    cmd3.Connection = baglanti;
                    cmd3.ExecuteNonQuery();
                    baglanti.Close();
                }

                MessageBox.Show("Kurye geri döndü");
                listView4.BackColor = Color.White;
                
                for (int i = 0; i < boyut; i++)
                {
                    listView4.TopItem.Remove();
                }

                textBox4.Text = "0,00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yil.Text = DateTime.Now.Year.ToString();
            ay.Text = DateTime.Now.Month.ToString();
            gun.Text = DateTime.Now.Day.ToString();
            saat.Text = DateTime.Now.Hour.ToString();
            dakika.Text = DateTime.Now.Minute.ToString();
            tarih = yil.Text + "/" + ay.Text + "/" + gun.Text + "/" + saat.Text + "/" + dakika.Text;
        }
    }
}
