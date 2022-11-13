using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLlerenaDevin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre: Devin Fabricio");
            Console.WriteLine("Apellidos: Llerena Ballesteros");
            Console.WriteLine("Curso: 2 do de Tics");
            Console.WriteLine("Asignatura: Programacion estructurada y funcional ");
            Console.WriteLine("Fecha: 13/11/2022");
            Console.WriteLine("Tema: Operadores logicos");

            var Random = new Random().Next(1, 8);

            if(Random==1)
            {
                Console.WriteLine("El numero es {0}",Random);

                Console.WriteLine("Lunes ");
            }
            else if(Random==2)
            {
                Console.WriteLine("El numero es {0}", Random);

                Console.WriteLine("Martes");
            }
            else if (Random == 3)
            {
                Console.WriteLine("El numero es {0}", Random);

                Console.WriteLine("Miercoles");

            }
            else if (Random == 4)
            {
                Console.WriteLine("El numero es {0}", Random);

                Console.WriteLine("Jueves");

            }
            else if (Random == 5)
            {
                Console.WriteLine("El numero es {0}", Random);

                Console.WriteLine("Viernes");

            }
            else if (Random == 6)
            {
                Console.WriteLine("El numero es {0}", Random);

                Console.WriteLine("Sabado");

            }
            else if (Random == 7)
            {
                Console.WriteLine("El numero es {0}", Random);

                Console.WriteLine("Domingo");

            }
            else if (Random == 2)
            {
                Console.WriteLine("El numero es {0}", Random);

                Console.WriteLine("Martes");

            }

            var r = new Random().Next(1, 101);
            if(!(r>=18 && r<=50))
            {
                Console.WriteLine("El numero es {0}", r);
                Console.WriteLine("Esta poblacion es Trabajadora");
            }
            else
            {
                Console.WriteLine("El numero es {0}", r);
                Console.WriteLine("Esta poblacion No es economicamente activa");
            }
            Console.ReadKey();
        }
    }
}
