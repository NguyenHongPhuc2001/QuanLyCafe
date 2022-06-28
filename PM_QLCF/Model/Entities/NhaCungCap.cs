namespace PM_QLCF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [Key]
        public int IDNhaCungCap { get; set; }

        [StringLength(100)]
        public string TenNCC { get; set; }

        public string DiaChi { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }
    }
    
    //public partial class NhaCungCap
    //{
    //    public static List<NhaCungCap> GetAllNCC()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.NhaCungCaps.ToList();
    //    }

    //    public static NhaCungCap GetNhaCungCap(int id)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.NhaCungCaps.Find(id);
    //    }

    //    public void InsertUpdateNCC()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        db.NhaCungCaps.AddOrUpdate(this);
    //        db.SaveChanges();
    //    }

    //    public static void DeleteNCC(int idncc)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        NhaCungCap ncc = db.NhaCungCaps.Where(p => p.IDNhaCungCap == idncc).FirstOrDefault();
    //        if (ncc != null)
    //        {
    //            db.NhaCungCaps.Remove(ncc);
    //            db.SaveChanges();
    //        }
    //    }
    //}
}
