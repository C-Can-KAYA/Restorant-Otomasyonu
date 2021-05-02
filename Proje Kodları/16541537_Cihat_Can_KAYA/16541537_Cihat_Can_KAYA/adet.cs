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
    public partial class adet : Form
    {
        public static string sayi { get; set; }
        public adet()
        {
            InitializeComponent();
        }
        
        private void Onayla_Click(object sender, EventArgs e)
        {
            if(adett.Text!="")
            {
                sayi = adett.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Adet Giriniz");
            }

            
        }
    }
}
