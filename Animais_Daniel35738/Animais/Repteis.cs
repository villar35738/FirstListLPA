using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Repteis : Vertebrados
    {

        bool agressivo;

        public Repteis(string nome, string tipo, int idade, bool agressivo): base (nome, tipo, idade)
        {
            this.agressivo = agressivo;
        }

        public bool Agressivo { get => agressivo; }

        public override string GetDescricao()
        {
            return "Repteil";
        }
    }
}
