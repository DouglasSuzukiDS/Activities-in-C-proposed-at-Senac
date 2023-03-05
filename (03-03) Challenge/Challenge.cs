using System;

class AllChallenges {
   static void Main() {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("Choose the Challenge: ");
      Console.WriteLine("1) Notes System  2) Shopping  3) Finance System");
      Console.ResetColor();
      
      int choose = int.Parse(Console.ReadLine());
      Console.WriteLine("");

      chooseTheChallenge:
      switch(choose) {
         case 1:
            // Console.WriteLine("Choose: Challenge 1");
            Console.WriteLine();
            Console.WriteLine("Sistema Escolar");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Informe o nome do aluno:");
            string student = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Informe a turma do aluno:");
            string studentClass = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite a 1 nota (somente números*, se for decimal use VIRGULA*):");
            float note1 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a 2 nota (somente números*, se for decimal use VIRGULA*):");
            float note2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a 3 nota (somente números*, se for decimal use VIRGULA*):");
            float note3 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a 4 nota (somente números*, se for decimal use VIRGULA*):");
            float note4 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            float totalNotal = note1 + note2 + note3 + note4;

            double media = Math.Round((totalNotal / 4), 2);
            // Console.WriteLine(media); 

            if (media < 5) {
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("O aluno {0}, da turma {1} obeteve {2} de média, consequentemente foi reprovado.", student, studentClass, media);
                  Console.ResetColor();
            }
            else if (media >= 5 && media < 6.5) {
                  Console.ForegroundColor = ConsoleColor.Yellow;
                  Console.WriteLine("O aluno {0}, da turma {1} obeteve {2} de média, consequentemente ficou em recuperação.", student, studentClass, media);
                  Console.ResetColor();
            }
            else {
                  Console.ForegroundColor = ConsoleColor.Blue;
                  Console.WriteLine("O aluno {0}, da turma {1} obeteve {2} de média, foi aprovado.", student, studentClass, media);
                  Console.ResetColor();
            }

            Console.WriteLine();
            Console.ReadKey();
            break;
         case 2:
            // Console.WriteLine("Choose: Challenge 2");
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
            break;
         case 3:
            // Console.WriteLine("Choose: Challenge 3");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sistema de Finanças");
            Console.WriteLine("\n--------------\n");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Qual seu nome? ");
            string name = Console.ReadLine();

            Console.WriteLine("\nPor obséquio informe vossos gastos entre as 4 semana do mês. Lembrando que são 8 valores, sendo divididos em 2 categorias, Dispesas e Diversos, onde:");
            Console.WriteLine("\nDispesas => Contas fixas, aluguel, água, luz, internet, alimentação, transporte");
            Console.WriteLine("\nDiversos => Passeios, diversão, comprinhas pessoais, prostibulos, bebidas, drogas.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nQuais foram seus gastos caracterizados como 'Dispezas Fixas? (Para valores decimais, por obséquio utilizar VÍRCULA*)");
            Console.ResetColor();

            double[] expenses = new double [4];

            for(int i = 0; i <= 3; i++) {
                  Console.ForegroundColor = ConsoleColor.Yellow;
                  Console.WriteLine("\nValor da dispesa na semana {0}:", (i + 1));
                  Console.ResetColor();

                  Console.ForegroundColor = ConsoleColor.Blue;
                  double value = Math.Round(double.Parse(Console.ReadLine()), 2);
                  Console.ResetColor();

                  expenses[i] = value;
            } 
            
            /*foreach(double expense in expenses) {
                  Console.WriteLine(expense);
            }*/

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nQuais foram seus gastos caracterizados como 'Diversos' ? (Para valores decimais, por obséquio utilizar VÍRCULA*)");
            Console.ResetColor();

            double[] diverses = new double [4];

            for(int i = 0; i <= 3; i++) {
                  Console.ForegroundColor = ConsoleColor.Yellow;
                  Console.WriteLine("\nValor do gasto diverso na semana {0}:", (i + 1));
                  Console.ResetColor();

                  Console.ForegroundColor = ConsoleColor.Blue;
                  double value = Math.Round(double.Parse(Console.ReadLine()), 2);
                  Console.ResetColor();

                  diverses[i] = value;
            } 
            
            /*foreach(double diverse in diverses) {
                  Console.WriteLine(diverse);
            }*/

            double amountExpenses = 0;
            double amountDiverses = 0;
            int index = 0;

            while(index < expenses.Length) {
                  Math.Round((amountExpenses += expenses[index]), 2);
                  Math.Round((amountDiverses += diverses[index]), 2);
                  index++; 
            }

            double amountGeneral = Math.Round((amountExpenses + amountDiverses), 2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nA soma total de gastos em Dispesas é R${0} reais.", amountExpenses);
            Console.WriteLine("\nA soma total de gastos em Diversos foi de R${0} reais.", amountDiverses);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nCamarada {0}, a soma de todos vossos gastos desse mês foi R${1} reais.", name, amountGeneral);
            Console.ResetColor();


            Console.WriteLine("");
            break;
         default:
            goto chooseTheChallenge;
      }
   }
}