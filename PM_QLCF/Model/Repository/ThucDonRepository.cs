using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    class ThucDonRepository : IThucDonRepository
    {
        DB_QLCF db = new DB_QLCF();
        //private static readonly object lockobj = new object();
        //private static ThucDonRepository instance = null;
        //public static ThucDonRepository getInstance()
        //{
        //    lock (lockobj)
        //    {
        //        if (instance == null)
        //        {
        //            instance = new ThucDonRepository();
        //        }
        //        return instance;
        //    }
        //}
        public void DeleteTD(int idtd)
        {
            ThucDon td = db.ThucDons.Where(p => p.IDMonAn == idtd).FirstOrDefault();
            if (td != null)
            {
                db.ThucDons.Remove(td);
                db.SaveChanges();
            }
        }

        public List<ThucDon> GetAllThucDon()
        {
            return db.ThucDons.ToList();
        }

        public ThucDon GetIDDanhMucByTen(string tendm)
        {
            ThucDon td = db.ThucDons.Where(p => p.DanhMuc.TenDM == tendm).FirstOrDefault();
            return td;
        }

        public ThucDon GetThucDon(int idtd)
        {
            return db.ThucDons.Find(idtd);
        }

        public List<ThucDon> GetThucDonByIDDanhMuc(int iddm)
        {
            return db.ThucDons.Where(p => p.IDDanhMuc == iddm).ToList();
        }

        public void InsertUpdate(ThucDon thucdon)
        {
            db.ThucDons.AddOrUpdate(thucdon);
            db.SaveChanges();
        }
    }
}
