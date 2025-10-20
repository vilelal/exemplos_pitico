namespace exemplo_orientacaoEncap2
{
    // Cria uma classe chamada Cliente com propriedades 
    // para armazenar informações do cliente
    public class Cliente
    {
        private string nome;
        private int idade;
        private string email;
        public Cliente(string nome, int idade, string email)
        {
            this.Nome = nome;
            this.nome = this.Nome;
            this.Idade = idade;
            this.idade = this.Idade;
            this.Email = email;
            this.email = this.Email;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set
            {
                if (value > 0)
                {
                    idade = value;
                }
                else
                {
                    MessageBox.Show("Idade inválida");
                }
            }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
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