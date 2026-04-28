using System;

namespace Ex03_ContaCorrente
{
    class Program
    {
        static void Main()
        {
            // Criando a conta
            Conta minhaConta = new Conta("2024-ACCOUNT", "Carlos Vitor");

            Console.WriteLine("--- TESTANDO CONTA UNIVERSITÁRIA ---");
            Console.WriteLine(minhaConta); // Usa o ToString automaticamente

            minhaConta.Depositar(100);
            Console.WriteLine("\nApós depositar R$ 100:");
            Console.WriteLine(minhaConta);

            // Testando o limite: saldo é 100, vou sacar 300 (vai usar 200 do limite)
            if (minhaConta.Sacar(300))
            {
                Console.WriteLine("\nSaque de R$ 300 realizado com sucesso!");
            }

            Console.WriteLine(minhaConta);
            Console.WriteLine($"Status atual: {minhaConta.StatusConta}");
            Console.WriteLine("------------------------------------");
        }
    }
}
