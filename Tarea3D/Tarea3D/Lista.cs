using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3D
{
    public class Lista
    {
        
        public void agregaElemento(List<string> Elementos)
        {
            string temp;
            Console.Write("Introducir el elemento a agregar:");
            temp = Console.ReadLine()!;
            temp = temp.Trim().ToLower();
            Elementos.Add(temp);
            Console.WriteLine("");
            Console.WriteLine("elemento agregado a la lista ({0} elementos actualmente)", Elementos.Count());
            Console.WriteLine("");
            
        }
        
        public void muestraElementos(List<string> Elementos)
        {
            if (Elementos.Count() > 0) 
            {
                Console.WriteLine("");
                Console.WriteLine("La lista contiene actualmente los sig elementos:");
                foreach (var elem in Elementos)
                {
                    Console.WriteLine(elem);
                }
            }
            else
            {
                Console.WriteLine("La lista actualmente NO contiene elementos");
            }

            Console.WriteLine("");
            
        }

        public void modificaXValor(List<string> Elementos)
        {
            int pos;
            string busca, reemplaza;
            Console.WriteLine("");
            Console.Write("Elemento a modificar?: ");
            busca = Convert.ToString(Console.ReadLine()!);
            busca = busca.Trim().ToLower();
            pos = Elementos.IndexOf(busca);
            if(pos == -1)
            {
                Console.WriteLine("El elemento {0} NO existe en la lista actualmente", busca);
            }
            else
            {
                Console.Write("Por que valor lo desea modificar?: ");
                reemplaza = Console.ReadLine()!;
                reemplaza = reemplaza.Trim().ToLower();
                Elementos[pos] = reemplaza;
                Console.WriteLine("El elemento {0} fue reemplazado por {1}", busca,reemplaza);
            }

        }

        public void modificaXPosicion(List<string> Elementos)
        {
            int pos, max;
            string reemplaza;
            Console.WriteLine("");
            max = Elementos.Count();
            Console.Write("Posicion del elemento a modificar?: (0 al {0}): ",max-1);
            pos = Convert.ToInt32((Console.ReadLine()!));
            
            if (pos >= 0 && pos < max)
            {
                Console.Write("Por que valor lo desea modificar?: ");
                reemplaza = Console.ReadLine()!;
                reemplaza = reemplaza.Trim().ToLower();
                Elementos[pos] = reemplaza;
                Console.WriteLine("El elemento del indice {0} fue reemplazado por {1}", pos, reemplaza);
            }
            else
            {
                Console.WriteLine("La posicion indicada {0} esta fuera del rango", pos);
            }

        }

        public void eliminaXValor(List<string> Elementos)
        {
            int pos;
            string busca;
            Console.WriteLine("");
            Console.Write("Valor del elemento a eliminar?: ");
            busca = Convert.ToString(Console.ReadLine()!);
            busca = busca.Trim().ToLower();
            pos = Elementos.IndexOf(busca);
            if (pos == -1)
            {
                Console.WriteLine("El elemento {0} NO existe en la lista actualmente", busca);
            }
            else
            {
                Elementos.Remove(busca);
                Console.WriteLine("El elemento {0} ha sido eliminado ", busca);
            }

        }

        public void eliminaXPosicion(List<string> Elementos)
        {
            int pos, max;
            Console.WriteLine("");
            max = Elementos.Count();
            Console.Write("Posicion del elemento a eliminar?: (0 al {0}):",max-1);
            pos = Convert.ToInt32(Console.ReadLine()!);

            if (pos >= 0 && pos < max)
            {
                Elementos.RemoveAt(pos);
                Console.WriteLine("El elemento {0} ha sido eliminado ", pos);
            }
            else
            {
                Console.WriteLine("El elemento en la posicion {0} NO existe en la lista actualmente", pos);
            }

        }

    }
}
