using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionClasesyObjetos.Ejercicios
{
    public class PuntosPlano
    {

        public int x;
        public int y;
        public void Inicializar()
        {
            try
            {
                string linea;
                while (true)
                {
                    Console.WriteLine("Ingrese la coordenada x: ");
                    linea = Console.ReadLine();

                    if (int.TryParse(linea, out x))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Asegúrese de ingresar un número valido");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Ingrese la coordenada y: ");
                    linea = Console.ReadLine();

                    if (int.TryParse(linea, out y))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Asegúrese de ingresar un número valido");
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");

            }

        }

        public void ImprimirCuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.Write("Se encuentra en el primer cuadrante.");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.Write("Se encuentra en el segundo cuadrante.");
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.Write("Se encuentra en el tercer cuadrante.");
                    }
                    else
                    {
                        if (x > 0 && y < 0)
                        {
                            Console.Write("Se encuentra en el cuarto cuadrante.");
                        }
                        else
                        {
                            Console.Write("El punto no está en un cuadrante.");
                        }
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
