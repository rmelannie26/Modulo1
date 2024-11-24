using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Modulo1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EntidadFinanciera> EntidadesFinancieras { get; set; }
        public DbSet<TipoEntidad> TiposEntidad { get; set; }
    }
