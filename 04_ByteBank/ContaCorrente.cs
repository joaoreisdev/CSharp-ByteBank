
public class contaCorrente
{

    public string titular;
    public string titularCPF;
    public string titularProfissao;

    public int agencia;
    public int numero;
    public double saldo;

    public contaCorrente()
    {
        titular = "N/A";
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








