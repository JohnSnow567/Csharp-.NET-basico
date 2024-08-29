using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionBuclesWhile.Clases
{
    public class _10NumerosSumayPromedio
    {
        public void Calcular10SumayPromedio()
        {
            try
            {
                //Creamos las variables
                int suma = 0;
                decimal promedio = 0;
                int i = 0;
                int numero = 0;

                //Creamos un bucle para preguntar al usuario los numeros a sumar

                while (i < 10)
                {
                    Console.Write($"Ingrese el número {i + 1}: ");
                    string linea = Console.ReadLine();
                   
                    if (int.TryParse(linea, out numero))
                    {
                        suma += numero;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("La cantidad es invalida.");
                        continue;
                    }
                    
                }

                //Almacenamos en una variable el promedio de los diez numeros
                promedio = (decimal)suma / 10;

                //Mostramos al usuario en pantalla la suma de los 10 numeros y su promedio
                Console.WriteLine($"La suma de los 10 números es: {suma}");
                Console.WriteLine($"El promedio aritmético de los 10 números es: {promedio}");
            }

            catch (Exception ex) 
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
    }
}
