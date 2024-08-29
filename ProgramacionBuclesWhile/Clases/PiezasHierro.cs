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
                string input = "";

                // Pedimos al usuario que ingrese el número total de piezas
                while (true)
                {
                    Console.WriteLine("Ingrese el número total de piezas: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out numPiezas) && numPiezas > 0)
                    {
                        break; // Salimos del bucle si el valor es válido
                    }
                    else
                    {
                        Console.WriteLine("Cantidad inválida. Asegúrese de ingresar un número entero positivo.");
                        continue;
                    }
                }

                // Pedimos al usuario la longitud mínima de las piezas
                while (true)
                {
                    Console.WriteLine("Ingrese la longitud mínima del rango (en cm): ");
                    input = Console.ReadLine();
                    if (decimal.TryParse(input, out longitudMinima) && longitudMinima > 0)
                    {
                        break; // Salimos del bucle si el valor es válido
                    }
                    else
                    {
                        Console.WriteLine("Longitud mínima inválida. Asegúrese de ingresar un número positivo.");
                        continue;
                    }
                }

                // Pedimos al usuario la longitud máxima de las piezas
                while (true)
                {
                    Console.WriteLine("Ingrese la longitud máxima del rango (en cm): ");
                    input = Console.ReadLine();
                    if (decimal.TryParse(input, out longitudMaxima) && longitudMaxima > longitudMinima)
                    {
                        break; // Salimos del bucle si el valor es válido
                    }
                    else
                    {
                        Console.WriteLine("Longitud máxima inválida. Asegúrese de que sea mayor que la longitud mínima.");
                        continue;
                    }
                }

                while (i < numPiezas)
                {
                    // Pedimos al usuario la longitud de la pieza y la almacenamos en una variable
                    Console.WriteLine($"Ingrese la longitud de la pieza {i + 1} (en cm): ");
                    input = Console.ReadLine();
                    if (!decimal.TryParse(input, out longitudPieza) || longitudPieza <= 0)
                    {
                        Console.WriteLine("Longitud de pieza inválida. Asegúrese de ingresar un número positivo.");
                        continue;
                    }

                    // Si la longitud de la pieza es mayor que el mínimo y menor que el máximo, incrementamos el contador
                    if (longitudPieza >= longitudMinima && longitudPieza <= longitudMaxima)
                    {
                        contadorAptas++;
                        Console.WriteLine($"Pieza {i + 1} es apta"); // Imprimir la pieza apta directamente
                    }

                    i++;
                }

                // Desplegamos en pantalla el número de piezas que son aptas
                Console.WriteLine($"Número de piezas aptas para fabricar perfiles: {contadorAptas}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }

        }
    }
}
