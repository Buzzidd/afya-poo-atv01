using System;

namespace Ex04_RPG
{
    class Program
    {
        static void Main()
        {
            Personagem heroi = new Personagem("Carlos o Bárbaro", "Guerreiro");

            Console.WriteLine("--- INÍCIO DA JORNADA ---");
            Console.WriteLine(heroi);

            Console.WriteLine("\n--- COMBATE: LEVOU 100 DE DANO ---");
            heroi.ReceberDano(100);
            Console.WriteLine(heroi);

            Console.WriteLine("\n--- SUBINDO DE NÍVEL ---");
            heroi.SubirNivel();
            Console.WriteLine(heroi);

            Console.WriteLine("\n--- GOLPE FATAL: LEVOU 200 DE DANO ---");
            heroi.ReceberDano(200);
            Console.WriteLine(heroi);

            Console.WriteLine("\n--- TENTANDO CURAR MORTO ---");
            heroi.Curar(50);
            Console.WriteLine(heroi); // Vida deve continuar 0

            Console.WriteLine("\n--- RESSUSCITANDO ---");
            heroi.Ressuscitar();
            Console.WriteLine(heroi);
            Console.WriteLine("-------------------------");
        }
    }
}
