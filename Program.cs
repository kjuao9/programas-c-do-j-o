using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    public class Fatorial
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para calcular o seu fatorial: \t");
            int num = Convert.ToInt32(Console.ReadLine());
            int numi = num;
            int res = 1;

            for (int i = 1; i <= num; i++)
            {
                res = res * i;
            }
            Console.WriteLine("{0}! é igual a {1}", numi, res);
            P1.num();
            Matematica.Formula();
            Carro Civic = new Carro("preto", "Honda", 200);
            Civic.LigarCarro();
            Caminhao Volvo = new Caminhao("vermelho", "Volvo", 120);
            Volvo.LigarCaminhao();
        escolhaDeNovo:
            Console.WriteLine("\nDeseja adicionar um novo carro ou caminhão? s/n");
            String sn = Console.ReadLine();
            if (sn == "S" || sn == "s")
            {
            escolha:
                Console.WriteLine("\nO que deseja adicionar: um carro(1), ou um caminhão(2)?");
                SByte carOuCam = Convert.ToSByte(Console.ReadLine());
                if (carOuCam == 1)
                {
                    //blablabla
                    Console.Write("\nDigite o nome do carro:\t");
                    string nome = Console.ReadLine();
                    Console.Write("\nDigite a cor do carro:\t");
                    string cor = Console.ReadLine();
                    Console.Write("\nDigite a marca do carro:\t");
                    string marca = Console.ReadLine();
                    Console.Write("\nDigite a velocidade máxima:\t");
                    int velocidade = Convert.ToInt16(Console.ReadLine());
                    Carro Nome = new Carro(cor, marca, velocidade);
                    Console.WriteLine($"O seu carro {nome}, de cor {cor}, marca {marca} e de velocidade máxima de {velocidade}km/h, foi registrado.");
                }
                else if (carOuCam == 2)
                {
                    //lalala
                    Console.Write("\nDigite o nome do caminhão:\t");
                    string nome = Console.ReadLine();
                    Console.Write("\nDigite a cor do caminhão:\t");
                    string cor = Console.ReadLine();
                    Console.Write("\nDigite a marca do caminhão:\t");
                    string marca = Console.ReadLine();
                    Console.Write("\nDigite a velocidade máxima:\t");
                    int velocidade = Convert.ToInt16(Console.ReadLine());
                    Caminhao Nome = new Caminhao(cor, marca, velocidade);
                    Console.WriteLine($"O seu caminhão {nome}, de cor {cor}, marca {marca} e de velocidade máxima de {velocidade}km/h, foi registrado.");

                }
                else
                {
                    Console.WriteLine("\nEscolha um valor válido.");
                    goto escolha;
                }
            }
            else if (sn == "n" || sn == "N") { Console.WriteLine("Aperte qualquer tecla para sair."); }
            else { Console.WriteLine("Faça uma escolha válida."); goto escolhaDeNovo; }
            Console.ReadKey();
        }
    }

    public class P1
    {
        public static void num()
        {
            Console.WriteLine("\nDigite um número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            string[] numeros = new string[num2 + 1];
            for (int a = 0; a < num2 + 1; a++)
            {

                int axa = a * a;
                if (a == 0)
                {
                    numeros[a] = Convert.ToString($"({a} : {axa}, ");
                }
                else if (a != num2 && a != 0)
                {
                    numeros[a] = Convert.ToString($"{a} : {axa}, ");
                }
                else if (a == num2)
                {
                    numeros[a] = Convert.ToString($"{a} : {axa})");
                }
            }
            foreach (string numero in numeros)
            {
                Console.Write(numero);
            }
        }
    }
    public class Carro
    {
        public string cor;
        public string marca;
        public int velocidade;
        public SByte rodas;

        public Carro(string corCarro, string marcaCarro, int velocidadeCarro)
        {
            rodas = 4;
            cor = corCarro;
            marca = marcaCarro;
            velocidade = velocidadeCarro;

        }
        public void LigarCarro()
        {
            Console.WriteLine("\nO seu carro da marca {0}, de cor {1} e de velocidade máxima de {2}km/h, foi ligado.", marca, cor, velocidade);
        }
    }
    public class Caminhao : Carro
    {
        public Caminhao(string corCarro, string marcaCarro, int velocidadeCarro) : base(corCarro, marcaCarro, velocidadeCarro)
        {
            rodas = 10;
        }
        public void LigarCaminhao()
        {
            Console.WriteLine("\nO seu caminhao da marca {0}, de cor {1}, de velocidade máxima de {2}km/h, e de {3} rodas foi ligado.", marca, cor, velocidade, rodas);
        }
    }
    public class Matematica
    {
        public static double Formula()
        {
            Console.Write("\nDigite um número para ser aplicado na fórmula:");
            int num = int.Parse(Console.ReadLine());
            Double res = Math.Round(Math.Sqrt((2*50*num)/30));
            Console.Write("O resultado foi: {0}", res);
            return res;            
        }
    }
}