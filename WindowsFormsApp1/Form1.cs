using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Veritabanı veritabanı = new Veritabanı();
        private void btnEntityFrameworks_Click(object sender, EventArgs e)
        {
            CalısmaEntities1 db = new CalısmaEntities1();

            db.tbl_Kategoriler.Add(new tbl_Kategoriler { KategoriAdi = "Müzik" });
            
            db.SaveChanges();

            dataGridView1.DataSource = db.tbl_Urunler.ToList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CalısmaEntities1 db = new CalısmaEntities1();

            

            veritabanı.Insert(txtUrunAd.Text, txtKategoriID.Text, txtFiyat.Text, txtResim.Text, txtAciklama.Text);
            Temizle();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            veritabanı.List(dataGridView1);
            Temizle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            veritabanı.Remove(txtUrunID.Text);
            Temizle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            veritabanı.Update(txtUrunID.Text, txtUrunAd.Text, txtKategoriID.Text, txtFiyat.Text, txtResim.Text, txtAciklama.Text);
            Temizle();
        }


        public void Temizle()
        {
            txtUrunID.Clear();
            txtUrunAd.Clear();
            txtResim.Clear();
            txtKategoriID.Clear();
            txtFiyat.Clear();
            txtAciklama.Clear();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            veritabanı.Find(int.Parse(txtUrunID.Text));
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

        }
    }
}
