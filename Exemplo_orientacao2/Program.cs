namespace Exemplo_orientacao2
{
    //defini��o da classe pessoa
    public class Pessoa
    {
        //Atributo publico
        public string Nome { get; set; }
        //Atributo privado

        private int idade;
        //Atributo constante

        public const string Especie= "Humano";

        //Atributo est�tico
        public static int ContadorDePessoas = 0;

        //construtorlkjjjjjjjjjjjhhhhhhhhhhhhhhh
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            this.idade = idade;
            ContadorDePessoas++;
        }

        // M�todo para exibir informa��es
        public void ExibirInformacoes()
        {
            MessageBox.Show($"Nome: {Nome}, Idade: {idade}, Esp�cie: {Especie}, Total de Pessoas: { ContadorDePessoas}");
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