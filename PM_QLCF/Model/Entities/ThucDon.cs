namespace PM_QLCF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("ThucDon")]
    public partial class ThucDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThucDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        public int IDMonAn { get; set; }

        public int? IDDanhMuc { get; set; }

        [StringLength(100)]
        public string TenMonAn { get; set; }

        public double? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }

    //public partial class ThucDon
    //{
    //    public static List<ThucDon> GetAllThucDon()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.ThucDons.ToList();
    //    }

    //    public static ThucDon GetThucDon(int idtd)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.ThucDons.Find(idtd);           
    //    }
    
    //    public void InsertUpdate()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        db.ThucDons.AddOrUpdate(this);
    //        db.SaveChanges();
    //    }

    //    public static void DeleteTD(int idtd)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        ThucDon td = db.ThucDons.Where(p => p.IDMonAn == idtd).FirstOrDefault();
    //        if(td!= null)
    //        {
    //            db.ThucDons.Remove(td);
    //            db.SaveChanges();
    //        }
    //    }

    //    public static ThucDon GetIDDanhMucByTen(string tendm)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        ThucDon td = db.ThucDons.Where(p => p.DanhMuc.TenDM == tendm).FirstOrDefault();
    //        return td;
    //    }

    //    public static List<ThucDon> GetThucDonByIDDanhMuc(int iddm)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.ThucDons.Where(p => p.IDDanhMuc == iddm).ToList();
    //    }
    //}
}
