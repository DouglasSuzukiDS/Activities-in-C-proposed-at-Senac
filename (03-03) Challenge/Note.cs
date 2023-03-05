using System;
class SchoolSystem {
    static void Main() {
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
    }
}
