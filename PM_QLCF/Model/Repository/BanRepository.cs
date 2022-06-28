using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    class BanRepository: IBanRepository
    {
        DB_QLCF db = new DB_QLCF();
        
        public void DeleteBan(int id)
        {
            Ban ban = db.Bans.Where(p => p.IDBan == id).FirstOrDefault();
            if (ban != null)
            {
                db.Bans.Remove(ban);
                db.SaveChanges();
            }
        }

        public List<Ban> GetAllBan()
        {
            return db.Bans.ToList();
        }

        public Ban GetBan(int id)
        {
            return db.Bans.Find(id);
        }

        public void InsertUpdate(Ban ban)
        {
            db.Bans.AddOrUpdate(ban);
            db.SaveChanges();
        }
    }
}
