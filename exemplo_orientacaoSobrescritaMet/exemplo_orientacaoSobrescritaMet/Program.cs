namespace exemplo_orientacaoSobrescritaMet
{
    // Defini��o da classe base Animal
    public class Animal
    {
        // Atributos
        public string Nome { get; set; }
        // M�todo virtual que pode ser sobrescrito
        public virtual void EmitirSom()
        {
            MessageBox.Show($"{Nome} est� fazendo um som.");
        }
    }
    // Defini��o da subclasse Cachorro
    public class Cachorro : Animal
    {
        // Sobrescrita do m�todo EmitirSom
        public override void EmitirSom()
        {
            MessageBox.Show($"{Nome} est� latindo.");
        }
    }
    // Defini��o da subclasse Gato
    public class Gato : Animal
    {
        // Sobrescrita do m�todo EmitirSom
        public override void EmitirSom()
        {
            MessageBox.Show($"{Nome} est� miando.");
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