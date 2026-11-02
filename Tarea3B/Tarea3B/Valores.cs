using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Tarea3B
{
    public class Valores
    {
        int i, j;
        int[,] arreglo = new int[50, 50];

        public void leer(int fil, int col)
        {
            for (i = 0; i < fil; i++)
            {
                for(j=0; j< col; j++)
                {
                    Console.Write("Introducir el elemento ({0},{1}):", i+1,j+1);
                    arreglo[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public int suma(int fil,int col)
        {
            int total = 0;
            for (i = 0; i < fil; i++)
            {
                for (j = 0; j < col; j++)
                {
                    total = total + arreglo[i, j];
                }
            }
            return total;
        }
    }
}
