using System;
using System.Timers;

namespace LibroCalificaciones_3
{
    public class LibroPruebaCalificaciones
    {
        static void Main(string[] args)
        {
            LibroCalificaciones MyLibro = new LibroCalificaciones("CS101 Programacion en C#");
            LibroCalificaciones MyLibro2 = new LibroCalificaciones("CS102 Estructura de datos");
            Console.WriteLine("El nombre nombre del curso es: {0}", MyLibro);
            Console.WriteLine("El nombre nombre del curso es: {0}", MyLibro2);

            Console.WriteLine("\nEscriba El nombre del curso: ");
            string elNombreCurso = Console.ReadLine();
            MyLibro.NombreCurso = elNombreCurso;
            Console.WriteLine("El nombre del curso es: {0}", MyLibro.NombreCurso);

        }
    }
}
