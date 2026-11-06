using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3E
{
    public class Animal
    {
        private string nombre;
        private int edad;
        private string especie;
        private string genero;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Genero { get => genero; set => genero = value; }


        public Animal(string nombre,int edad,string especie,string genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.especie = especie; 
            this.genero = genero;
        }

        
    }
}
