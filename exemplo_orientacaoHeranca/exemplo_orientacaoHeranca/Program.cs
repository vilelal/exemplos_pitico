namespace exemplo_orientacaoHeranca
{

    // Cria uma classe chamada Cliente com propriedades 
    // para armazenar informa��es do cliente
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public virtual string GetDetalhes()
        {
            return $"Nome: {Nome}\nSobrenome: {Sobrenome}\nIdade: {Idade}";
        }
    }
    public class Cliente : Pessoa
    {
        public string Endereco { get; set; }
        public string Email { get; set; }
        public Cliente()
        {
            this.Endereco = "Rua do Cemit�rio";
        }
        public override string GetDetalhes()
        {
            return $"{base.GetDetalhes()}\nEndere�o: {Endereco}\nEmail: { Email}";
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