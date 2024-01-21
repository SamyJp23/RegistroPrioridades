using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace RegistroPrioridades;

public class ClientesBLL
{


          private readonly ClienteContext _contexto;

        public ClientesBLL(ClienteContext contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(string nombres)
        {
            return _contexto.Clientes.Any(s => s.Nombres == nombres);
        }

        private bool Insertar(Clientes cliente)
        {
            _contexto.Clientes.Add(cliente);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        private bool Modificar(Clientes cliente)
        {
            _contexto.Update(cliente);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public bool Guardar(Clientes cliente)
        {
            if (!Existe(cliente.Nombres))
                return Insertar(cliente);
            else
                return Modificar(cliente);
        }

        public bool Eliminar(Clientes cliente)
        {
            _contexto.Remove(cliente);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public Clientes? Buscar(int clienteId)
        {
            return _contexto.Clientes
                .AsNoTracking()
                .FirstOrDefault(s => s.IdCliente == clienteId);
        }

        public List<Clientes> GetList(Expression<Func<Clientes, bool>> Criterio)
        {
            return _contexto.Clientes
                .Where(Criterio)
                .AsNoTracking()
                .ToList();
        }
        
    }
    
