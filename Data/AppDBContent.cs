using Microsoft.EntityFrameworkCore;
using Saite_1.Data.Models;

namespace Saite_1.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        { }
        public DbSet<Car> Car {get; set;}
        public DbSet<Category> Categories { get; set; }
    }
}
