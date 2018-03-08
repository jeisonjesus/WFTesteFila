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

        public int Idade
        {
            get
            {
                return Convert.ToInt32(DateTime.Now.Subtract(Aniversario).TotalDays / 365);
            }
        }

        public void Salvar()
        {
            if (Nome == "João")
            {
                Nome = "João da Silva";
            }
        }
    }
}
