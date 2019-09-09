namespace CRUD.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CRUD.Clases;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DBEntity")
        {
        }
        public DbSet<Producto> ProdList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
