using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecioyCantidad.Clases
{
    internal class Calculo
    {
        public void Calcular()
        {
            //Declaramos las variables
            int precio = 0;
            int cantidad = 0;
            decimal total = 0;
            string linea = string.Empty;

            try
            {
                // Solicitar el precio del artículo
                Console.WriteLine("Ingrese el precio del artículo: ");
                linea = Console.ReadLine();

                // Validamos el tipo de datos
                if (!int.TryParse(linea, out precio))
                {
                    Console.WriteLine("El precio es invalido.");
                    return;
                }

                // Solicitar la cantidad de artículos
                Console.Write("Ingrese la cantidad que lleva el cliente: ");
                linea = Console.ReadLine();

                // Validamos el tipo de datos
                if (!int.TryParse(linea, out cantidad))
                {
                    Console.WriteLine("La cantidad es invalida.");
                    return;
                }

                // Calcular el total a abonar
                total = (precio * cantidad);

                // Mostrar el total a abonar
                Console.WriteLine($"El total a abonar es: {total}");

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message} realizando la operacion");
            }

        }
    }
}
