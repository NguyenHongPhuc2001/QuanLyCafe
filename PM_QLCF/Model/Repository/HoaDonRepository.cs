using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    class HoaDonRepository : IHoaDonRepository
    {
        DB_QLCF db = new DB_QLCF();
        //private static HoaDonRepository instance = null;
        //private static readonly object lockobj = new object();
        //public static HoaDonRepository getInstance()
        //{
        //    lock (lockobj)
        //    {
        //        if (instance == null)
        //        {
        //            instance = new HoaDonRepository();
        //        }
        //        return instance;
        //    }
        //}
        public void DeleteHoaDon(int idhd)
        {
            HoaDon hd = db.HoaDons.Where(p => p.IDHoaDon == idhd).FirstOrDefault();
            db.HoaDons.Remove(hd);
            db.SaveChanges();
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return db.HoaDons.ToList();
        }

        public HoaDon GetHoaDonByIDBan(int idban)
        {
            return db.HoaDons.Where(p => p.IDBan == idban).FirstOrDefault();
        }

        public HoaDon GetHoaDonByIDBanTrangThai(int idban, int trangthai)
        {
            return db.HoaDons.Where(p => p.IDBan == idban && p.TrangThai == trangthai).FirstOrDefault();
        }

        public HoaDon GetHoaDonByIDHD(int idhd)
        {
            return db.HoaDons.Find(idhd);
        }

        public void InsertUpdate(HoaDon hoadon)
        {
            db.HoaDons.AddOrUpdate(hoadon);
            db.SaveChanges();
        }
    }
}
