using Ex01_Lampada;

// 1. Criamos a lâmpada (chamando o construtor)
Lampada minhaLampada = new Lampada("Philips", "LED");

// 2. Mostramos como ela está no começo
Console.WriteLine("--- Início do Teste ---");
Console.WriteLine(minhaLampada.MostrarStatus());

// 3. Vamos ligar e aumentar o brilho
minhaLampada.Ligar();
minhaLampada.AumentarBrilho();
minhaLampada.AumentarBrilho();

Console.WriteLine("\n--- Depois de Ligar e Aumentar Brilho ---");
Console.WriteLine(minhaLampada.MostrarStatus());

// 4. Vamos desligar
minhaLampada.Desligar();
Console.WriteLine("\n--- Depois de Desligar ---");
Console.WriteLine(minhaLampada.MostrarStatus());
