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
                //Creamos un array para almacenar los numeros que pediremos al usuario
                int[] numeros = new int[10];

                //Creamos el bucle for para que el usuario ingrese sus numeros
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Ingrese el número {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                //Creamos una variable para almacenar los ultimos 5 numeros
                int sumaUltimos5 = 0;

                //Con un bucle for, iteramos sobre los ultimos 5 numeros
                for (int i = 5; i < 10; i++)
                {
                    sumaUltimos5 += numeros[i];
                }

                //Mostramos al usuario la suma de los ultimos 5 numeros
                Console.WriteLine($"La suma de los últimos 5 números ingresados es: {sumaUltimos5}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
            
        }
    }
}
