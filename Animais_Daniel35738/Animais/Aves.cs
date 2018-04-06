using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Aves : Vertebrados
    {

        bool voa;

        public Aves(string nome, string tipo, int idade, bool voa): base (nome, tipo, idade)
        {
            this.voa = voa;
        }

        public bool Voa { get => voa; }

        public override string GetDescricao()
        {
            return "Ave";
        }
    }
}
