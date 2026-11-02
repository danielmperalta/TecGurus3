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
            int i = 1;
            Console.WriteLine("La lista de nombres es:");
            foreach (var nombre in nombres)
            {
                Console.WriteLine(i + ") " + nombre);
                i++;
            }
        }

        public List<string> CaractABuscar(List<string> nombres)
        {
            char letra;
            int indice;

            Console.Write("Que caracter desea buscar?: ");
            letra = Convert.ToChar(Console.ReadLine()!);
            letra = char.ToLower(letra);

            List<string> resultado = new List<string>();
            foreach (var nombre in nombres)
            {
                indice = nombre.ToLower().IndexOf(letra);

                if (indice >= 0)
                {
                    resultado.Add(nombre);
                    //Console.WriteLine(nombre);
                }
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
