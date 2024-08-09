using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionCondicional.Clases
{
    internal class CalculoNumeros
    {
        public void CalcularNumeros()
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int resta = 0;
            decimal division = 0;
            int producto = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Ingrese el valor del numero 1: ");
                linea = Console.ReadLine();


                // Verificamos que sea diferente de vacio
                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El numero 1 es requerido.");
                    return;

                }

                //Verificamos que sea un dato valido
                if (!int.TryParse(linea, out num1))
                {
                    Console.WriteLine("El numero 1 es invalido.");
                    return;

                }
                else
                {
                    num1 = Convert.ToInt32(linea);
                }

                Console.WriteLine("Ingrese el valor del numero 2: ");
                linea = Console.ReadLine();

                // Verificamos que sea diferente de vacio
                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El numero 2 es requerido");
                    return;

                }

                //Verificamos que sea un dato valido
                if (!int.TryParse(linea, out num2))
                {
                    Console.WriteLine("El numero 2 es invalido.");
                    return;

                }
                else
                {
                    num2 = Convert.ToInt32(linea);
                }

                if (num1 > num2)
                {
                    suma = num1 + num2;
                    resta = num2 - num1;

                    Console.WriteLine($"La suma es: {suma} y la resta: {resta}");

                }
                else
                {
                    producto = num1 * num2;
                    division = (num1 / num2);

                    Console.WriteLine($"El producto es: {producto} y la division: {division}");

                }

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }

        }
    }
}
