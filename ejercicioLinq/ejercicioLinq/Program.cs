using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Generar (usando operadores LINQ) una lista de enteros, de 1 a 100, y devolver solo la lista de los números divisibles entre 7
            */

            // Métodos de extensión
            List<int> listaNumerosDivisiblesPor7 = Enumerable.Range(1, 100).Where(x => x % 7 == 0).ToList();
            List<int> listaNumerosDivisiblesPor7YPares = listaNumerosDivisiblesPor7.Where(x => x % 2 == 0).ToList();
            List<int> listaNumerosDivisiblesPor7YImpares = listaNumerosDivisiblesPor7.Where(x => x % 2 != 0).ToList();

            Console.WriteLine("Métodos de extensión");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Lista números hasta el 100 divisibles por 7: " + string.Join(", ", listaNumerosDivisiblesPor7));
            Console.WriteLine("Lista números hasta el 100 divisibles por 7 y pares: " + string.Join(", ", listaNumerosDivisiblesPor7YPares));
            Console.WriteLine("Lista números hasta el 100 divisibles por 7 y impares: " + string.Join(", ", listaNumerosDivisiblesPor7YImpares));


            // Expresión de consulta

            List<int> expListaNumerosDivisiblesPor7 = (from x in Enumerable.Range(1, 100) where x % 7 == 0 select x).ToList();
            List<int> expListaNumerosDivisiblesPor7YPares = (from x in expListaNumerosDivisiblesPor7 where x % 2 == 0 select x).ToList();
            List<int> expListaNumerosDivisiblesPor7YImpares = (from x in expListaNumerosDivisiblesPor7 where x % 2 != 0 select x).ToList();

            Console.WriteLine("\n\nExpresión de consulta");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Lista números hasta el 100 divisibles por 7: " + string.Join(", ", expListaNumerosDivisiblesPor7));
            Console.WriteLine("Lista números hasta el 100 divisibles por 7 y pares: " + string.Join(", ", expListaNumerosDivisiblesPor7YPares));
            Console.WriteLine("Lista números hasta el 100 divisibles por 7 y impares: " + string.Join(", ", expListaNumerosDivisiblesPor7YImpares));

            // Para salir
            Console.Write("\n\n\tPulse una tecla para salir");
            Console.ReadKey();
        }
    }
}
