
namespace WindowsFormsApp1
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
            this.btnEntityFrameworks = new System.Windows.Forms.Button();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtKategoriID = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblKategoriID = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblResim = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.lblMinFiyat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinFiyat = new System.Windows.Forms.TextBox();
            this.txtMaxFiyat = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEntityFrameworks
            // 
            this.btnEntityFrameworks.Location = new System.Drawing.Point(995, 72);
            this.btnEntityFrameworks.Name = "btnEntityFrameworks";
            this.btnEntityFrameworks.Size = new System.Drawing.Size(135, 42);
            this.btnEntityFrameworks.TabIndex = 1;
            this.btnEntityFrameworks.Text = "EntityFrameworks";
            this.btnEntityFrameworks.UseVisualStyleBackColor = true;
            this.btnEntityFrameworks.Click += new System.EventHandler(this.btnEntityFrameworks_Click);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(188, 37);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAd.TabIndex = 2;
            // 
            // txtKategoriID
            // 
            this.txtKategoriID.Location = new System.Drawing.Point(188, 65);
            this.txtKategoriID.Name = "txtKategoriID";
            this.txtKategoriID.Size = new System.Drawing.Size(100, 22);
            this.txtKategoriID.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(188, 93);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 4;
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(188, 121);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(100, 22);
            this.txtResim.TabIndex = 5;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(188, 149);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(195, 40);
            this.txtAciklama.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 32);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(104, 40);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(67, 17);
            this.lblUrunAd.TabIndex = 10;
            this.lblUrunAd.Text = "Urun Adi:";
            // 
            // lblKategoriID
            // 
            this.lblKategoriID.AutoSize = true;
            this.lblKategoriID.Location = new System.Drawing.Point(104, 68);
            this.lblKategoriID.Name = "lblKategoriID";
            this.lblKategoriID.Size = new System.Drawing.Size(78, 17);
            this.lblKategoriID.TabIndex = 10;
            this.lblKategoriID.Text = "KategoriID:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(104, 96);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 17);
            this.lblFiyat.TabIndex = 10;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Location = new System.Drawing.Point(104, 124);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(47, 17);
            this.lblResim.TabIndex = 10;
            this.lblResim.Text = "Resim";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(104, 152);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(64, 17);
            this.lblAciklama.TabIndex = 10;
            this.lblAciklama.Text = "Açıklama";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 126);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 32);
            this.btnList.TabIndex = 11;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(188, 9);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(100, 22);
            this.txtUrunID.TabIndex = 12;
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Location = new System.Drawing.Point(104, 12);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(52, 17);
            this.lblUrunID.TabIndex = 13;
            this.lblUrunID.Text = "UrunID";
            // 
            // lblMinFiyat
            // 
            this.lblMinFiyat.AutoSize = true;
            this.lblMinFiyat.Location = new System.Drawing.Point(614, 87);
            this.lblMinFiyat.Name = "lblMinFiyat";
            this.lblMinFiyat.Size = new System.Drawing.Size(68, 17);
            this.lblMinFiyat.TabIndex = 14;
            this.lblMinFiyat.Text = "Min. Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Max. Fiyat";
            // 
            // txtMinFiyat
            // 
            this.txtMinFiyat.Location = new System.Drawing.Point(713, 83);
            this.txtMinFiyat.Name = "txtMinFiyat";
            this.txtMinFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtMinFiyat.TabIndex = 15;
            // 
            // txtMaxFiyat
            // 
            this.txtMaxFiyat.Location = new System.Drawing.Point(713, 115);
            this.txtMaxFiyat.Name = "txtMaxFiyat";
            this.txtMaxFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtMaxFiyat.TabIndex = 15;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(617, 143);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(196, 34);
            this.btnAra.TabIndex = 16;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(294, 8);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(44, 23);
            this.btnBul.TabIndex = 17;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 525);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtMaxFiyat);
            this.Controls.Add(this.txtMinFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMinFiyat);
            this.Controls.Add(this.lblUrunID);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblResim);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblKategoriID);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtResim);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtKategoriID);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.btnEntityFrameworks);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEntityFrameworks;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtKategoriID;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblKategoriID;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.Label lblMinFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinFiyat;
        private System.Windows.Forms.TextBox txtMaxFiyat;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnBul;
    }
}

