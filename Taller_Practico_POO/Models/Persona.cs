using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.Models
{
    public class Persona
    {
        protected Guid Id { get; set; }
        protected string? Nombre { get; set; }
        protected string? Apellido { get; set; }
        protected string? TipoDocumento { get; set; }
        protected string? NumeroDocumento { get; set; }
        protected string? Email { get; set; }
        protected string? Telefono { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");            
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Tipo de documento: {TipoDocumento}");
            Console.WriteLine($"Numero de documento: {NumeroDocumento}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefono: {Telefono}");
        }
    }
}