using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");
        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            if (quantidadePessoas > 0)
            {
                Console.WriteLine("Ele está acompanhado. Pode Entrar!");
            }
            else
            {
                Console.WriteLine("Não pode Entrar!");
            }
        }


        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }

}
