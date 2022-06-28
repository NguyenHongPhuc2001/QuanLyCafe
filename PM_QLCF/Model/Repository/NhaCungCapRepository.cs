using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    class NhaCungCapRepository : INhaCungCapRepository
    {
        DB_QLCF db = new DB_QLCF();
        //private static readonly object lockobj = new object();
        //private static NhaCungCapRepository instance = null;
        //public static NhaCungCapRepository getInstance()
        //{
        //    lock (lockobj)
        //    {
        //        if (instance == null)
        //        {
        //            instance = new NhaCungCapRepository();
        //        }
        //        return instance;
        //    }
        //}
        public void DeleteNCC(int idncc)
        {
            NhaCungCap ncc = db.NhaCungCaps.Where(p => p.IDNhaCungCap == idncc).FirstOrDefault();
            if (ncc != null)
            {
                db.NhaCungCaps.Remove(ncc);
                db.SaveChanges();
            }
        }

        public List<NhaCungCap> GetAllNCC()
        {
            return db.NhaCungCaps.ToList();
        }

        public NhaCungCap GetNhaCungCap(int id)
        {
            return db.NhaCungCaps.Find(id);
        }

        public void InsertUpdateNCC(NhaCungCap ncc)
        {
            db.NhaCungCaps.AddOrUpdate(ncc);
            db.SaveChanges();
        }
    }
}
