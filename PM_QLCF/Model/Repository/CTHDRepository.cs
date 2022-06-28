using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    class CTHDRepository : ICTHDRepository
    {
        DB_QLCF db = new DB_QLCF();
        //private static readonly object lockobj = new object();
        //private static CTHDRepository instance = null;
        //public static CTHDRepository getInstance()
        //{
        //    lock (lockobj)
        //    {
        //        if (instance == null)
        //        {
        //            instance = new CTHDRepository();
        //        }
        //        return instance;
        //    }
        //}

        public void DeleteCTHoaDon(int idcthd)
        {
            ChiTietHoaDon cthd = db.ChiTietHoaDons.Where(p => p.IDChiTietHoaDon == idcthd).FirstOrDefault();
            db.ChiTietHoaDons.Remove(cthd);
            db.SaveChanges();
        }

        public List<ChiTietHoaDon> GetAllCTHD()
        {
            return db.ChiTietHoaDons.ToList();
        }

        public ChiTietHoaDon GetCTHDByIDMon(int idmon)
        {
            return db.ChiTietHoaDons.Where(p => p.IDMonAn == idmon).FirstOrDefault();
        }

        public List<ChiTietHoaDon> GetListCTHDByIDHoaDon(int idhd)
        {
            return db.ChiTietHoaDons.Where(p => p.IDHoaDon == idhd).ToList();
        }

        public void InsertUpdate(ChiTietHoaDon cthd)
        {
            db.ChiTietHoaDons.AddOrUpdate(cthd);
            db.SaveChanges();
        }
    }
}
