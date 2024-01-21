using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroPrioridades
{
    public class Clientes
    {
        [Key]
        public int IdCliente {get;set;}
        public string? Nombres{get;set;}
        public string? Telefono{get;set;}

        public string? Celular{get;set;}

        public string? Rnc{get;set;}
        public string? Email{get;set;}

        public string? Direccion{get;set;}

    }
}
