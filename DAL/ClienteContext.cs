using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace RegistroPrioridades;

public class ClienteContext : DbContext
{
    public ClienteContext(DbContextOptions<ClienteContext>Options)
    : base(Options){}

    public DbSet<Clientes> Clientes{get;set;}
}
