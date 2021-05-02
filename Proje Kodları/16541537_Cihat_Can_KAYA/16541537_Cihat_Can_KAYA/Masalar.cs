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
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {

                Anamenu ana = new Anamenu();
                ana.Visible = true;
                this.Visible = false;
            
        }

        private void Masalar_Load(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataReader dr;
            OleDbCommand cmd;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=restaurant_veritabani.mdb");
            cmd = new OleDbCommand("Select * From masalar", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr["MasaNumarasi"].ToString());
                item.SubItems.Add(dr["ToplamTutar"].ToString());

                listView7.Items.Add(item);
            }
            con.Close();
            string bir = listView7.Items[0].SubItems[1].ToString();
            bir = bir.Replace("ListViewSubItem: {", "");
            bir = bir.Replace("}", "");
            string iki = listView7.Items[1].SubItems[1].ToString();
            iki = iki.Replace("ListViewSubItem: {", "");
            iki = iki.Replace("}", "");
            string uc = listView7.Items[2].SubItems[1].ToString();
            uc = uc.Replace("ListViewSubItem: {", "");
            uc = uc.Replace("}", "");
            string dort = listView7.Items[3].SubItems[1].ToString();
            dort = dort.Replace("ListViewSubItem: {", "");
            dort = dort.Replace("}", "");
            string bes = listView7.Items[4].SubItems[1].ToString();
            bes = bes.Replace("ListViewSubItem: {", "");
            bes = bes.Replace("}", "");
            string alti = listView7.Items[5].SubItems[1].ToString();
            alti = alti.Replace("ListViewSubItem: {", "");
            alti = alti.Replace("}", "");
            textBox1.Text = bir;
            textBox2.Text = iki;
            textBox3.Text = uc;
            textBox4.Text = dort;
            textBox5.Text = bes;
            textBox6.Text = alti;
            con.Open();
            cmd = new OleDbCommand("Select * From masa1", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                item.SubItems.Add(dr["adet"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView1.Items.Add(item);
            }
            con.Close();
            con.Open();
            cmd = new OleDbCommand("Select * From masa2", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                item.SubItems.Add(dr["adet"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView2.Items.Add(item);
            }
            con.Close();
            con.Open();
            cmd = new OleDbCommand("Select * From masa3", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                item.SubItems.Add(dr["adet"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView3.Items.Add(item);
            }
            con.Close();
            con.Open();
            cmd = new OleDbCommand("Select * From masa4", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                item.SubItems.Add(dr["adet"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView4.Items.Add(item);
            }
            con.Close();
            con.Open();
            cmd = new OleDbCommand("Select * From masa5", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                item.SubItems.Add(dr["adet"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView5.Items.Add(item);
            }
            con.Close();
            con.Open();
            cmd = new OleDbCommand("Select * From masa6", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr["yiyecekadi"].ToString());
                item.SubItems.Add(dr["adet"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());

                listView6.Items.Add(item);
            }
            con.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
