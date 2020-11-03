using Catering.Data.Models;
using System.Data.Entity;

namespace Catering.Data
{
    public class CateringContext : DbContext
    {
        public CateringContext() : base("Data Source=.; Initial Catalog = CateringDB; Integrated Security = true") { }

        public CateringContext(string connectionString) : base(connectionString)
        { }

        public DbSet<CateringOrder> CateringOrders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ChefType> ChefTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region CateringOrder
            modelBuilder.Entity<CateringOrder>()
                .ToTable("CateringOrders")
                .HasKey(x => x.Id);

            modelBuilder.Entity<CateringOrder>()
                .HasRequired(x => x.User)
                .WithMany(x => x.CateringOrders)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<CateringOrder>()
                .HasRequired(x => x.ChefType)
                .WithMany(x => x.CateringOrders)
                .HasForeignKey(x => x.ChefTypeId);

            #endregion
        }
    }
}
