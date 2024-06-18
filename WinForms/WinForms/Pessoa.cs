using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public class Pessoa
    {

        private Pessoa() { 
        }
        public Pessoa( string nome, int cpf)
        {
           
            this.Nome = nome;
            this.Cpf = cpf;
        }

       
        public string Nome { get; set; }
        public int Cpf { get; set; }

    }
}
