namespace exemplo_orientacaoSobrescritaMet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Instanciando um objeto da classe Cachorro
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Rex";
            cachorro.EmitirSom();
            // Instanciando um objeto da classe Gato
            Gato gato = new Gato();
            gato.Nome = "Mimi";
            gato.EmitirSom();

        }
    }
}
