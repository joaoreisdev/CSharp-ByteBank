//*Sinaliza qual namespace estamos utilizando, assim podemos usar só o nome da classe
using _05_ByteBank;

//Outra maneira de declarar namespace
namespace _05_ByteBank
{
    public class contaCorrente
    {
        //namespace.NomeDaClasse*
        public _05_ByteBank.Cliente titular;

        public int agencia;
        public int numero;
        public double saldo;

        public contaCorrente()
        {
            agencia = 50;
            numero = 999999;
            saldo = 100;
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
                System.Console.WriteLine("Valor negativo!");
            else
                this.saldo += valor;
        }

        public bool Transferir(double valor, contaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                System.Console.WriteLine("Saldo Insuficiente");
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

    }


}








