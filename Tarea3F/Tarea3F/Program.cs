namespace Tarea3F
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Persona persona = new Persona();
            List<Persona> personas = new List<Persona>();
            Listado listado = new Listado();

            personas.Add(new Persona(1,"Carlos","Perez","Hernandez",'M',25));
            personas.Add(new Persona(2,"Sofia","Alarcon","Benitez",'F',28));
            personas.Add(new Persona(3,"Mateo","Castillo","Dominguez",'M',34));
            personas.Add(new Persona(4,"Valentina","Esparza","Fuentes",'F',16));
            personas.Add(new Persona(5,"Santiago","Gutierrez","Herrera",'M',45));
            personas.Add(new Persona(6,"Camila","Ibarra","Juarez",'F',52));
            personas.Add(new Persona(7,"Sebastian","Mendoza","Navarro",'M',23));
            personas.Add(new Persona(8,"Isabella","Ortiz","Puga",'F',31));

            //listado.muestraPersonas(personas);

            Console.WriteLine("");
            Console.WriteLine("Obtener todos los atributos de la Lista de personas");

            listado.listaPersonas(personas);

            Console.WriteLine("");
            Console.WriteLine("Obtener los nombres, primer apellido y género");
            listado.listaNomPatGen(personas);

            Console.WriteLine("");
            Console.WriteLine("Obtener las personas mayores de edad, mostrar todos atributos");
            listado.mayoresEdad(personas);

            Console.WriteLine("");
            Console.WriteLine("Obtener la primera persona de la Lista, ordenada ascendentemente, mostrar todos sus atributos (FirstOrDefault)");
            listado.ordenAscPrimer(personas);

            Console.WriteLine("");
            Console.WriteLine("Obtener la última persona de la Lista, ordenada descendentemente, mostrar todos sus atributos (OrderByDescending).");
            listado.ordenDescUltimo(personas);

            Console.WriteLine("");
            Console.WriteLine("Obtener la suma total de las edades.");
            listado.sumaEdades(personas);

            Console.WriteLine("");
            Console.WriteLine("Obtener el valor máximo de las edades");
            listado.maximoEdades(personas);

            Console.WriteLine("");
            Console.WriteLine("Obtener el valor mínimo de las edades");
            listado.minimoEdades(personas);

            Console.WriteLine("");
            Console.WriteLine("Obtener el promedio de las edades");
            listado.promedioEdades(personas);

            Console.WriteLine("");
            Console.WriteLine("Verificar si todas las personas de la Lista son mayores de edad, si todas las personas son mayores de edad, mostrar todos sus atributos, si no son mayores de edad mostrar un mensaje informativo");
            listado.todosMayores(personas);

            Console.WriteLine("");
            Console.WriteLine("Verificar si alguno de los elementos de la Lista son menores de edad, si todas las personas son menores de edad, mostrar todos sus atributos, si no son menores de edad mostrar un mensaje informativo");
            listado.algunoMenor(personas);

            Console.WriteLine("");
            Console.WriteLine("Obtener una persona por su id, mostrar todos sus atributos, si no se encuentra el id, mostrar un mensaje de advertencia (Where).");
            listado.muestraId(personas);
     



            Console.ReadKey();
        }
    }
}
