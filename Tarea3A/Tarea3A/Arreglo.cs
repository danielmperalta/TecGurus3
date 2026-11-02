using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3A
{
    public class Arreglo
    {
        const int TAMANIO = 10;
        int i;
        private char[] caracteres = new char[TAMANIO];
        public char[] Caracteres { get => caracteres; set => caracteres = value; }
        


        public void leer()
        {
            Console.WriteLine("Introducir 10 caracteres:");
            for (i = 0; i < TAMANIO; i++)
            {
                int temp = i + 1;
                Console.Write("Introduczca el caracter " + temp + "/" + TAMANIO + ": ");
                caracteres[i] = Convert.ToChar(Console.ReadLine()!.ToLower());
            }  

        }

        public void muestra()
        {
            Console.WriteLine("");
            Console.WriteLine("El arreglo resultante de caracteres es:");
            for (i = 0; i < TAMANIO; i++)
            {
                Console.Write(caracteres[i] + " ");
            }
        }

        public int cuentaVocales()
        {
            int contador = 0;

            for (i = 0; i < TAMANIO; i++)
            {
                if (caracteres[i] == 'a' || caracteres[i] == 'e' || caracteres[i] == 'i' || caracteres[i] == 'o' || caracteres[i] == 'u')
                {
                    contador++;
                }
            }

            return contador;
        }

    }
}
