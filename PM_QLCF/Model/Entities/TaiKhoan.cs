namespace PM_QLCF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }

    //public partial class TaiKhoan
    //{
    //    public static List<TaiKhoan> GetAllTaiKhoan()
    //    {
    //        DB_Update_TaiKhoan db = new DB_Update_TaiKhoan();
    //        return db.TaiKhoans.ToList();
    //    }       
    //}

}
