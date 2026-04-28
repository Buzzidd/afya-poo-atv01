namespace Ex04_RPG
{
    public class Personagem
    {
        private string _nome;
        private string _classe;
        private int _nivel;
        private double _vidaAtual;
        private double _vidaMaxima;

        // Construtor: Define a vida baseada na classe
        public Personagem(string nome, string classe)
        {
            _nome = nome;
            _classe = classe;
            _nivel = 1;

            if (classe.ToLower() == "guerreiro") 
                _vidaMaxima = 150;
            else if (classe.ToLower() == "mago") 
                _vidaMaxima = 80;
            else 
                _vidaMaxima = 100; // Caso digitem outra coisa

            _vidaAtual = _vidaMaxima;
        }

        public void ReceberDano(int pontos)
        {
            _vidaAtual -= pontos;
            if (_vidaAtual < 0) _vidaAtual = 0;
        }

        public void Curar(int pontos)
        {
            // Regra de Ouro: Morto não se cura!
            if (_vidaAtual > 0)
            {
                _vidaAtual += pontos;
                if (_vidaAtual > _vidaMaxima) _vidaAtual = _vidaMaxima;
            }
        }

        public void SubirNivel()
        {
            // Regra de Ouro: Morto não ganha XP!
            if (_vidaAtual > 0)
            {
                _nivel++;
                _vidaMaxima *= 1.10; // Aumenta 10%
                _vidaAtual = _vidaMaxima; // Restaura tudo
            }
        }

        // Método extra exigido pela "Regra de Ouro" para ressuscitar
        public void Ressuscitar()
        {
            if (_vidaAtual == 0) _vidaAtual = _vidaMaxima * 0.1; // Volta com 10% da vida
        }

        public override string ToString()
        {
            return $"{_nome} ({_classe}) - Lvl {_nivel} - HP: {_vidaAtual:F1}/{_vidaMaxima:F1}";
        }
    }
}