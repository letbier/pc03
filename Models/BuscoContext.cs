using Microsoft.EntityFrameworkCore;

namespace busco.Models
{
    public class BuscoContext : DbContext
    {

        public DbSet<Categoria> Categoria{get;set;}
        public DbSet<Cliente> Clientes{get;set;}


        public BuscoContext(DbContextOptions dco) : base(dco) {

        }
    }
}