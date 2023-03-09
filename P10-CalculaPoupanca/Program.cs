using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;

        double rendimento = investimento * 0.005;

        int mes = 1;
        

        while (mes <= 12)
        {
            investimento = investimento + rendimento;
            Console.WriteLine("No mês "+mes + " você terá R$:" + investimento);
            mes++;
        }


        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }

}
