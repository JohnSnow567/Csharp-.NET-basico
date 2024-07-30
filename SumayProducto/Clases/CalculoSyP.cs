using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumayProducto.Clases
{
    internal class CalculoSyP
    {
        public void Calcular()
        {
            // Declaramos las Variables //

            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int producto = 0;
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

                suma = (num1 + num2);
                producto = (num1 * num2);

                Console.WriteLine($"La suma es {suma} y el producto es {producto}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message} realizando la operacion");
            }
        }
    }
}
