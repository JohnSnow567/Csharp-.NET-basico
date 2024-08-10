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
                //Pedimos al usuario que ingrese el numero total de piezas
                Console.WriteLine("Ingrese el número total de piezas: ");
                int numPiezas = int.Parse(Console.ReadLine());

                //Pedimos al usuario la longitud minima de las piezas
                Console.WriteLine("Ingrese la longitud mínima del rango (en cm): ");
                double longitudMinima = double.Parse(Console.ReadLine());

               //Pedimos al usuario la longitud maxima de las piezas
                Console.WriteLine("Ingrese la longitud máxima del rango (en cm): ");
                double longitudMaxima = double.Parse(Console.ReadLine());

               //Creamos una variable para almacenar las piezas aptas
                int contadorAptas = 0;

                //Creamos un bucle for para iterar sobre el numero de piezas que quiere el usuario
                for (int i = 0; i < numPiezas; i++)
                {
                    
                    //Pedimos al usuario la longitud de la pieza y la almacenamos en una variable
                    Console.WriteLine($"Ingrese la longitud de la pieza {i + 1} (en cm): ");
                    double longitudPieza = double.Parse(Console.ReadLine());

                    //Si la longitud de la pieza es mayor que el minimo y menor que el maximo, incrementamos el contador
                    if (longitudPieza >= longitudMinima && longitudPieza <= longitudMaxima)
                    {
                        contadorAptas++;
                    }
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
