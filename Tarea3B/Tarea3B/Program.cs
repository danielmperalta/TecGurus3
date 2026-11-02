using System.Numerics;

namespace Tarea3B
{
    public class Program
    {
        static void Main(string[] args)
        {
            int filas, columnas, total;

            Valores valores = new Valores();

            Console.Write("");
            
            Console.Write("Introducir numero de filas: ");
            filas = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Introducir numero de columnas: ");
            columnas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Introducir elementos:");
            valores.leer(filas, columnas);


            total = valores.suma(filas,columnas);
            Console.WriteLine("");
            Console.WriteLine("La suma de todos los elementos es: " + total);

            Console.ReadKey();
        }
    }
}
