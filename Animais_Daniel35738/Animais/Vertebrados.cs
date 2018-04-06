using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    abstract class Vertebrados : IAnimais
    {

        string nome, tipo;
        int idade;

        public Vertebrados(string nome, string tipo, int idade)
        {
            this.Nome = nome;
            this.Tipo = tipo;
            this.Idade = idade;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Idade { get => idade; set => idade = value; }

        public abstract string GetDescricao();
    }
}
