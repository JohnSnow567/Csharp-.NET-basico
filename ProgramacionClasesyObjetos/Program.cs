using ProgramacionClasesyObjetos.Ejercicios;
class Program
{
    static void Main(string[] args)
    {
        //PuntosPlano puntosPlano = new PuntosPlano();

        //puntosPlano.Inicializar();
        //puntosPlano.ImprimirCuadrante();  // Ejercicio 1



        //// Creamos una instancia del libro
        //Libro libro = new Libro("Don Quijote", "Miguel de Cervantes", 863);

        //// Mostramos la información del libro
        //libro.MostrarInformacion();

        //// Verificamos si el libro es largo
        //if (libro.EsLargo())
        //{
        //    Console.WriteLine("El libro es largo.");
        //}
        //else
        //{
        //    Console.WriteLine("El libro no es largo."); // Ejercicio 2
        //}


        // Creamos instancias de la clase Alumno
        Alumno alumno1 = new Alumno(
            "Juan Pérez",
            "A12345",
            "Ingeniería en Sistemas",
            new List<int> { 85, 90, 78, 92, 88 });

        Alumno alumno2 = new Alumno(
            "María López",
            "B54321",
            "Medicina",
            new List<int> { 95, 89, 93, 88, 92 });

        // Mostramos información de los alumnos
        Console.WriteLine("Información del Alumno 1:");
        alumno1.MostrarInformacion();
        Console.WriteLine();

        Console.WriteLine("Información del Alumno 2:");
        alumno2.MostrarInformacion(); // Ejercicio 3 


    }
}
