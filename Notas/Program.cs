using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto__Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            string sO, sO2, sSair = "nao";
            int[] aNotas = new int[10];
            int icontN, iPos, iPos1, iAux;
            icontN = 0;

            //Início
            Console.Clear();
            Console.WriteLine("Bem-vindo ao armazenamento das suas notas");
            Console.WriteLine("═════════════════════════════════════════");
            Console.WriteLine("(Prima Enter)");
            Console.ReadLine();

            do
            {
                //Menu
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Inserir Notas");
                Console.WriteLine("2 - Ver Notas");
                Console.WriteLine("3 - Sair");
                sO = Console.ReadLine();
                sO = sO.Trim();

                if (sO == "1")
                {
                    Console.Clear();
                    for (iPos = 0; iPos < 10; iPos++)
                    {
                        Console.WriteLine("Escreva a " + (iPos + 1) + "ª Nota.");
                        aNotas[iPos] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");
                        while (aNotas[iPos] < 0 || aNotas[iPos] > 20)
                        {
                            Console.WriteLine("Nota inválida. Tente novamente.");
                            Console.WriteLine("Escreva a " + (iPos + 1) + "ª Nota.");
                            aNotas[iPos] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" ");
                        }
                    }
                    icontN = 1;
                    Console.WriteLine(" ");
                    Console.WriteLine("(Voltar - Enter)");
                    Console.ReadLine();
                }
                else if (sO == "2")
                {
                    if (icontN == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Ainda não há notas inseridas.");
                        Console.WriteLine(" ");
                        Console.WriteLine("(Voltar - Enter)");
                        Console.ReadLine();
                    }
                    else if (icontN == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Notas:");
                        Console.WriteLine(" ");
                        Console.WriteLine("1ª Nota: " + aNotas[0]);
                        Console.WriteLine("2ª Nota: " + aNotas[1]);
                        Console.WriteLine("3ª Nota: " + aNotas[2]);
                        Console.WriteLine("4ª Nota: " + aNotas[3]);
                        Console.WriteLine("5ª Nota: " + aNotas[4]);
                        Console.WriteLine("6ª Nota: " + aNotas[5]);
                        Console.WriteLine("7ª Nota: " + aNotas[6]);
                        Console.WriteLine("8ª Nota: " + aNotas[7]);
                        Console.WriteLine("9ª Nota: " + aNotas[8]);
                        Console.WriteLine("10ª Nota: " + aNotas[9]);
                        Console.WriteLine(" ");
                        Console.WriteLine("════════════════════════════════");
                        Console.WriteLine(" ");
                        Console.WriteLine("1 - Ordenar por ordem crescente");
                        Console.WriteLine("2 - Ordenar por ordem decrescente");
                        Console.WriteLine("3 - Limpar Notas");
                        Console.WriteLine("4 - Voltar ao Menu");
                        Console.WriteLine(" ");
                        sO2 = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Notas:");
                        Console.WriteLine(" ");
                        if (sO2 == "1")
                        {
                            for (iPos = 0; iPos < 9; iPos++)
                            {
                                for (iPos1 = iPos + 1; iPos1 < 10; iPos1++)
                                {
                                    if (aNotas[iPos] > aNotas[iPos1])
                                    {
                                        iAux = aNotas[iPos];
                                        aNotas[iPos] = aNotas[iPos1];
                                        aNotas[iPos1] = iAux;
                                    }
                                }
                            }
                        }
                        else if (sO2 == "2")
                        {
                            for (iPos = 0; iPos < 9; iPos++)
                            {
                                for (iPos1 = iPos + 1; iPos1 < 10; iPos1++)
                                {
                                    if (aNotas[iPos] < aNotas[iPos1])
                                    {
                                        iAux = aNotas[iPos];
                                        aNotas[iPos] = aNotas[iPos1];
                                        aNotas[iPos1] = iAux;
                                    }
                                }
                            }
                        }
                        if (sO2 == "1" || sO2 == "2")
                        {
                            Console.WriteLine("1ª Nota: " + aNotas[0]);
                            Console.WriteLine("2ª Nota: " + aNotas[1]);
                            Console.WriteLine("3ª Nota: " + aNotas[2]);
                            Console.WriteLine("4ª Nota: " + aNotas[3]);
                            Console.WriteLine("5ª Nota: " + aNotas[4]);
                            Console.WriteLine("6ª Nota: " + aNotas[5]);
                            Console.WriteLine("7ª Nota: " + aNotas[6]);
                            Console.WriteLine("8ª Nota: " + aNotas[7]);
                            Console.WriteLine("9ª Nota: " + aNotas[8]);
                            Console.WriteLine("10ª Nota: " + aNotas[9]);
                            Console.WriteLine(" ");
                            Console.WriteLine("(Voltar - Enter)");
                            Console.ReadLine();
                        }
                        if (sO2 == "3")
                        {
                            icontN = 0;
                            Console.Clear();
                            Console.WriteLine("Notas Limpas.");
                            Console.WriteLine(" ");
                            Console.WriteLine("(Voltar - Enter)");
                            Console.ReadLine();
                        }
                    }

                }
                else if (sO == "3")
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
                else if (sO != "1" && sO != "2" && sO != "3")
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
