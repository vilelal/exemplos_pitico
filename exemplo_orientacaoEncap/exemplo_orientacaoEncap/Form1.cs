namespace exemplo_orientacaoEncap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Instanciando um objeto da classe Pessoa
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Jo�o";
            pessoa.Idade = 30;
            // Exibindo informa��es da pessoa
            pessoa.ExibirInformacoes();

        }
    }
}
