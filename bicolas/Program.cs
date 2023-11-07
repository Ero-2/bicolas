using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> miCola = new Queue<int>();

            // Encolar elementos
            miCola.Enqueue(1);
            miCola.Enqueue(2);
            miCola.Enqueue(3);

            Console.WriteLine("Elementos en la cola:");
            foreach (int elemento in miCola)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("Desencolando elementos:");
            while (miCola.Count > 0)
            {
                int elemento = miCola.Dequeue();
                Console.WriteLine(elemento);
            }

            Console.WriteLine("La cola está vacía:");
            Console.WriteLine(miCola.Count == 0);

            Console.ReadKey ();
        }



    }
    
}
