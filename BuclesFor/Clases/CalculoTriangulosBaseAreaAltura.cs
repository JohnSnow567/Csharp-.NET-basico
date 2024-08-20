using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesFor.Clases
{
    public class CalculoTriangulosBaseAreaAltura
    {
        public void CalcularAreaBaseAlturaTriangulos()
        {
            try
            {

                //Definimos las variables
                int numtriangulos = 0;
                int mayoresque12 = 0;
                decimal basetriangulo = 0;
                decimal alturatriangulo = 0;
                decimal areatriangulo = 0;
                
                
                // Solicitar al usuario ingresar la cantidad de triángulos a procesar
                Console.WriteLine("Ingrese la cantidad de triángulos a procesar: ");
                numtriangulos = int.Parse(Console.ReadLine());


                // Iterar sobre cada triángulo
                for (int i = 1; i <= numtriangulos; i++)
                {
                    Console.WriteLine($"\nTriángulo {i}:");

                    // Capturar la base y la altura del triángulo
                    Console.WriteLine("Ingrese la base: ");
                    basetriangulo = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura: ");
                    alturatriangulo = decimal.Parse(Console.ReadLine());

                    // Calcular el área del triángulo
                    areatriangulo = (basetriangulo * alturatriangulo) / 2;

                    // Mostrar los datos del triángulo
                    Console.WriteLine($"Base: {basetriangulo}");
                    Console.WriteLine($"Altura: {alturatriangulo}");
                    Console.WriteLine($"Área: {areatriangulo}");

                    // Verificar si el área es mayor a 12 y actualizar el contador
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
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
    }
}
