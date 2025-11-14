
using LavadoAuto.Infretruture.Model;
using Microsoft.EntityFrameworkCore;


namespace LavadoAuto.Infretruture.Data
{
    public class LavadoAutosContext : DbContext
    {
        public LavadoAutosContext(DbContextOptions<LavadoAutosContext> options) : base(options)
        {
        }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<VehiculoModel> Vehiculos { get; set; }
        public DbSet<EmpleadoModel> Empleados { get; set; }
        public DbSet<ServicioModel> Servicios { get; set; }
        public DbSet<TicketModel> Tickets { get; set; }

    }
}
