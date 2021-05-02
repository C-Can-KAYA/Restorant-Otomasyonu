using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16541537_Cihat_Can_KAYA
{
    public partial class Anamenu : Form
    {
        public Anamenu()
        {
            InitializeComponent();
        }

        private void Anamenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            rezervasyonlar.Visible = false;
            hesapislemleri.Visible = false;
            mutfak.Visible = false;
            siparisler.Visible = false;
            masalar.Visible = false;
            personeler.Visible = false;
            kurye.Visible = false;
            ayarlar.Visible = false;
            raporlar.Visible = false;
            /*Mutfak perso = new Mutfak();
            perso.Visible = true;
            this.Visible = false;*/
            ad.Text = giris.personeladi;
            string yetki = giris.personelyetki;
            if (yetki == "Komi")
            {
                masalar.Visible = true;
                siparisler.Visible = true;
                ayarlar.Visible = true;
            }
            else if (yetki == "İşyeri Sahibi")
            {
          //      rezervasyonlar.Visible = true;
                hesapislemleri.Visible = true;
                mutfak.Visible = true;
                siparisler.Visible = true;
                masalar.Visible = true;
                personeler.Visible = true;
                kurye.Visible = true;
                ayarlar.Visible = true;
             //   raporlar.Visible = true;
            }
            else if (yetki == "Garson")
            {
                siparisler.Visible = true;
                masalar.Visible = true;
                ayarlar.Visible = true;
            }
            else if (yetki == "Kurye")
            {
                kurye.Visible = true;
                ayarlar.Visible = true;

            }
            else if (yetki == "Aşcı")
            {
                ayarlar.Visible = true;
                mutfak.Visible = true;
            }
            else if (yetki == "Kasiyer")
            {
            //    rezervasyonlar.Visible = true;
                masalar.Visible = true;
                hesapislemleri.Visible = true;
                kurye.Visible = true;
                ayarlar.Visible = true;
            }
        }


        private void cikis_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Anamenu.ActiveForm.Close();
            giris ana = new giris();
            ana.Visible = true;
        }

        private void ayarlar_Click(object sender, EventArgs e)
        {
            Ayar ayara = new Ayar();
            ayara.Visible = true;
        }

        private void mutfak_Click(object sender, EventArgs e)
        {
            Mutfak mut = new Mutfak();
            mut.Visible = true;
            this.Visible = false;
        }

        private void personeller_Click(object sender, EventArgs e)
        {
            Personeller perso = new Personeller();
            perso.Visible = true;
            this.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.Hour.ToString() + ":";
            dakika.Text = DateTime.Now.Minute.ToString() + ":";
            saniye.Text = DateTime.Now.Second.ToString();
            if (saat.Text == "0:")
                saat.Text = "24:";
        }

        private void siparisler_Click(object sender, EventArgs e)
        {
            Siparisler sip = new Siparisler();
            sip.Visible = true;
            this.Visible = false;
        }

        private void hesapislemleri_Click(object sender, EventArgs e)
        {
            Hesapislemlemleri hesap = new Hesapislemlemleri();
            hesap.Visible = true;
            this.Visible = false;
        }

        private void kurye_Click(object sender, EventArgs e)
        {
            Kuryeler krye = new Kuryeler();
            krye.Visible = true;
            this.Visible = false;
        }

        private void masalar_Click(object sender, EventArgs e)
        {
            Masalar msa = new Masalar();
            msa.Visible = true;
            this.Visible = false;
        }


    }
}
