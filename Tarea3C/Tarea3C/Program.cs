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

            List <(int,string)> resultado = lista.CaractABuscar(nombres);

            Console.WriteLine("");

            Console.WriteLine(string.Join(",", resultado));
            
            Console.WriteLine("");
            
            foreach (var res in resultado)
            {
                Console.WriteLine("En el indice: {0} contiene el nombre: {1}",res.Item1,res.Item2);
            }
                
            
                
            

            Console.ReadKey();

        }
    }
}
