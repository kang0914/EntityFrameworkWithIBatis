namespace EntityWithIBatis
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Common;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public Model2(DbConnection existingConnection, bool contextOwnsConnection)
               : base(existingConnection, contextOwnsConnection)
        {
        }

        public virtual DbSet<MM_CODE> MM_CODE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
