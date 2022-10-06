using Microsoft.EntityFrameworkCore;
using webApiAut.Entidades;

namespace webApiAut
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
    }
}
