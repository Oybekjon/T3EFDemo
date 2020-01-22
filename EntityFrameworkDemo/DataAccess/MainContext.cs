using EntityFrameworkDemo.DataAccess.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.DataAccess
{
    public class MainContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Trim> Trims { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Model>()
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(400);

            modelBuilder
                .Entity<Model>()
                .ToTable("Model");

            modelBuilder.Configurations.Add(new TrimMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
