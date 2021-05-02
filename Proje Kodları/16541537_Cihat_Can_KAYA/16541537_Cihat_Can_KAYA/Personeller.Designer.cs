namespace _16541537_Cihat_Can_KAYA
{
    partial class Personeller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personeller));
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.k_adi = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad = new System.Windows.Forms.TextBox();
            this.personel_ekle = new System.Windows.Forms.Button();
            this.personel_guncelle = new System.Windows.Forms.Button();
            this.personel_sil = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.seviye = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(1174, 479);
            this.sil.Margin = new System.Windows.Forms.Padding(4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(141, 61);
            this.sil.TabIndex = 51;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(1174, 479);
            this.ekle.Margin = new System.Windows.Forms.Padding(4);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(141, 61);
            this.ekle.TabIndex = 50;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(1174, 479);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(141, 61);
            this.guncelle.TabIndex = 49;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(1143, 385);
            this.sifre.Margin = new System.Windows.Forms.Padding(4);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(209, 25);
            this.sifre.TabIndex = 47;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // k_adi
            // 
            this.k_adi.Location = new System.Drawing.Point(1143, 340);
            this.k_adi.Margin = new System.Windows.Forms.Padding(4);
            this.k_adi.Name = "k_adi";
            this.k_adi.Size = new System.Drawing.Size(209, 25);
            this.k_adi.TabIndex = 46;
            this.k_adi.TextChanged += new System.EventHandler(this.k_adi_TextChanged);
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(1143, 290);
            this.soyad.Margin = new System.Windows.Forms.Padding(4);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(209, 25);
            this.soyad.TabIndex = 45;
            this.soyad.TextChanged += new System.EventHandler(this.soyad_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(25, 202);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(860, 478);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Id";
            this.columnHeader0.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AD";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SOYAD";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "KULLANICI ADI";
            this.columnHeader3.Width = 153;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ŞİFRE";
            this.columnHeader4.Width = 138;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "YETKİ SEVİYESİ";
            this.columnHeader5.Width = 204;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(1143, 257);
            this.ad.Margin = new System.Windows.Forms.Padding(4);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(209, 25);
            this.ad.TabIndex = 39;
            this.ad.TextChanged += new System.EventHandler(this.ad_TextChanged);
            // 
            // personel_ekle
            // 
            this.personel_ekle.BackColor = System.Drawing.Color.Transparent;
            this.personel_ekle.BackgroundImage = global::_16541537_Cihat_Can_KAYA.Properties.Resources.pekle;
            this.personel_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personel_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personel_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personel_ekle.Location = new System.Drawing.Point(372, 34);
            this.personel_ekle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.personel_ekle.Name = "personel_ekle";
            this.personel_ekle.Size = new System.Drawing.Size(325, 139);
            this.personel_ekle.TabIndex = 52;
            this.personel_ekle.UseVisualStyleBackColor = false;
            this.personel_ekle.Click += new System.EventHandler(this.personel_ekle_Click);
            // 
            // personel_guncelle
            // 
            this.personel_guncelle.BackColor = System.Drawing.Color.Transparent;
            this.personel_guncelle.BackgroundImage = global::_16541537_Cihat_Can_KAYA.Properties.Resources.pgüncelle;
            this.personel_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personel_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personel_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personel_guncelle.Location = new System.Drawing.Point(25, 34);
            this.personel_guncelle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.personel_guncelle.Name = "personel_guncelle";
            this.personel_guncelle.Size = new System.Drawing.Size(325, 139);
            this.personel_guncelle.TabIndex = 37;
            this.personel_guncelle.UseVisualStyleBackColor = false;
            this.personel_guncelle.Click += new System.EventHandler(this.personel_guncelle_Click);
            // 
            // personel_sil
            // 
            this.personel_sil.BackColor = System.Drawing.Color.Transparent;
            this.personel_sil.BackgroundImage = global::_16541537_Cihat_Can_KAYA.Properties.Resources.psil;
            this.personel_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personel_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personel_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personel_sil.Location = new System.Drawing.Point(711, 34);
            this.personel_sil.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.personel_sil.Name = "personel_sil";
            this.personel_sil.Size = new System.Drawing.Size(325, 139);
            this.personel_sil.TabIndex = 36;
            this.personel_sil.UseVisualStyleBackColor = false;
            this.personel_sil.Click += new System.EventHandler(this.personel_sil_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Transparent;
            this.geri.BackgroundImage = global::_16541537_Cihat_Can_KAYA.Properties.Resources.geri;
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri.Location = new System.Drawing.Point(1312, -1);
            this.geri.Margin = new System.Windows.Forms.Padding(4);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(67, 64);
            this.geri.TabIndex = 35;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1081, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 36);
            this.label1.TabIndex = 53;
            this.label1.Text = "AD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1032, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 36);
            this.label2.TabIndex = 54;
            this.label2.Text = "SOYAD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(904, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 36);
            this.label3.TabIndex = 55;
            this.label3.Text = "KULLANICI ADI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1040, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 36);
            this.label4.TabIndex = 56;
            this.label4.Text = "ŞİFRE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(903, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 36);
            this.label5.TabIndex = 57;
            this.label5.Text = "YETKİ SEVİYESİ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(1143, 182);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 25);
            this.id.TabIndex = 58;
            this.id.Visible = false;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // seviye
            // 
            this.seviye.FormattingEnabled = true;
            this.seviye.Location = new System.Drawing.Point(1143, 425);
            this.seviye.Name = "seviye";
            this.seviye.Size = new System.Drawing.Size(210, 26);
            this.seviye.TabIndex = 59;
            // 
            // Personeller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::_16541537_Cihat_Can_KAYA.Properties.Resources.giris_arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 764);
            this.ControlBox = false;
            this.Controls.Add(this.seviye);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personel_ekle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.k_adi);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.personel_guncelle);
            this.Controls.Add(this.personel_sil);
            this.Controls.Add(this.geri);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Personeller";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Personeller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Personeller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button personel_ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox k_adi;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Button personel_guncelle;
        private System.Windows.Forms.Button personel_sil;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ComboBox seviye;

    }
}