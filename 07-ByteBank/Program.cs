using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            contaCorrente conta = new contaCorrente(123, 897363);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            contaCorrente contaDaGabriela = new contaCorrente(453, 197363);

            Console.WriteLine(contaCorrente.TotalDeContasCriadas);


            Console.ReadLine();

        }
    }
}
