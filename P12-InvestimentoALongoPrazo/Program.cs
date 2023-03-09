using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Investindo a longo prazo");

        double investimento = 1000.0;

        double fatorRendimento = 1.005;



        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            Console.WriteLine("No mês " + mes + " do "+ anos +"º ano" + " você terá R$:" + investimento);

            }
            fatorRendimento += 0.001;

        }
        Console.WriteLine("Depois de 5 anos você terá R$:" + investimento);

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }

}
