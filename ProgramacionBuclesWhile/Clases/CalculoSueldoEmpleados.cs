using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionBuclesWhile.Clases
{
    public class CalculoSueldoEmpleados
    {
        public void CalcularSueldoEmpleados()
        {
            try
            {
                //Declaramos las variables a usar
                int n = 0;
                int contadorentre100y300 = 0;
                int contadormayorde300 = 0;
                decimal sueldo = 0;
                decimal totalSueldo = 0;
                int i = 0;
                string linea = string.Empty;

                // Solicitar al usuario ingresar la cantidad de empleados
                while (true)
                {
                    Console.WriteLine("Ingrese la cantidad de empleados: ");
                    linea = Console.ReadLine();

                    if (int.TryParse(linea, out n))
                    {
                        break; // Salimos del bucle si el valor es válido
                    }
                    else
                    {
                        Console.WriteLine("Cantidad inválida. Asegúrese de ingresar un número entero positivo.");
                        continue;
                    }
                }
               

                // Iterar sobre cada empleado
                while (i < n)
                {
                    // Capturar el sueldo del empleado
                    Console.WriteLine($"Ingrese el sueldo del empleado {i + 1}: ");
                    linea = Console.ReadLine();

                    if (decimal.TryParse(linea, out sueldo))
                    {
                        // Sumar el sueldo al total de sueldos
                        totalSueldo += sueldo;

                        // Verificar en qué rango se encuentra el sueldo y actualizar los contadores
                        if (sueldo >= 100 && sueldo <= 300)
                        {
                            contadorentre100y300++;
                        }
                        else if (sueldo > 300)
                        {
                            contadormayorde300++;
                        }

                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Cantidad inválida. Asegúrese de ingresar un número entero positivo.");
                        continue;
                    }

                }

                // Mostrar resultados
                Console.WriteLine($"\nCantidad de empleados que cobran entre $100 y $300: {contadorentre100y300}");
                Console.WriteLine($"Cantidad de empleados que cobran más de $300: {contadormayorde300}");
                Console.WriteLine($"Total que gasta la empresa en sueldos: ${totalSueldo}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
    }
}
