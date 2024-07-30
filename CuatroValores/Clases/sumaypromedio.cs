using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuatroValores.Clases
{
    internal class sumaypromedio
    {
        public void Calcular()
        {
            // Declaramos las Variables //

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int suma = 0;
            int promedio = 0;
            string linea = string.Empty;

            try
            {
                // Pedimos los numeros

                Console.WriteLine("Ingrese el primer numero: ");
                linea = Console.ReadLine();

                // Validamos el tipo de datos
                if (!int.TryParse(linea, out num1))
                {
                    Console.WriteLine("El numero 1 es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el segundo numero: ");
                linea = Console.ReadLine();

                // Validamos el tipo de datos
                if (!int.TryParse(linea, out num2))
                {
                    Console.WriteLine("El numero 2 es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el tercer numero: ");
                linea = Console.ReadLine();

                // Validamos el tipo de datos
                if (!int.TryParse(linea, out num3))
                {
                    Console.WriteLine("El numero 3 es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el cuarto numero: ");
                linea = Console.ReadLine();

                // Validamos el tipo de datos
                if (!int.TryParse(linea, out num4))
                {
                    Console.WriteLine("El numero 4 es invalido.");
                    return;
                }

                suma = (num1 + num2 + num3 + num4);
                promedio = ((num1 + num2 + num3 + num4) / 4);

                Console.WriteLine($"La suma es {suma} y el promedio es {promedio}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message} realizando la operacion");
            }
        }
    }
}

