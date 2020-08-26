using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Data
{
    
    public class StoreContext : DbContext
    {
        public StoreContext( DbContextOptions<StoreContext> options): base(options)
        {
            
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}