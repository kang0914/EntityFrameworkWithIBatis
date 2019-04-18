namespace EntityWithIBatis.DBContexts
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Common;

    public partial class TEMP_BIZ_DBContext : DbContext
    {
        public TEMP_BIZ_DBContext()
            : base("name=TEMP_BIZ_DBContext")
        {
        }

        public TEMP_BIZ_DBContext(DbConnection existingConnection, bool contextOwnsConnection)
           : base(existingConnection, contextOwnsConnection)
        {
        }

        public virtual DbSet<MM_CODE> MM_CODE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
