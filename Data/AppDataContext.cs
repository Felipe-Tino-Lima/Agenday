using Agenday.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenday.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
            Agendamentos = Set<Agendamentos>();
        }

        // Classes que vão se tornar tabelas no banco de dados
        public DbSet<Agendamentos> Agendamentos { get; set; }
    }
}
