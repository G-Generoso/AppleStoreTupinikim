using AppleStoreTupinikim.Models;
using Microsoft.EntityFrameworkCore;



namespace AppleStoreTupinikim.Data
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto>options):base(options) { }
        public DbSet<Produto> produto { get; set; }
    }
}
