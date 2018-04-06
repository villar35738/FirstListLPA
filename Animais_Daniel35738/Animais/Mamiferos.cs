using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Mamiferos: Vertebrados
    {

        bool roedor;

        public Mamiferos(string nome, string tipo, int idade, bool roedor): base (nome, tipo, idade)
        {
            this.roedor = roedor;
        }

        public bool Roedor { get => roedor; }

        public override string GetDescricao()
        {
            return "Mamifero";
        }
    }
}
