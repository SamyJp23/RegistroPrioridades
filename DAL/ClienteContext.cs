using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroPrioridades.Models;

namespace RegistroPrioridades;

public class ClienteContext : DbContext
{
    public ClienteContext(DbContextOptions<ClienteContext>Options)
    : base(Options){}

    DbSet<Clientes> Clientes{get;set;}
}
