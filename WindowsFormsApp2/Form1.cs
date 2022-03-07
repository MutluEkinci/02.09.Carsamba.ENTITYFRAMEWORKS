using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CalısmaEntities db = new CalısmaEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategoriDoldur();
        }
        private void cmbKategoriDoldur()
        {
            cmbKategori.DataSource = db.tbl_Kategoriler.ToList();

            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";
        }

        private tbl_Urunler UrunNesnesiOlustur()
        {
            tbl_Urunler urun = new tbl_Urunler
            {
                UrunAdi = txtUrunAdi.Text,
                Fiyat = Convert.ToDecimal(txtFiyat.Text),
                KategoriID = Convert.ToInt32(cmbKategori.SelectedValue),
                Resim = txtResim.Text,
                Aciklama = txtAciklama.Text
            };
            return urun;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            db.tbl_Urunler.Add(UrunNesnesiOlustur());

            db.SaveChanges();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_Urunler.ToList();
        }

        private void EkranDoldur(tbl_Urunler urun)
        {
            txtUrunID.Text = urun.UrunID.ToString();
            txtUrunAdi.Text = urun.UrunAdi;
            txtFiyat.Text = urun.Fiyat.ToString();
            cmbKategori.Text = urun.tbl_Kategoriler.KategoriAdi;
            txtResim.Text = urun.Resim;
            txtAciklama.Text = urun.Aciklama;
        }

        private void btnIDAra_Click(object sender, EventArgs e)
        {
            //1.Yöntem:Find() metodu Primary key üzerinde çalışır.
            //tbl_Urunler urun= db.tbl_Urunler.Find(int.Parse(txtUrunID.Text));

            //2.Yöntem
            int urunID = int.Parse(txtUrunID.Text);
            //tbl_Urunler urun = db.tbl_Urunler.Where(u => u.UrunID == urunID).FirstOrDefault();

            //3.Yöntem
            var urun = (from u in db.tbl_Urunler
                        where u.UrunID == urunID
                        select u).SingleOrDefault();

            if (urun != null)
            {
                EkranDoldur(urun);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int urunID = int.Parse(txtUrunID.Text);
            DialogResult dr = MessageBox.Show("Emin misiniz!", "UYARI!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                db.tbl_Urunler.Remove(db.tbl_Urunler.Find(urunID));

            db.SaveChanges();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int urunID = int.Parse(txtUrunID.Text);

            var urun = db.tbl_Urunler.Find(urunID);

            urun.UrunAdi = txtUrunAdi.Text;
            urun.KategoriID = Convert.ToInt32(cmbKategori.SelectedValue);
            urun.Fiyat = decimal.Parse(txtFiyat.Text);
            urun.Resim = txtResim.Text;
            urun.Aciklama = txtAciklama.Text;

            db.Entry<tbl_Urunler>(urun).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
        }

        private void btnKategoriAra_Click(object sender, EventArgs e)
        {
            int kategoriID = Convert.ToInt32(cmbKategori.SelectedValue);
            var liste = db.tbl_Urunler.Where(u => u.KategoriID == kategoriID);

            dataGridView1.DataSource = liste.ToList();
        }

        private void bntFiyatAra_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtMinFiyat.Text);
            int max = int.Parse(txtMaxFiyat.Text);

            var liste = db.tbl_Urunler.Where(u => u.Fiyat >= min && u.Fiyat <= max).ToList();

            dataGridView1.DataSource = liste;
        }

        private void btnSıralaAz_Click(object sender, EventArgs e)
        {
            var liste = db.tbl_Urunler.OrderBy(u => u.Fiyat);

            dataGridView1.DataSource = liste.ToList();
        }

        private void btnAdAra_Click(object sender, EventArgs e)
        {
            string ad = txtUrunAdi.Text;

            var liste = db.tbl_Urunler.Where(u => u.UrunAdi.Contains(ad)).ToList();


            dataGridView1.DataSource = liste;
        }

        private void btnSıralaZa_Click(object sender, EventArgs e)
        {
            var liste = db.tbl_Urunler.OrderByDescending(u => u.Fiyat);

            dataGridView1.DataSource = liste.ToList();

        }

        private void btnOzet_Click(object sender, EventArgs e)
        {
            //var liste = db.tbl_Urunler.Select(u => new { u.UrunID, u.UrunAdi, u.Fiyat });

            var liste = from u in db.tbl_Urunler
                        select new { ID=u.UrunID, İSİM=u.UrunAdi, MAYIŞI=u.Fiyat };

            dataGridView1.DataSource = liste.ToList();
        }
    }
}
