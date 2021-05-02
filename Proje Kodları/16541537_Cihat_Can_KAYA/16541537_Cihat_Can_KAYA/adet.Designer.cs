namespace _16541537_Cihat_Can_KAYA
{
    partial class adet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adet));
            this.label1 = new System.Windows.Forms.Label();
            this.adett = new System.Windows.Forms.TextBox();
            this.Onayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adet Giriniz";
            // 
            // adett
            // 
            this.adett.Location = new System.Drawing.Point(95, 99);
            this.adett.Name = "adett";
            this.adett.Size = new System.Drawing.Size(100, 20);
            this.adett.TabIndex = 5;
            // 
            // Onayla
            // 
            this.Onayla.Location = new System.Drawing.Point(104, 137);
            this.Onayla.Name = "Onayla";
            this.Onayla.Size = new System.Drawing.Size(75, 23);
            this.Onayla.TabIndex = 6;
            this.Onayla.Text = "Onayla";
            this.Onayla.UseVisualStyleBackColor = true;
            this.Onayla.Click += new System.EventHandler(this.Onayla_Click);
            // 
            // adet
            // 
            this.AcceptButton = this.Onayla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Onayla);
            this.Controls.Add(this.adett);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adet";
            this.Text = "adet";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adett;
        private System.Windows.Forms.Button Onayla;
    }
}