using EFCoreCurdStoreProcedure.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCurdStoreProcedure.Context
{
    public class DatabaseContex : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Data Source=DESKTOP-VELMG60;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            options.UseSqlServer(connectionString);
        }

        public DbSet<Student> Students { get; set; }
    }
}
