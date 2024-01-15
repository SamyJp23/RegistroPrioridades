using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prioridad.DAL;
using Prioridad.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;



namespace Prioridad.BLL
{

   
    public class PrioridadesBLL
    {
         private readonly PrioridadContext _context;
         public PrioridadesBLL(PrioridadContext context){

            _context = context;
         }

public bool Existe(int PrioridadId)
		{
			return _context.Prioridades.Any(s => s.IdPrioridad == PrioridadId);
		}
		
		private bool Insertar(Prioridades prioridad)
		{
			_context.Prioridades.Add(prioridad);
			int cantidad = _context.SaveChanges();
			return cantidad > 0;
		}
		
		private bool Modificar(Prioridades prioridad)
		{
			_context.Update(prioridad);
			int cantidad = _context.SaveChanges();
			return cantidad > 0;
		}

		public bool Guardar(Prioridades prioridad)
		{
			if (!Existe(prioridad.IdPrioridad))
				return Insertar(prioridad);
			else
				return Modificar(prioridad);
		}

		public bool Eliminar(Prioridades prioridad)
		{
			_context.Prioridades.Remove(prioridad);
			int cantidad = _context.SaveChanges();
			return cantidad > 0;
		}

		public Prioridades? Buscar(int PrioridadId)
		{
			return _context.Prioridades
				.AsNoTracking()
				.FirstOrDefault(s => s.IdPrioridad == PrioridadId);
		}

		public List<Prioridades> GetList(Expression<Func<Prioridades, bool>> Criterio)
		{
			return _context.Prioridades
				.Where(Criterio)
				.AsNoTracking()
				.ToList();
		}

    }
}