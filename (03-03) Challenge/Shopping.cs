using System;

class Shopping {
    static void Main(string[] args) {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Compras no Paraguai");
        Console.WriteLine("\n------------------\n");

        Console.WriteLine("Vossa excelência está com os documentos necessários para a viagem? ");
        string doc = Console.ReadLine();
        Console.ResetColor();

        if(doc == "Sim" || doc == "sim" || doc == "SIM" || doc == "S" || doc == "s" || doc == "Sim") {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nO que comprou lá? Digite apenas um item.");

            string product = Console.ReadLine();

            Console.WriteLine("\nQual a quantidade? Por item*");
            int quantity = int.Parse(Console.ReadLine());

            chooseAgain:
            Console.WriteLine("\nEm que categoria esse produto de encontra?");
            Console.WriteLine("\n1) Vestuário  2) Bebidas 3) Drogas 4) Eletronicos 5) Bugigangas");
            Console.ResetColor();
            int category = int.Parse(Console.ReadLine());

            switch (category) {
                case 1:
                    if (quantity <= 5) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nFique tranquilo, não há problemas de passar na fonteira com {0} peças de vestuário desde que tenha em mãos as notas fiscais", quantity);
                        Console.ResetColor();
                        Console.WriteLine("\nMas é bom deixar o 'café' reservado para o pessoal da fronteira");
                    } else {
                        int rest = quantity - 5;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nCamarada, você para não ir preso, precisa se desfazer de {0} peças", rest);
                        Console.ResetColor();
                    }
                    break;

                case 2:
                    if (quantity <= 3) {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nOpa pode seguir tranquilo, porém deixe as bebidas (alcoolicas) no fundo do pora malas, para os guardas da fronteira não alegarem que vai beber enquanto dirige ou arrume confusão dentro do veículo de transporte");
                        Console.ResetColor();
                    } else {
                        int rest = quantity - 5;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nCamarada, você para não ir preso, precisa se desfazer de {0} bebidas, para não perder a grana beba o máximo que puder caso não estiver digindo", rest);
                        Console.ResetColor();
                    }
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nobre camarada, cuidado você ira preso.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nArrume um coiote para te atravessar");
                    Console.ResetColor();
                    break;

                case 4:
                    if (quantity <= 2) {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nCamarada, fique tranquilo, irá passar tranquilamente com sua mercadoria, se não ser assaltado/roubado antes/depois da viagem");
                        Console.ResetColor();
                    } else {
                    int rest = quantity - 5;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nCamarada, você para não ir preso, precisa se desfazer de {0} produtos, para não perder a grana seja esperto, tente mandar para si mesmo do 'correios' do Pagaraguai para você no país que reside", rest);
                        Console.ResetColor();
                    }
                    break;

                case 5:
                    if (quantity <= 5) {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nRelaxa camarada, pode ir sem medo, desde que suas comprinhas não sejam objetos pontiagudos, lâminas, armas. Mas se for, so preparar o 'café' dos guardas da fronteira");
                        Console.ResetColor();
                    } else {
                        int rest = quantity - 5;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nCamarada, você para não ir preso, precisa se desfazer de {0} produtos, para não perder a grana seja esperto, tente mandar para si mesmo do 'correios' do Pagaraguai para você no país que reside desde que compense", rest);
                        Console.ResetColor();
                    }
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nCategoria errada, por obséquio informe o tipo novamente");
                    Console.ResetColor();
                    goto chooseAgain;
            } 
            
        } else {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNobre camarada, como vossa excelência não possui os documentos necessários pra seguir a viagem, lhe dou 3 alternativas:");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n1) Procure o Consolado do seu país de origem, e peça ajuda.");

            Console.WriteLine("2) Encontre o 'perigo' desse país que providêncie uns documentos quentes pra vossa excelência.");

            Console.WriteLine("3) Arrume um Coite para de atravessar. Nada que umas 'foia' não resolva.");
            Console.ResetColor();
        }
    }
}