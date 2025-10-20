using static Exemplo_orientacaoPolimor.Program;

namespace Exemplo_orientacaoPolimor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<Animal> animais = new List<Animal>
{
            new Cachorro { Nome = "Rex" },
            new Gato { Nome = "Mimi" }
            };
            // Demonstrando polimorfismo
            foreach (Animal animal in animais)
            {
                animal.EmitirSom();
            }
        }
    }
}
