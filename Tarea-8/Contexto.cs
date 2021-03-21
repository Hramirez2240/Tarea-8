// Este es el contexto donde se indicará cuál base de datos usará
using Microsoft.EntityFrameworkCore;

namespace Tarea_8
{
    public class Contexto : DbContext
    {
        public DbSet<Modelos.Vacunados> Vacunadas { get; set; }
        public DbSet<Modelos.inventario> Inventarios { get; set; }
        public DbSet<Modelos.provincia> Provincias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {

            if (!option.IsConfigured)
            {

                option.UseMySql("Server=mysql5044.site4now.net;Database=db_a71057_registr;Uid=a71057_registr;Pwd=Hector123;");
            }
        }
    }
}
