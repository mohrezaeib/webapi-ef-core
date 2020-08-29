using Microsoft.EntityFrameworkCore;
using webapi.CoreEntities.Models;
using webapi.Infrastructure.EF.Configurations;

namespace webapi.InfrastructureEF
{
    
    public class StoreContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public StoreContext( DbContextOptions<StoreContext> options): base(options)
        {
            
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CarConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
           
        
        }
    }
}