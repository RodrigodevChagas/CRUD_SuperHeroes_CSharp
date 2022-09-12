using CRUD_Escolinha.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Escolinha.Data
{
    public class HeroiContext: DbContext
    {
        public HeroiContext(DbContextOptions<HeroiContext> opts): base(opts){ }

        public DbSet<Cadastro_Herois> cadastro_Herois { get; set; }
    }
}
