using System;

class Desafio2
{
    static void Main()
    {
        
        string titulo, descricao, dataVencimento;

        Console.WriteLine("Digite o título da tarefa:");
        titulo = Console.ReadLine();

        Console.WriteLine("Digite a descrição da tarefa:");
        descricao = Console.ReadLine();

        if (descricao.Length > 50)
        {
            Console.WriteLine("A descrição excede 50 caracteres.");
        }
        else
        {
            Console.WriteLine("Digite a data de vencimento da tarefa:");
            dataVencimento = Console.ReadLine();

            Console.WriteLine($"Descrição da tarefa: {descricao}");
            Console.WriteLine($"Data de vencimento: {dataVencimento}");
        }
    }
}