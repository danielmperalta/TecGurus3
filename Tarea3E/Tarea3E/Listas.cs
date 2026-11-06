using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea3E
{
    public class Listas
    {
        public void muestraAnimales(List<Animal> Animales)
        {
            Console.WriteLine("NOMBRE /  EDAD  /  ESPECIE  /  GENERO");
            foreach (Animal animal in Animales)
            {
                Console.WriteLine(animal.Nombre+", "+animal.Edad+", "+animal.Especie+", "+animal.Genero);
                
            }

        }


        public string buscaNombre(List<Animal> animales,string buscaNombre)
        {
            string mensaje = "";
            bool bandera = false;
            buscaNombre = buscaNombre.ToLower();
            foreach (Animal animal in animales)
            {
                //if (animal.Nombre.ToLower().Contains(buscaNombre))
                if (animal.Nombre.ToLower() == buscaNombre)
                    bandera = true;
            }

            if (bandera)
                mensaje = $"El nombre '{buscaNombre}' SI se encuentra en el nombre de algun animal";
            else
                mensaje = $"El nombre '{buscaNombre}' NO se encuentra en el nombre de algun animal";
            return mensaje;
        }
        public string buscaEspecie(List<Animal> animales, string busca)
        {
            string mensaje = "";
            busca = busca.ToLower();
            bool bandera = false;

            foreach (Animal animal in animales)
            {

                if (animal.Especie.ToLower().Contains(busca))
                    bandera = true;
            }

            if(bandera)
                mensaje = $"La especie: '{busca}' SI se encuentra en la lista de animales";
            else
                mensaje = $"La especie: '{busca}' NO se encuentra en la Lista de animales";

            return mensaje;
                
        }
    }
}
