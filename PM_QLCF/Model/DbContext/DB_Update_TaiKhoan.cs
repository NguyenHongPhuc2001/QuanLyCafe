using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PM_QLCF.Model
{
    public partial class DB_Update_TaiKhoan : DbContext
    {
        public DB_Update_TaiKhoan()
            : base("name=DB_Update_TaiKhoan")
        {
        }

        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
