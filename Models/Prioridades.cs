using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Prioridad.Models
{
    public class Prioridades
    {
        [Key]
        public int IdPrioridad{get;set;}

         [Required (ErrorMessage = "La descripcion es obligatoria")]
        public string? Descripcion{get;set;}
        public int DiasCompromiso{get;set;}
        
    }
}