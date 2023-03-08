using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuições de variáveis");

        int idade = 30;
        int idadeAna = idade;
        idade = 25;
        Console.WriteLine(idadeAna);// imprime 30

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }

}
