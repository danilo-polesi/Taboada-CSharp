using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Recebe as Variaveis
            int formula, contador, numero;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite o Numero para Obter a Tabuada: ");
            numero = Int32.Parse(Console.ReadLine());

            //para
            for (contador = 1; contador <= 10; ++contador)
            {
                formula = numero * contador;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(numero);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" X ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(contador);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" = ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(formula);
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }

    }
}