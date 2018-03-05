using System;

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
