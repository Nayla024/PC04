using Microsoft.EntityFrameworkCore;
using PC04.Models;

namespace PC04.Data
{
    public class RegistroContext : DbContext
    {
        public DbSet<Registro> Registros { get; set; }

        public RegistroContext(DbContextOptions dco) : base(dco) {

        }
    }
    
}