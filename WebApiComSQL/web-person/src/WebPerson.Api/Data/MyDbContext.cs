using Microsoft.EntityFrameworkCore;
using WebPerson.Models;

namespace WebPerson.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
      : base(options)
        { }

        public DbSet<Person> Person { get; set; }
    }
}
