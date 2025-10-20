namespace exemplo_orientacaoAbstrato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Usando classes abstratas

            Animal cachorro = new Cachorro { Nome = "Rex" };
            Animal gato = new Gato { Nome = "Mimi" };

            cachorro.EmitirSom();
            gato.EmitirSom();

            // Usando interfaces
            IAnimal animalCachorro = new ICachorro { Nome = "Rex" };
            IAnimal animalGato = new IGato { Nome = "Mimi" };
            animalCachorro.Comer();
            animalGato.Comer();

        }
    }
}
