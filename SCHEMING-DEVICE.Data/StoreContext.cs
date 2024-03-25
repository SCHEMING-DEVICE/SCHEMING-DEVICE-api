using Microsoft.EntityFrameworkCore;
using Scheming.Device.Data;
using Scheming.Device.Domain.Catalog;
using Scheming.Device.Domain.Orders;

namespace SCHEMING_DEVICE.Data
{

    public class StoreContext : DbContext
{
        public StoreContext(DbContextOptions<StoreContext> options)
         : base(options)
        {}

        public DbSet<Item> Items { get; set;}

        public DbSet<Order> Orders { get; set;}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        
    }
}
}