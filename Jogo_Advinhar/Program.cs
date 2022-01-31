using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.Advinhar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random
            Random rnd = new Random();

            //Variáveis
            char O, D;
            int N, N1, Nm = 1, NM = 100, cont, C = 10;
            string Sair = "NAO";

            //Início
            
            Console.WriteLine("Bem vindo ao jogo - 'Advinhar' !");
            Console.WriteLine("O teu objetvio é advinhar um número que estará entre um intervalo de números de 0 a x.");
            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine("(Prima enter)");
            Console.ReadLine();

            do
            {
                cont = C;
                //Menu
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine(" ");
                Console.WriteLine("Jogar - 1");
                Console.WriteLine("Configurações - 2");
                Console.WriteLine("Sair - 3");
                O = Convert.ToChar(Console.ReadLine());

                if (O == '1')
                {
                    Console.Clear();
                    N = rnd.Next(Nm, NM);
                    Console.WriteLine("Insira um número entre " + Nm + " e " + NM + ".");
                    Console.WriteLine("________________________________________________");
                    N1 = Convert.ToInt32(Console.ReadLine());
                    
                    do
                    {
                        cont--;
                        if (N1 < N && cont != 0)
                        {
                            Console.WriteLine("________________________________________________");
                            Console.WriteLine("Tem " + cont + " tentativas.");
                            Console.WriteLine(N1 + " é menor que o número correto. Tente novamente.");
                            Console.WriteLine(" ");
                            N1 = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (N1 > N  && cont != 0)
                        {
                            Console.WriteLine("________________________________________________");
                            Console.WriteLine("Tem " + cont + " tentativas.");
                            Console.WriteLine(N1 + " é maior que o número correto. Tente novamente.");
                            Console.WriteLine(" ");
                            
                            N1 = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    while (cont != 0);
                    if (N1 != N && cont == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Você perdeu. O número correto era o " + N);
                        Console.WriteLine(" ");
                        Console.WriteLine("(Voltar ao Menu)");
                        Console.ReadLine();
                    }
                    else if (N1 == N)
                    {
                        Console.Clear();
                        Console.WriteLine("Parabéns, " + N + " era o número certo!");
                        Console.WriteLine(" ");
                        Console.WriteLine("(Voltar ao Menu)");
                        Console.ReadLine();
                    }
                }
                else if (O == '2')
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("~ Limite de números - 1");
                        Console.WriteLine("~ Número de tentativas - 2");
                        Console.WriteLine("~ Pré-definições - 3");
                        Console.WriteLine("~ Voltar ao Menu - 4");
                        D = Convert.ToChar(Console.ReadLine());
                        if (D == '1')
                        {
                            Console.Clear();
                            Console.WriteLine("Número mínimo : ");
                            Nm = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Número máximo : ");
                            NM = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" ");
                            Console.WriteLine("(Voltar)");
                            Console.ReadLine();
                        }
                        else if (D == '2')
                        {
                            Console.Clear();
                            Console.WriteLine("Escolher número de tentativas : ");
                            C = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" ");
                            Console.WriteLine("(Voltar)");
                            Console.ReadLine();
                        }
                        else if (D == '3')
                        {
                            Console.Clear();
                            C = 10;
                            Console.WriteLine("Número de tentativas : 10");
                            Nm = 1;
                            NM = 100;
                            Console.WriteLine("Número mínimo : 1; Número máximo : 100");
                            Console.WriteLine(" ");
                            Console.WriteLine("(Voltar)");
                            Console.ReadLine();
                        }
                        else if (D < '1' || D > '4')
                        {
                            Console.Clear();
                            Console.WriteLine("Opção inválida. " + D + " não está nas opções.");
                            Console.WriteLine(" ");
                            Console.WriteLine("(Voltar)");
                            Console.ReadLine();
                        }
                    }
                    while (D != '4');
                }
                else if (O == '3')
                {
                    Console.Clear();
                    Console.WriteLine("Deseja sair? (Sim/Não)");
                    Sair = Console.ReadLine();
                    Sair = Sair.ToUpper();
                    while (Sair != "SIM" && Sair != "NAO" && Sair != "NÃO")
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida.");
                        Console.WriteLine("Deseja sair? (Sim/Não)");
                        Sair = Console.ReadLine();
                        Sair = Sair.ToUpper();
                    }
                    if (Sair == "NAO" || Sair == "NÃO")
                    {

                    }
                }
                else if (O < '1' || O > '3')
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida. " + O + " não está no menu.");
                    Console.WriteLine(" ");
                    Console.WriteLine("(Voltar ao Menu)");
                    Console.ReadLine();
                }
            }
            while (Sair == "NAO" || Sair == "NÃO");
            if (Sair == "SIM")
            {
                Console.Clear();
                Console.WriteLine("Obrigado por jogar. Até à próxima.");
                Console.ReadLine();
            }
        }
    }
}
