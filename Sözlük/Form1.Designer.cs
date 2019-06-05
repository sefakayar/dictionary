namespace Sözlük
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCevir = new System.Windows.Forms.Button();
            this.cbEn = new System.Windows.Forms.CheckBox();
            this.lbKelime = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.tbTr = new System.Windows.Forms.TextBox();
            this.tbEn = new System.Windows.Forms.TextBox();
            this.btEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCevir
            // 
            this.btCevir.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btCevir.Location = new System.Drawing.Point(432, 103);
            this.btCevir.Name = "btCevir";
            this.btCevir.Size = new System.Drawing.Size(72, 40);
            this.btCevir.TabIndex = 0;
            this.btCevir.Text = "Çevir";
            this.btCevir.UseVisualStyleBackColor = true;
            this.btCevir.Click += new System.EventHandler(this.btCevir_Click);
            // 
            // cbEn
            // 
            this.cbEn.AutoSize = true;
            this.cbEn.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.cbEn.Location = new System.Drawing.Point(179, 85);
            this.cbEn.Name = "cbEn";
            this.cbEn.Size = new System.Drawing.Size(194, 27);
            this.cbEn.TabIndex = 1;
            this.cbEn.Text = "Türkçeden İngilizceye";
            this.cbEn.UseVisualStyleBackColor = true;
            // 
            // lbKelime
            // 
            this.lbKelime.AutoSize = true;
            this.lbKelime.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.lbKelime.Location = new System.Drawing.Point(101, 115);
            this.lbKelime.Name = "lbKelime";
            this.lbKelime.Size = new System.Drawing.Size(72, 23);
            this.lbKelime.TabIndex = 2;
            this.lbKelime.Text = "Kelime :";
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSonuc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbSonuc.Location = new System.Drawing.Point(227, 152);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(73, 29);
            this.lbSonuc.TabIndex = 3;
            this.lbSonuc.Text = "Sonuç";
            // 
            // tbKelime
            // 
            this.tbKelime.Location = new System.Drawing.Point(179, 118);
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(236, 20);
            this.tbKelime.TabIndex = 4;
            // 
            // tbTr
            // 
            this.tbTr.Location = new System.Drawing.Point(179, 272);
            this.tbTr.Name = "tbTr";
            this.tbTr.Size = new System.Drawing.Size(106, 20);
            this.tbTr.TabIndex = 5;
            // 
            // tbEn
            // 
            this.tbEn.Location = new System.Drawing.Point(309, 272);
            this.tbEn.Name = "tbEn";
            this.tbEn.Size = new System.Drawing.Size(106, 20);
            this.tbEn.TabIndex = 6;
            // 
            // btEkle
            // 
            this.btEkle.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEkle.Location = new System.Drawing.Point(432, 252);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(72, 40);
            this.btEkle.TabIndex = 7;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label1.Location = new System.Drawing.Point(199, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Türkçe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label2.Location = new System.Drawing.Point(324, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "İngilizce";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(612, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEkle);
            this.Controls.Add(this.tbEn);
            this.Controls.Add(this.tbTr);
            this.Controls.Add(this.tbKelime);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.lbKelime);
            this.Controls.Add(this.cbEn);
            this.Controls.Add(this.btCevir);
            this.Name = "Form1";
            this.Text = "İngilizce / Türkçe Sözlük";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCevir;
        private System.Windows.Forms.CheckBox cbEn;
        private System.Windows.Forms.Label lbKelime;
        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.TextBox tbKelime;
        private System.Windows.Forms.TextBox tbTr;
        private System.Windows.Forms.TextBox tbEn;
        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

