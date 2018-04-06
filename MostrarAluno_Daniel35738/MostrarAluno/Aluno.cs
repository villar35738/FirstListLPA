using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarAluno
{
    class Aluno
    {
        string matricula, nome, email;

        public Aluno(string matricula, string nome, string email)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.email = email;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
    }
}
