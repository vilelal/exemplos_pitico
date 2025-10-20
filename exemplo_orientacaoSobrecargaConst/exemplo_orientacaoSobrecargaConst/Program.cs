namespace exemplo_orientacaoSobrecargaConst
{
    // Definição da classe Pessoa
    public class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        // Construtor padrão (sem parâmetros)
        public Pessoa()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }
        // Construtor com um parâmetro
        public Pessoa(string nome)
        {
            Nome = nome;
            Idade = 0;
        }
        // Construtor com dois parâmetros
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        // Método para exibir informações
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