using Microsoft.EntityFrameworkCore;
using ModelsClass.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataClass
{
    public class AppContext :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=TAURUS\DBDESASQLCLU1;Database=wcarv;User ID=wsanchezm;Password=wsanchezm;Trusted_Connection=false");

        public DbSet<User> Users { get; set; }
        public DbSet<IdentificationType> IdentificationTypes { get; set; }
        public DbSet<HandleSession> HandleSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(p => new { p.IdNumber})
                .IsUnique(true);
            
            modelBuilder.Entity<IdentificationType>()
                .HasIndex(p => new { p.Code})
                .IsUnique(true);
        }

    }
}
