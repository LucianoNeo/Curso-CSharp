using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula Poupança 2");

        double investimento = 1000.0;

        double rendimento = investimento * 0.005;

        


        for (int mes = 1; mes <= 12; mes++)
        {
            investimento += rendimento;
            Console.WriteLine("No mês " + mes + " você terá R$:" + investimento);
    
        }


        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }

}
