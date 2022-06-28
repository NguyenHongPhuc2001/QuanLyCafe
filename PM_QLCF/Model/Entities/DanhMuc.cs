namespace PM_QLCF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("DanhMuc")]
    public partial class DanhMuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMuc()
        {
            ThucDons = new HashSet<ThucDon>();
        }

        [Key]
        public int IDDanhMuc { get; set; }

        [StringLength(100)]
        public string TenDM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucDon> ThucDons { get; set; }
    }

    //public partial class DanhMuc
    //{
    //    public static List<DanhMuc> GetAllDanhMuc()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.DanhMucs.ToList();
    //    }
    //    public static DanhMuc GetDanhMuc(int iddm)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.DanhMucs.Find(iddm);
    //    }

    //    public void InsertUpdate()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        db.DanhMucs.AddOrUpdate(this);
    //        db.SaveChanges();
    //    }

    //    public static void DeleteDM(int iddm)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        DanhMuc dm = db.DanhMucs.Where(p => p.IDDanhMuc == iddm).FirstOrDefault();
    //        if(db != null)
    //        {
    //            db.DanhMucs.Remove(dm);
    //            db.SaveChanges();
    //        }  
    //    }

    //}
}
