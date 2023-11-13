using Cok_Cok_İliskisel_Db.Entity;
using Cok_Cok_İliskisel_Db.MainEntity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Cok_Cok_İliskisel_Db.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Person> People { get; set; }
        public DbSet<Name> names { get; set; }
        public DbSet<SurName> Surnames { get; set; }
        public DbSet<Age> Ages { get; set; }



    }
}
