using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programas
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1.Maximo();
            Console.ReadKey();
        }
    }
    public class P1
    {
       public static void Maximo()
        {
            Console.Write("Digite o 1º número: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("\nDigite o 2º número: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine("O número {0} é maior do que o número {1}.",num1, num2);
            }
            else if(num2 > num1)
            {
                Console.WriteLine("O número {0} é maior do que o número {1}.", num2, num1);
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }
        }



    }
}
