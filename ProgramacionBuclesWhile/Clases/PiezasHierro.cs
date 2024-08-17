using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionBuclesWhile.Clases
{
    public class PiezasHierro
    {
        public void CalcularPiezasHierro()
        {
            try
            {
                int numPiezas = 0;
                decimal longitudMinima = 0;
                decimal longitudMaxima = 0;
                decimal longitudPieza = 0;
                int contadorAptas = 0;
                int i = 0;
                
                //Pedimos al usuario que ingrese el numero total de piezas
                Console.WriteLine("Ingrese el número total de piezas: ");
                numPiezas = int.Parse(Console.ReadLine());

                //Pedimos al usuario la longitud minima de las piezas
                Console.WriteLine("Ingrese la longitud mínima del rango (en cm): ");
                longitudMinima = decimal.Parse(Console.ReadLine());

               //Pedimos al usuario la longitud maxima de las piezas
                Console.WriteLine("Ingrese la longitud máxima del rango (en cm): ");
                longitudMaxima = decimal.Parse(Console.ReadLine());


                while ( i < numPiezas)
                {
                    //Pedimos al usuario la longitud de la pieza y la almacenamos en una variable
                    Console.WriteLine($"Ingrese la longitud de la pieza {i + 1} (en cm): ");
                    longitudPieza = decimal.Parse(Console.ReadLine());

                    //Si la longitud de la pieza es mayor que el minimo y menor que el maximo, incrementamos el contador
                    if (longitudPieza >= longitudMinima && longitudPieza <= longitudMaxima)
                    {
                        contadorAptas++;
                        Console.WriteLine($"Pieza {i + 1} es apta"); // Imprimir la pieza apta directamente
                    }

                    i++;
                }

                //Desplegamos en pantalla el numero de piezas que son aptas
                Console.WriteLine($"Número de piezas aptas para fabricar perfiles: {contadorAptas}");

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
    }
}
