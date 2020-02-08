using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ATIVIDADES";
            Console.Beep();
            Atividades.PrintMelhorado();
            Atividades.PrimoOuNao();
            Atividades.Palindromos();
            Console.ReadKey();
            Console.Beep();
        }
    }
    class Atividades
    {
        public static void PrintMelhorado()
        {
            Console.WriteLine("-{0}-", new string('_', 3));
            Console.WriteLine("Escreva qualquer coisa\n");
            string texto = Console.ReadLine();
            int numeroCaracteres = texto.Length;

            Console.Write("+");
            for(int x=0;x < numeroCaracteres+2; x++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");

            Console.Write("| {0} |\n",texto);

            Console.Write("+");
            for (int x = 0; x < numeroCaracteres+2; x++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");
        }
        public static bool PrimoOuNao()
        {
        repetir:
            Console.WriteLine("Digite um número, anta");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            for(int i=2; i <= numero / 2; i++)
            {
                if(numero % i == 0)
                {
                    Console.WriteLine($"O número {numero} não é primo.");
                    Console.WriteLine("Quer testar outro número, pedaço de bosta? s/n");
                    char sn = Convert.ToChar(Console.ReadLine());
                    if(sn == 's' || sn == 'S') { goto repetir; } 
                    return true;
                }
                else
                {
                    Console.WriteLine($"O número {numero} é primo.");
                    Console.WriteLine("Quer testar outro número, pedaço de bosta? s/n");
                    char sn = Convert.ToChar(Console.ReadLine());
                    if (sn == 's' || sn == 'S') { goto repetir; }
                   
                    return false;
                }
            }
            return true;
        }
        public static void Palindromos()
        {
            queroTestarDeNovo:
            Console.WriteLine("Escreva para ver se é palíndromo: ");
            string frase = Console.ReadLine();
            bool ePalindromo;

            string fraseInvertida = new string(frase.Reverse().ToArray());
            if(fraseInvertida.Replace(" ","") == frase.Replace(" ","")) { ePalindromo = true; }
            else { ePalindromo = false; }

            if(ePalindromo == true)
            {
                Console.WriteLine("A frase é um palíndromo.");
                Console.WriteLine("{0} = {1}",frase, fraseInvertida);
                Console.WriteLine("Quer testar outra frase, retardado mental? s/n");
                char sn = Convert.ToChar(Console.ReadLine());
                if (sn == 's' || sn == 'S') { goto queroTestarDeNovo; }
            }
            else if(ePalindromo == false)
            {
                Console.WriteLine("A frase não é um palíndromo.");
                Console.WriteLine("{0} != {1}", frase, fraseInvertida);
                Console.WriteLine("Quer testar outra frase, retardado mental? s/n");
                char sn = Convert.ToChar(Console.ReadLine());
                if (sn == 's' || sn == 'S') { goto queroTestarDeNovo; }
            }
        }
    }
}
