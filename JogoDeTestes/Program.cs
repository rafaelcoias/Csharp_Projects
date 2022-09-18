using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natal
{
    class Program
    {
        static void LimparLinhas()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                ║\n╠════════════════════════════════════════════════╣\n║                                                ║");
            Console.WriteLine("║                                                ║\n║                                                ║\n║                                                ║");
            Console.WriteLine("║                                                ║\n║                                                ║\n║                                                ║");
            Console.WriteLine("║                                                ║\n║                                                ║\n║                                                ║");
            Console.WriteLine("║                                                ║\n║                                                ║\n║                                                ║");
            Console.WriteLine("║                                                ║\n║                                                ║\n║                                                ║");
            Console.WriteLine("║                                                ║\n║                                                ║\n║                                                ║");
            Console.WriteLine("║                                                ║\n║                                                ║\n║                                                ║");
            Console.WriteLine("║                                                ║\n║                                                ║\n║                                                ║");
            Console.WriteLine("║                                                ║\n║                                                ║\n║                                                ║");
            Console.WriteLine("║                                                ║\n║                                                ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
        }
        static void Main(string[] args)
        {
            int cME = 0, cMC = 0, cCE = 0, cCC = 0, cHE = 0, cHC = 0, cGE = 0, cGC = 0;
            string M1, M2, M3, M4, M5, C1, C2, C3, C4, C5, H1, H2, H3, H4, H5, G1, G2, G3, G4, G5, sO, sO1, sSair;
            sSair = "nao";

            //Início
            Console.Title = "Jogo de Testes";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            LimparLinhas();
            Console.SetCursorPosition(12, 1);
            Console.WriteLine("BEM-VINDO AO JOGO DE TESTE");
            Console.SetCursorPosition(18, 3);
            Console.WriteLine("(Prima Enter)");
            Console.SetCursorPosition(31, 3);
            Console.ReadLine();

            do
            {
                //Menu
                LimparLinhas();
                Console.SetCursorPosition(22, 1);
                Console.WriteLine("MENU");
                Console.SetCursorPosition(18, 5);
                Console.WriteLine("1   -   Jogar");
                Console.SetCursorPosition(18, 7);
                Console.WriteLine("2   -   Resultados");
                Console.SetCursorPosition(18, 9);
                Console.WriteLine("3   -   Como Jogar");
                Console.SetCursorPosition(18, 11);
                Console.WriteLine("4   -   Sair");
                Console.SetCursorPosition(18, 13);
                sO = Console.ReadLine();
                sO = sO.Trim();
                if (sO == "1")
                {
                    do
                    {
                        LimparLinhas();
                        Console.SetCursorPosition(17, 1);
                        Console.WriteLine("ESCOLHA UM TEMA");
                        Console.SetCursorPosition(15, 5);
                        Console.WriteLine("1   -   Matemática");
                        Console.SetCursorPosition(15, 7);
                        Console.WriteLine("2   -   Ciência");
                        Console.SetCursorPosition(15, 9);
                        Console.WriteLine("3   -   História");
                        Console.SetCursorPosition(15, 11);
                        Console.WriteLine("4   -   Geografia");
                        Console.SetCursorPosition(15, 13);
                        Console.WriteLine("5   -   Voltar ao Menu");
                        Console.SetCursorPosition(15, 15);
                        sO1 = Console.ReadLine();
                        sO1 = sO1.Trim();
                        if (sO1 != "1" && sO1 != "2" && sO1 != "3" && sO1 != "4" && sO1 != "5")
                        {
                            LimparLinhas();
                            Console.SetCursorPosition(9, 1);
                            Console.WriteLine("Opção inválida, tente novamente.");
                            Console.SetCursorPosition(21, 3);
                            Console.WriteLine("(Voltar)");
                            Console.SetCursorPosition(29, 3);
                            Console.ReadLine();
                        }
                        else if (sO1 == "1")
                        {
                            LimparLinhas();
                            cME = 0;
                            cMC = 0;
                            Console.SetCursorPosition(16, 1);
                            Console.WriteLine("TEMA: MATEMÁTICA");
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Pergunta 1");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("Quanto é 6 x 9 ?");
                            Console.SetCursorPosition(3, 8);
                            M1 = Console.ReadLine();
                            M1 = M1.Trim();
                            if (M1 != "54")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 9);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cME++;
                            }
                            else if (M1 == "54")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 9);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cMC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 10);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 12);
                            Console.WriteLine("Pergunta 2");
                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine("Quanto é a raiz quadrada de 144?");
                            Console.SetCursorPosition(3, 15);
                            M2 = Console.ReadLine();
                            M2 = M2.Trim();
                            if (M2 != "12")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 16);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cME++;
                            }
                            else if (M2 == "12")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 16);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cMC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 17);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 19);
                            Console.WriteLine("Pergunta 3");
                            Console.SetCursorPosition(3, 21);
                            Console.WriteLine("Quanto é 214 / 2 ?");
                            Console.SetCursorPosition(3, 22);
                            M3 = Console.ReadLine();
                            M3 = M3.Trim();
                            if (M3 != "107")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 23);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cME++;
                            }
                            else if (M3 == "107")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 23);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cMC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 24);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 26);
                            Console.WriteLine("Pergunta 4");
                            Console.SetCursorPosition(3, 28);
                            Console.WriteLine("Quanto é 14 + 12 x 2");
                            Console.SetCursorPosition(3, 29);
                            M4 = Console.ReadLine();
                            M4 = M4.Trim();
                            if (M4 != "38")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 30);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cME++;
                            }
                            else if (M4 == "38")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 30);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cMC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(3, 32);
                            Console.WriteLine("(Enter - Continuar)");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(22, 32);
                            Console.ReadLine();
                            LimparLinhas();
                            Console.SetCursorPosition(16, 1);
                            Console.WriteLine("TEMA: MATEMÁTICA");
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Pergunta final");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("Qual o valor de 'a' na equação: ");
                            Console.SetCursorPosition(3, 8);
                            Console.WriteLine("4a - 72 + 8 = 0 ");
                            Console.SetCursorPosition(3, 10);
                            M5 = Console.ReadLine();
                            if (M5 != "16")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 11);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cME++;
                            }
                            else if (M5 == "16")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 11);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cMC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 12);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine("(Prima enter para ver os resultados)");
                            Console.SetCursorPosition(3, 15);
                            Console.ReadLine();
                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine("Resultados:                         ");
                            Console.SetCursorPosition(3, 16);
                            Console.WriteLine(cME + " respostas erradas.");
                            Console.SetCursorPosition(3, 17);
                            Console.WriteLine(cMC + " respostas certas.");
                            if (cME > cMC)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(3, 19);
                                Console.WriteLine("Reprovado a Matemática");
                                Console.ResetColor();
                            }
                            else if (cME < cMC)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(3, 19);
                                Console.WriteLine("Aprovado a Matemática");
                                Console.ResetColor();
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 21);
                            Console.WriteLine("(Voltar)");
                            Console.SetCursorPosition(11, 21);
                            Console.ReadLine();
                        }
                        else if (sO1 == "2")
                        {
                            cCE = 0;
                            cCC = 0;
                            LimparLinhas();
                            Console.SetCursorPosition(19, 1);
                            Console.WriteLine("TEMA: CIÊNCIA");
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Pergunta 1");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("Qual a fórmula Química da água?");
                            Console.SetCursorPosition(3, 8);
                            C1 = Console.ReadLine();
                            C1 = C1.Trim();
                            C1 = C1.ToUpper();
                            if (C1 != "H2O" && C1 != "H20")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 9);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cCE++;
                            }
                            else if (C1 == "H2O" || C1 == "H20")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 9);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cCC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 10);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 12);
                            Console.WriteLine("Pergunta 2");
                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine("Qual o nome da camada interna mais");
                            Console.SetCursorPosition(3, 15);
                            Console.WriteLine("quente da terra?");
                            Console.SetCursorPosition(3, 16);
                            C2 = Console.ReadLine();
                            C2 = C2.Trim();
                            C2 = C2.ToUpper();
                            if (C2 != "NUCLEO" && C2 != "NÚCLEO")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 17);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cCE++;
                            }
                            else if (C2 == "NÚCLEO" || C2 == "NUCLEO")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 17);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cCC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 18);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 20);
                            Console.WriteLine("Pergunta 3");
                            Console.SetCursorPosition(3, 22);
                            Console.WriteLine("Qual o sétimo planeta do sistema solar?");
                            Console.SetCursorPosition(3, 23);
                            C3 = Console.ReadLine();
                            C3 = C3.Trim();
                            C3 = C3.ToUpper();
                            if (C3 != "URANO")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 24);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cCE++;
                            }
                            else if (C3 == "URANO")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 24);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cCC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 25);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 27);
                            Console.WriteLine("Pergunta 4");
                            Console.SetCursorPosition(3, 29);
                            Console.WriteLine("Qual o ponto cardial em que o Sol nasce?");
                            Console.SetCursorPosition(3, 30);
                            C4 = Console.ReadLine();
                            C4 = C4.Trim();
                            C4 = C4.ToUpper();
                            if (C4 != "ESTE" && C4 != "LESTE" && C4 != "E")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 31);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cCE++;
                            }
                            else if (C4 == "ESTE" || C4 == "LESTE" || C4 == "E")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 31);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cCC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(3, 32);
                            Console.WriteLine("(Enter - Continuar)");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(22, 32);
                            Console.ReadLine();
                            LimparLinhas();
                            Console.SetCursorPosition(19, 1);
                            Console.WriteLine("TEMA: CIÊNCIA");
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Pergunta final");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("Como se chama a linha imaginária que divíde");
                            Console.SetCursorPosition(3, 8);
                            Console.WriteLine("os dois hemisférios do planeta?");
                            Console.SetCursorPosition(3, 9);
                            C5 = Console.ReadLine();
                            C5 = C5.Trim();
                            C5 = C5.ToUpper();
                            if (C5 != "EQUADOR")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 10);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cCE++;
                            }
                            else if (C5 == "EQUADOR")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 10);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cCC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 12);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine("(Prima enter para ver os resultados)");
                            Console.SetCursorPosition(3, 15);
                            Console.ReadLine();
                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine("Resultados:                         ");
                            Console.SetCursorPosition(3, 16);
                            Console.WriteLine(cCE + " respostas erradas.");
                            Console.SetCursorPosition(3, 17);
                            Console.WriteLine(cCC + " respostas certas.");
                            if (cCE > cCC)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(3, 19);
                                Console.WriteLine("Reprovado a Ciências");
                                Console.ResetColor();
                            }
                            else if (cCE < cCC)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(3, 19);
                                Console.WriteLine("Aprovado a Ciências");
                                Console.ResetColor();
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 21);
                            Console.WriteLine("(Voltar)");
                            Console.SetCursorPosition(11, 21);
                            Console.ReadLine();
                        }
                        else if (sO1 == "3")
                        {
                            cHE = 0;
                            cHC = 0;
                            LimparLinhas();
                            Console.SetCursorPosition(19, 1);
                            Console.WriteLine("TEMA: HISTÓRIA");
                            Console.SetCursorPosition(3, 3);
                            Console.WriteLine("Pergunta 1");
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Que dia do ano é conhecido como");
                            Console.SetCursorPosition(3, 6);
                            Console.WriteLine("'o dia da liberdade'?");
                            Console.SetCursorPosition(3, 7);
                            H1 = Console.ReadLine();
                            H1 = H1.Trim();
                            H1 = H1.ToUpper();
                            if (H1 != "25 DE ABRIL" && H1 != "25 DO 4" && H1 != "25/4" && H1 != "25.4" && H1 != "25/04")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 8);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cHE++;
                            }
                            else if (H1 == "25 DE ABRIL" || H1 == "25 DO 4" || H1 == "25/4" || H1 == "25.4" || H1 == "25/04")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 8);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cHC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 9);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 11);
                            Console.WriteLine("Pergunta 2");
                            Console.SetCursorPosition(3, 13);
                            Console.WriteLine("Em que ano houve o atentado às");
                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine("torres gêmeas nos EUA?");
                            Console.SetCursorPosition(3, 15);
                            H2 = Console.ReadLine();
                            H2 = H2.Trim();
                            H2 = H2.ToUpper();
                            if (H2 != "2001")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 16);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cHE++;
                            }
                            else if (H2 == "2001")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 16);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cHC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 17);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 19);
                            Console.WriteLine("Pergunta 3");
                            Console.SetCursorPosition(3, 21);
                            Console.WriteLine("Quem pintou a capela sistina?");
                            Console.SetCursorPosition(3, 22);
                            H3 = Console.ReadLine();
                            H3 = H3.Trim();
                            H3 = H3.ToUpper();
                            if (H3 != "MIGUEL ANGELO" && H3 != "MIGUEL ÂNGELO" && H3 != "MICHAEL ANGELO" && H3 != "MICHAEL ÂNGELO")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 23);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cHE++;
                            }
                            else if (H3 == "MIGUEL ANGELO" || H3 == "MIGUEL ÂNGELO" || H3 == "MICHAEL ANGELO" || H3 == "MICHAEL ÂNGELO")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 23);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cHC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 24);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 26);
                            Console.WriteLine("Pergunta 4");
                            Console.SetCursorPosition(3, 28);
                            Console.WriteLine("Em que ano começou a primeira guerra mundial?");
                            Console.SetCursorPosition(3, 29);
                            H4 = Console.ReadLine();
                            H4 = H4.Trim();
                            H4 = H4.ToUpper();
                            if (H4 != "1914")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 30);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cHE++;
                            }
                            else if (H4 == "1914")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 30);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cHC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(3, 32);
                            Console.WriteLine("(Enter - Continuar)");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(22, 32);
                            Console.ReadLine();
                            LimparLinhas();
                            Console.SetCursorPosition(19, 1);
                            Console.WriteLine("TEMA: HISTÓRIA");
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Pergunta final");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("Que imperador invadiu Portugal no século XIX?");
                            Console.SetCursorPosition(3, 8);
                            H5 = Console.ReadLine();
                            H5 = H5.Trim();
                            H5 = H5.ToUpper();
                            if (H5 != "NAPOLEÃO" && H5 != "NAPOLEAO")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 9);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cHE++;
                            }
                            else if (H5 == "NAPOLEÃO" || H5 == "NAPOLEAO")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 9);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cHC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 10);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 12);
                            Console.WriteLine("(Prima enter para ver os resultados)");
                            Console.SetCursorPosition(3, 13);
                            Console.ReadLine();
                            Console.SetCursorPosition(3, 12);
                            Console.WriteLine("Resultados:                         ");
                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine(cHE + " respostas erradas.");
                            Console.SetCursorPosition(3, 15);
                            Console.WriteLine(cHC + " respostas certas.");
                            if (cHE > cHC)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(3, 17);
                                Console.WriteLine("Reprovado a História");
                                Console.ResetColor();
                            }
                            else if (cHE < cHC)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(3, 17);
                                Console.WriteLine("Aprovado a História");
                                Console.ResetColor();
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 19);
                            Console.WriteLine("(Voltar)");
                            Console.SetCursorPosition(11, 19);
                            Console.ReadLine();                            
                        }
                        else if (sO1 == "4")
                        {
                            cGE = 0;
                            cGC = 0;
                            LimparLinhas();
                            Console.SetCursorPosition(16, 1);
                            Console.WriteLine("TEMA: GEOGRAFIA");
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Pergunta 1");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("Qual o maior país do mundo?");
                            Console.SetCursorPosition(3, 8);
                            G1 = Console.ReadLine();
                            G1 = G1.ToUpper();
                            G1 = G1.Trim();
                            if (G1 != "RUSSIA" && G1 != "RÚSSIA")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 9);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cGE++;
                            }
                            else if (G1 == "RUSSIA" || G1 == "RÚSSIA")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 9);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cGC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 10);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 12);
                            Console.WriteLine("Pergunta 2");
                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine("Qual a língua falada na Escócia?");
                            Console.SetCursorPosition(3, 15);
                            G2 = Console.ReadLine();
                            G2 = G2.ToUpper();
                            G2 = G2.Trim();
                            if (G2 != "INGLES" && G2 != "INGLÊS")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 16);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cGE++;
                            }
                            else if (G2 == "INGLES" || G2 == "INGLÊS")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 16);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cGC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 17);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 19);
                            Console.WriteLine("Pergunta 3");
                            Console.SetCursorPosition(3, 21);
                            Console.WriteLine("Em que continente fica a Austrália?");
                            Console.SetCursorPosition(3, 22);
                            G3 = Console.ReadLine();
                            G3 = G3.ToUpper();
                            G3 = G3.Trim();
                            if (G3 != "OCEANIA" && G3 != "OCEÂNIA")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 23);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cGE++;
                            }
                            else if (G3 == "OCEANIA" || G3 == "OCEÂNIA")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 23);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cGC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 24);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 26);
                            Console.WriteLine("Pergunta 4");
                            Console.SetCursorPosition(3, 28);
                            Console.WriteLine("Qual a capital da Suíça?");
                            Console.SetCursorPosition(3, 29);
                            G4 = Console.ReadLine();
                            G4 = G4.ToUpper();
                            G4 = G4.Trim();
                            if (G4 != "ZURIQUE")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 30);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cGE++;
                            }
                            else if (G4 == "ZURIQUE")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 30);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cGC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(3, 32);
                            Console.WriteLine("(Enter - Continuar)");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(22, 32);
                            Console.ReadLine();
                            LimparLinhas();
                            Console.SetCursorPosition(16, 1);
                            Console.WriteLine("TEMA: GEOGRAFIA");
                            Console.SetCursorPosition(3, 5);
                            Console.WriteLine("Pergunta final");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("Para além da Rússia, que outro país");
                            Console.SetCursorPosition(3, 8);
                            Console.WriteLine("está presente em 2 continentes?");
                            Console.SetCursorPosition(3, 10);
                            G5 = Console.ReadLine();
                            G5 = G5.ToUpper();
                            G5 = G5.Trim();
                            if (G5 != "TURQUIA")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(20, 11);
                                Console.WriteLine("<errado>");
                                Console.ResetColor();
                                cGE++;
                            }
                            else if (G5 == "TURQUIA")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(20, 11);
                                Console.WriteLine("<certo>");
                                Console.ResetColor();
                                cGC++;
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 12);
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine("(Prima enter para ver os resultados)");
                            Console.SetCursorPosition(3, 15);
                            Console.ReadLine();
                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine("Resultados:                         ");
                            Console.SetCursorPosition(3, 16);
                            Console.WriteLine(cGE + " respostas erradas.");
                            Console.SetCursorPosition(3, 17);
                            Console.WriteLine(cGC + " respostas certas.");
                            if (cGE > cGC)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(3, 19);
                                Console.WriteLine("Reprovado a Geografia");
                                Console.ResetColor();
                            }
                            else if (cGE < cGC)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(3, 19);
                                Console.WriteLine("Aprovado a Geografia");
                                Console.ResetColor();
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(3, 21);
                            Console.WriteLine("(Voltar)");
                            Console.SetCursorPosition(11, 21);
                            Console.ReadLine();                            
                        }
                    }
                    while (sO1 != "5");
                }
                else if (sO == "2")
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    LimparLinhas();
                    Console.SetCursorPosition(20, 1);
                    Console.WriteLine("RESULTADOS");
                    if (cME < 1 && cMC < 1 && cCE < 1 && cCC < 1 && cHE < 1 && cHC < 1 && cGE < 1 && cGC < 1)
                    {
                        Console.SetCursorPosition(3, 5);
                        Console.WriteLine("Ainda não há resultados.");
                    }
                    if (cME > cMC)
                    {
                        Console.SetCursorPosition(3, 5);
                        Console.WriteLine("Reprovado a Matemática.");
                    }
                    if (cME < cMC)
                    {
                        Console.SetCursorPosition(3, 5);
                        Console.WriteLine("Aprovado a Matemática.");
                    }
                    if (cCE > cCC)
                    {
                        Console.SetCursorPosition(3, 7);
                        Console.WriteLine("Reprovado a Ciência.");
                    }
                    if (cCE < cCC)
                    {
                        Console.SetCursorPosition(3, 7);
                        Console.WriteLine("Aprovado a Ciência.");
                    }
                    if (cHE > cHC)
                    {
                        Console.SetCursorPosition(3, 9);
                        Console.WriteLine("Reprovado a História.");
                    }
                    if (cHE < cHC)
                    {
                        Console.SetCursorPosition(3, 9);
                        Console.WriteLine("Aprovado a História.");
                    }
                    if (cGE > cGC)
                    {
                        Console.SetCursorPosition(3, 11);
                        Console.WriteLine("Reprovado a Geografia.");
                    }
                    if (cGE < cGC)
                    {
                        Console.SetCursorPosition(3, 11);
                        Console.WriteLine("Aprovado a Geografia.");
                    }
                    Console.SetCursorPosition(3, 13);
                    Console.WriteLine("(Voltar)");
                    Console.SetCursorPosition(11, 13);
                    Console.ReadLine();
                }
                else if (sO == "3")
                {
                    LimparLinhas();
                    Console.SetCursorPosition(20, 1);
                    Console.WriteLine("COMO JOGAR");
                    Console.SetCursorPosition(3, 5);
                    Console.WriteLine("♦ Você deverá escolher um tema.");
                    Console.SetCursorPosition(3, 7);
                    Console.WriteLine("♦ Cada tema leva a um teste, no qual haverá");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("5 perguntas acerca do tema selacionado.");
                    Console.SetCursorPosition(3, 10);
                    Console.WriteLine("♦ Se tiver 3 respostas certas, será aprovado.");
                    Console.SetCursorPosition(3, 12);
                    Console.WriteLine("Boa sorte!");
                    Console.SetCursorPosition(3, 14);
                    Console.WriteLine("(Prima enter)");
                    Console.SetCursorPosition(16, 14);
                    Console.ReadLine();
                }
                else if (sO == "4")
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    LimparLinhas();
                    Console.SetCursorPosition(14, 1);
                    Console.WriteLine("Deseja Sair? (Sim/Não)");
                    Console.SetCursorPosition(3, 5);
                    sSair = Console.ReadLine();
                    sSair.Trim();
                    sSair = sSair.ToLower();
                    while (sSair != "sim" && sSair != "nao" && sSair != "não")
                    {
                        LimparLinhas();
                        Console.SetCursorPosition(9, 1);
                        Console.WriteLine("Opção inválida, tente novamente.");
                        Console.SetCursorPosition(3, 5);
                        Console.WriteLine("Deseja Sair? (Sim/Não)");
                        Console.SetCursorPosition(3, 6);
                        sSair = Console.ReadLine();
                        sSair = sSair.Trim();
                        sSair = sSair.ToLower();
                    }
                }
                else if (sO != "1" && sO != "2" && sO != "3" && sO != "4")
                {
                    LimparLinhas();
                    Console.SetCursorPosition(9, 1);
                    Console.WriteLine("Opção inválida, tente novamente");
                    Console.SetCursorPosition(21, 3);
                    Console.WriteLine("(Voltar)");
                    Console.SetCursorPosition(29, 3);
                    Console.ReadLine();
                }
            }
            while (sSair == "nao" || sSair == "não");
        }
    }
}
