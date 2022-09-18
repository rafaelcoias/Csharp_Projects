using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string sO, sO2, sSair = "nao";
            int icont, icontLinha, icontColuna, iLeft, iTop;
            int[,] aMatriz = new int[3, 3];
            int[,] aMatriz2 = new int[3, 3];
            int[,] aResultados = new int[3, 3];


            //Início
            Console.Clear();
            Console.WriteLine("Bem-vindo às Matrizes");
            Console.WriteLine("═════════════════════");
            Console.WriteLine("(Prima Enter)");
            Console.ReadLine();

            do
            {
                //Menu
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Fazer matrizes");
                Console.WriteLine("2 - Sair");
                sO = Console.ReadLine();
                sO = sO.Trim();

                if (sO == "1")
                {
                    Console.Clear();
                    do
                    {
                        Console.SetCursorPosition(53, 6);
                        Console.WriteLine("MATRIZES");
                        Console.SetCursorPosition(34, 10);
                        Console.WriteLine("┌───┬───┬───┐");
                        Console.SetCursorPosition(34, 11);
                        Console.WriteLine("│   │   │   │");
                        Console.SetCursorPosition(34, 12);
                        Console.WriteLine("├───┼───┼───┤");
                        Console.SetCursorPosition(34, 13);
                        Console.WriteLine("│   │   │   │");
                        Console.SetCursorPosition(34, 14);
                        Console.WriteLine("├───┼───┼───┤");
                        Console.SetCursorPosition(34, 15);
                        Console.WriteLine("│   │   │   │");
                        Console.SetCursorPosition(34, 16);
                        Console.WriteLine("└───┴───┴───┘");
                        iTop = 9;
                        icont = 1;
                        for (icontColuna = 0; icontColuna < 3; icontColuna++)
                        {
                            iLeft = 32;
                            iTop = iTop + 2;
                            for (icontLinha = 0; icontLinha < 3; icontLinha++)
                            {
                                Console.SetCursorPosition(34, 18);
                                Console.WriteLine("→ Escreva um número para a " + (icont++) + "ª posição (máximo 2 dígitos)");
                                iLeft = iLeft + 4;
                                Console.SetCursorPosition(iLeft, iTop);
                                aMatriz[icontLinha, icontColuna] = Convert.ToInt32(Console.ReadLine());
                                Console.SetCursorPosition(iLeft, iTop);
                                Console.WriteLine(aMatriz[icontLinha, icontColuna]);
                            }
                        }
                        do
                        {
                            Console.SetCursorPosition(34, 18);
                            Console.WriteLine("1 - Próxima Matriz                                      ");
                            Console.SetCursorPosition(34, 19);
                            Console.WriteLine("2 - Alterar                                             ");
                            Console.SetCursorPosition(34, 20);
                            sO2 = Console.ReadLine();
                            sO2 = sO2.Trim();
                            Console.SetCursorPosition(34, 18);
                            Console.WriteLine("                                         ");
                            Console.SetCursorPosition(34, 19);
                            Console.WriteLine("                                         ");
                            Console.SetCursorPosition(34, 20);
                            Console.WriteLine("                                         ");
                            Console.SetCursorPosition(34, 21);
                            Console.WriteLine("                                         ");
                            if (sO2 != "1" && sO2 != "2")
                            {
                                Console.SetCursorPosition(34, 21);
                                Console.WriteLine("Tente Novamente.");
                            }
                        }
                        while (sO2 != "1" && sO2 != "2");
                    }
                    while (sO2 == "2");
                    do
                    {
                        Console.SetCursorPosition(48, 13);
                        Console.WriteLine("x");
                        Console.SetCursorPosition(50, 10);
                        Console.WriteLine("┌───┬───┬───┐");
                        Console.SetCursorPosition(50, 11);
                        Console.WriteLine("│   │   │   │");
                        Console.SetCursorPosition(50, 12);
                        Console.WriteLine("├───┼───┼───┤");
                        Console.SetCursorPosition(50, 13);
                        Console.WriteLine("│   │   │   │");
                        Console.SetCursorPosition(50, 14);
                        Console.WriteLine("├───┼───┼───┤");
                        Console.SetCursorPosition(50, 15);
                        Console.WriteLine("│   │   │   │");
                        Console.SetCursorPosition(50, 16);
                        Console.WriteLine("└───┴───┴───┘");
                        iTop = 9;
                        icont = 1;
                        for (icontColuna = 0; icontColuna < 3; icontColuna++)
                        {
                            iLeft = 48;
                            iTop = iTop + 2;
                            for (icontLinha = 0; icontLinha < 3; icontLinha++)
                            {
                                Console.SetCursorPosition(50, 18);
                                Console.WriteLine("→ Escreva um número para a " + (icont++) + "ª posição (máximo 2 dígitos)");
                                iLeft = iLeft + 4;
                                Console.SetCursorPosition(iLeft, iTop);
                                aMatriz2[icontLinha, icontColuna] = Convert.ToInt32(Console.ReadLine());
                                Console.SetCursorPosition(iLeft, iTop);
                                Console.WriteLine(aMatriz2[icontLinha, icontColuna]);
                            }
                        }
                        do
                        {
                            Console.SetCursorPosition(50, 18);
                            Console.WriteLine("1 - Ver Resultados                                      ");
                            Console.SetCursorPosition(50, 19);
                            Console.WriteLine("2 - Alterar                                             ");
                            Console.SetCursorPosition(50, 20);
                            sO2 = Console.ReadLine();
                            sO2 = sO2.Trim();
                            Console.SetCursorPosition(50, 18);
                            Console.WriteLine("                                         ");
                            Console.SetCursorPosition(50, 19);
                            Console.WriteLine("                                         ");
                            Console.SetCursorPosition(50, 20);
                            Console.WriteLine("                                         ");
                            Console.SetCursorPosition(50, 21);
                            Console.WriteLine("                                         ");
                            if (sO2 != "1" && sO2 != "2")
                            {
                                Console.SetCursorPosition(50, 21);
                                Console.WriteLine("Tente Novamente.");
                            }
                        }
                        while (sO2 != "1" && sO2 != "2");
                    }
                    while (sO2 == "2");
                    Console.SetCursorPosition(65, 13);
                    Console.WriteLine("=");
                    Console.SetCursorPosition(68, 10);
                    Console.WriteLine("┌───┬───┬───┐");
                    Console.SetCursorPosition(68, 11);
                    Console.WriteLine("│   │   │   │");
                    Console.SetCursorPosition(68, 12);
                    Console.WriteLine("├───┼───┼───┤");
                    Console.SetCursorPosition(68, 13);
                    Console.WriteLine("│   │   │   │");
                    Console.SetCursorPosition(68, 14);
                    Console.WriteLine("├───┼───┼───┤");
                    Console.SetCursorPosition(68, 15);
                    Console.WriteLine("│   │   │   │");
                    Console.SetCursorPosition(68, 16);
                    Console.WriteLine("└───┴───┴───┘");
                    iTop = 9;
                    for (icontColuna = 0; icontColuna < 3; icontColuna++)
                    {
                        iLeft = 66;
                        iTop = iTop + 2;
                        for (icontLinha = 0; icontLinha < 3; icontLinha++)
                        {                            
                            iLeft = iLeft + 4;
                            aResultados[icontLinha, icontColuna] = aMatriz2[icontLinha, icontColuna] * aMatriz[icontColuna, icontLinha];
                            Console.SetCursorPosition(iLeft, iTop);
                            Console.WriteLine(aResultados[icontLinha, icontColuna]);
                        }
                    }
                    Console.SetCursorPosition(49, 19);
                    Console.WriteLine("(Voltar - Enter)                                      ");
                    Console.SetCursorPosition(65, 19);
                    Console.ReadLine();                
                }
                else if (sO == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Deseja Sair? (Sim/Não)");
                    Console.WriteLine(" ");
                    sSair = Console.ReadLine();
                    sSair.Trim();
                    sSair = sSair.ToLower();
                    while (sSair != "sim" && sSair != "nao" && sSair != "não")
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida, tente novamente.");
                        Console.WriteLine("════════════════════════════════");
                        Console.WriteLine("Deseja Sair? (Sim/Não)");
                        Console.WriteLine(" ");
                        sSair = Console.ReadLine();
                        sSair = sSair.Trim();
                        sSair = sSair.ToLower();
                    }
                }
                else if (sO != "1" && sO != "2")
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida, prima enter para voltar.");
                    Console.WriteLine("════════════════════════════════════════");
                    Console.WriteLine("(Voltar)");
                    Console.ReadLine();
                }
            }
            while (sSair == "nao" || sSair == "não");
        }
    }
}
