namespace Ex03_ContaCorrente 
{
    public class Conta
    {
        // Atributos privados (Checklist: Encapsulamento)
        private readonly string _numero; // Check: Somente leitura
        private string _titular;
        private double _saldo;
        private double _limite;

        // Propriedades Calculadas (Checklist: Campos Calculados)
        public double SaldoTotal => _saldo + _limite;
        public string StatusConta => _saldo < 0 ? "Negativo" : "Positivo";

        // Construtor (Checklist: Inicializar estado)
        public Conta(string numero, string titular)
        {
            _numero = numero;
            _titular = titular;
            _saldo = 0;
            _limite = 500;
        }

        // Métodos de Negócio
        public void Depositar(double valor)
        {
            if (valor > 0) _saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= SaldoTotal)
            {
                _saldo -= valor;
                return true;
            }
            return false;
        }

        // Sobrescrita (Checklist: public override string ToString)
        public override string ToString()
        {
            return $"Conta: {_numero} | Titular: {_titular} | Saldo: {_saldo:C2} | Limite: {_limite:C2}";
        }
    }
}