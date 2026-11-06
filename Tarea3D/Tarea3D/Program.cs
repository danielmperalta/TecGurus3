namespace Tarea3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            List<string> Elementos = new List<string>();
            int opcion;
            bool sw;

            sw = true;
            
            do
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("****************************************************************");
                Console.WriteLine(" - - - - - M E N U - - - - - ");
                Console.WriteLine("1- Creacion de la lista");
                Console.WriteLine("2- Llenado de la lista (agregar elemento)");
                Console.WriteLine("3- Modificar un elemento de la lista por valor");
                Console.WriteLine("4- Modificar un elemento de la lista por posicion");
                Console.WriteLine("5- Eliminar un elemento de la lista por valor");
                Console.WriteLine("6- Eliminar un elemento de la lista por posicion");
                Console.WriteLine("7- Mostrar la lista");
                Console.WriteLine("8- Salir");
                Console.WriteLine("");
                Console.Write("Escoja una opcion:");

                opcion = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("--- Creacion de la lista ---");
                        //List<string> Elementos = new List<string>();
                        Elementos.Clear();
                        Console.WriteLine("Lista creada!!!");
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("--- Llenado de la lista ---");
                        lista.agregaElemento(Elementos);
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("--- Modificar un elemento de la lista por valor ---");
                        lista.modificaXValor(Elementos);
                        break;
                    case 4:
                        Console.WriteLine("--- Modificar un elemento de la lista por posicion ---");
                        lista.modificaXPosicion(Elementos);
                        break;
                    case 5:
                        Console.WriteLine("--- Eliminar un elemento de la lista por valor ---");
                        lista.eliminaXValor(Elementos);
                        break;
                    case 6:
                        Console.WriteLine("--- Eliminar un elemento de la lista por posicion ---");
                        lista.eliminaXPosicion(Elementos);
                        break;
                    case 7:
                        Console.WriteLine("--- Mostrar la lista de elementos ---");
                        lista.muestraElementos(Elementos);
                        break;
                    case 8:
                        sw = false;
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Intente nuevamente");
                        break;
                }
            }
            while (sw);
        }
    }
}
