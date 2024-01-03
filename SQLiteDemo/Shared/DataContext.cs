using Microsoft.EntityFrameworkCore;
using SQLiteDemo.Shared.Models;

namespace SQLiteDemo.Shared
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
