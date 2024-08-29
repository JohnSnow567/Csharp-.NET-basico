using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesFor.Clases
{
    public class CalculoUltimos5
    {
        public void CalcularUltimos5()
        {
            try
            {
                // Creamos un array para almacenar los números que pediremos al usuario
                int[] numeros = new int[10];
                int sumaUltimos5 = 0;

                // Creamos el bucle for para que el usuario ingrese sus números
                for (int i = 0; i < 10; i++)
                {
                    while (true)
                    {
                        Console.WriteLine($"Ingrese el número {i + 1}: ");
                        string linea = Console.ReadLine();

                        if (int.TryParse(linea, out numeros[i]))
                        {
                            break; // Salimos del bucle si el valor es válido
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Asegúrese de ingresar un número entero.");
                            continue;
                        }
                    }

                    // Sumar los últimos 5 números en el mismo bucle
                    if (i >= 5)
                    {
                        sumaUltimos5 += numeros[i];
                    }
                }

                // Mostramos al usuario la suma de los últimos 5 números
                Console.WriteLine($"La suma de los últimos 5 números ingresados es: {sumaUltimos5}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }


        }
    }
}
