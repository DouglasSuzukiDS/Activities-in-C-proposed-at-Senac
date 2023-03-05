using System;

class Finance {
    static void Main() {
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
    }
}