namespace EntityWithIBatis.DBContexts
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TEMP_BIZ_DBContext : DbContext
    {
        public TEMP_BIZ_DBContext()
            : base("name=TEMP_BIZ_DBContext")
        {
        }

        public virtual DbSet<MM_CODE> MM_CODE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
