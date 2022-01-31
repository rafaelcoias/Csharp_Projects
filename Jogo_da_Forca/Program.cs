using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_forca
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis
            var rnd = new Random();            
            string O, O2, T, Sair, Palavra, TentativaUsada, Tema;
            int Pos, PosT, TamTent, TamT, Tam, TamArrayP, TamArrayT, Left, Left2, contE, contC, contEsp, contEs, contTE, contTU;

            //Início
            Console.WriteLine("Bem vindo ao jogo da Forca.");
            Console.WriteLine("═══════════════════════════");
            Console.WriteLine("(Prima Enter)");
            Console.ReadLine();
            do
            {                
                TentativaUsada = "";
                Palavra = "palavra";
                Sair = "NÃO";

                do
                {
                    O2 = "";
                    //Menu
                    Console.Clear();
                    Console.WriteLine("Menu:");
                    Console.WriteLine(" ");
                    Console.WriteLine("1 - Jogar single-player");
                    Console.WriteLine("2 - Jogar multi-player");
                    Console.WriteLine("3 - Sair");
                    O = Console.ReadLine();
                    O = O.Trim();

                    if (O == "1")
                    {
                        do
                        {
                            //Escolher a Dificuldade
                            Console.Clear();
                            Console.WriteLine("Escolha a sua dificuldade:");
                            Console.WriteLine(" ");
                            Console.WriteLine("1 - Fácil");
                            Console.WriteLine("2 - Normal");
                            Console.WriteLine("3 - Difícil");
                            Console.WriteLine("4 - Voltar ao Menu");
                            O2 = Console.ReadLine();
                            O2 = O2.Trim();
                            if (O2 != "1" && O2 != "2" && O2 != "3" && O2 != "4")
                            {
                                Console.Clear();
                                Console.WriteLine("Opção Inválida. Tente novamente");
                                Console.WriteLine(" ");
                                Console.WriteLine("(Voltar)");
                                Console.ReadLine();
                            }
                        }
                        while (O2 != "4" && O2 != "1" && O2 != "2" && O2 != "3");
                    }
                }
                while (O2 == "4");

                //Forca
                Console.SetCursorPosition(35, 5);
                Console.WriteLine("    ╔════════════════╗");
                Console.SetCursorPosition(35, 6);
                Console.WriteLine("    ║                ║");
                Console.SetCursorPosition(35, 7);
                Console.WriteLine("    ║");
                Console.SetCursorPosition(35, 8);
                Console.WriteLine("    ║");
                Console.SetCursorPosition(35, 9);
                Console.WriteLine("    ║");
                Console.SetCursorPosition(35, 10);
                Console.WriteLine("    ║");
                Console.SetCursorPosition(35, 11);
                Console.WriteLine("    ║");
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("    ║");
                Console.SetCursorPosition(35, 13);
                Console.WriteLine("    ║");
                Console.SetCursorPosition(35, 14);
                Console.WriteLine("    ║");
                Console.SetCursorPosition(35, 15);
                Console.WriteLine("════╩════");
                Console.SetCursorPosition(36, 19);
                Console.WriteLine("Tentar → ");
                Console.SetCursorPosition(75, 5);
                Console.WriteLine("Tentativas erradas:");
                Console.SetCursorPosition(73, 4);
                Console.WriteLine("╔══════════════════════╗");
                Console.SetCursorPosition(73, 13);
                Console.WriteLine("╚══════════════════════╝");
                if (O == "1")
                {
                    //Escolher Tema
                    var aTema = new string[11];
                    aTema[0] = "Clubes"; aTema[1] = "Países"; aTema[2] = "Natureza";
                    aTema[3] = "Disciplínas"; aTema[4] = "Eletrodomésticos"; aTema[5] = "Animais";
                    aTema[6] = "Instrumentos"; aTema[7] = "Comidas-Bebidas"; aTema[8] = "Marcas de automóvel";
                    aTema[9] = "Marcas de roupa"; aTema[10] = "Filmes";
                    TamArrayT = aTema.Length;
                    var rndTema = rnd.Next(0, TamArrayT - 1);
                    Tema = aTema[rndTema];
                    
                    //Escolher Palavra para Clubes
                    if (O2 == "1" && Tema == "Clubes")
                    {
                        var aPalavras = new string[6];
                        aPalavras[0] = "sporting"; aPalavras[1] = "benfica"; aPalavras[2] = "porto";
                        aPalavras[3] = "arsenal"; aPalavras[4] = "paris"; aPalavras[5] = "braga";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(42, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "2" && Tema == "Clubes")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "barcelona"; aPalavras[1] = "chelsea"; aPalavras[2] = "liverpool";
                        aPalavras[3] = "juventus"; aPalavras[4] = "sporting";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra= rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(42, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "3" && Tema == "Clubes")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "real madrid"; aPalavras[1] = "dortmund"; aPalavras[2] = "atlético de madrid";
                        aPalavras[3] = "bayern de múnique"; aPalavras[4] = "palmeiras";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(42, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    //Escolher Palavra para Países
                    else if (O2 == "1" && Tema == "Países")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "portugal"; aPalavras[1] = "espanha"; aPalavras[2] = "rússia";
                        aPalavras[3] = "itália"; aPalavras[4] = "frança";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(42, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "2" && Tema == "Países")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "estados unidos"; aPalavras[1] = "inglaterra";
                        aPalavras[2] = "irlanda"; aPalavras[3] = "brasil"; aPalavras[4] = "escócia";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(42, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "3" && Tema == "Países")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "argentina"; aPalavras[1] = "argentina";
                        aPalavras[2] = "argentina"; aPalavras[3] = "argentina"; aPalavras[4] = "argentina";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(42, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    //Escolher Palavra para Natureza
                    else if (O2 == "1" && Tema == "Natureza")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "árvore"; aPalavras[1] = "flor"; aPalavras[2] = "mar";
                        aPalavras[3] = "céu"; aPalavras[4] = "terra";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(41, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "2" && Tema == "Natureza")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "animal"; aPalavras[1] = "núvem"; aPalavras[2] = "vulcão";
                        aPalavras[3] = "madeira"; aPalavras[4] = "oceano";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(41, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "3" && Tema == "Natureza")
                    {
                        var aPalavras = new string[6];
                        aPalavras[0] = "deserto"; aPalavras[1] = "montanha"; aPalavras[2] = "floresta";
                        aPalavras[3] = "pétala"; aPalavras[4] = "tropical"; aPalavras[5] = "cascata";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(41, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    //Escolher Palavra para Disciplínas
                    else if (O2 == "1" && Tema == "Disciplínas")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "música"; aPalavras[1] = "ciência"; aPalavras[2] = "inglês";
                        aPalavras[3] = "física"; aPalavras[4] = "química";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(40, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "2" && Tema == "Disciplínas")
                    {
                        var aPalavras = new string[5];           
                        aPalavras[0] = "religião"; aPalavras[1] = "história"; aPalavras[2] = "educação-física";
                        aPalavras[3] = "matemática"; aPalavras[4] = "português";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(40, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "3" && Tema == "Disciplínas")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "desenho"; aPalavras[1] = "geografia"; aPalavras[2] = "biologia";
                        aPalavras[3] = "educação-física"; aPalavras[4] = "geologia";                         
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(40, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    //Escolher Palavra para Eletrodomésticos
                    else if (O2 == "1" && Tema == "Eletrodomésticos")
                    {
                        var aPalavras = new string[4];
                        aPalavras[0] = "forno"; aPalavras[1] = "televisão"; aPalavras[2] = "lâmpada";
                        aPalavras[3] = "lâmpada";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(38, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "2" && Tema == "Eletrodomésticos")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "micro ondas"; aPalavras[1] = "aspirador"; aPalavras[2] = "máquina de café";
                        aPalavras[3] = "máquina de lavar loiça"; aPalavras[4] = "máquina de lavar roupa";                      
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(38, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "3" && Tema == "Eletrodomésticos")
                    {
                        var aPalavras = new string[4];
                        aPalavras[0] = "torradeira"; aPalavras[1] = "batedeira"; aPalavras[2] = "frigorífico";
                        aPalavras[3] = "impressora";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(38, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    //Escolher Palavra para Animais
                    else if (O2 == "1" && Tema == "Animais")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "girafa"; aPalavras[1] = "tubarão"; aPalavras[2] = "zebra";
                        aPalavras[3] = "gato"; aPalavras[4] = "macaco";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(42, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "2" && Tema == "Animais")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "leopardo"; aPalavras[1] = "pinguin"; aPalavras[2] = "elefante";                        
                        aPalavras[3] = "borboleta"; aPalavras[4] = "camelo";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(42, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "3" && Tema == "Animais")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "crocodilo"; aPalavras[1] = "baleia branca"; aPalavras[2] = "peixe espada";
                        aPalavras[3] = "rinoceronte"; aPalavras[4] = "golfinho";

                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(42, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    // Escolher Palavra para Instrumentos
                    else if (O2 == "1" && Tema == "Instrumentos")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "bateria"; aPalavras[1] = "piano"; aPalavras[2] = "violino";
                        aPalavras[3] = "trompete"; aPalavras[4] = "tuba"; 
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(40, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "2" && Tema == "Instrumentos")
                    {
                        var aPalavras = new string[4];
                        aPalavras[0] = "guitarra-elétrica"; aPalavras[1] = "saxofone"; aPalavras[2] = "ukulele";
                        aPalavras[3] = "tambor";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(40, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "3" && Tema == "Instrumentos")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "guitarra-clássica"; aPalavras[1] = "violoncelo"; aPalavras[2] = "balalaica";
                        aPalavras[3] = "contra baixo"; aPalavras[4] = "xilofone"; 
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(40, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    // Escolher Palavra para Comidas-Bebidas
                    else if (O2 == "1" && Tema == "Comidas-Bebidas")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "pizza"; aPalavras[1] = "sardinha"; aPalavras[2] = "ovo";
                        aPalavras[3] = "batata"; aPalavras[4] = "água"; 
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(38, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "2" && Tema == "Comidas-Bebidas")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "hamburguer"; aPalavras[1] = "limonada"; aPalavras[2] = "salsicha";
                        aPalavras[3] = "sumo de laranja"; aPalavras[4] = "cerveja"; 
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(38, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "3" && Tema == "Comidas-Bebidas")
                    {
                        var aPalavras = new string[5];                        
                        aPalavras[0] = "somersby"; aPalavras[1] = "batata cozida"; aPalavras[2] = "esparguete";
                        aPalavras[3] = "francesinha"; aPalavras[4] = "sardinha";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(38, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    // Escolher Palavra para Marcas de automóvel
                    else if (O2 == "1" && Tema == "Marcas de automóvel")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "volvo"; aPalavras[1] = "audi"; aPalavras[2] = "jeep";
                        aPalavras[3] = "bmw"; aPalavras[4] = "mini";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(37, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "2" && Tema == "Marcas de automóvel")
                    {
                        var aPalavras = new string[4];
                        aPalavras[0] = "mercedes"; aPalavras[1] = "honda"; aPalavras[2] = "toyota";
                        aPalavras[3] = "ferrari"; aPalavras[4] = "porsche";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(37, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "3" && Tema == "Marcas de automóvel")
                    {
                        var aPalavras = new string[4];
                        aPalavras[0] = "peugeot"; aPalavras[1] = "renault";  aPalavras[2] = "jagoar";
                        aPalavras[3] = "citroën"; 
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(37, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    // Escolher Palavra para Marcas de roupa
                    else if (O2 == "1" && Tema == "Marcas de roupa")
                    {
                        var aPalavras = new string[4];
                        aPalavras[0] = "polo"; aPalavras[1] = "prada"; aPalavras[2] = "vans";
                        aPalavras[3] = "tommy";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(38, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "2" && Tema == "Marcas de roupa")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "ralph lauren"; aPalavras[1] = "element"; aPalavras[2] = "converse";
                        aPalavras[3] = "quicksilver"; aPalavras[4] = "adidas";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(38, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "3" && Tema == "Marcas de roupa")
                    {
                        var aPalavras = new string[4];
                        aPalavras[0] = "bimba&lola"; aPalavras[1] = "pull&bear"; aPalavras[1] = "bershka";
                        aPalavras[3] = "lacoste"; 
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(38, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    // Escolher Palavra para Filmes
                    else if (O2 == "1" && Tema == "Filmes")
                    {
                        var aPalavras = new string[4];
                        aPalavras[0] = "james bond"; aPalavras[1] = "starwars"; aPalavras[2] = "toy story";
                        aPalavras[3] = "ted";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(32, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "2" && Tema == "Filmes")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "ben-hur"; aPalavras[1] = "end game"; aPalavras[2] = "spiderman";
                        aPalavras[3] = "forrest gump"; aPalavras[4] = "o padrinho";
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(32, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    else if (O2 == "3" && Tema == "Filmes")
                    {
                        var aPalavras = new string[5];
                        aPalavras[0] = "regresso ao futuro"; aPalavras[1] = "interstellar"; aPalavras[2] = "piratas do caribe";
                        aPalavras[3] = "harry potter"; aPalavras[4] = "the truman";                         
                        TamArrayP = aPalavras.Length;
                        var rndPalavra = rnd.Next(0, TamArrayP - 1);
                        Palavra = aPalavras[rndPalavra];
                        Console.SetCursorPosition(32, 3);
                        Console.WriteLine("Tema: " + Tema);
                    }
                    //Limpar linhas
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.SetCursorPosition(37, 1);
                    Console.WriteLine("== Single-player Mode ==");                    
                    Console.SetCursorPosition(36, 17);
                    Console.Write("Palavra: ");                    
                }
                else if (O == "2")
                {                                      
                    //Limpar linhas
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.WriteLine("                           ");
                    Console.SetCursorPosition(37, 1);
                    Console.WriteLine("== Multi-player Mode ==");
                    Console.SetCursorPosition(45, 3);
                    Console.WriteLine("Forca");
                    Console.SetCursorPosition(36, 17);
                    Console.WriteLine("Palavra/frase secreta: ");
                    Console.SetCursorPosition(59, 17);
                    Palavra = Console.ReadLine();
                    Palavra = Palavra.Trim();
                    Palavra = Palavra.ToLower();
                    Tam = Palavra.Length;
                    while (Tam == 0)
                    {
                        Console.SetCursorPosition(36, 21);
                        Console.WriteLine("Erro: introduza pelo menos uma letra");
                        Console.SetCursorPosition(59, 17);
                        Palavra = Console.ReadLine();
                        Palavra = Palavra.Trim();
                        Palavra = Palavra.ToLower();
                        Tam = Palavra.Length;
                        Console.SetCursorPosition(36, 21);
                        Console.WriteLine("                                     ");
                    }
                    Console.SetCursorPosition(36, 17);
                    Console.Write("Palavra:                                                   ");                    
                }
                //Jogo
                if (O == "1" || O == "2" && Palavra != "")
                {
                    Tam = Palavra.Length;
                    Left = 44;
                    contEsp = 0;
                    for (Pos = 0; Pos < Tam; Pos++)
                    {
                        Left = Left + 2;
                        if (Palavra[Pos] != ' ' && Palavra[Pos] != '&' && Palavra[Pos] != '-')
                        {
                            Console.SetCursorPosition(Left, 17);
                            Console.Write("_ ");
                            contEsp++;
                        }
                        else if (Palavra[Pos] == ' ')
                        {
                            Console.SetCursorPosition(Left, 17);
                            Console.Write("  ");
                        }
                        else if(Palavra[Pos] == '&')
                        {
                            Console.SetCursorPosition(Left, 17);
                            Console.Write("& ");
                        }
                        else if (Palavra[Pos] == '-')
                        {
                            Console.SetCursorPosition(Left, 17);
                            Console.Write("- ");
                        }
                    }
                    contC = 0;
                    contTE = 1;
                    contE = 0;
                    do
                    {
                        contEs = 0;
                        if (contC != contEsp)
                        {
                            Console.SetCursorPosition(45, 19);
                            Console.Write("                              ");
                            Console.SetCursorPosition(45, 19);
                            T = Console.ReadLine();
                            T = T.ToLower();
                            T = T.Trim();
                            TamTent = T.Length;
                            //Se Tentar 2 letras
                            do
                            {
                                if (TamTent > 1 || TamTent == 0)
                                {
                                    Console.SetCursorPosition(36, 21);
                                    Console.WriteLine("Erro: introduza apenas uma letra");
                                    Console.SetCursorPosition(45, 19);
                                    Console.WriteLine("                                     ");
                                    Console.SetCursorPosition(45, 19);
                                    T = Console.ReadLine();
                                    T = T.ToLower();
                                    T = T.Trim();
                                    TamTent = T.Length;
                                    Console.SetCursorPosition(36, 21);
                                    Console.WriteLine("                                   ");
                                }
                            }
                            while (TamTent > 1 || TamTent == 0);
                            Left2 = 44;
                            contTU = 0;
                            for (Pos = 0; Pos < Tam; Pos++)
                            {
                                Console.SetCursorPosition(36, 21);
                                Console.WriteLine("                                ");
                                Left2 = Left2 + 2;
                                if (Palavra[Pos] != ' ')
                                {
                                    TamT = TentativaUsada.Length;
                                    for (PosT = 0; PosT < TamT; PosT++)
                                    {
                                        if (TentativaUsada[PosT] == T[0])
                                        {
                                            contTU = 1;
                                            Console.SetCursorPosition(36, 21);
                                            Console.WriteLine("Erro: letra já usada");
                                        }
                                    }
                                    if (contTU == 0)
                                    {
                                        if (T[0] == Palavra[Pos] && Palavra[Pos] != '&' && Palavra[Pos] != '-')
                                        {
                                            Console.SetCursorPosition(Left2, 17);
                                            Console.WriteLine(T);
                                            contC++;
                                        }
                                        else if (T == "a")
                                        {
                                            if (Palavra[Pos] == 'à' || Palavra[Pos] == 'á' || Palavra[Pos] == 'ã' || Palavra[Pos] == 'ä')
                                            {
                                                Console.SetCursorPosition(Left2, 17);
                                                Console.WriteLine(Palavra[Pos]);
                                                contC++;
                                            }
                                            else if (Palavra[Pos] != 'a' && Palavra[Pos] != 'à' && Palavra[Pos] != 'á' && Palavra[Pos] != 'ã' && Palavra[Pos] != 'ä' && Palavra[Pos] != '&' && Palavra[Pos] != '-')
                                            {
                                                contEs++;
                                            }
                                        }
                                        else if (T == "e")
                                        {
                                            if (Palavra[Pos] == 'é' || Palavra[Pos] == 'ê' || Palavra[Pos] == 'ë' || Palavra[Pos] == 'è')
                                            {
                                                Console.SetCursorPosition(Left2, 17);
                                                Console.WriteLine(Palavra[Pos]);
                                                contC++;
                                            }
                                            else if (Palavra[Pos] != 'e' && Palavra[Pos] != 'é' && Palavra[Pos] != 'ê' && Palavra[Pos] != 'ë' && Palavra[Pos] != 'è' && Palavra[Pos] != '&' && Palavra[Pos] != '-')
                                            {
                                                contEs++;
                                            }
                                        }
                                        else if (T == "i")
                                        {
                                            if (Palavra[Pos] == 'í' || Palavra[Pos] == 'ì')
                                            {
                                                Console.SetCursorPosition(Left2, 17);
                                                Console.WriteLine(Palavra[Pos]);
                                                contC++;
                                            }
                                            else if (Palavra[Pos] != 'i' && Palavra[Pos] != 'í' && Palavra[Pos] != 'ì' && Palavra[Pos] != '&' && Palavra[Pos] != '-')
                                            {
                                                contEs++;
                                            }
                                        }
                                        else if (T == "o")
                                        {
                                            if (Palavra[Pos] == 'ó' || Palavra[Pos] == 'ò' || Palavra[Pos] == 'õ' || Palavra[Pos] == 'ö')
                                            {
                                                Console.SetCursorPosition(Left2, 17);
                                                Console.WriteLine(Palavra[Pos]);
                                                contC++;
                                            }
                                            else if (Palavra[Pos] != 'o' && Palavra[Pos] != 'ó' && Palavra[Pos] != 'ò' && Palavra[Pos] != 'õ' && Palavra[Pos] != 'ö' && Palavra[Pos] != '&' && Palavra[Pos] != '-')
                                            {
                                                contEs++;
                                            }
                                        }
                                        else if (T == "u")
                                        {
                                            if (Palavra[Pos] == 'ú' || Palavra[Pos] == 'ù' || Palavra[Pos] == 'ü')
                                            {
                                                Console.SetCursorPosition(Left2, 17);
                                                Console.WriteLine(Palavra[Pos]);
                                                contC++;
                                            }
                                            else if (Palavra[Pos] != 'u' && Palavra[Pos] != 'ú' && Palavra[Pos] != 'ù' && Palavra[Pos] != 'ü' && Palavra[Pos] != '&' && Palavra[Pos] != '-')
                                            {
                                                contEs++;
                                            }
                                        }
                                        else if (T == "c")
                                        {
                                            if (Palavra[Pos] == 'ç')
                                            {
                                                Console.SetCursorPosition(Left2, 17);
                                                Console.WriteLine(Palavra[Pos]);
                                                contC++;
                                            }
                                            else if (Palavra[Pos] != 'c' && Palavra[Pos] != 'ç')
                                            {
                                                contEs++;
                                            }
                                        }
                                        else if (T[0] != Palavra[Pos] && T != "a" && T != "e" && T != "i" && T != "o" && T != "u" && T != "c" && Palavra[Pos] != '&' && Palavra[Pos] != '-')
                                        {
                                            contEs++;
                                        }
                                    }
                                }

                            }
                            TentativaUsada = TentativaUsada + T;
                            if (contEs >= contEsp && contTE == 1)
                            {
                                Console.SetCursorPosition(56, 7);
                                Console.Write("O");
                                Console.SetCursorPosition(75, 7);
                                Console.Write(T);
                                contTE++;
                                contE++;
                            }
                            else if (contEs >= contEsp && contTE == 2)
                            {
                                Console.SetCursorPosition(56, 8);
                                Console.Write("|");
                                Console.SetCursorPosition(75, 9);
                                Console.Write(T);
                                contTE++;
                                contE++;
                            }
                            else if (contEs >= contEsp && contTE == 3)
                            {
                                Console.SetCursorPosition(56, 9);
                                Console.Write("|");
                                Console.SetCursorPosition(75, 11);
                                Console.Write(T);
                                contTE++;
                                contE++;
                            }
                            else if (contEs >= contEsp && contTE == 4)
                            {
                                Console.SetCursorPosition(55, 8);
                                Console.Write("{");
                                Console.SetCursorPosition(84, 7);
                                Console.Write(T);
                                contTE++;
                                contE++;
                            }
                            else if (contEs >= contEsp && contTE == 5)
                            {
                                Console.SetCursorPosition(57, 8);
                                Console.Write("}");
                                Console.SetCursorPosition(84, 9);
                                Console.Write(T);
                                contTE++;
                                contE++;
                            }
                            else if (contEs >= contEsp && contTE == 6)
                            {
                                Console.SetCursorPosition(55, 10);
                                Console.Write("(");
                                Console.SetCursorPosition(84, 11);
                                Console.Write(T);
                                contTE++;
                                contE++;
                            }
                            else if (contEs >= contEsp && contTE == 7)
                            {
                                Console.SetCursorPosition(57, 10);
                                Console.Write(")");
                                Console.SetCursorPosition(93, 7);
                                Console.Write(T);
                                contTE++;
                                contE++;
                            }

                        }
                    }
                    while (contTE < 8 && contC != contEsp);
                    if (contC == contEsp && Palavra != "")
                    {
                        Console.SetCursorPosition(36, 19);
                        Console.Write("Você ganhou (Prima Enter)");
                        Console.SetCursorPosition(61, 19);
                        Console.ReadLine();
                        Console.Clear();
                        Console.SetCursorPosition(50, 1);
                        Console.Write("===== Parabéns =====");
                        Console.SetCursorPosition(46, 3);
                        Console.WriteLine("A palavra/frase secreta era : ");
                        Console.SetCursorPosition(46, 4);
                        Console.WriteLine("→ " + Palavra);
                        Console.SetCursorPosition(56, 6);
                        Console.WriteLine("(Voltar)");
                        Console.SetCursorPosition(64, 6);
                        Console.ReadLine();
                    }
                    else if (contTE >= 8)
                    {
                        Console.SetCursorPosition(36, 19);
                        Console.Write("Você perdeu (Prima Enter)");
                        Console.SetCursorPosition(61, 19);
                        Console.ReadLine();
                        Console.Clear();
                        Console.SetCursorPosition(50, 1);
                        Console.Write("===== Game Over =====");
                        Console.SetCursorPosition(46, 3);
                        Console.WriteLine("A palavra/frase secreta era : ");
                        Console.SetCursorPosition(46, 4);
                        Console.WriteLine("→ " + Palavra);
                        Console.SetCursorPosition(56, 6);
                        Console.WriteLine("(Voltar)");
                        Console.SetCursorPosition(64, 6);
                        Console.ReadLine();
                    }
                }
                else if (O == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Deseja sair? (Sim/Não)");
                    Console.WriteLine(" ");
                    Sair = Console.ReadLine();
                    Sair = Sair.ToUpper();
                    while (Sair != "SIM" && Sair != "NAO" && Sair != "NÃO")
                    {
                        Console.Clear();
                        Console.WriteLine("Opção Inválida. Tente novamente");
                        Console.WriteLine(" ");
                        Console.WriteLine("Deseja sair? (Sim/Não)");
                        Sair = Console.ReadLine();
                        Sair = Sair.ToUpper();
                    }
                }
                else if (O != "1" || O != "3" || O != "2")
                {
                    Console.Clear();
                    Console.WriteLine("Opção não está no Menu. Tente novamente");
                    Console.WriteLine(" ");
                    Console.WriteLine("(Voltar)");
                    Console.ReadLine();
                }
            }
            while (Sair == "NAO" || Sair == "NÃO");
            if (Sair == "SIM")
            {
                Console.Clear();
                Console.WriteLine("Obrigado por jogar!");
                Console.ReadLine();
            }
        }
    }
}
