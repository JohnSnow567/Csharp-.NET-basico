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
                //Creamos una variable para la suma
                int suma = 0;

                //Creamos un bucle para preguntar al usuario los numeros a sumar
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Ingrese el número {i + 1}: ");
                    int numero = int.Parse(Console.ReadLine());
                    suma += numero;
                }

                //Almacenamos en una variable el promedio de los diez numeros
                double promedio = (double)suma / 10;

                //Mostramos al usuario en pantalla la suma de los 10 numeros y su promedio
                Console.WriteLine($"La suma de los 10 números es: {suma}");
                Console.WriteLine($"El promedio aritmético de los 10 números es: {promedio:F2}");
            }

            catch (Exception ex) 
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
    }
}
