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

                // Solicitar al usuario ingresar la cantidad de empleados
                Console.Write("Ingrese la cantidad de empleados: ");
                n = int.Parse(Console.ReadLine());

                // Iterar sobre cada empleado
                while (i < n)
                {
                    // Capturar el sueldo del empleado
                    Console.Write($"Ingrese el sueldo del empleado {i + 1}: ");
                    sueldo = decimal.Parse(Console.ReadLine());

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
