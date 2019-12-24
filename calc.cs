using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            calcular:
            Console.WriteLine("\nEscolha a operação que deseja fazer:\n" +
                " 1-Somar\n 2-Subtrair\n 3-Multiplicar\n 4-Dividir");
            int escolha = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escolha o 1º número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o 2º número:");
            int num2 = int.Parse(Console.ReadLine());
            if (escolha == 1)
                {
                    Console.WriteLine(num1 + num2);
                    Console.WriteLine("Deseja continuar? s/n");
                    string sn = Console.ReadLine();
                    if(sn == "s" || sn == "S") { goto calcular; }
                    if(sn == "n" || sn == "N") { Console.ReadKey(); }
                }
                else if (escolha == 2)
                {
                    Console.WriteLine(num1 - num2);
                    Console.WriteLine("Deseja continuar? s/n");
                    string sn = Console.ReadLine();
                    if (sn == "s" || sn == "S") { goto calcular; }
                    if (sn == "n" || sn == "N") { Console.ReadKey(); }
            }
                else if (escolha == 3)
                {
                    Console.WriteLine(num1 * num2);
                    Console.WriteLine("Deseja continuar? s/n");
                    string sn = Console.ReadLine();
                    if (sn == "s" || sn == "S") { goto calcular; }
                    if (sn == "n" || sn == "N") { Console.ReadKey(); }
            }
                else if (escolha == 4)
                {
                    Console.WriteLine(num1 / num2);
                    Console.WriteLine("Deseja continuar? s/n");
                    string sn = Console.ReadLine();
                    if (sn == "s" || sn == "S") { goto calcular; }
                    if (sn == "n" || sn == "N") { Console.ReadKey(); }
            }
          
        }
    }
}
