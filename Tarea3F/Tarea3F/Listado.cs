using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3F
{
    public class Listado
    {
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        public void muestraTodo(List<Persona>  resultado)
        {
            foreach (var p in resultado)
            {
                Console.WriteLine($"{p.Id} | {p.Nombres} | {p.Paterno} | {p.Materno} | {p.Genero} | {p.Edad}");
            }
            if (resultado.Count ==0)
                Console.WriteLine("---NO existen registros que coincidan el parametro de busqueda---");

        }
        public void ListaUnaPersona(Persona resultado)
        {
            if (resultado is null)
                Console.WriteLine("---No existen personas---");
            else
                Console.WriteLine($"{resultado.Id} | {resultado.Nombres} | {resultado.Paterno} | {resultado.Materno} | {resultado.Genero} | {resultado.Edad}");
        }
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        /*
        public void muestraPersonas(List<Persona> personas)
        {
            foreach (Persona p in personas)
            {
                Console.WriteLine($"{p.Id} | {p.Nombres} | {p.Paterno} | {p.Materno} | {p.Genero} | {p.Edad}");
            }
        }
        */
        public void listaPersonas(List<Persona> lista)
        {
            var resultado = lista.Select(p => p).ToList();
            muestraTodo(resultado);
        }

        public void listaNomPatGen(List<Persona> lista)
        {
            var resultado = lista.Select(p => new { p.Nombres, p.Paterno, p.Genero }).ToList();
            foreach (var p in resultado)
            {
                Console.WriteLine($"{p.Nombres} | {p.Paterno} | {p.Genero}");
            }
        }

        public void mayoresEdad(List<Persona> lista)
        {
            var resultado = lista.Where(p => p.Edad >= 18).ToList();
            muestraTodo(resultado);
        }

        public void ordenAscPrimer(List<Persona> lista)
        {
            //var resultado = (from ascPrimer in lista orderby ascPrimer.Nombres, ascPrimer.Paterno, ascPrimer.Materno select ascPrimer).FirstOrDefault();
            Persona resultado = lista.OrderBy(x => x.Nombres).FirstOrDefault()!;
            ListaUnaPersona(resultado!);
        }

        public void ordenDescUltimo(List<Persona> lista)
        {
            Persona resultado = lista.OrderByDescending(x => x.Nombres).LastOrDefault()!;
            ListaUnaPersona(resultado!);
        }

        public void sumaEdades(List<Persona> lista)
        {
            int resultado = lista.Sum(x => x.Edad);
            Console.WriteLine("-La SUMA de todas las edades de las personas es: " + resultado);
        }

        public void maximoEdades(List<Persona> lista)
        {
            int resultado = lista.Max(x => x.Edad);
            Console.WriteLine("-La edad MAXIMA es: " + resultado);
        }
        public void minimoEdades(List<Persona> lista)
        {
            int resultado = lista.Min(x => x.Edad);
            Console.WriteLine("-La edad MINIMA es: " + resultado);
        }
        public void promedioEdades(List<Persona> lista)
        {
            double resultado = lista.Average(x => x.Edad);
            Console.WriteLine("-La edad PROMEDIO es: " + resultado);
        }

        public void todosMayores(List<Persona> lista)
        {
            bool sonTodosMayores = lista.All(x => x.Edad>= 18);

            if (sonTodosMayores)
            {
                Console.WriteLine("---TODAS las personas son mayores de edad---");
                muestraTodo(lista);
            }
            else
            {
                Console.WriteLine("---NO TODAS las personas son mayores de edad---");
            }

        }
        public void algunoMenor(List<Persona> lista)
        {
            bool hayMenores = lista.Any(x => x.Edad < 18);

            if (hayMenores)
            {
                bool todosMenores = lista.All(x => x.Edad < 18);
                if(todosMenores)
                {
                    var menores = lista.Where(x => x.Edad < 18).ToList();
                    muestraTodo(menores);
                }
                else
                {
                    Console.WriteLine("---Hay MENORES de edad pero NO son TODOS---");
                }
            }
            else
            {
                Console.WriteLine("---NO existe ningun MENOR de edad---");
            }
                
        }

        public void muestraId(List<Persona> lista)
        {
            Console.Write("Escriba el ID de la persona a mostrar:");
            int buscaId = Convert.ToInt32(Console.ReadLine());
            List<Persona> datosID = lista.Where(x => x.Id == buscaId).ToList();
            muestraTodo(datosID);
        }
    }
}
