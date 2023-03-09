using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        string textoAdicional;

        if (acompanhado)
        {
           textoAdicional = "João está acompanhado";
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            textoAdicional = "João não está acompanhado";
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode Entrar!");

        }


        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }

}
