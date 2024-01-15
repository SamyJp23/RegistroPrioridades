using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prioridad.Models;

namespace Prioridad.DAL
{
    public class PrioridadContext : DbContext
    {
        public PrioridadContext(DbContextOptions<PrioridadContext>Options)
        : base(Options){}
        public DbSet<Prioridades> Prioridades {get;set;}
    }
}