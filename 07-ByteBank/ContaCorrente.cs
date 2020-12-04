//*Sinaliza qual namespace estamos utilizando, assim podemos usar só o nome da classe
using _07_ByteBank;

//Outra maneira de declarar namespace
namespace _07_ByteBank
{
    public class contaCorrente
    {
        //Construtor da classe
        public contaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }

        public static int TotalDeContasCriadas { get; private set; }

        //Criando getters e setter padrão para um atributo. (Sem lógica para getter e setter)
        public Cliente Titular { get; set; }


        private int _agencia;
        public int Agencia 
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <=0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        
        public int Numero { get; set; }

        private double _saldo;

        //Propriedades --> Getters And Setter
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                    return;

                this._saldo = value;
            }
        }

        //Métodos da classe
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
                System.Console.WriteLine("Valor negativo!");
            else
                this._saldo += valor;
        }

        public bool Transferir(double valor, contaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                System.Console.WriteLine("Saldo Insuficiente");
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

    }


}








