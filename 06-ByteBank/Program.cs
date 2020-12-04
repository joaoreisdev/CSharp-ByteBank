using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            contaCorrente conta = new contaCorrente();

            Cliente cliente = new Cliente();

            cliente.Nome = "João";
            cliente.Cpf = "55555555555";
            cliente.Profissao = "Desenvolvedor C#";

            conta.Titular = cliente;

            conta.Saldo = 10;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();
        }
    }
}
