using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Tarea3C
{
    internal class Lista
    {
        
        public void ListaNombres(List<string> nombres)
        {
            int i = 0;
            Console.WriteLine("La lista de nombres es:");
            foreach (var nombre in nombres)
            {
                Console.WriteLine(i + ") " + nombre);
                i++;
            }
        }

        public List<(int,string)> CaractABuscar(List<string> nombres)
        {
            char letra;
            int pos;
            int i = 0;

            Console.Write("Que caracter desea buscar?: ");
            letra = Convert.ToChar(Console.ReadLine()!);
            letra = char.ToLower(letra);

            List<(int indice, string nombre)> resultado = new List<(int, string)>();
            
            foreach (var nombre in nombres)
            {
                pos = nombre.ToLower().IndexOf(letra);

                if (pos >= 0)
                {
                    //Console.WriteLine(nombre);
                    resultado.Add((i,nombre));
                }

                i++;
            }

            Console.WriteLine("");
            if (resultado.Count > 0)
                Console.WriteLine("Nombre(s) que contiene(n) la leta '{0}' : ",letra);
            else
                Console.WriteLine("No se encontro el caracter '{0}' en ningun nombre",letra);


                return resultado;

        }

    }
}
