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

            Console.WriteLine("El numero es {0}", Random);
            if (Random==1)
            {
               

                Console.WriteLine("Lunes ");
            }
            else if(Random==2)
            {
               

                Console.WriteLine("Martes");
            }
            else if (Random == 3)
            {
              

                Console.WriteLine("Miercoles");

            }
            else if (Random == 4)
            {
                

                Console.WriteLine("Jueves");

            }
            else if (Random == 5)
            {
               

                Console.WriteLine("Viernes");

            }
            else if (Random == 6)
            {
                

                Console.WriteLine("Sabado");

            }
            else if (Random == 7)
            {
              

                Console.WriteLine("Domingo");

            }
            else if (Random == 2)
            {
               

                Console.WriteLine("Martes");

            }

            var r = new Random().Next(1, 101);

            Console.WriteLine("El numero es {0}", r);

            if (!(r>=18 && r<=50))
            {
               
                Console.WriteLine("Esta poblacion es Trabajadora");
            }
            else
            {
                
                Console.WriteLine("Esta poblacion No es economicamente activa");
            }
            Console.ReadKey();
        }
    }
}
