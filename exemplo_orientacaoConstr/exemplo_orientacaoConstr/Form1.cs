namespace exemplo_orientacaoConstr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Usando o construtor padr�o
            Pessoa pessoa1 = new Pessoa();
            pessoa1.ExibirInformacoes();
            // Usando o construtor com um par�metro
            Pessoa pessoa2 = new Pessoa("Maria");
            pessoa2.ExibirInformacoes();
            // Usando o construtor com dois par�metros
            Pessoa pessoa3 = new Pessoa("Jo�o", 30);
            pessoa3.ExibirInformacoes();
        }
    }
}
