using Microsoft.EntityFrameworkCore;
using transpositionAPI.Models;

namespace transpositionAPI.Context
{
    public class DBContexto : DbContext
    {
        public DBContexto(DbContextOptions<DBContexto> options) : base(options)
        {
        }

        public DbSet<Notas> notas { set; get; }
        public DbSet<Acordes> acordes { set; get; }

    }
}
