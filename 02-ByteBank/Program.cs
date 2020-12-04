using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            contaCorrente conta;
            conta = new contaCorrente();


            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.numero);
            Console.WriteLine(conta.agencia);

            Console.ReadLine();
        }
    }
}
