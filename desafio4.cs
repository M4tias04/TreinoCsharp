using System;

class Desafio4
{
 static void Main()
    {
        
        int quantidadeJogos = int.Parse(Console.ReadLine());

      
       string[] nomesJogos = new string[quantidadeJogos];

        
       for(int i=0; i < quantidadeJogos;i++)
       {
         AdicionarJogo(i, nomesJogos);
       }

       
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
       
        nomes[indice] = Console.ReadLine();
    }

   static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
   {
    string listaJogos = string.Join(", ", nomes, 0, quantidadeJogos);
    Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {listaJogos} ao catalogo.");
   }
}
