using APIwithCQRSMediatr.Models;
using Microsoft.EntityFrameworkCore;

namespace APIwithCQRSMediatr.DataAccess
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {                
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
