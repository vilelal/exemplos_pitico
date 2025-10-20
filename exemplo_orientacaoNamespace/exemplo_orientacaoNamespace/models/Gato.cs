using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_orientacaoNamespace.models
{
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            MessageBox.Show($"{Nome} está miando!");
        }
    }
}
