namespace PM_QLCF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Ban")]
    public partial class Ban
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ban()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public int IDBan { get; set; }

        public int SoBan { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }


        public static int ChieuDai = 100;
        public static int ChieuRong = 100;
    }

    //public partial class Ban
    //{
    //    public static List<Ban> GetAllBan()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.Bans.ToList();
    //    }

    //    public static Ban GetBan(int idban)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        return db.Bans.Find(idban);
    //    }

    //    public void InsertUpdate()
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        db.Bans.AddOrUpdate(this);
    //        db.SaveChanges();
    //    }

    //    public static void DeleteBan(int idban)
    //    {
    //        DB_QLCF db = new DB_QLCF();
    //        Ban ban = db.Bans.Where(p => p.IDBan == idban).FirstOrDefault();
    //        if(ban != null)
    //        {
    //            db.Bans.Remove(ban);
    //            db.SaveChanges();
    //        }
    //    }

    //}
}
