namespace PM_QLCF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        public int IDChiTietHoaDon { get; set; }

        public int? IDHoaDon { get; set; }

        public int? IDMonAn { get; set; }

        public int? SoLuong { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual ThucDon ThucDon { get; set; }
    }
    
    //public partial class ChiTietHoaDon
    //{
    //    public static List<ChiTietHoaDon> GetAllCTHD()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.ChiTietHoaDons.ToList();
    //    }

    //    public static List<ChiTietHoaDon> GetListCTHDByIDHoaDon(int idhd)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.ChiTietHoaDons.Where(p => p.IDHoaDon == idhd).ToList();
    //    }

    //    public static ChiTietHoaDon GetCTHDByIDMon(int idmon)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.ChiTietHoaDons.Where(p => p.IDMonAn == idmon).FirstOrDefault();
    //    }

    //    public void InsertUpdate()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        db.ChiTietHoaDons.AddOrUpdate(this);
    //        db.SaveChanges();
    //    }

    //    public void DeleteCTHoaDon(int idcthd)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        ChiTietHoaDon cthd = db.ChiTietHoaDons.Where(p => p.IDChiTietHoaDon == idcthd).FirstOrDefault();
    //        db.ChiTietHoaDons.Remove(cthd);
    //        db.SaveChanges();
    //    }
    //}
}
