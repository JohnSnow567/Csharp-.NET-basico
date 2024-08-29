using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BuclesFor.Clases
{
    public class CalculoTriangulosBaseAreaAltura
    {
        public void CalcularAreaBaseAlturaTriangulos()
        {

            try
            {
                // Definimos las variables
                int numtriangulos = 0;
                int mayoresque12 = 0;
                decimal basetriangulo = 0;
                decimal alturatriangulo = 0;
                decimal areatriangulo = 0;
                string linea = string.Empty;

                // Solicitar al usuario ingresar la cantidad de triángulos a procesar
                while (true)
                {
                    Console.WriteLine("Ingrese la cantidad de triángulos a procesar: ");
                    linea = Console.ReadLine();

                    if (int.TryParse(linea, out numtriangulos) && numtriangulos > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cantidad inválida. Asegúrese de ingresar un número entero positivo.");
                    }
                }

                // Iterar sobre cada triángulo
                for (int i = 1; i <= numtriangulos; i++)
                {
                    Console.WriteLine($"\nTriángulo {i}:");

                    // Capturar la base del triángulo
                    while (true)
                    {
                        Console.WriteLine("Ingrese la base: ");
                        linea = Console.ReadLine();

                        if (decimal.TryParse(linea, out basetriangulo) && basetriangulo > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Base inválida. Asegúrese de ingresar un número positivo.");
                            continue;
                        }
                    }

                    // Capturar la altura del triángulo
                    while (true)
                    {
                        Console.WriteLine("Ingrese la altura: ");
                        linea = Console.ReadLine();

                        if (decimal.TryParse(linea, out alturatriangulo) && alturatriangulo > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Altura inválida. Asegúrese de ingresar un número positivo.");
                            continue;
                        }
                    }

                    // Calcular el área del triángulo
                    areatriangulo = (basetriangulo * alturatriangulo) / 2;

                    // Mostrar los datos del triángulo
                    Console.WriteLine($"Base: {basetriangulo}");
                    Console.WriteLine($"Altura: {alturatriangulo}");
                    Console.WriteLine($"Área: {areatriangulo}");

                    // Verificar si el área es mayor que 12 y contarla si es así
                    if (areatriangulo > 12)
                    {
                        mayoresque12++;
                    }
                }

                // Reportar la cantidad de triángulos con área superior a 12 unidades cuadradas
                Console.WriteLine($"\nCantidad de triángulos con un área superior a 12 unidades cuadradas: {mayoresque12}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }

           
        }
    }
}
