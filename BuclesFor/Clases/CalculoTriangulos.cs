using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesFor.Clases
{
    public class CalculoTriangulos
    {
        public void CalcularTriangulos()
        {
            try
            {
                //Definimos las variables a utilizar
                int numtriangulos = 0;
                int limitearea = 0;
                int contador = 0;
                decimal basetriangulo;
                decimal altura;
                decimal area;
                string linea = string.Empty;



                while (true)
                {
                    Console.WriteLine("Ingrese el número de triángulos: ");
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



                while (true)
                {
                    Console.Write("Ingrese el valor límite para el área: ");
                    linea = Console.ReadLine();

                    if (int.TryParse(linea, out limitearea) && limitearea > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cantidad inválida. Asegúrese de ingresar un número entero positivo.");
                    }
                }



                //Establecemos nuestro bucle for para hacer varios triangulos
                for (int i = 0; i < numtriangulos; i++)
                {
                    Console.WriteLine($"Triángulo {i + 1}:");

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

                        if (decimal.TryParse(linea, out altura) && altura > 0)
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
                    area = (basetriangulo * altura) / 2;

                    if (area > limitearea)
                    {
                        contador++;
                    }

                }

                Console.WriteLine($"Número de triángulos con área superior al límite: {contador}");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }   
    }
}
