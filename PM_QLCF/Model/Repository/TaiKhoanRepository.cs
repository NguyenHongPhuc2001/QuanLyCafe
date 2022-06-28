using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    class TaiKhoanRepository : ITaiKhoanRepository
    {
        DB_Update_TaiKhoan db = new DB_Update_TaiKhoan();
        //private static TaiKhoanRepository instance = null;
        //private static readonly object lockobj = new object(); 
        //public static TaiKhoanRepository getInstance()
        //{
        //    lock (lockobj)
        //    {
        //        if(instance == null)
        //        {
        //            instance = new TaiKhoanRepository();
        //        }
        //        return instance;
        //    }   
        //}
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            return db.TaiKhoans.ToList();
        }
    }
}
