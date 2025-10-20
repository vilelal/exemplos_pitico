namespace exemplo_orientacaoSobrecargaConst
{
    // Defini��o da classe Pessoa
    public class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        // Construtor padr�o (sem par�metros)
        public Pessoa()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }
        // Construtor com um par�metro
        public Pessoa(string nome)
        {
            Nome = nome;
            Idade = 0;
        }
        // Construtor com dois par�metros
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
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