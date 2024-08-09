using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionCondicional.Clases
{
    public class CalculoNivel
    {
        public void CalcularNivel()
        {
            try
            {
                //Declaramos las variables a usar
                int totalpreguntas;
                int respuestascorrectas;
                double porcentajeaciertos;
                string nivel;
                string linea = string.Empty;


                // Solicitar el número total de preguntas
                Console.WriteLine("Ingrese el número total de preguntas: ");
                linea = Console.ReadLine();

                // Verificamos que sea diferente de vacio
                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El numero total de preguntas es requerido.");
                    return;

                }

                //Verificamos que sea un dato valido
                if (!int.TryParse(linea, out totalpreguntas))
                {
                    Console.WriteLine("Entrada invalida, favor de ingresar un numero.");
                    return;

                }
                else
                {
                    totalpreguntas = Convert.ToInt32(linea);
                }

               

                // Solicitar el número de respuestas correctas
                Console.Write("Ingrese el número de respuestas correctas: ");
                linea = Console.ReadLine();

                // Verificamos que sea diferente de vacio
                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El numero total de respuestas es requerido.");
                    return;

                }

                //Verificamos que sea un dato valido
                if (!int.TryParse(linea, out respuestascorrectas))
                {
                    Console.WriteLine("Entrada invalida, favor de ingresar un numero.");
                    return;

                }
                else
                {
                    respuestascorrectas = Convert.ToInt32(linea);
                }


                // Calcular el porcentaje de aciertos
                porcentajeaciertos = (double)respuestascorrectas / totalpreguntas * 100;
                //porcentajeaciertos = Convert.ToDouble(respuestascorrectas / totalpreguntas * 100);
 

                // Determinar el nivel del postulante


                if (porcentajeaciertos >= 90)
                {
                    nivel = "Nivel máximo";
                }
                else if (porcentajeaciertos >= 75)
                {
                    nivel = "Nivel medio";
                }
                else if (porcentajeaciertos >= 50)
                {
                    nivel = "Nivel regular";
                }
                else
                {
                    nivel = "Fuera de nivel";
                }

                // Mostrar el resultado
                Console.WriteLine($"Porcentaje de aciertos: {porcentajeaciertos:F2}%");
                Console.WriteLine($"Nivel del postulante: {nivel}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }

        }
    }
}
