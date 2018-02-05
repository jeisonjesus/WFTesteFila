using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTesteFila
{
    public class Pessoa
    {
        public Pessoa(string nome, DateTime aniversario)
        {
            Nome = nome;
            Aniversario = aniversario;
        }

        public string Nome { get; set; }

       public DateTime Aniversario { get; set; }
    }
}
