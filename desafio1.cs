using System;

class Program
{
    static void Main(string[] args)
    {
        
        string registroEmail, registroNome, senha;

        
        //Console.WriteLine("Digite seu email:");
        registroEmail = Console.ReadLine();

       // Console.WriteLine("Digite seu nome:");
        registroNome = Console.ReadLine();

        //Console.WriteLine("Digite sua Senha:");
        senha = Console.ReadLine();
    
       
        Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");

        
        //Console.ReadLine();
    }
}
