namespace exemplo_orientacaoEncap
{
    // Defini��o da classe Pessoa
    public class Pessoa
    {
        // Atributos privados
        private string nome;
        private int idade;
        // Propriedade para acessar o atributo nome
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        // Propriedade para acessar o atributo idade
        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
                else
                {
                    throw new ArgumentException("Idade n�o pode ser negativa");
                }
            }
        }
        // M�todo para exibir informa��es
        public void ExibirInformacoes()
        {
            MessageBox.Show($"Nome: {Nome}, Idade: {Idade}");
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}