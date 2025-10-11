using Microsoft.EntityFrameworkCore;
using tienda_videojuegos.Model.Entities;

namespace tienda_videojuegos.DbContex
{
    public class videogamescontext:DbContext
    {
        public videogamescontext(DbContextOptions<videogamescontext> options) : base(options)
        {
        }
        public DbSet<Employe> Employers { get; set; }
    }
}
