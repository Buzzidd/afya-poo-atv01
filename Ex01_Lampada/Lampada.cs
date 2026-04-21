namespace Ex01_Lampada
{
    public class Lampada
    {
        // Atributos privados (Encapsulamento)
        private string marca;
        private string tecnologia;
        private bool estaLigada;
        private int brilho;

        // Construtor: como a lâmpada "nasce"
        public Lampada(string marcaInicial, string tecnologiaInicial)
        {
            marca = marcaInicial;
            tecnologia = tecnologiaInicial;
            estaLigada = false;
            brilho = 0;
        }

        // Ações (Métodos)
        public void Ligar()
        {
            estaLigada = true;
            if (brilho == 0) brilho = 50; // Começa com um brilho padrão
        }

        public void Desligar()
        {
            estaLigada = false;
        }

        public void AumentarBrilho()
        {
            if (estaLigada && brilho < 100) brilho += 10;
        }

        public void DiminuirBrilho()
        {
            if (estaLigada && brilho > 0) brilho -= 10;
        }

        // Método extra para a gente conseguir ver o que está acontecendo
        public string MostrarStatus()
        {
            string status = estaLigada ? "Ligada" : "Desligada";
            return $"Lâmpada {marca} ({tecnologia}) | Status: {status} | Brilho: {brilho}%";
        }
    }
}