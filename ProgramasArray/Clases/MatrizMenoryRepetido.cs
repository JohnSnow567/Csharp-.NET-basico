using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramasArray.Clases
{
    public class MatrizMenoryRepetido
    {
        public static void CalculoMatriz()
        {
            try
            {
                // Solicitar la cantidad de números a ingresar con validación
                int n = LeerCantidadNumeros();

                // Crear la lista para almacenar los números
                List<int> numeros = LeerNumeros(n);

                // Determinar el menor valor
                int menorValor = numeros.Min();
                Console.WriteLine($"El menor valor es: {menorValor}");

                // Determinar si algún valor se repite
                bool hayRepetidos = HayValoresRepetidos(numeros);
                Console.WriteLine(hayRepetidos ? "Hay al menos un valor que se repite." : "No hay valores repetidos.");

                static int LeerCantidadNumeros()
                {
                    int n;
                    while (true)
                    {
                        Console.WriteLine("Ingrese la cantidad de números:");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out n) && n > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida. Asegúrese de ingresar un número entero positivo.");
                        }
                    }
                    return n;
                }

                static List<int> LeerNumeros(int n)
                {
                    List<int> numeros = new List<int>();
                    Console.WriteLine("Ingrese los números:");
                    for (int i = 0; i < n; i++)
                    {
                        while (true)
                        {
                            Console.WriteLine($"Número {i + 1}: ");
                            string input = Console.ReadLine();

                            if (int.TryParse(input, out int num))
                            {
                                numeros.Add(num);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Asegúrese de ingresar un número entero.");
                            }
                        }
                    }
                    return numeros;
                }

                static bool HayValoresRepetidos(List<int> numeros)
                {
                    return numeros.GroupBy(x => x).Any(g => g.Count() > 1);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
    }
}

