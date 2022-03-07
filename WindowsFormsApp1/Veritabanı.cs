using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Veritabanı
    {

        
        public void Insert(string UrunAdi,string KategoriID,string Fiyat,string Resim,string Aciklama)
        {
            CalısmaEntities1 db = new CalısmaEntities1();

            db.tbl_Urunler.Add(new tbl_Urunler { UrunAdi = UrunAdi, KategoriID = int.Parse(KategoriID), Fiyat = Convert.ToDecimal(Fiyat), Resim = Resim, Aciklama = Aciklama });

            db.SaveChanges();
        }

        public void List(DataGridView datagrid)
        {
            CalısmaEntities1 db = new CalısmaEntities1();

            datagrid.DataSource = db.tbl_Urunler.ToList();
        }

        public void Remove(string UrunID)
        {
            CalısmaEntities1 db = new CalısmaEntities1();

            tbl_Urunler id = db.tbl_Urunler.Find(int.Parse(UrunID));

            db.tbl_Urunler.Remove(id);

            db.SaveChanges();

        }

        public void Update(string UrunID,string UrunAdi,string KategoriID,string Fiyat,string Resim,string Aciklama)
        {
            CalısmaEntities1 db = new CalısmaEntities1();

            tbl_Urunler id = db.tbl_Urunler.Find(int.Parse(UrunID));

            id.UrunAdi = UrunAdi;
            id.KategoriID = int.Parse(KategoriID);
            id.Fiyat = Convert.ToDecimal(Fiyat);
            id.Resim = Resim;
            id.Aciklama = Aciklama;

            db.Entry<tbl_Urunler>(id).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
        }

        public void Find(DataGridView dataGrid, string UrunID)
        {
            CalısmaEntities1 db = new CalısmaEntities1();

            tbl_Urunler id = db.tbl_Urunler.Find(int.Parse(UrunID));

            
        }
    }
}
