using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            contaCorrente contaDaGabriela = new contaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 342;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Tituar "+contaDaGabriela.titular+"\nAgencia "+ contaDaGabriela.agencia+ "\nNumero "+ contaDaGabriela.numero+"\nSaldo "+ contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
