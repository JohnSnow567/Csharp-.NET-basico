using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesFor.Clases
{
    public class CalculoDivisibles
    {
        public void CalcularDivisibles()
        {

            try
            {
                //Definimos una variable para almacenar el numero de divisibles
                int contadorDivisibles = 0;

                for (int i = 0; i < 10; i++)
                {
                    //Pedimos al usuario que ingrese los numeros
                    Console.WriteLine($"Ingrese el número {i + 1}: ");
                    int numero = int.Parse(Console.ReadLine());

                    //Si alguno de los numeros ingresados es divisible por 3 o por 5, incrementamos el contador
                    if (numero % 3 == 0 || numero % 5 == 0)
                    {
                        contadorDivisibles++;
                    }
                }
                
                //Mostramos en pantalla
                Console.WriteLine($"Cantidad de números divisibles por 3 o por 5: {contadorDivisibles}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
           
        }

    }
    
}
