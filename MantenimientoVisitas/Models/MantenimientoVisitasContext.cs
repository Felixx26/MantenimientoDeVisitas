using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MantenimientoVisitas.Models;

namespace MantenimientoVisitas.Models
{
    public class MantenimientoVisitasContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MantenimientoVisitasContext() : base("name=MantenimientoVisitasContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MantenimientoVisitasContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MantenimientoVisitasContext>());
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Visita> Visitas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

        }
    }
}
