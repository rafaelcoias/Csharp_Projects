using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora___IF
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            char O, Sair = 'N';
            double R, N1, N2;

            //Início
            Console.Clear();
            Console.WriteLine("Bem-vindo à calculadora.");
            Console.WriteLine(" ");
            Console.WriteLine("(Prima enter para usar)");
            Console.ReadLine();
            do
            {
                //Menu
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine(" ");
                Console.WriteLine("Soma - 1");
                Console.WriteLine("Subtração - 2");
                Console.WriteLine("Multiplicação - 3");
                Console.WriteLine("Divisão - 4");
                Console.WriteLine("Sair - 5");

                O = Convert.ToChar(Console.ReadLine());

                while (O < '1' || O > '5')
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida. Por favor escreva outra opção.");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Soma - 1");
                    Console.WriteLine("Subtração - 2");
                    Console.WriteLine("Multiplicação - 3");
                    Console.WriteLine("Divisão - 4");
                    Console.WriteLine("Sair - 5");
                    O = Convert.ToChar(Console.ReadLine());
                }
                //Pedir números

                if (O > '0' && O < '5')
                {
                    Console.Clear();
                    Console.WriteLine("Escreva o primeiro número:");
                    N1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Escreva o Segundo número:");
                    N2 = Convert.ToDouble(Console.ReadLine());

                    //Calculadora

                    if (O == '4' && N2 == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Solução Impossível.");

                    }
                    else if (O == '1')
                    {
                        Console.Clear();
                        R = N1 + N2;
                        Console.WriteLine(N1 + "+" + N2 + "=" + R);

                    }

                    else if (O == '2')
                    {
                        Console.Clear();
                        R = N1 - N2;
                        Console.WriteLine(N1 + "-" + N2 + "=" + R);

                    }
                    else if (O == '3')
                    {
                        Console.Clear();
                        R = N1 * N2;
                        Console.WriteLine(N1 + "x" + N2 + "=" + R);

                    }
                    else if (O == '4')
                    {
                        Console.Clear();
                        R = N1 / N2;
                        Console.WriteLine(N1 + "/" + N2 + "=" + R);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("(Voltar)");
                    Console.ReadLine();

                }
                else if (O == '5')
                {
                    Console.Clear();
                    Console.WriteLine("Deseja Sair? (S/N)");
                    Sair = Convert.ToChar(Console.ReadLine());

                    while (Sair != 'N' && Sair != 'S' && Sair != 's' && Sair != 'n')
                    {
                        Console.WriteLine("Opção inválida. Escreva outra opção.");
                        Sair = Convert.ToChar(Console.ReadLine());
                    }

                }
            }
            while (Sair != 'S' && Sair != 's');
            if (Sair == 'S' || Sair == 's')
            {
                Console.Clear();
                Console.WriteLine("Adeus.");
                Console.ReadLine();
            }
        }
    }
}
