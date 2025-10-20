using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_orientacaoNamespace.models
{
    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            MessageBox.Show($"{Nome} está latindo!");
        }
    }
}
