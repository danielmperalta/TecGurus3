using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3F
{
    public class Persona
    {
        private int id;
        private string nombres;
        private string paterno;
        private string materno;
        private char genero;
        private int edad;

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public char Genero { get => genero; set => genero = value; }
        public int Edad { get => edad; set => edad = value; }


        //constructor
        public Persona(int id, string nombres, string paterno, string materno, char genero, int edad)
        {
            this.id = id;
            this.nombres = nombres;
            this.paterno = paterno;
            this.materno = materno;
            this.genero = genero;
            this.edad = edad;
        }
        
    }
}
