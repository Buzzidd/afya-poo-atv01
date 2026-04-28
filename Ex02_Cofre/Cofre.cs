namespace Ex02_Cofre {
    public class Cofre {
        private string _dono;
        private string _senha;
        private bool _estaAberto;
        private int _erros;

        // Regra de Ouro: Somente leitura para o exterior
        public bool EstaAberto => _estaAberto;

        public Cofre(string dono, string senhaInicial) {
            _dono = dono;
            _senha = senhaInicial;
            _estaAberto = false;
            _erros = 0;
        }

        public string Abrir(string senhaInformada) {
            if (_erros >= 3) return "Cofre Bloqueado! Procure o suporte.";

            if (senhaInformada == _senha) {
                _estaAberto = true;
                _erros = 0;
                return "Cofre Aberto com sucesso!";
            } else {
                _erros++;
                return $"Senha incorreta! Tentativas: {_erros}/3";
            }
        }

        public void Fechar() => _estaAberto = false;

        public bool AlterarSenha(string senhaAntiga, string novaSenha) {
            if (_estaAberto && senhaAntiga == _senha) {
                _senha = novaSenha;
                return true;
            }
            return false;
        }
    }
}