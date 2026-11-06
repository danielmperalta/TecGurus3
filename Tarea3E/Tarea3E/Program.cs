namespace Tarea3E
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animales = new List<Animal>();
            Listas lista = new Listas();

            const string ESP_CANINO = "canino";
            string mensaje;
            string nombreBuscar;

            Animales.Add(new Animal("Luna", 5, "Gato", "Hembra"));
            Animales.Add(new Animal("Carlos", 28, "Humano", "Masculino"));
            Animales.Add(new Animal("Rayo", 12, "Tortuga terrestre", "Macho"));
            Animales.Add(new Animal("Kiwii",1,"Loro","Hembra"));
            Animales.Add(new Animal("Max", 3, "Canino", "Macho"));
            Animales.Add(new Animal("Yoda",900,"Desconocida","Masculino"));
            Animales.Add(new Animal("Simbaz", 4, "León", "Macho"));
            Animales.Add(new Animal("Axo", 2, "Ajolote", "Hembra"));


            lista.muestraAnimales(Animales);

            Console.WriteLine("");

            Console.Write("Escriba el nombre del animal a buscar:");
            nombreBuscar= Convert.ToString(Console.ReadLine()!);

            mensaje = lista.buscaNombre(Animales, nombreBuscar);

            Console.WriteLine(mensaje);

            Console.WriteLine("");

            mensaje = lista.buscaEspecie(Animales,ESP_CANINO);

            Console.WriteLine("");

            Console.WriteLine(mensaje);

            Console.ReadKey();
        }
    }
}
