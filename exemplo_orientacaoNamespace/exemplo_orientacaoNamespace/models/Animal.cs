using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_orientacaoNamespace.models
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public abstract void EmitirSom();
    }
}
