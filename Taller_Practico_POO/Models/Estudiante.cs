using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.Models
{
    public class Estudiante : Persona
    {
        public string NombreAcudiente { get; set; }
        public string CursoActual { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public List<double> Calificaciones { get; set; }

        public Estudiante(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono, string nombreAcudiente, string cursoActual, DateOnly fechaNacimiento)
        {
            this.Id = new Guid();
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;
            this.Email = email;
            this.Telefono = telefono;
            this.NombreAcudiente = nombreAcudiente;
            this.CursoActual = cursoActual;
            this.FechaNacimiento = fechaNacimiento;
            this.Calificaciones = new List<double>();
        }

        public void AgregarCalificaciones(double calificacion)
        {
            Calificaciones.Add(calificacion);
        }

        private void CalcularPromedio()
        {
            Console.WriteLine($"Promedio: {Calificaciones.Average()}");
        }

        public int CalcularEdad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year; 
        }

        public void MostrarCalificaciones()
        {
            foreach (var calificacion in Calificaciones)
            {
                Console.WriteLine($"{calificacion},");
            }
        }

        public override void MostrarDetalles() //override -> permite sobreescribir
        {
            Console.WriteLine($"Rol: Estudiante");
            base.MostrarDetalles();
            Console.WriteLine($"Nombre Acudiente: {NombreAcudiente}");
            Console.WriteLine($"Curso Actual: {CursoActual}");
            Console.WriteLine($"Edad: {CalcularEdad()} años");
            Console.WriteLine("Calificaciones: ");
            MostrarCalificaciones();
            CalcularPromedio();
        }
    }
}