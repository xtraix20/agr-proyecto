using Microsoft.EntityFrameworkCore;
using ProyectoAgro.Dominio;


namespace ProyectoAgro.Persistencia
{
   public class AppContex: DbContext
   {
       public DbSet<Persona> Personas{get;set;}
       public DbSet<DueñoFinca> DueñosFincas{get;set;}       
       public DbSet<Finca> Fincas{get;set;}       
       public DbSet<Insumo> Insumos{get;set;}
       public DbSet<LiderObra> LideresObras{get;set;}
       public DbSet<Lote> Lotes{get;set;}
       public DbSet<Material> Materiales{get;set;}
       public DbSet<Trabajador> Trabajadores{get;set;}
       public DbSet<Trazabilidad> trazabilidades{get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        optionsBuilder
        .UseSqlServer("Data Source=(Localdb)\\mssqllocaldb;Initial Catalog=ProyectoAgro");
        }
        
    }
   } 

} 