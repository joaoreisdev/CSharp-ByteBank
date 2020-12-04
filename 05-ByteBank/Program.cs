using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();
            
            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "518.923.456-46";

            contaCorrente conta = new contaCorrente();
            //conta.titular = gabriela;

            //conta.titular = new Cliente();

            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.profissao = "Desenvolvedora C#";
            //conta.titular.cpf = "518.923.456-46";

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular);

            Console.ReadLine(); 
        }
    }
}
