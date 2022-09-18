using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_do_Galo
{
    class Program
    {
        static void LimparLinhas()
        {
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 13);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 14);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 15);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 16);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 17);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 18);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 19);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 20);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(3, 21);
            Console.WriteLine("                                                            ");
        }
        static void Main(string[] args)
        {
            Console.Title = "Jogo do Galo";

            //Variáveis do Programa
            var rnd = new Random();
            string sO, sO1, sO2, sO3, sO4 = "1", sO5 = "1", sO6 = "2", sSair, sJogo, sJ1 = "X", sJ2 = "O";
            int icont, icont2, iVerEmpate, iVerFim, iPos, iTamsJogo, icontJs1, icontJs2;           

            //Formação do Início
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(16, 0);
            Console.WriteLine("║                               ║");
            Console.SetCursorPosition(16, 1);
            Console.WriteLine("║                               ║");
            Console.SetCursorPosition(16, 2);
            Console.WriteLine("║                               ║");
            Console.SetCursorPosition(16, 3);
            Console.WriteLine("║                               ║");
            Console.SetCursorPosition(16, 4);
            Console.WriteLine("║                               ║"); 
            Console.SetCursorPosition(16, 5);
            Console.WriteLine("╚═══════════════════════════════╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(20, 1);
            Console.WriteLine("Bem-vindo ao Jogo do Galo");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("═════════════════════════");            
            Console.SetCursorPosition(26, 3);
            Console.WriteLine("(Prima Enter)");
            Console.SetCursorPosition(39, 3);
            Console.ReadLine();
            Console.ResetColor();

            do
            {
                sSair = "nao";

                //Menu e Desenhar ecrã                
                Console.Clear();
                if (sO5 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (sO5 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (sO5 == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (sO5 == "4")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (sO5 == "5")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.SetCursorPosition(1, 4);
                Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(1, 5);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 6);
                Console.WriteLine("╠═════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(1, 7);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 8);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 9);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 10);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 11);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 12);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 13);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 14);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 15);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 16);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 17);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 18);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 19);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 20);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 21);
                Console.WriteLine("║                                                             ║");
                Console.SetCursorPosition(1, 22);
                Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
                Console.ResetColor();
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("Menu:");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("1 → Jogar - singleplayer");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("2 → Jogar - multiplayer");
                Console.SetCursorPosition(3, 9);
                Console.WriteLine("3 → Configurar");
                Console.SetCursorPosition(3, 10);
                Console.WriteLine("4 → Sair");
                Console.SetCursorPosition(3, 11);
                sO = Console.ReadLine();
                sO = sO.Trim();               
                //Jogar
                if (sO == "1" || sO == "2")
                {
                    LimparLinhas();
                    do
                    {
                        LimparLinhas();
                        Console.SetCursorPosition(3, 5);
                        Console.WriteLine("Jogo");
                        Console.SetCursorPosition(3, 7);
                        Console.WriteLine("1 → Clássico (1 Jogo)");
                        Console.SetCursorPosition(3, 8);
                        Console.WriteLine("2 → Melhor de 3");
                        Console.SetCursorPosition(3, 9);
                        Console.WriteLine("3 → Melhor de 5");
                        Console.SetCursorPosition(3, 10);
                        sO1 = Console.ReadLine();
                        sO1 = sO1.Trim();
                        LimparLinhas();
                        if (sO1 == "")
                        {
                            sO1 = "1";
                        }
                        if (sO1 != "1" && sO1 != "2" && sO1 != "3")
                        {
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Opção inválida, prima Enter para voltar           ");                            
                            Console.SetCursorPosition(43, 5);
                            Console.ReadLine();
                            LimparLinhas();
                        }                        
                    }
                    while (sO1 != "1" && sO1 != "2" && sO1 != "3");
                    icontJs1 = 0;
                    icontJs2 = 0;
                    LimparLinhas();
                    do
                    {                        
                        //Desenhar Jogo
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(23, 5);
                        Console.WriteLine("   Jogo do Galo   ");
                        Console.ResetColor();
                        //Tabuleiro
                        if (sO4 == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (sO4 == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (sO4 == "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (sO4 == "4")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        Console.SetCursorPosition(26, 9);
                        Console.WriteLine("   │   │    ");
                        Console.SetCursorPosition(26, 10);
                        Console.WriteLine("───┼───┼─── ");
                        Console.SetCursorPosition(26, 11);
                        Console.WriteLine("   │   │    ");
                        Console.SetCursorPosition(26, 12);
                        Console.WriteLine("───┼───┼─── ");
                        Console.SetCursorPosition(26, 13);
                        Console.WriteLine("   │   │    ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(27, 9);
                        Console.WriteLine("1");
                        Console.SetCursorPosition(27, 11);
                        Console.WriteLine("4");
                        Console.SetCursorPosition(27, 13);
                        Console.WriteLine("7");
                        Console.SetCursorPosition(31, 9);
                        Console.WriteLine("2");
                        Console.SetCursorPosition(31, 11);
                        Console.WriteLine("5");
                        Console.SetCursorPosition(31, 13);
                        Console.WriteLine("8");
                        Console.SetCursorPosition(35, 9);
                        Console.WriteLine("3");
                        Console.SetCursorPosition(35, 11);
                        Console.WriteLine("6");
                        Console.SetCursorPosition(35, 13);
                        Console.WriteLine("9");
                        Console.ResetColor();
                        //Mais que 1 Jogo
                        if (sO1 != "1")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;                            
                            Console.SetCursorPosition(8, 10);
                            Console.WriteLine("Vitórias");
                            Console.SetCursorPosition(6, 11);
                            Console.WriteLine("Do Jogador 1");                           
                            Console.SetCursorPosition(47, 10);
                            Console.WriteLine("Vitórias");
                            Console.SetCursorPosition(45, 11);
                            Console.WriteLine("Do Jogador 2");
                            if (sO == "1")
                            {
                                Console.SetCursorPosition(44, 11);
                                Console.WriteLine("Do Computador");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(21, 20);
                        Console.WriteLine("♦");
                        Console.ResetColor();
                        Console.SetCursorPosition(23, 20);
                        Console.WriteLine("Escolha uma posição");
                        Console.SetCursorPosition(23, 17);
                        Console.WriteLine("Jogador 1 ( ) →          ");
                        Console.SetCursorPosition(34, 17);
                        Console.WriteLine(sJ1);
                        if (sJ1 == "♥" || sJ1 == "♦")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(34, 17);
                            Console.WriteLine(sJ1);
                            Console.ResetColor();
                        }
                        if (sO == "2")
                        {
                            Console.SetCursorPosition(23, 18);
                            Console.WriteLine("Jogador 2 ( ) →          ");
                            Console.SetCursorPosition(34, 18);
                            Console.WriteLine(sJ2);
                        }
                        //Jogo
                        //Variáveis do Jogo
                        int iVerJ1 = '0', iVerJ2 = '0', iVerJ3 = '0', iVerJ4 = '0', iVerJ5 = '0', iVerJ6 = '0', iVerJ7 = '0', iVerJ8 = '0', iVerJ9 = '0';
                        int iG1J1 = '0', iG1J2 = '0', iG1J3 = '0', iG1J4 = '0', iG1J5 = '0', iG1J6 = '0', iG1J7 = '0', iG1J8 = '0', iG1J9 = '0', iG2J1 = '0', iG2J2 = '0', iG2J3 = '0', iG2J4 = '0', iG2J5 = '0', iG2J6 = '0', iG2J7 = '0', iG2J8 = '0', iG2J9 = '0';
                        iVerEmpate = '0';
                        iVerFim = '0';
                        icont2 = '0';
                        icont = 0;
                        for (iPos = 0; iPos < 5; iPos++)
                        {
                            if (iVerFim == '0')
                            {
                                icont++;
                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.SetCursorPosition(39, 17);
                                    sJogo = Console.ReadLine();
                                    sJogo = sJogo.Trim();
                                    Console.ResetColor();
                                    Console.SetCursorPosition(39, 17);
                                    Console.WriteLine("                   ");
                                    Console.SetCursorPosition(14, 20);
                                    Console.WriteLine("                                     ");
                                    if (sJogo != "1" && sJogo != "2" && sJogo != "3" && sJogo != "4" && sJogo != "5" && sJogo != "6" && sJogo != "7" && sJogo != "8" && sJogo != "9")
                                    {
                                        Console.SetCursorPosition(14, 20);
                                        Console.WriteLine("(Posição não existe. Tente Novamente)");
                                    }
                                    else if ((iVerJ1 != '0' && sJogo == "1") || (iVerJ2 != '0' && sJogo == "2") || (iVerJ3 != '0' && sJogo == "3") || (iVerJ4 != '0' && sJogo == "4") || (iVerJ5 != '0' && sJogo == "5") || (iVerJ6 != '0' && sJogo == "6") || (iVerJ7 != '0' && sJogo == "7") || (iVerJ8 != '0' && sJogo == "8") || (iVerJ9 != '0' && sJogo == "9"))
                                    {
                                        Console.SetCursorPosition(14, 20);
                                        Console.WriteLine("(Posição já existe. Tente Novamente)");
                                    }
                                }
                                while (sJogo != "1" && sJogo != "2" && sJogo != "3" && sJogo != "4" && sJogo != "5" && sJogo != "6" && sJogo != "7" && sJogo != "8" && sJogo != "9" || (iVerJ1 != '0' && sJogo == "1") || (iVerJ2 != '0' && sJogo == "2") || (iVerJ3 != '0' && sJogo == "3") || (iVerJ4 != '0' && sJogo == "4") || (iVerJ5 != '0' && sJogo == "5") || (iVerJ6 != '0' && sJogo == "6") || (iVerJ7 != '0' && sJogo == "7") || (iVerJ8 != '0' && sJogo == "8") || (iVerJ9 != '0' && sJogo == "9"));
                                if (sJogo == "1" && iVerJ1 == '0')
                                {
                                    iG1J1 = '1';
                                    iVerJ1 = '1';
                                    Console.SetCursorPosition(27, 9);
                                    Console.WriteLine(sJ1);
                                    if (sJ1 == "♥" || sJ1 == "♦")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(27, 9);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                }
                                else if (sJogo == "2" && iVerJ2 == '0')
                                {
                                    iG1J2 = '1';
                                    iVerJ2 = '1';
                                    Console.SetCursorPosition(31, 9);
                                    Console.WriteLine(sJ1);
                                    if (sJ1 == "♥" || sJ1 == "♦")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(31, 9);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                }
                                else if (sJogo == "3" && iVerJ3 == '0')
                                {
                                    iG1J3 = '1';
                                    iVerJ3 = '1';
                                    Console.SetCursorPosition(35, 9);
                                    Console.WriteLine(sJ1);
                                    if (sJ1 == "♥" || sJ1 == "♦")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(35, 9);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                }
                                else if (sJogo == "4" && iVerJ4 == '0')
                                {
                                    iG1J4 = '1';
                                    iVerJ4 = '1';
                                    Console.SetCursorPosition(27, 11);
                                    Console.WriteLine(sJ1);
                                    if (sJ1 == "♥" || sJ1 == "♦")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(27, 11);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                }
                                else if (sJogo == "5" && iVerJ5 == '0')
                                {
                                    iG1J5 = '1';
                                    iVerJ5 = '1';
                                    Console.SetCursorPosition(31, 11);
                                    Console.WriteLine(sJ1);
                                    if (sJ1 == "♥" || sJ1 == "♦")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(31, 11);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                }
                                else if (sJogo == "6" && iVerJ6 == '0')
                                {
                                    iG1J6 = '1';
                                    iVerJ6 = '1';
                                    Console.SetCursorPosition(35, 11);
                                    Console.WriteLine(sJ1);
                                    if (sJ1 == "♥" || sJ1 == "♦")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(35, 11);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                }
                                else if (sJogo == "7" && iVerJ7 == '0')
                                {
                                    iG1J7 = '1';
                                    iVerJ7 = '1';
                                    Console.SetCursorPosition(27, 13);
                                    Console.WriteLine(sJ1);
                                    if (sJ1 == "♥" || sJ1 == "♦")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(27, 13);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                }
                                else if (sJogo == "8" && iVerJ8 == '0')
                                {
                                    iG1J8 = '1';
                                    iVerJ8 = '1';
                                    Console.SetCursorPosition(31, 13);
                                    Console.WriteLine(sJ1);
                                    if (sJ1 == "♥" || sJ1 == "♦")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(31, 13);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                }
                                else if (sJogo == "9" && iVerJ9 == '0')
                                {
                                    iG1J9 = '1';
                                    iVerJ9 = '1';
                                    Console.SetCursorPosition(35, 13);
                                    Console.WriteLine(sJ1);
                                    if (sJ1 == "♥" || sJ1 == "♦")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(35, 13);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                }
                                if ((iG1J1 == '1' && iG1J2 == '1' && iG1J3 == '1') || (iG1J1 == '1' && iG1J4 == '1' && iG1J7 == '1') || (iG1J1 == '1' && iG1J5 == '1' && iG1J9 == '1') || (iG1J2 == '1' && iG1J5 == '1' && iG1J8 == '1') || (iG1J3 == '1' && iG1J6 == '1' && iG1J9 == '1') || (iG1J3 == '1' && iG1J5 == '1' && iG1J7 == '1') || (iG1J4 == '1' && iG1J5 == '1' && iG1J6 == '1') || (iG1J7 == '1' && iG1J8 == '1' && iG1J9 == '1'))
                                {
                                    iVerFim = '1';
                                    iVerEmpate = '1';
                                    icontJs1++;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.SetCursorPosition(22, 17);
                                    Console.WriteLine("O Jogador 1 Ganhou!");
                                    Console.SetCursorPosition(23, 18);
                                    Console.WriteLine("                   ");
                                    Console.ResetColor();
                                    if (iG1J1 == '1' && iG1J2 == '1' && iG1J3 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(27, 9);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(31, 9);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(35, 9);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                    else if (iG1J1 == '1' && iG1J4 == '1' && iG1J7 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(27, 9);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(27, 11);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(27, 13);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                    else if (iG1J1 == '1' && iG1J5 == '1' && iG1J9 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(27, 9);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(31, 11);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(35, 13);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                    else if (iG1J2 == '1' && iG1J5 == '1' && iG1J8 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(31, 9);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(31, 11);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(31, 13);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                    else if (iG1J3 == '1' && iG1J6 == '1' && iG1J9 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(35, 9);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(35, 11);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(35, 13);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                    else if (iG1J3 == '1' && iG1J5 == '1' && iG1J7 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(35, 9);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(31, 11);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(27, 13);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                    else if (iG1J4 == '1' && iG1J5 == '1' && iG1J6 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(27, 11);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(31, 11);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(35, 11);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                    else if (iG1J7 == '1' && iG1J8 == '1' && iG1J9 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(27, 13);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(31, 13);
                                        Console.WriteLine(sJ1);
                                        Console.SetCursorPosition(35, 13);
                                        Console.WriteLine(sJ1);
                                        Console.ResetColor();
                                    }
                                }
                                if (icont != 5 && iVerFim == '0')
                                {
                                    if (sO == "1")
                                    {
                                        if (icont2 == '0' || sO6 == "1")
                                        {
                                            icont2 = '1';
                                            if ((sO6 == "2" || sO6 == "3") && iG1J5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if ((sO6 == "2" || sO6 == "3") && iG1J5 == '1')
                                            {
                                                sJogo = "3";
                                            }
                                            else if (sO6 == "1")
                                            {
                                                do
                                                {
                                                    var asJogo = new string[9];
                                                    asJogo[0] = "1"; asJogo[1] = "2"; asJogo[2] = "3"; asJogo[3] = "4"; asJogo[4] = "5"; asJogo[5] = "6"; asJogo[6] = "7"; asJogo[7] = "8"; asJogo[8] = "9";
                                                    iTamsJogo = asJogo.Length;
                                                    var rndsJogo = rnd.Next(0, iTamsJogo - 1);
                                                    sJogo = asJogo[rndsJogo];
                                                    Console.SetCursorPosition(14, 20);
                                                    Console.WriteLine("                                     ");
                                                }
                                                while ((iVerJ1 != '0' && sJogo == "1") || (iVerJ2 != '0' && sJogo == "2") || (iVerJ3 != '0' && sJogo == "3") || (iVerJ4 != '0' && sJogo == "4") || (iVerJ5 != '0' && sJogo == "5") || (iVerJ6 != '0' && sJogo == "6") || (iVerJ7 != '0' && sJogo == "7") || (iVerJ8 != '0' && sJogo == "8") || (iVerJ9 != '0' && sJogo == "9"));
                                            }
                                        }
                                        else if (sO6 == "3" && icont2 == '1')
                                        {
                                            //Tentar Ganhar
                                            if (iG2J1 == '1' && iG2J2 == '1' && iVerJ3 == '0')
                                            {
                                                sJogo = "3";
                                            }
                                            else if (iG2J1 == '1' && iG2J3 == '1' && iVerJ2 == '0')
                                            {
                                                sJogo = "2";
                                            }
                                            else if (iG2J2 == '1' && iG2J3 == '1' && iVerJ1 == '0')
                                            {
                                                sJogo = "1";
                                            }
                                            else if (iG2J4 == '1' && iG2J5 == '1' && iVerJ6 == '0')
                                            {
                                                sJogo = "6";
                                            }
                                            else if (iG2J4 == '1' && iG2J6 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG2J5 == '1' && iG2J6 == '1' && iVerJ4 == '0')
                                            {
                                                sJogo = "4";
                                            }
                                            else if (iG2J7 == '1' && iG2J8 == '1' && iVerJ9 == '0')
                                            {
                                                sJogo = "9";
                                            }
                                            else if (iG2J7 == '1' && iG2J9 == '1' && iVerJ8 == '0')
                                            {
                                                sJogo = "8";
                                            }
                                            else if (iG2J8 == '1' && iG2J9 == '1' && iVerJ7 == '0')
                                            {
                                                sJogo = "7";
                                            }
                                            else if (iG2J1 == '1' && iG2J4 == '1' && iVerJ7 == '0')
                                            {
                                                sJogo = "7";
                                            }
                                            else if (iG2J1 == '1' && iG2J7 == '1' && iVerJ4 == '0')
                                            {
                                                sJogo = "4";
                                            }
                                            else if (iG2J4 == '1' && iG2J7 == '1' && iVerJ1 == '0')
                                            {
                                                sJogo = "1";
                                            }
                                            else if (iG2J2 == '1' && iG2J5 == '1' && iVerJ8 == '0')
                                            {
                                                sJogo = "8";
                                            }
                                            else if (iG2J2 == '1' && iG2J8 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG2J5 == '1' && iG2J8 == '1' && iVerJ2 == '0')
                                            {
                                                sJogo = "2";
                                            }
                                            else if (iG2J3 == '1' && iG2J6 == '1' && iVerJ9 == '0')
                                            {
                                                sJogo = "9";
                                            }
                                            else if (iG2J3 == '1' && iG2J9 == '1' && iVerJ6 == '0')
                                            {
                                                sJogo = "6";
                                            }
                                            else if (iG2J6 == '1' && iG2J9 == '1' && iVerJ3 == '0')
                                            {
                                                sJogo = "3";
                                            }
                                            else if (iG2J1 == '1' && iG2J5 == '1' && iVerJ9 == '0')
                                            {
                                                sJogo = "9";
                                            }
                                            else if (iG2J1 == '1' && iG2J9 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG2J5 == '1' && iG2J9 == '1' && iVerJ1 == '0')
                                            {
                                                sJogo = "1";
                                            }
                                            else if (iG2J3 == '1' && iG2J5 == '1' && iVerJ7 == '0')
                                            {
                                                sJogo = "7";
                                            }
                                            else if (iG2J3 == '1' && iG2J7 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG2J7 == '1' && iG2J5 == '1' && iVerJ3 == '0')
                                            {
                                                sJogo = "3";
                                            }
                                            //Não deixar o Jog. 1 Ganhar                                       
                                            else if (iG1J1 == '1' && iG1J2 == '1' && iVerJ3 == '0')
                                            {
                                                sJogo = "3";
                                            }
                                            else if (iG1J1 == '1' && iG1J3 == '1' && iVerJ2 == '0')
                                            {
                                                sJogo = "2";
                                            }
                                            else if (iG1J2 == '1' && iG1J3 == '1' && iVerJ1 == '0')
                                            {
                                                sJogo = "1";
                                            }
                                            else if (iG1J4 == '1' && iG1J5 == '1' && iVerJ6 == '0')
                                            {
                                                sJogo = "6";
                                            }
                                            else if (iG1J4 == '1' && iG1J6 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG1J5 == '1' && iG1J6 == '1' && iVerJ4 == '0')
                                            {
                                                sJogo = "4";
                                            }
                                            else if (iG1J7 == '1' && iG1J8 == '1' && iVerJ9 == '0')
                                            {
                                                sJogo = "9";
                                            }
                                            else if (iG1J7 == '1' && iG1J9 == '1' && iVerJ8 == '0')
                                            {
                                                sJogo = "8";
                                            }
                                            else if (iG1J8 == '1' && iG1J9 == '1' && iVerJ7 == '0')
                                            {
                                                sJogo = "7";
                                            }
                                            else if (iG1J1 == '1' && iG1J4 == '1' && iVerJ7 == '0')
                                            {
                                                sJogo = "7";
                                            }
                                            else if (iG1J1 == '1' && iG1J7 == '1' && iVerJ4 == '0')
                                            {
                                                sJogo = "4";
                                            }
                                            else if (iG1J4 == '1' && iG1J7 == '1' && iVerJ1 == '0')
                                            {
                                                sJogo = "1";
                                            }
                                            else if (iG1J2 == '1' && iG1J5 == '1' && iVerJ8 == '0')
                                            {
                                                sJogo = "8";
                                            }
                                            else if (iG1J2 == '1' && iG1J8 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG1J5 == '1' && iG1J8 == '1' && iVerJ2 == '0')
                                            {
                                                sJogo = "2";
                                            }
                                            else if (iG1J3 == '1' && iG1J6 == '1' && iVerJ9 == '0')
                                            {
                                                sJogo = "9";
                                            }
                                            else if (iG1J3 == '1' && iG1J9 == '1' && iVerJ6 == '0')
                                            {
                                                sJogo = "6";
                                            }
                                            else if (iG1J6 == '1' && iG1J9 == '1' && iVerJ3 == '0')
                                            {
                                                sJogo = "3";
                                            }
                                            else if (iG1J1 == '1' && iG1J5 == '1' && iVerJ9 == '0')
                                            {
                                                sJogo = "9";
                                            }
                                            else if (iG1J1 == '1' && iG1J9 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG1J5 == '1' && iG1J9 == '1' && iVerJ1 == '0')
                                            {
                                                sJogo = "1";
                                            }
                                            else if (iG1J3 == '1' && iG1J5 == '1' && iVerJ7 == '0')
                                            {
                                                sJogo = "9";
                                            }
                                            else if (iG1J3 == '1' && iG1J7 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG1J7 == '1' && iG1J5 == '1' && iVerJ3 == '0')
                                            {
                                                sJogo = "3";
                                            }
                                            else if (icont2 == '1')
                                            {
                                                do
                                                {
                                                    var asJogo = new string[9];
                                                    asJogo[0] = "1"; asJogo[1] = "2"; asJogo[2] = "3"; asJogo[3] = "4"; asJogo[4] = "5"; asJogo[5] = "6"; asJogo[6] = "7"; asJogo[7] = "8"; asJogo[8] = "9";
                                                    iTamsJogo = asJogo.Length;
                                                    var rndsJogo = rnd.Next(0, iTamsJogo - 1);
                                                    sJogo = asJogo[rndsJogo];
                                                    Console.SetCursorPosition(14, 20);
                                                    Console.WriteLine("                                     ");
                                                }
                                                while ((iVerJ1 != '0' && sJogo == "1") || (iVerJ2 != '0' && sJogo == "2") || (iVerJ3 != '0' && sJogo == "3") || (iVerJ4 != '0' && sJogo == "4") || (iVerJ5 != '0' && sJogo == "5") || (iVerJ6 != '0' && sJogo == "6") || (iVerJ7 != '0' && sJogo == "7") || (iVerJ8 != '0' && sJogo == "8") || (iVerJ9 != '0' && sJogo == "9"));
                                            }

                                        }
                                        else if (sO6 == "2" && icont2 == '1')
                                        {
                                            //Tentar Ganhar
                                            if (iG2J1 == '1' && iG2J2 == '1' && iVerJ3 == '0')
                                            {
                                                sJogo = "3";
                                            }
                                            else if (iG2J1 == '1' && iG2J3 == '1' && iVerJ2 == '0')
                                            {
                                                sJogo = "2";
                                            }
                                            else if (iG2J2 == '1' && iG2J3 == '1' && iVerJ1 == '0')
                                            {
                                                sJogo = "1";
                                            }
                                            else if (iG2J4 == '1' && iG2J5 == '1' && iVerJ6 == '0')
                                            {
                                                sJogo = "6";
                                            }
                                            else if (iG2J4 == '1' && iG2J6 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG2J5 == '1' && iG2J6 == '1' && iVerJ4 == '0')
                                            {
                                                sJogo = "4";
                                            }
                                            else if (iG2J7 == '1' && iG2J8 == '1' && iVerJ9 == '0')
                                            {
                                                sJogo = "9";
                                            }
                                            else if (iG2J7 == '1' && iG2J9 == '1' && iVerJ8 == '0')
                                            {
                                                sJogo = "8";
                                            }
                                            else if (iG2J8 == '1' && iG2J9 == '1' && iVerJ7 == '0')
                                            {
                                                sJogo = "7";
                                            }
                                            else if (iG2J1 == '1' && iG2J4 == '1' && iVerJ7 == '0')
                                            {
                                                sJogo = "7";
                                            }
                                            else if (iG2J1 == '1' && iG2J7 == '1' && iVerJ4 == '0')
                                            {
                                                sJogo = "4";
                                            }
                                            else if (iG2J4 == '1' && iG2J7 == '1' && iVerJ1 == '0')
                                            {
                                                sJogo = "1";
                                            }
                                            else if (iG2J2 == '1' && iG2J5 == '1' && iVerJ8 == '0')
                                            {
                                                sJogo = "8";
                                            }
                                            else if (iG2J2 == '1' && iG2J8 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG2J5 == '1' && iG2J8 == '1' && iVerJ2 == '0')
                                            {
                                                sJogo = "2";
                                            }
                                            else if (iG2J3 == '1' && iG2J6 == '1' && iVerJ9 == '0')
                                            {
                                                sJogo = "9";
                                            }
                                            else if (iG2J3 == '1' && iG2J9 == '1' && iVerJ6 == '0')
                                            {
                                                sJogo = "6";
                                            }
                                            else if (iG2J6 == '1' && iG2J9 == '1' && iVerJ3 == '0')
                                            {
                                                sJogo = "3";
                                            }
                                            else if (iG2J1 == '1' && iG2J5 == '1' && iVerJ9 == '0')
                                            {
                                                sJogo = "9";
                                            }
                                            else if (iG2J1 == '1' && iG2J9 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG2J5 == '1' && iG2J9 == '1' && iVerJ1 == '0')
                                            {
                                                sJogo = "1";
                                            }
                                            else if (iG2J3 == '1' && iG2J5 == '1' && iVerJ7 == '0')
                                            {
                                                sJogo = "7";
                                            }
                                            else if (iG2J3 == '1' && iG2J7 == '1' && iVerJ5 == '0')
                                            {
                                                sJogo = "5";
                                            }
                                            else if (iG2J7 == '1' && iG2J5 == '1' && iVerJ3 == '0')
                                            {
                                                sJogo = "3";
                                            }
                                            else if (icont2 == '1')
                                            {
                                                do
                                                {
                                                    var asJogo = new string[9];
                                                    asJogo[0] = "1"; asJogo[1] = "2"; asJogo[2] = "3"; asJogo[3] = "4"; asJogo[4] = "5"; asJogo[5] = "6"; asJogo[6] = "7"; asJogo[7] = "8"; asJogo[8] = "9";
                                                    iTamsJogo = asJogo.Length;
                                                    var rndsJogo = rnd.Next(0, iTamsJogo - 1);
                                                    sJogo = asJogo[rndsJogo];
                                                    Console.SetCursorPosition(14, 20);
                                                    Console.WriteLine("                                     ");
                                                }
                                                while ((iVerJ1 != '0' && sJogo == "1") || (iVerJ2 != '0' && sJogo == "2") || (iVerJ3 != '0' && sJogo == "3") || (iVerJ4 != '0' && sJogo == "4") || (iVerJ5 != '0' && sJogo == "5") || (iVerJ6 != '0' && sJogo == "6") || (iVerJ7 != '0' && sJogo == "7") || (iVerJ8 != '0' && sJogo == "8") || (iVerJ9 != '0' && sJogo == "9"));
                                            }
                                        }
                                    }
                                    else if (sO == "2")
                                    {
                                        do
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.SetCursorPosition(39, 18);
                                            sJogo = Console.ReadLine();
                                            sJogo = sJogo.Trim();
                                            Console.ResetColor();
                                            Console.SetCursorPosition(39, 18);
                                            Console.WriteLine("                   ");
                                            Console.SetCursorPosition(14, 20);
                                            Console.WriteLine("                                     ");
                                            if (sJogo != "1" && sJogo != "2" && sJogo != "3" && sJogo != "4" && sJogo != "5" && sJogo != "6" && sJogo != "7" && sJogo != "8" && sJogo != "9")
                                            {
                                                Console.SetCursorPosition(14, 20);
                                                Console.WriteLine("(Posição não existe. Tente Novamente)");
                                            }
                                            else if ((iVerJ1 != '0' && sJogo == "1") || (iVerJ2 != '0' && sJogo == "2") || (iVerJ3 != '0' && sJogo == "3") || (iVerJ4 != '0' && sJogo == "4") || (iVerJ5 != '0' && sJogo == "5") || (iVerJ6 != '0' && sJogo == "6") || (iVerJ7 != '0' && sJogo == "7") || (iVerJ8 != '0' && sJogo == "8") || (iVerJ9 != '0' && sJogo == "9"))
                                            {
                                                Console.SetCursorPosition(14, 20);
                                                Console.WriteLine("(Posição já existe. Tente Novamente)");
                                            }
                                        }
                                        while (sJogo != "1" && sJogo != "2" && sJogo != "3" && sJogo != "4" && sJogo != "5" && sJogo != "6" && sJogo != "7" && sJogo != "8" && sJogo != "9" || (iVerJ1 != '0' && sJogo == "1") || (iVerJ2 != '0' && sJogo == "2") || (iVerJ3 != '0' && sJogo == "3") || (iVerJ4 != '0' && sJogo == "4") || (iVerJ5 != '0' && sJogo == "5") || (iVerJ6 != '0' && sJogo == "6") || (iVerJ7 != '0' && sJogo == "7") || (iVerJ8 != '0' && sJogo == "8") || (iVerJ9 != '0' && sJogo == "9"));                                       
                                    }
                                    if (sJogo == "1" && iVerJ1 == '0')
                                    {
                                        iG2J1 = '1';
                                        iVerJ1 = '1';
                                        Console.SetCursorPosition(27, 9);
                                        Console.WriteLine(sJ2);
                                    }
                                    else if (sJogo == "2" && iVerJ2 == '0')
                                    {
                                        iG2J2 = '1';
                                        iVerJ2 = '1';
                                        Console.SetCursorPosition(31, 9);
                                        Console.WriteLine(sJ2);
                                    }
                                    else if (sJogo == "3" && iVerJ3 == '0')
                                    {
                                        iG2J3 = '1';
                                        iVerJ3 = '1';
                                        Console.SetCursorPosition(35, 9);
                                        Console.WriteLine(sJ2);
                                    }
                                    else if (sJogo == "4" && iVerJ4 == '0')
                                    {
                                        iG2J4 = '1';
                                        iVerJ4 = '1';
                                        Console.SetCursorPosition(27, 11);
                                        Console.WriteLine(sJ2);
                                    }
                                    else if (sJogo == "5" && iVerJ5 == '0')
                                    {
                                        iG2J5 = '1';
                                        iVerJ5 = '1';
                                        Console.SetCursorPosition(31, 11);
                                        Console.WriteLine(sJ2);
                                    }
                                    else if (sJogo == "6" && iVerJ6 == '0')
                                    {
                                        iG2J6 = '1';
                                        iVerJ6 = '1';
                                        Console.SetCursorPosition(35, 11);
                                        Console.WriteLine(sJ2);
                                    }
                                    else if (sJogo == "7" && iVerJ7 == '0')
                                    {
                                        iG2J7 = '1';
                                        iVerJ7 = '1';
                                        Console.SetCursorPosition(27, 13);
                                        Console.WriteLine(sJ2);
                                    }
                                    else if (sJogo == "8" && iVerJ8 == '0')
                                    {
                                        iG2J8 = '1';
                                        iVerJ8 = '1';
                                        Console.SetCursorPosition(31, 13);
                                        Console.WriteLine(sJ2);
                                    }
                                    else if (sJogo == "9" && iVerJ9 == '0')
                                    {
                                        iG2J9 = '1';
                                        iVerJ9 = '1';
                                        Console.SetCursorPosition(35, 13);
                                        Console.WriteLine(sJ2);
                                    }
                                }
                                if ((iG2J1 == '1' && iG2J2 == '1' && iG2J3 == '1') || (iG2J1 == '1' && iG2J4 == '1' && iG2J7 == '1') || (iG2J1 == '1' && iG2J5 == '1' && iG2J9 == '1') || (iG2J2 == '1' && iG2J5 == '1' && iG2J8 == '1') || (iG2J3 == '1' && iG2J6 == '1' && iG2J9 == '1') || (iG2J3 == '1' && iG2J5 == '1' && iG2J7 == '1') || (iG2J4 == '1' && iG2J5 == '1' && iG2J6 == '1') || (iG2J7 == '1' && iG2J8 == '1' && iG2J9 == '1'))
                                {
                                    iVerFim = '1';
                                    iVerEmpate = '1';
                                    icontJs2++;
                                    Console.SetCursorPosition(23, 17);
                                    Console.WriteLine("                   ");
                                    if (sO == "1")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.SetCursorPosition(22, 17);
                                        Console.WriteLine("O Computador Ganhou!");
                                        Console.ResetColor();
                                        Console.SetCursorPosition(22, 18);
                                        Console.WriteLine("                   ");
                                    }
                                    else if (sO == "2")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.SetCursorPosition(22, 17);
                                        Console.WriteLine("O Jogador 2 Ganhou!");
                                        Console.ResetColor();
                                        Console.SetCursorPosition(22, 18);
                                        Console.WriteLine("                   ");
                                    }
                                    if (iG2J1 == '1' && iG2J2 == '1' && iG2J3 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(27, 9);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(31, 9);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(35, 9);
                                        Console.WriteLine(sJ2);
                                        Console.ResetColor();
                                    }
                                    else if (iG2J1 == '1' && iG2J4 == '1' && iG2J7 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(27, 9);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(27, 11);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(27, 13);
                                        Console.WriteLine(sJ2);
                                        Console.ResetColor();
                                    }
                                    else if (iG2J1 == '1' && iG2J5 == '1' && iG2J9 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(27, 9);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(31, 11);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(35, 13);
                                        Console.WriteLine(sJ2);
                                        Console.ResetColor();
                                    }
                                    else if (iG2J2 == '1' && iG2J5 == '1' && iG2J8 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(31, 9);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(31, 11);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(31, 13);
                                        Console.WriteLine(sJ2);
                                        Console.ResetColor();
                                    }
                                    else if (iG2J3 == '1' && iG2J6 == '1' && iG2J9 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(35, 9);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(35, 11);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(35, 13);
                                        Console.WriteLine(sJ2);
                                        Console.ResetColor();
                                    }
                                    else if (iG2J3 == '1' && iG2J5 == '1' && iG2J7 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(35, 9);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(31, 11);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(27, 13);
                                        Console.WriteLine(sJ2);
                                        Console.ResetColor();
                                    }
                                    else if (iG2J4 == '1' && iG2J5 == '1' && iG2J6 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(27, 11);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(31, 11);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(35, 11);
                                        Console.WriteLine(sJ2);
                                        Console.ResetColor();
                                    }
                                    else if (iG2J7 == '1' && iG2J8 == '1' && iG2J9 == '1')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(27, 13);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(31, 13);
                                        Console.WriteLine(sJ2);
                                        Console.SetCursorPosition(35, 13);
                                        Console.WriteLine(sJ2);
                                        Console.ResetColor();
                                    }
                                }
                            }
                        }
                        if (iVerEmpate == '0')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(23, 17);
                            Console.WriteLine("                   ");
                            Console.SetCursorPosition(23, 18);
                            Console.WriteLine("                   ");
                            Console.SetCursorPosition(28, 17);
                            Console.WriteLine("Empate!");
                            Console.ResetColor(); 
                        }
                        if (sO1 != "1")
                        {
                            if ((sO1 == "2" || sO1 == "3") && icontJs1 == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.SetCursorPosition(9, 12);
                                Console.WriteLine("I");
                                Console.ResetColor();
                            }
                            if ((sO1 == "2" || sO1 == "3") && icontJs2 == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.SetCursorPosition(48, 12);
                                Console.WriteLine("I");
                                Console.ResetColor();
                            }
                            if (sO1 == "3" && icontJs1 == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.SetCursorPosition(9, 12);
                                Console.WriteLine("I I");
                                Console.ResetColor();
                            }
                            if (sO1 == "3" && icontJs2 == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.SetCursorPosition(48, 12);
                                Console.WriteLine("I I");
                                Console.ResetColor();
                            }
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            if (sO1 == "2" && icontJs1 == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.SetCursorPosition(9, 12);
                                Console.WriteLine("I I");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            else if (sO1 == "3" && icontJs1 == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.SetCursorPosition(9, 12);
                                Console.WriteLine("I I I");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            Console.SetCursorPosition(8, 10);
                            Console.WriteLine("Vitórias");
                            Console.SetCursorPosition(6, 11);
                            Console.WriteLine("Do Jogador 1");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            if (sO1 == "2" && icontJs2 == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.SetCursorPosition(48, 12);
                                Console.WriteLine("I I");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            else if (sO1 == "3" && icontJs2 == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.SetCursorPosition(48, 12);
                                Console.WriteLine("I I I");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            Console.SetCursorPosition(47, 10);
                            Console.WriteLine("Vitórias");
                            Console.SetCursorPosition(45, 11);
                            Console.WriteLine("Do Jogador 2");
                            if (sO == "1")
                            {
                                Console.SetCursorPosition(44, 11);
                                Console.WriteLine("Do Computador");
                            }
                            Console.ResetColor();
                        }                        
                        Console.SetCursorPosition(19, 21);
                        Console.WriteLine("(Prima Enter para Voltar)");
                        Console.SetCursorPosition(44, 21);
                        Console.ReadLine();
                        Console.SetCursorPosition(19, 21);
                        Console.WriteLine("                         ");
                        Console.SetCursorPosition(22, 17);
                        Console.WriteLine("                         ");
                    }
                    while ((sO1 == "2" && icontJs1 != 2 && icontJs2 < 2) || (sO1 == "2" && icontJs2 != 2 && icontJs1 < 2) || (sO1 == "3" && icontJs1 != 3 && icontJs2 < 3) || (sO1 == "3" && icontJs2 != 3 && icontJs1 < 3));
                }                         
                else if (sO == "3")
                {
                    do
                    {
                        LimparLinhas();
                        //Menu
                        Console.SetCursorPosition(3, 5);
                        Console.WriteLine("Configurações:                                       ");
                        Console.SetCursorPosition(3, 7);
                        Console.WriteLine("1 - Alterar símbolo de jogo                          ");
                        Console.SetCursorPosition(3, 8);
                        Console.WriteLine("2 - Alterar cor de fundo                             ");
                        Console.SetCursorPosition(3, 9);
                        Console.WriteLine("3 - Alterar cor do tabuleiro                         ");
                        Console.SetCursorPosition(3, 10);
                        Console.WriteLine("4 - Alterar Dificuldade                              ");
                        Console.SetCursorPosition(3, 11);
                        Console.WriteLine("5 - Pré-Definições                                   ");
                        Console.SetCursorPosition(3, 12);
                        Console.WriteLine("6 - Voltar ao Menu                                   ");                     
                        Console.SetCursorPosition(3, 13);
                        sO2 = Console.ReadLine();
                        sO2 = sO2.Trim();
                        LimparLinhas();
                        if (sO2 == "1")
                        {
                            do
                            {
                                Console.SetCursorPosition(3, 15);
                                Console.WriteLine("     ");
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("Escolha um símbolo de jogo para o ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.SetCursorPosition(37, 5);
                                Console.WriteLine("Jogador 1");
                                Console.ResetColor();
                                Console.SetCursorPosition(3, 7);
                                Console.WriteLine("1 - X   ");                                
                                Console.SetCursorPosition(3, 9);
                                Console.WriteLine("2 - ■   ");                                
                                Console.SetCursorPosition(3, 11);
                                Console.WriteLine("3 -     ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(7, 11);
                                Console.WriteLine("♦");
                                Console.ResetColor();
                                Console.SetCursorPosition(3, 13);
                                Console.WriteLine("4 -     ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(7, 13);
                                Console.WriteLine("♥");
                                Console.ResetColor();                                
                                Console.SetCursorPosition(3, 15);
                                sO3 = Console.ReadLine();
                                sO3 = sO3.Trim();
                                if (sO3 == "1")
                                {
                                    sJ1 = "X";
                                }
                                else if (sO3 == "2")
                                {
                                    sJ1 = "■";
                                }                                
                                else if (sO3 == "3")
                                {
                                    sJ1 = "♦";
                                }                               
                                else if (sO3 == "4")
                                {
                                    sJ1 = "♥";
                                }                                
                                else if (sO3 != "1" && sO3 != "2" && sO3 != "3" && sO3 != "4")
                                {
                                    LimparLinhas();
                                    Console.SetCursorPosition(3, 5);
                                    Console.WriteLine("Opção inválida, prima Enter para voltar           ");                                   
                                    Console.SetCursorPosition(43, 5);
                                    Console.ReadLine();
                                }
                            }
                            while (sO3 != "1" && sO3 != "2" && sO3 != "3" && sO3 != "4");
                            do
                            {
                                Console.SetCursorPosition(3, 15);
                                Console.WriteLine("     ");
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("Escolha um símbolo de jogo para o ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.SetCursorPosition(37, 5);
                                Console.WriteLine("Jogador 2");
                                Console.ResetColor();
                                Console.SetCursorPosition(10, 7);
                                Console.WriteLine("│ 1 - O ");
                                Console.SetCursorPosition(10, 8);
                                Console.WriteLine("│ ");
                                Console.SetCursorPosition(10, 9);
                                Console.WriteLine("│ 2 - ▲ ");
                                Console.SetCursorPosition(10, 10);
                                Console.WriteLine("│  ");
                                Console.SetCursorPosition(10, 11);
                                Console.WriteLine("│ 3 - ♣ ");
                                Console.SetCursorPosition(10, 12);
                                Console.WriteLine("│  ");
                                Console.SetCursorPosition(10, 13);
                                Console.WriteLine("│ 4 - ♠ ");                                
                                Console.SetCursorPosition(12, 15);
                                sO3 = Console.ReadLine();
                                sO3 = sO3.Trim();                                
                                if (sO3 == "1")
                                {
                                    sJ2 = "O";
                                }
                                else if (sO3 == "2")
                                {
                                    sJ2 = "▲";
                                }
                                else if (sO3 == "3")
                                {
                                    sJ2 = "♣";
                                }
                                else if (sO3 == "4")
                                {
                                    sJ2 = "♠";
                                }
                                else if (sO3 != "1" && sO3 != "2" && sO3 != "3" && sO3 != "4")
                                {
                                    LimparLinhas();
                                    Console.SetCursorPosition(3, 5);
                                    Console.WriteLine("Opção inválida, prima Enter para voltar           ");                                   
                                    Console.SetCursorPosition(43, 5);
                                    Console.ReadLine();
                                }
                            }
                            while (sO3 != "1" && sO3 != "2" && sO3 != "3" && sO3 != "4");
                            LimparLinhas();
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Símbolos Escolhidos:                            ");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("Jogador 1: " + sJ1 + "       ");
                            if (sJ1 == "♦" || sJ1 == "♥")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(14, 7);
                                Console.WriteLine(sJ1);
                                Console.ResetColor();
                            }                            
                            Console.SetCursorPosition(3, 9);
                            Console.WriteLine("Jogador 2: " + sJ2 + "       ");                            
                            Console.SetCursorPosition(3, 11);
                            Console.WriteLine("(Prima Enter para Voltar)                            ");                                                
                            Console.SetCursorPosition(3, 12);
                            Console.ReadLine();
                        }
                        else if (sO2 == "2")
                        {
                            do
                            {
                                LimparLinhas();
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("Cor de Fundo");
                                Console.SetCursorPosition(3, 7);
                                Console.WriteLine("1 - ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.SetCursorPosition(7, 7);
                                Console.WriteLine("Azul");
                                Console.ResetColor();
                                Console.SetCursorPosition(3, 8);
                                Console.WriteLine("2 - ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(7, 8);
                                Console.WriteLine("Vermelho");
                                Console.ResetColor();
                                Console.SetCursorPosition(3, 9);
                                Console.WriteLine("3 - ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.SetCursorPosition(7, 9);
                                Console.WriteLine("Amarelo");
                                Console.ResetColor();
                                Console.SetCursorPosition(3, 10);
                                Console.WriteLine("4 - ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(7, 10);
                                Console.WriteLine("Verde");
                                Console.ResetColor();
                                Console.SetCursorPosition(3, 11);
                                Console.WriteLine("5 - ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(7, 11);
                                Console.WriteLine("Branco");
                                Console.ResetColor();
                                Console.SetCursorPosition(3, 12);
                                sO5 = Console.ReadLine();
                                sO5 = sO5.Trim();
                                if (sO5 != "1" && sO5 != "2" && sO5 != "3" && sO5 != "4" && sO5 != "5")
                                {
                                    LimparLinhas();
                                    Console.SetCursorPosition(3, 5);
                                    Console.WriteLine("Opção inválida, prima Enter para voltar ");                                   
                                    Console.SetCursorPosition(43, 5);
                                    Console.ReadLine();
                                }
                            }
                            while (sO5 != "1" && sO5 != "2" && sO5 != "3" && sO5 != "4" && sO5 != "5");
                            LimparLinhas();
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Cor de Fundo escolhida - Volte ao Menu para ver ");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("(Prima Enter para Voltar)         ");                           
                            Console.SetCursorPosition(3, 8);
                            Console.ReadLine();
                        }
                        else if (sO2 == "3")
                        {
                            do
                            {
                                LimparLinhas();
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("Cor do Tabuleiro");
                                Console.SetCursorPosition(3, 7);
                                Console.WriteLine("1 - ");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.SetCursorPosition(7, 7);
                                Console.WriteLine("Cinzento");
                                Console.ResetColor();
                                Console.SetCursorPosition(3, 8);
                                Console.WriteLine("2 - ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(7, 8);
                                Console.WriteLine("Vermelho");
                                Console.ResetColor();
                                Console.SetCursorPosition(3, 9);
                                Console.WriteLine("3 - ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(7, 9);
                                Console.WriteLine("Verde");
                                Console.ResetColor();
                                Console.SetCursorPosition(3, 10);
                                Console.WriteLine("4 - ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.SetCursorPosition(7, 10);
                                Console.WriteLine("Azul");
                                Console.ResetColor();
                                Console.SetCursorPosition(3, 11);
                                sO4 = Console.ReadLine();
                                sO4 = sO4.Trim();
                                if (sO4 != "1" && sO4 != "2" && sO4 != "3" && sO4 != "4")
                                {
                                    LimparLinhas();
                                    Console.SetCursorPosition(3, 5);
                                    Console.WriteLine("Opção inválida, prima Enter para voltar           ");                                    
                                    Console.SetCursorPosition(43, 5);
                                    Console.ReadLine();
                                }
                            }
                            while (sO4 != "1" && sO4 != "2" && sO4 != "3" && sO4 != "4");
                            LimparLinhas();
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Cor de Tabuleiro escolhida              ");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("(Prima Enter para Voltar)             ");
                            Console.SetCursorPosition(3, 8);
                            Console.ReadLine();
                        }
                        else if (sO2 == "4")
                        {
                            do
                            {
                                LimparLinhas();
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("Dificuldade                       ");
                                Console.SetCursorPosition(3, 7);
                                Console.WriteLine("1 - Fácil                         ");
                                Console.SetCursorPosition(3, 8);
                                Console.WriteLine("2 - Normal                        ");
                                Console.SetCursorPosition(3, 9);
                                Console.WriteLine("3 - Difícil                       ");
                                Console.SetCursorPosition(3, 10);
                                sO6 = Console.ReadLine();
                                if (sO6 != "1" && sO6 != "2" && sO6 != "3")
                                {
                                    LimparLinhas();
                                    Console.SetCursorPosition(3, 5);
                                    Console.WriteLine("Opção inválida, prima Enter para voltar");                         
                                    Console.SetCursorPosition(43, 5);
                                    Console.ReadLine();
                                }
                            }
                            while (sO6 != "1" && sO6 != "2" && sO6 != "3");
                            LimparLinhas();
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Dificuldade escolhida                 ");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("(Prima Enter para Voltar)             ");                          
                            Console.SetCursorPosition(3, 8);
                            Console.ReadLine();
                        }
                        else if (sO2 == "5")
                        {
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Pré - Definições                  ");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("Jogador 1 : X                     ");
                            Console.SetCursorPosition(3, 8);
                            Console.WriteLine("Jogador 2 : O                     ");
                            Console.SetCursorPosition(3, 9);
                            Console.WriteLine("Cor de Fundo :                    ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(18, 9);
                            Console.WriteLine("Azul");
                            Console.ResetColor();
                            Console.SetCursorPosition(3, 10);
                            Console.WriteLine("Cor do Tabuleiro :                ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.SetCursorPosition(22, 10);
                            Console.WriteLine("Cinzento");
                            Console.ResetColor();                            
                            Console.SetCursorPosition(3, 11);
                            Console.WriteLine("Diculdade : Normal");
                            Console.SetCursorPosition(3, 13);
                            Console.WriteLine("(Prima Enter para Voltar)         ");
                            Console.SetCursorPosition(3, 14);
                            Console.ReadLine();
                            sJ1 = "X";
                            sJ2 = "O";
                            sO4 = "1";
                            sO5 = "1";
                            sO6 = "2";
                        }
                        else if (sO2 != "1" && sO2 != "2" && sO2 != "3" && sO2 != "4" && sO2 != "5" && sO2 != "6")
                        {
                            LimparLinhas();
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Opção inválida, prima Enter para voltar");
                            Console.SetCursorPosition(43, 5);
                            Console.ReadLine();
                        }
                    }
                    while (sO2 != "6");
                }
                else if (sO == "4")
                {
                    LimparLinhas();
                    Console.SetCursorPosition(3, 5);
                    Console.WriteLine("Deseja Sair? (Sim/Não)");
                    Console.SetCursorPosition(3, 7);
                    sSair = Console.ReadLine();
                    sSair.Trim();
                    sSair = sSair.ToLower();
                    while (sSair != "sim" && sSair != "nao" && sSair != "não" && sSair != "s" && sSair != "n")
                    {
                        LimparLinhas();
                        Console.SetCursorPosition(3, 5);
                        Console.WriteLine("Opção inválida, tente novamente");                        
                        Console.SetCursorPosition(3, 7);
                        Console.WriteLine("Deseja Sair? (Sim/Não)");
                        Console.SetCursorPosition(3, 8);
                        Console.WriteLine("                      ");
                        Console.SetCursorPosition(3, 8);
                        sSair = Console.ReadLine();
                        sSair = sSair.Trim();
                        sSair = sSair.ToLower();
                    }
                }
                else if (sO != "1" && sO != "2" && sO != "3" && sO != "4")
                {
                    LimparLinhas();
                    Console.SetCursorPosition(3, 5);
                    Console.WriteLine("Opção inválida, prima enter para voltar");                    
                    Console.SetCursorPosition(43, 5);
                    Console.ReadLine();
                }
            }
            while (sSair == "nao" || sSair == "não" || sSair == "n");            
        }    
    }
}