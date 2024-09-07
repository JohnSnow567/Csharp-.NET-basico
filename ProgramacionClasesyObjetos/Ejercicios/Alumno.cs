using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionClasesyObjetos.Ejercicios
{
    public class Alumno
    {
        // Propiedades
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public List<int> Calificaciones { get; set; }

        // Constructor
        public Alumno(string nombre, string matricula, string carrera, List<int> calificaciones)
        {
            Nombre = nombre;
            Matricula = matricula;
            Carrera = carrera;
            Calificaciones = calificaciones;
        }

        // Método para calcular el promedio de las calificaciones
        public double CalcularPromedio()
        {
            if (Calificaciones.Count == 0)
            {
                return 0; // Evitar división entre 0 si no hay calificaciones
            }
            return Calificaciones.Average();
        }

        // Método para mostrar la información del alumno
        public void MostrarInformacion()
        {
            double promedio = CalcularPromedio();
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Promedio: {promedio:F2}");
        }
    }

}
