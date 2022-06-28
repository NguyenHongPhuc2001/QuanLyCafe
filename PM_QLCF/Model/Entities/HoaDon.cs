namespace PM_QLCF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        public int IDHoaDon { get; set; }

        public int? IDBan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLapHD { get; set; }

        public double? TongTien { get; set; }

        public int? TrangThai { get; set; }

        public virtual Ban Ban { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }

    //public partial class HoaDon
    //{
    //    public static List<HoaDon> GetAllHoaDon()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.HoaDons.ToList();
    //    }

    //    public static HoaDon GetHoaDonByIDHD(int idhd)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.HoaDons.Find(idhd);
    //    }

    //    public static HoaDon GetHoaDonByIDBan(int idban)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.HoaDons.Where(p => p.IDBan == idban).FirstOrDefault();
    //    }

    //    public static HoaDon GetHoaDonByIDBanTrangThai(int idban, int trangthai)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.HoaDons.Where(p => p.IDBan == idban && p.TrangThai == trangthai).FirstOrDefault();
    //    }

    //    public void InsertUpdate()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        db.HoaDons.AddOrUpdate(this);
    //        db.SaveChanges();
    //    }

    //    public void DeleteHoaDon(int idhd)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        HoaDon hd = db.HoaDons.Where(p => p.IDHoaDon == idhd).FirstOrDefault();
    //        db.HoaDons.Remove(hd);
    //        db.SaveChanges();
    //    }
    //}
}
