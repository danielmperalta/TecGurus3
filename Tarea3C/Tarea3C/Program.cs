namespace Tarea3C
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Lista lista = new Lista();

            List<string> nombres = new List<string> { "Ursula", "Rosmery", "Mercedes", "Oliveira", "Zaida", "Melquiades", "Silvana" };


            Console.WriteLine("");
            
            lista.ListaNombres(nombres);


            List <string> resultado = lista.CaractABuscar(nombres);


            Console.WriteLine(string.Join(", ", resultado));

            Console.ReadKey();

        }
    }
}
