using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CalcularNotas.Clases
{
    public class Calificaciones
    {
        public void CalcularNumeros()
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int resta = 0;
            decimal division = 0;
            int producto = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Ingrese el valor del numero 1: ");
                linea = Console.ReadLine();

                
                // Verificamos que sea diferente de vacio
                if (string.IsNullOrEmpty(linea)) 
                {
                    Console.WriteLine("El numero 1 es requerido.");
                    return;
                
                }

                //Verificamos que sea un dato valido
                if (!int.TryParse(linea, out num1))
                {
                    Console.WriteLine("El numero 1 es invalido.");
                    return;

                }
                else
                {
                    num1 = Convert.ToInt32(linea);
                }

                Console.WriteLine("Ingrese el valor del numero 2: ");
                linea = Console.ReadLine();

                // Verificamos que sea diferente de vacio
                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El numero 2 es requerido");
                    return;

                }

                //Verificamos que sea un dato valido
                if (!int.TryParse(linea, out num2))
                {
                    Console.WriteLine("El numero 2 es invalido.");
                    return;

                }
                else
                {
                    num2 = Convert.ToInt32(linea);
                }

                if (num1 > num2)
                {
                    suma = num1 + num2;
                    resta = num2 - num1;

                    Console.WriteLine($"La suma es: {suma} y la resta: {resta}");

                }
                else
                {
                    producto = num1 * num2;
                    division = (num1 / num2);

                    Console.WriteLine($"El producto es: {producto} y la division: {division}");

                }

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
            
        }

        public void CalculoCalificaciones()
        {
            //Leer 3 calificaciones y calcular el promedio,
            //si es > 7 imprimir mensaje de alummno aprobado


            //Definimos las variables

            decimal calificacion1 = 0;
            decimal calificacion2 = 0;
            decimal calificacion3 = 0;
            decimal promedio = 0;
            string linea = string.Empty;

            try
            {
                //Ingresamos el primer valor
                Console.WriteLine("Ingrese el valor de la calificacion 1: ");
                linea = Console.ReadLine();


                // Verificamos que sea diferente de vacio
                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("La calificacion 1 es requerida.");
                    return;

                }

                //Verificamos que sea un dato valido
                if (!decimal.TryParse(linea, out calificacion1))
                {
                    Console.WriteLine("La calificacion 1 es invalida.");
                    return;

                }
                else
                {
                    calificacion1 = Convert.ToDecimal(linea);
                }

                //Ingresamos el segundo valor
                Console.WriteLine("Ingrese el valor de la calificacion 2: ");
                linea = Console.ReadLine();

                // Verificamos que sea diferente de vacio
                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("La calificacion 2 es requerida");
                    return;

                }

                //Verificamos que sea un dato valido
                if (!decimal.TryParse(linea, out calificacion2))
                {
                    Console.WriteLine("La calificacion 2 es invalida.");
                    return;

                }
                else
                {
                    calificacion2 = Convert.ToDecimal(linea);
                }

                //Ingresamos el tercer valor
                Console.WriteLine("Ingrese el valor de la calificacion 3: ");
                linea = Console.ReadLine();

                // Verificamos que sea diferente de vacio
                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("La calificacion 3 es requerida");
                    return;

                }

                //Verificamos que sea un dato valido
                if (!decimal.TryParse(linea, out calificacion3))
                {
                    Console.WriteLine("La calificacion 3 es invalida.");
                    return;

                }
                else
                {
                    calificacion3 = Convert.ToDecimal(linea);
                }

                //Calculamos en una variable el promedio
                promedio = (calificacion1 + calificacion2 + calificacion3) / 3;


                //Si el promedio es mayor que 7, imprimimos mensaje de aprobado
                if (promedio > 7)
                {
                    Console.WriteLine($"Su promedio de calificaciones es de: {promedio} ");
                    Console.WriteLine("Usted ha aprobado");

                }

                //Si el promedio es menor que 7, imprimimos mensaje de reprobado
                else
                {
                    Console.WriteLine($"Su promedio de calificaciones es de: {promedio} ");
                    Console.WriteLine("Usted no ha aprobado");
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }

        }

    }
    
}
