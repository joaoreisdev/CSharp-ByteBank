using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {
        private string _cpf;

        //teclar prop e dar tab, recurso de code snippet
        public string Nome { get; set; }
        public string Cpf 
        { 
            get 
            {
                return _cpf;
            }
            set
            {
                //Escrevo minha lógica de validação de CPF
                _cpf = value;
            } 
        }
        public string Profissao { get; set; }

        public int Idade { get; set; }

        public bool EhMaiorDeIdade { get { return Idade >= 18; } set { } }
        
    }
}
