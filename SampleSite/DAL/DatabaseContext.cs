namespace SampleSite.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SampleSite.Models;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DbConn")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<SampleSite.Models.Logins> Logins { get; set; }
    }
}
