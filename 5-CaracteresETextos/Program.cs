using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a'; // armazena 1 caractere
        Console.WriteLine(letra);

        letra = (char)65; //imprime 'A' => conversão de decimal para char (consultar tabela ASCII)
        Console.WriteLine(letra);


        string primeiraFrase = "Alura - cursos de tecnologia";
        //para quebra de linha em string adicionar @
        string cursos = @"Cursos disponíveis:
- Go
- C#
- Python
- Java";
        Console.WriteLine(primeiraFrase);
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }

}
