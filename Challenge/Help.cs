using System;

class HelpStudent {
    static void Main() {
        Console.WriteLine("Ajudando o Aluno a passar. \n");

        Console.WriteLine("Qual seu nome? ");
        string name = Console.ReadLine();

        Console.WriteLine("\nQual sua nota?: 1 - 10");
        int note = int.Parse(Console.ReadLine());

        if (note < 6) {
            haveMoney:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTu tem dinheiro?");
            Console.ResetColor();
            string resUser = Console.ReadLine();
            bool money;

            if(resUser == "Sim" || resUser == "sim" || resUser == "SIM" || resUser == "s" || resUser == "S") {
               money = true;
            } else if(resUser == "Não" || resUser == "Nao" || resUser == "nao" || resUser == "não" || resUser == "N" || resUser == "n" ) {
               money = false;
            } else {
                goto haveMoney;
            }
            
            if (money) {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nCalmEE pequenEE gafanhotEEE");

                Console.WriteLine("\nPagou Passou, nobre camarada {0}!", name);

                Console.WriteLine("\nJá que você é um Aluno ESPECIAL, temos um descontinho para você!");
  
                Console.WriteLine("\nVosso Passe fica em apenas R$120 Reais.");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAceitamos Dinheiro, Pix, Cartões de Débito/Crédito, e/ou Vale Alimentação/Vale Refeição.");
                Console.WriteLine("\nPara lhe ajudar da melhor forma, Para lhe ajudar da melhor forma, parcelamos em Até 2X no CARTÃO!!!!");
                Console.ResetColor();

                Console.WriteLine("\n-------------------------------\n");

               int chooseError2 = 0;
               ChooseAgainConfirm:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Qual a forma de Pagamento?");
                Console.ResetColor();
               
                Console.WriteLine("\n-------------------------------\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1) Dinheiro \n2) Pix \n3) Cartão(Credito/debito) \n4) VA/VR");
                Console.ResetColor();

                int choosePayment = int.Parse(Console.ReadLine());

                if (choosePayment == 1) {
                  Console.ForegroundColor = ConsoleColor.Cyan;
                     Console.WriteLine("Você escolheu escolheu a opção em Dinheiro!");

                     Console.WriteLine("\nO pagamento pode ser realizado amanhã mesmo!");

                     Console.WriteLine("\nApós vosso pagamento, iniciaresmos vosso processo de aprovação.");

                     Console.WriteLine("\nGrupo Ponzi agradece, até breve.");
                     Console.ResetColor();

                  } else if (choosePayment == 2) {
                     Console.ForegroundColor = ConsoleColor.Cyan;
                     Console.WriteLine("Voce escolheu escolheu a opção Pix!");

                     Console.WriteLine("\nO pagamento pode ser realizado agora mesmo!");
                     Console.WriteLine("\nChave Pix: pagueipassei@payforpass.com");

                     Console.WriteLine("\nApós vosso pagamento, iniciaresmos vosso processo de aprovação.");

                     Console.WriteLine("\nGrupo Ponzi agradece, até breve.");
                     Console.ResetColor();

                  } else if (choosePayment == 3) {
                     Console.ForegroundColor = ConsoleColor.Cyan;
                     Console.WriteLine("Voce escolheu escolheu a opção 3!");

                     Console.WriteLine("\nO pagamento pode ser realizado amanhã mesmo!");

                     Console.WriteLine("\nNão se preocupe... Levamos a maquininha até você!");

                     Console.WriteLine("\nApós vosso pagamento, iniciaresmos vosso processo de aprovação.");

                     Console.WriteLine("\nGrupo Ponzi agradece, até breve.");
                     Console.ResetColor();

                  } else if (choosePayment == 4) {
                     Console.ForegroundColor = ConsoleColor.Cyan;
                     Console.WriteLine("Voce escolheu escolheu a opção VA/VR!");

                     Console.WriteLine("\nPagamento pode ser realizado amanhã mesmo!");

                     Console.WriteLine("\nNão se preocupe... Levamos a maquininha até você!");

                     Console.WriteLine("\nApós vosso pagamento, iniciaresmos vosso processo de aprovação.");

                     Console.WriteLine("\nGrupo Ponzi agradece, até breve.");
                     Console.ResetColor();
                  } else { 
                  chooseError2++;
                  if(chooseError2 >= 2) {
                     Console.ForegroundColor = ConsoleColor.Yellow;
                     Console.Write("\nQuerido aluno, lamentos lhe informar.");
                     Console.ResetColor();

                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.Write("\nMas não há nada que possamos fazer para lhe tirar dessa lamentável situação.\n");
                     Console.ResetColor();
                  } else {
                     goto ChooseAgainConfirm; 
                  }
               }

            }
            else {
                int chooseError = 0;
                int resNote = 6 - note;

                chooseAgain:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nO senhor necessita de {0} Pontos na média.", resNote);
                Console.WriteLine("\nEntão temos a seguintes opções:");
                Console.ResetColor();
                Console.WriteLine("\n-------------------------------\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1) Recuperação aos Sábados das 8H às 18H;\n2) Realizar Atividades escolares das 9 às 12H de Segunda a Sexta;\n3) Realizar trabalhos de pesquisas, aprensentações;");
                Console.ResetColor();

                int resStudent = int.Parse(Console.ReadLine());
                switch (resStudent) {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("\nOk, vossa Recuperação vai começar no Sábado que vem, das 8h as 18h!");
                        Console.Write("\nBons estudos! \n");
                        Console.ResetColor();
                        break;
                    case 2:
                     Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("\nOk, vossas atividades irão começar semana que vem, de Segunda à Sexta das 9h as 12h");
                        Console.Write("\nBons estudos! \n");
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("\nOk, vossos trabalhos/pesquisas escolares começaram semana que vem!");
                        Console.WriteLine("\n1ª tema: Revolução Francesa");
                        Console.Write("\nBons estudos! \n");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nTEM CERTEZA QUE NÃO TEM DINHEIRO ?? S/N\n");
                        Console.ResetColor();

                        string resMoney = Console.ReadLine();

                        if (resMoney == "N" || resMoney == "n") {
                           Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nPagou Passou, nobre camarada {0}.", name);

                            Console.WriteLine("\nJá que você é um Aluno ESPECIAL, temos um descontinho para você");

                            Console.WriteLine("\nApenas R$150 Reais!");

                            Console.WriteLine("\nAceitamos Cartão Debito, Credito, Pix, Dinheiro, Vale Alimentação e Vale Refeição. ");

                            Console.WriteLine("\nPara lhe ajudar da melhor forma, Para lhe ajudar da melhor forma, parcelamos em Até 2X no CARTÃO!!!!");

                            Console.WriteLine("\n-------------------------------\n");
                            Console.ResetColor();

                            int chooseError2 = 0;
                            ChooseAgainConfirm:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nQual a forma de Pagamento?");

                            Console.WriteLine("1) Dinheiro \n2) Pix \n3) Cartão(Credito/debito) \n4) VA/VR");
                            Console.ResetColor();

                            int choosePayment = int.Parse(Console.ReadLine());

                            if (choosePayment == 1) {
                              Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Você escolheu escolheu a opção em Dinheiro!");

                                Console.WriteLine("\nO pagamento pode ser realizado amanhã mesmo!");

                                Console.WriteLine("\nApós vosso pagamento, iniciaresmos vosso processo de aprovação.");

                                Console.WriteLine("\nGrupo Ponzi agradece, até breve.");
                                Console.ResetColor();

                            } else if (choosePayment == 2) {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Voce escolheu escolheu a opção Pix!");

                                Console.WriteLine("\nO pagamento pode ser realizado agora mesmo!");
                                Console.WriteLine("\nChave Pix: pagueipassei@payforpass.com");

                                Console.WriteLine("\nApós vosso pagamento, iniciaresmos vosso processo de aprovação.");

                                Console.WriteLine("\nGrupo Ponzi agradece, até breve.");
                                Console.ResetColor();

                            } else if (choosePayment == 3) {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Voce escolheu escolheu a opção 3!");

                                Console.WriteLine("\nO pagamento pode ser realizado amanhã mesmo!");

                                Console.WriteLine("\nNão se preocupe... Levamos a maquininha até você!");

                                Console.WriteLine("\nApós vosso pagamento, iniciaresmos vosso processo de aprovação.");

                                Console.WriteLine("\nGrupo Ponzi agradece, até breve.");
                                Console.ResetColor();

                            } else if (choosePayment == 4) {
                               Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Voce escolheu escolheu a opção VA/VR!");

                                Console.WriteLine("\nPagamento pode ser realizado amanhã mesmo!");

                                Console.WriteLine("\nNão se preocupe... Levamos a maquininha até você!");

                                Console.WriteLine("\nApós vosso pagamento, iniciaresmos vosso processo de aprovação.");

                                Console.WriteLine("\nGrupo Ponzi agradece, até breve.");
                                Console.ResetColor();
                            } else { 
                              chooseError2++;
                              if(chooseError2 >= 2) {
                                 Console.ForegroundColor = ConsoleColor.Yellow;
                                 Console.Write("\nQuerido aluno, lamentos lhe informar.");
                                 Console.ResetColor();

                                 Console.ForegroundColor = ConsoleColor.Red;
                                 Console.Write("\nMas não há nada que possamos fazer para lhe tirar dessa lamentável situação.\n");
                                 Console.ResetColor();
                              } else {
                                 goto ChooseAgainConfirm; 
                              }
                           }
                        } else {
                              chooseError++;
                              if(chooseError >= 2) {
                                 Console.ForegroundColor = ConsoleColor.Yellow;
                                 Console.Write("\nQuerido aluno, lamentos lhe informar.");
                                 Console.ResetColor();

                                 Console.ForegroundColor = ConsoleColor.Red;
                                 Console.Write("\nMas não há nada que possamos fazer para lhe tirar dessa lamentável situação.\n");
                                 Console.ResetColor();
                              } else {
                                 goto chooseAgain;
                              }
                        }
                        break;
                      
                }

            }
        } else {
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.WriteLine("\nParabéns {0}, o senhorE foi aprovado!", name);
         Console.ResetColor();
        }

    }
}

