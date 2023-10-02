using Agenday.AgendamentoController;
using Microsoft.EntityFrameworkCore;
using Agenday.Models;

namespace Agenday.Data;
public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {

    }


}