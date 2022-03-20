using CatalogoDeMusicas.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoDeMusicas.Data
{
    public class TabelaBd : DbContext
    {
        public TabelaBd(DbContextOptions<TabelaBd> options) : base(options) { }

        public DbSet<cadastro> Cadastro { get; set; }
    }
}
