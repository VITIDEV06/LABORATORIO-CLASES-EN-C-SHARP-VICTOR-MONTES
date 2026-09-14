using System;

namespace LibroCalificasiones_2
{
    public class LibroPruebaCalificaciones
    {
        static void Main(string[] args)
        {
            MiLibroCalificasiones MyLibro= new MiLibroCalificasiones();

            Console.WriteLine("Por favor ingrese el nombre del curso: ");

            string nombreCurso = Console.ReadLine();
            Console.WriteLine();

            MyLibro.MostrarMensaje(nombreCurso);
        }
    }
}