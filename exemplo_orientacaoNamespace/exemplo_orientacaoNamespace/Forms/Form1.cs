using exemplo_orientacaoNamespace.models;

namespace exemplo_orientacaoNamespace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Criando uma lista de animais
            List<Animal> animais = new List<Animal>
            {
                new Cachorro { Nome = "Rex" },
                new Gato { Nome = "Mimi" }
            };

            // Demostrando o polimorfismo

            foreach (Animal animal in animais)
            {
                animal.EmitirSom();
            }   
        }
    }
}
