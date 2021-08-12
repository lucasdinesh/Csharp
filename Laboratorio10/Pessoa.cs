using System;

namespace Laboratorio10
{
    class Pessoa
    {
        private bool casada;
        private String nome;
        private DateTime dataNascimento;
        public bool Casada
        {
            get { return casada; }
            set { casada = value; }
        }
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public override string ToString()
        {
            return "[Nome=" + nome + ", Casada=" + casada + ", DataNascimento=" +
           dataNascimento.ToShortDateString() + "]";
        }
    }
}
