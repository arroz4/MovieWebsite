using Microsoft.EntityFrameworkCore;
using PeliculasAPI.Controllers;
using PeliculasAPI.Entidades;

namespace PeliculasAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<Genero> Generos
        {
            get;set;
        }

    }
}