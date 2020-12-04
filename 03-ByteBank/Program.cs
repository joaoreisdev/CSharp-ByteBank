using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            contaCorrente contaDaGabriela = new contaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 89659;

            contaCorrente contaDaAna = new contaCorrente();
            contaDaAna.titular = "Ana";
            contaDaAna.agencia = 863;
            contaDaAna.numero = 89659;

            contaDaGabriela = contaDaAna;

            Console.WriteLine(contaDaAna.titular);
            Console.WriteLine(contaDaGabriela.titular);

            Console.WriteLine(contaDaGabriela == contaDaAna);

            Console.ReadLine();

        }
    }
}
