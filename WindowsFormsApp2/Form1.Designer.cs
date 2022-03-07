
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtMinFiyat = new System.Windows.Forms.TextBox();
            this.txtMaxFiyat = new System.Windows.Forms.TextBox();
            this.btnIDAra = new System.Windows.Forms.Button();
            this.btnKategoriAra = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnFiyatAra = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSıralaZa = new System.Windows.Forms.Button();
            this.btnSıralaAz = new System.Windows.Forms.Button();
            this.btnAdAra = new System.Windows.Forms.Button();
            this.btnOzet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Urun ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Urun Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Resim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(949, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Min.Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(949, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Max.Fiyat";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(92, 12);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(100, 22);
            this.txtUrunID.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(92, 72);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(92, 136);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 2;
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(346, 72);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(121, 22);
            this.txtResim.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(346, 136);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(424, 65);
            this.txtAciklama.TabIndex = 2;
            // 
            // txtMinFiyat
            // 
            this.txtMinFiyat.Location = new System.Drawing.Point(1033, 249);
            this.txtMinFiyat.Name = "txtMinFiyat";
            this.txtMinFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtMinFiyat.TabIndex = 2;
            // 
            // txtMaxFiyat
            // 
            this.txtMaxFiyat.Location = new System.Drawing.Point(1033, 283);
            this.txtMaxFiyat.Name = "txtMaxFiyat";
            this.txtMaxFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtMaxFiyat.TabIndex = 2;
            // 
            // btnIDAra
            // 
            this.btnIDAra.Location = new System.Drawing.Point(198, 12);
            this.btnIDAra.Name = "btnIDAra";
            this.btnIDAra.Size = new System.Drawing.Size(53, 27);
            this.btnIDAra.TabIndex = 3;
            this.btnIDAra.Text = "Ara";
            this.btnIDAra.UseVisualStyleBackColor = true;
            this.btnIDAra.Click += new System.EventHandler(this.btnIDAra_Click);
            // 
            // btnKategoriAra
            // 
            this.btnKategoriAra.Location = new System.Drawing.Point(473, 12);
            this.btnKategoriAra.Name = "btnKategoriAra";
            this.btnKategoriAra.Size = new System.Drawing.Size(52, 27);
            this.btnKategoriAra.TabIndex = 3;
            this.btnKategoriAra.Text = "Ara";
            this.btnKategoriAra.UseVisualStyleBackColor = true;
            this.btnKategoriAra.Click += new System.EventHandler(this.btnKategoriAra_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(952, 16);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(181, 37);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(952, 59);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(181, 35);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(952, 100);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(181, 36);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnFiyatAra
            // 
            this.btnFiyatAra.Location = new System.Drawing.Point(952, 318);
            this.btnFiyatAra.Name = "btnFiyatAra";
            this.btnFiyatAra.Size = new System.Drawing.Size(181, 40);
            this.btnFiyatAra.TabIndex = 3;
            this.btnFiyatAra.Text = "Ara";
            this.btnFiyatAra.UseVisualStyleBackColor = true;
            this.btnFiyatAra.Click += new System.EventHandler(this.bntFiyatAra_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(346, 15);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 24);
            this.cmbKategori.TabIndex = 4;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(952, 139);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(181, 34);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSıralaZa
            // 
            this.btnSıralaZa.Location = new System.Drawing.Point(952, 379);
            this.btnSıralaZa.Name = "btnSıralaZa";
            this.btnSıralaZa.Size = new System.Drawing.Size(181, 35);
            this.btnSıralaZa.TabIndex = 6;
            this.btnSıralaZa.Text = "Fiyata Göre Z-A";
            this.btnSıralaZa.UseVisualStyleBackColor = true;
            this.btnSıralaZa.Click += new System.EventHandler(this.btnSıralaZa_Click);
            // 
            // btnSıralaAz
            // 
            this.btnSıralaAz.Location = new System.Drawing.Point(952, 420);
            this.btnSıralaAz.Name = "btnSıralaAz";
            this.btnSıralaAz.Size = new System.Drawing.Size(181, 35);
            this.btnSıralaAz.TabIndex = 7;
            this.btnSıralaAz.Text = "Fiyata Göre A-Z";
            this.btnSıralaAz.UseVisualStyleBackColor = true;
            this.btnSıralaAz.Click += new System.EventHandler(this.btnSıralaAz_Click);
            // 
            // btnAdAra
            // 
            this.btnAdAra.Location = new System.Drawing.Point(952, 461);
            this.btnAdAra.Name = "btnAdAra";
            this.btnAdAra.Size = new System.Drawing.Size(181, 35);
            this.btnAdAra.TabIndex = 7;
            this.btnAdAra.Text = "Ad İçinde Ara";
            this.btnAdAra.UseVisualStyleBackColor = true;
            this.btnAdAra.Click += new System.EventHandler(this.btnAdAra_Click);
            // 
            // btnOzet
            // 
            this.btnOzet.Location = new System.Drawing.Point(952, 503);
            this.btnOzet.Name = "btnOzet";
            this.btnOzet.Size = new System.Drawing.Size(181, 37);
            this.btnOzet.TabIndex = 8;
            this.btnOzet.Text = "Özet(ID,Ad,Fiyat)";
            this.btnOzet.UseVisualStyleBackColor = true;
            this.btnOzet.Click += new System.EventHandler(this.btnOzet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 588);
            this.Controls.Add(this.btnOzet);
            this.Controls.Add(this.btnAdAra);
            this.Controls.Add(this.btnSıralaAz);
            this.Controls.Add(this.btnSıralaZa);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnFiyatAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnKategoriAra);
            this.Controls.Add(this.btnIDAra);
            this.Controls.Add(this.txtMaxFiyat);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtMinFiyat);
            this.Controls.Add(this.txtResim);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtMinFiyat;
        private System.Windows.Forms.TextBox txtMaxFiyat;
        private System.Windows.Forms.Button btnIDAra;
        private System.Windows.Forms.Button btnKategoriAra;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnFiyatAra;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSıralaZa;
        private System.Windows.Forms.Button btnSıralaAz;
        private System.Windows.Forms.Button btnAdAra;
        private System.Windows.Forms.Button btnOzet;
    }
}

