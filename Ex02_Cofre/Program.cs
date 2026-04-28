using System;
using Ex02_Cofre; // Isso aqui liga o Program ao seu arquivo Cofre.cs

class Program
{
    static void Main()
    {
        // Criando o cofre do Carlos com a senha "1234"
        Cofre meuCofre = new Cofre("Carlos Vitor", "1234");

        Console.WriteLine("--- TESTANDO O COFRE ---");

        // Teste 1: Errar a senha de propósito
        Console.WriteLine(meuCofre.Abrir("0000")); 
        
        // Teste 2: Errar de novo
        Console.WriteLine(meuCofre.Abrir("9999")); 

        // Teste 3: Errar a terceira vez (Deve bloquear!)
        Console.WriteLine(meuCofre.Abrir("5555")); 

        // Teste 4: Tentar a senha certa com o cofre já bloqueado
        Console.WriteLine(meuCofre.Abrir("1234")); 
        
        Console.WriteLine("-------------------------");
    }
}