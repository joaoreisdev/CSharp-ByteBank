using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            contaCorrente contaDoBruno = new contaCorrente();
            contaCorrente contaDaGabriela = new contaCorrente();

            contaDoBruno.titular = "Bruno";
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine($"Saldo do Bruno {contaDoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela {contaDoBruno.saldo}");

            contaDoBruno.Transferir(20000, contaDaGabriela);

            Console.WriteLine($"Saldo do Bruno {contaDoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela { contaDaGabriela.saldo}");

            Console.ReadLine();
        }
    }
}
