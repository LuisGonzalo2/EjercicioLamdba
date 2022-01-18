using System;
using System.Collections.Generic;
using System.Linq;

namespace EjerciciosLambda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };

            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla los nombres de los estudiantes
            var mostrar = details.Select(m => m.Nombre + " "+ m.Apellido);
            Console.WriteLine(string.Join("\n",mostrar));
            Console.WriteLine("--------------------------------------");
            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            var mostrar2 = details.OrderByDescending(promedio => promedio.Promedio).Select(m => m.Nombre + " " + m.Apellido + " "+m.Promedio);
            Console.WriteLine(string.Join("\n", mostrar2));
            Console.WriteLine("---------------------------------------");
            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            var mostrar3 = details.OrderBy(ordenar => ordenar.Apellido).Select(m => m.Apellido);
            Console.WriteLine(string.Join("\n",mostrar3));
            Console.WriteLine("---------------------------------------");
            //4. Muestre por pantalla los datos del estudiante mas joven
            var mostrar4 = details.OrderByDescending(orden => orden.Edad).Select(m => m.Id + " "+m.Nombre + " " + m.Apellido + " " + m.Edad+ " " + m.Promedio).Last();
            Console.WriteLine(string.Join("\n", mostrar4));
            Console.WriteLine("---------------------------------------");

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla el cuadrado de los números
            var resultado = list.Select(m => m * m);
            Console.WriteLine(string.Join(" ",resultado));
            Console.WriteLine("---------------------------------------");
            //2. Muestre por pantalla los números pares
            var resultado1 = list.Where(m => m % 2 == 0);
            Console.WriteLine(string.Join(" ", resultado1));
            Console.WriteLine("---------------------------------------");
            //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            var resultado2 = list.Where(m => m % 2 != 0).Select(m => m * 5);
            Console.WriteLine(string.Join(" ",resultado2));
            Console.ReadLine();
        }
    }
}
