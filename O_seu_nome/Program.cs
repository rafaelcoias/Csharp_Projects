using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Seu_Nome
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis
            char O;
            int Tam, Pos, N, cA, cE, cI, cO, cU, cTV;
            string Nome, Sair;
            
            //Início
            do
            {
                Console.Clear();
                Console.SetCursorPosition(37, 1);
                Console.WriteLine("Olá, por favor insira o seu Nome Completo:");
                Console.SetCursorPosition(40, 3);
                Nome = Console.ReadLine();
                Tam = Nome.Length;
                if (Tam < 3)
                {
                    Console.Clear();
                    Console.WriteLine("O Nome não pode ter menos de 3 letras, por favor tente novamente.");
                    Console.WriteLine(" ");
                    Console.WriteLine("(Voltar ao Início)");
                    Console.ReadLine();
                }
            }
            while (Tam < 3);
                
            do
            {
                //Menu
                Console.Clear();
                cA = 0;
                cE = 0;
                cI = 0;
                cO = 0;
                cU = 0;
                Sair = "não";
                Nome = Nome.ToUpper();
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("---------------------");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Iniciais do Nome");
                Console.WriteLine("2 - Apelido, Nome");
                Console.WriteLine("3 - Quantos Nomes");
                Console.WriteLine("4 - Contar vogais");
                Console.WriteLine("5 - Nome sem vogais");
                Console.WriteLine("6 - Trocar o Nome");
                Console.WriteLine("7 - Sair");
                O = Convert.ToChar(Console.ReadLine());

                if (O == '1')
                {
                    Pos = 0;
                    Console.Clear();
                    Console.Write("Iniciais do nome: ");
                    if (Nome[0] != ' ')
                    {
                        Console.Write(Nome[Pos]);
                    }
                    for (Pos = 0; Pos < Tam; Pos++)
                    {
                        if (Nome[Pos] == ' ' && Nome[Pos + 1] != ' ')
                        {
                            Console.Write(Nome[Pos + 1]);
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("(Voltar)");
                    Console.ReadLine();
                }
                else if (O == '2')
                {
                    Console.Clear();
                    for (Pos = Tam-1; Nome[Pos] != ' '; Pos--)
                    {
                        
                    }
                    for (Pos = Pos + 1; Pos < Tam; Pos++)
                    {
                        Console.Write(Nome[Pos]);
                    }
                    Console.Write(", ");
                    for (Pos = 0; Nome[Pos] != ' '; Pos++)
                    {
                        Console.Write(Nome[Pos]);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("(Voltar)");
                    Console.ReadLine();
                }
                else if (O == '3')
                {
                    Console.Clear();
                    N = 0;
                    if (Nome[0] != ' ')
                    {
                        N++;
                    }
                    for (Pos = 0; Pos < Tam; Pos++)
                    {
                        if (Nome[Pos] == ' ' && Nome[Pos + 1] != ' ')
                        {
                            N++;
                        }
                    }
                    Console.WriteLine("Há " + N + " nomes.");
                    Console.WriteLine(" ");
                    Console.WriteLine("(Voltar)");
                    Console.ReadLine();

                }
                else if (O == '4')
                {
                    Console.Clear();
                    for (Pos = 0; Pos < Tam; Pos++)
                    {
                        if (Nome[Pos] == 'A' || Nome[Pos] == 'Á' || Nome[Pos] == 'Ã' || Nome[Pos] == 'Ä')
                        {
                            cA++;
                        }
                        else if (Nome[Pos] == 'E' || Nome[Pos] == 'É' || Nome[Pos] == 'Ê' || Nome[Pos] == 'Ë')
                        {
                            cE++;
                        }
                        else if (Nome[Pos] == 'I' || Nome[Pos] == 'Í')
                        {
                            cI++;
                        }
                        else if (Nome[Pos] == 'O' || Nome[Pos] == 'Ó' || Nome[Pos] == 'Õ' || Nome[Pos] == 'Ö')
                        {
                            cO++;
                        }
                        else if (Nome[Pos] == 'U' || Nome[Pos] == 'Ú' || Nome[Pos] == 'Ü')
                        {
                            cI++;
                        }
                    }
                    cTV = cA + cE + cI + cO + cU;
                    Console.WriteLine("O nome tem " + cTV + " vogais.");
                    Console.WriteLine(" ");
                    Console.WriteLine("No nome há > " + cA + " 'A'");
                    Console.WriteLine("           > " + cE + " 'E'");
                    Console.WriteLine("           > " + cI + " 'I'");
                    Console.WriteLine("           > " + cO + " 'O'");
                    Console.WriteLine("           > " + cU + " 'U'");
                    Console.WriteLine(" ");
                    Console.WriteLine("(Voltar)");
                    Console.ReadLine();
                }
                else if (O == '5')
                {
                    Console.Clear();
                    for (Pos = 0; Pos < Tam; Pos++)
                    {
                        if (Nome[Pos] != 'A' && Nome[Pos] != 'Á' && Nome[Pos] != 'Ã' && Nome[Pos] != 'Ä' && Nome[Pos] != 'E' && Nome[Pos] != 'É' && Nome[Pos] != 'Ê' && Nome[Pos] != 'Ë' && Nome[Pos] != 'I' && Nome[Pos] != 'Í' && Nome[Pos] != 'O' && Nome[Pos] != 'Ó' && Nome[Pos] != 'Õ' && Nome[Pos] != 'Ö' && Nome[Pos] != 'U' && Nome[Pos] != 'Ú' && Nome[Pos] != 'Ü')
                        {
                            Console.Write(Nome[Pos]);
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("(Voltar)");
                    Console.ReadLine();
                }
                else if (O == '6')
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Insira o seu Nome:");
                        Nome = Console.ReadLine();
                        Tam = Nome.Length;
                        if (Tam < 3)
                        {
                            Console.Clear();
                            Console.WriteLine("O Nome não pode ter menos de 3 letras, por favor tente novamente.");
                            Console.WriteLine(" ");
                            Console.WriteLine("(Tentar Novamente)");
                            Console.ReadLine();
                        }
                    }
                    while (Tam < 3);
                }
                else if (O == '7')
                {
                    Console.Clear();
                    Console.WriteLine("Deseja Sair? (Sim/Não)");
                    Sair = Console.ReadLine();
                    Sair = Sair.ToUpper();
                    while (Sair != "SIM" && Sair != "NAO" && Sair != "NÃO")
                    {
                        Console.Clear();
                        Console.WriteLine("Opção indesponível.");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Deseja Sair? (Sim/Não)");
                        Sair = Console.ReadLine();
                        Sair = Sair.ToUpper();
                    }
                }
                else if (O < '1' || O > '7')
                {
                    Console.Clear();
                    Console.WriteLine("Opção não está no Menu.");
                    Console.WriteLine(" ");
                    Console.WriteLine("(Voltar)");
                    Console.ReadLine();
                }
             }
            while (Sair != "SIM");
            if (Sair == "SIM")
            {
                Console.Clear();
                Console.WriteLine("Adeus!");
                Console.ReadLine();
            }
        }
    }
}
