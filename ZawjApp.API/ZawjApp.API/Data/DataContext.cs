using Microsoft.EntityFrameworkCore;
using ZawjApp.API.Models;

namespace ZawjApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Value> Values { get; set; }
    }
}