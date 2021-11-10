
namespace _07_ByteBank
{
    public class ContaCorrente
    {
        //construtor
        public ContaCorrente(int agencia, int numero)//assim é obrigatório criar uma conta com agencia e numero
        {
            Agencia = agencia;
            Numero = numero;

            //sempre que a conta corrente for criada
            ContaCorrente.TotalDeContasCriadas++;
        }


        //criando uma propriedade estática e com o set privado, assim fora da classe não é possível trocar o valor
        //estática(não é uma característica individual do objeto e sim uma característica compartilhada por todos dessa classe)
        public static int TotalDeContasCriadas { get; private set; }


        public Cliente Titular { get; set; }

        public int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }

        public int Numero{ get; set; }

        private double _saldo = 100;

        //encapsulando o saldo
        public double Saldo { 
            get 
            {
                return _saldo;
            } set
            {
                if (value > 0)
                {
                    _saldo = value;
                }
            }
        }

      

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }


        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
