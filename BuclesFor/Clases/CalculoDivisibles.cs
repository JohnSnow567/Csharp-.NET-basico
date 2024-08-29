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
                //Definimos las variables
                int contadorDivisibles = 0;
                int numero = 0;

                for (int i = 0; i < 10;)
                {
                    //Pedimos al usuario que ingrese los numeros
                    Console.WriteLine($"Ingrese el número {i + 1}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out numero))
                    {
                        //Si alguno de los numeros ingresados es divisible por 3 o por 5, incrementamos el contador
                        if (numero % 3 == 0 || numero % 5 == 0)
                        {
                            contadorDivisibles++;
                        }

                        i++;

                    }
                    else
                    {
                        Console.WriteLine("Cantidad inválida. Asegúrese de ingresar un número entero positivo.");
                        continue;
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
