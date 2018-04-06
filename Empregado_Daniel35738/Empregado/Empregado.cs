using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregado
{
    class Empregado
    {
        string nome, sobrenome;
        double salario;

        public Empregado(string nome, string sobrenome, double salario)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Salario = salario;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public double Salario {
            get
            {
                return salario;
            }
            set
            {
                if (value > 0.0)
                {
                salario = value;
                }
                else
                {
                    salario = 0.0;
                }
            }
        }
    }
}
