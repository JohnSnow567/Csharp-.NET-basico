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
                int numtriangulos;
                int limitearea;
                int contador = 0;
                double basetriangulo;
                double altura;
                double area;
                string linea = string.Empty;



                Console.WriteLine("Ingrese el número de triángulos: ");
                linea = Console.ReadLine();

                // Verificamos que sea diferente de vacio
                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El numero de triangulos es requerido.");
                    return;

                }

                //Verificamos que sea un dato valido
                if (!int.TryParse(linea, out numtriangulos))
                {
                    Console.WriteLine("El numero de triangulos es invalido.");
                    return;

                }
                else
                {
                    numtriangulos = Convert.ToInt32(linea);
                }

                Console.Write("Ingrese el valor límite para el área: ");
                linea = Console.ReadLine();

                // Verificamos que sea diferente de vacio
                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor del area es requerido.");
                    return;

                }

                //Verificamos que sea un dato valido
                if (!int.TryParse(linea, out limitearea))
                {
                    Console.WriteLine("El valor del area es invalido.");
                    return;

                }
                else
                {
                    limitearea = Convert.ToInt32(linea);
                }


                //Establecemos nuestro bucle for para hacer varios triangulos
                for (int i = 0; i < numtriangulos; i++)
                {
                    Console.WriteLine($"Triángulo {i + 1}:");
                    Console.Write("Base: ");
                    basetriangulo = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    altura = double.Parse(Console.ReadLine());

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
