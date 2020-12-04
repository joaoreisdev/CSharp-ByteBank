//*Sinaliza qual namespace estamos utilizando, assim podemos usar só o nome da classe
using _06_ByteBank;

//Outra maneira de declarar namespace
namespace _06_ByteBank
{
    public class contaCorrente
    {
        //Criando getters e setter padrão para um atributo. (Sem lógica para getter e setter)
        public Cliente Titular { get; set; }

        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo;

        public contaCorrente()
        {
            Agencia = 50;
            Numero = 999999;
            _saldo = 100;
        }

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








