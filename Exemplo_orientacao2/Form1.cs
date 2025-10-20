namespace Exemplo_orientacao2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Instanciando objetos da classe Pessoa
            Pessoa pessoa1 = new Pessoa("João", 30);
            Pessoa pessoa2 = new Pessoa("Maria", 25);

            //Exibindo informações das pessoas
            pessoa1.ExibirInformacoes();
            pessoa2.ExibirInformacoes();
        }
    }
}
