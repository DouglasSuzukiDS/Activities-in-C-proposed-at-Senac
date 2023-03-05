using System;

class Quizz {
   static void Main() {
      int accerts = 0;
      int errors = 0;

      Random rand = new Random();
      int num = rand.Next(1, 5);
      // Console.WriteLine("O número sorteado é {0}", num);

      Console.WriteLine("Quizz - Teste seus conhecimentos");
      Console.WriteLine("O Quizz contém 5 perguntas de conhecimentos gerais.");
      Console.WriteLine("3 Erros você perde!");
      Console.WriteLine("---------------------");
      Console.WriteLine("");

      // Question 1
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("A) Qual a capital do do Acre ?");
      Console.ResetColor();

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("1) Rio Negro 2) Fernando de Noronha  3) Garanhuns  4) Sorriso");
      Console.ResetColor();

      int responseA = int.Parse(Console.ReadLine());
      Console.WriteLine("");

      if(responseA == 1)  {
         accerts++;
      } else {
         errors++;
      }

      // -----------------------------------------------

      // Question 2
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("B) Qual a raíz quadrada de 144 ?");
      Console.ResetColor();

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("1) 5  2) 9  3) 6  4) 12");
      Console.ResetColor();

      int responseB = int.Parse(Console.ReadLine());
      Console.WriteLine("");

      if(responseB == 4) {
         accerts++;
      } else {
         errors++;
      }

      // -----------------------------------------------

      // Question 3
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("C) Qual seria o termo correto em pronome nrutro para ele/ela ?");
      Console.ResetColor();
      
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("1) Elo  2) Elu  3) Eli  4) Eluz");
      Console.ResetColor();

      int responseC = int.Parse(Console.ReadLine());
      Console.WriteLine("");

      if(responseC == 2) {
         accerts++;
      } else {
         errors++;
      }

      if(errors >= 3) {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("GAME OVER");
         Console.WriteLine("YOU LOSE!");
         Console.ResetColor();
      } else {
         // Question 4
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine("D) Qual o nome das garotas que avistaram o ET em Varginha (MG) ?");
         Console.ResetColor();

         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine("1) Soraia, Marina e Julia  \n2) Valquíria, Liliane e Katia  \n3) Jurema, Zuleica e Maria  \n4) Francisca, Antonia e Carla");
         Console.ResetColor();

         int responseD = int.Parse(Console.ReadLine());
         Console.WriteLine("");
         
         if(responseD == 2) {
            accerts++;
         } else {
            errors++;
         } 

         // -----------------------------------------------
         if(errors >= 3) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.WriteLine("YOU LOSE!");
            Console.ResetColor();
         } else {
            // Question 5
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("E) Qual é a sequencia correta para: DOIS ZEROS DOIS QUATRO ?");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1) 2024  2) 0044  3) 0024  4) 2044");
            Console.ResetColor();

            int responseE = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if(responseE == num) {
               accerts++;
            } else {
               errors++;
            }

            if(errors >= 3) {
            Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("GAME OVER");
               Console.WriteLine("YOU LOSE!");
               Console.ResetColor();
            } else {
               Console.WriteLine("------------------------------------");

               if(accerts >= 3) {
                  Console.ForegroundColor = ConsoleColor.Blue;
                  Console.WriteLine("CONGRATULATIONS, VOCÊ ACERTOU {0} de 5 questões!", accerts);
                  Console.ResetColor();
               }

               if(accerts == 5) {
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.WriteLine("YOU WIN, VOCÊ ACERTOU TODAS AS {0} questões!", accerts);
                  Console.ResetColor();
               }
            }
         }
      }

      Console.WriteLine("");
   }
}