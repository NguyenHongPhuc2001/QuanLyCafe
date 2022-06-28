using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    class DanhMucRepository : IDanhMucRepository
    {
        DB_QLCF db = new DB_QLCF();
        //private static readonly object lockobj = new object();
        //private static DanhMucRepository instance = null;
        //public static DanhMucRepository getInstance()
        //{
        //    lock (lockobj)
        //    {
        //        if (instance == null)
        //        {
        //            instance = new DanhMucRepository();
        //        }
        //        return instance;
        //    }
        //}
        public void DeleteDM(int iddm)
        {
            DanhMuc dm = db.DanhMucs.Where(p => p.IDDanhMuc == iddm).FirstOrDefault();
            if (db != null)
            {
                db.DanhMucs.Remove(dm);
                db.SaveChanges();
            }
        }

        public List<DanhMuc> GetAllDanhMuc()
        {
            return db.DanhMucs.ToList();
        }

        public DanhMuc GetDanhMuc(int iddm)
        {
            return db.DanhMucs.Find(iddm);
        }

        public void InsertUpdate(DanhMuc danhmuc)
        {
            db.DanhMucs.AddOrUpdate(danhmuc);
            db.SaveChanges();
        }
    }
}
