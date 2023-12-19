using System;

class Desafio5
{
    static void Main()
    {
        //Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        //Console.WriteLine("Quantos quilômetros você percorre por dia?");
        double quilometrosPorDia = double.Parse(Console.ReadLine());

        //Console.WriteLine("Quantas horas por dia você usa eletrônicos?");
        int horasDeEletronicos = int.Parse(Console.ReadLine());

        //Console.WriteLine("Quantas refeições com carne você tem por dia?");
        int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

        // Exibe o resultado para o usuário
        Console.WriteLine($"{nome}! Sua pegada de carbono é de {pegadaDeCarbono} toneladas por ano.");

    }

    
    static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
        double pegadaTransporte = quilometrosPorDia * 365 * 0.2;
        double pegadaEletronicos = horasDeEletronicos * 0.1;
        double pegadaCarne = refeicoesComCarne * 0.5;

        double pegadaTotal = pegadaTransporte + pegadaEletronicos + pegadaCarne;
        return pegadaTotal;
    }
}
