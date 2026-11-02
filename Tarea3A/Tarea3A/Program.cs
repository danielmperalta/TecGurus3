namespace Tarea3A
{
    public class Program
    {
        static void Main(string[] args)
        {
            int total;
           Arreglo arreglo = new Arreglo();

            arreglo.leer();
            arreglo.muestra();

            total = arreglo.cuentaVocales();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            if (total == 0)
                Console.WriteLine("El objeto A no tiene vocales");
            else
                Console.WriteLine("El objeto A contiene -{0}- vocales ", total);

            Console.ReadKey();
        }
    }
}
