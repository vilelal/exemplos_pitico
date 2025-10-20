namespace exemplo_orientacaoSobrescritaMet
{
    // Definição da classe base Animal
    public class Animal
    {
        // Atributos
        public string Nome { get; set; }
        // Método virtual que pode ser sobrescrito
        public virtual void EmitirSom()
        {
            MessageBox.Show($"{Nome} está fazendo um som.");
        }
    }
    // Definição da subclasse Cachorro
    public class Cachorro : Animal
    {
        // Sobrescrita do método EmitirSom
        public override void EmitirSom()
        {
            MessageBox.Show($"{Nome} está latindo.");
        }
    }
    // Definição da subclasse Gato
    public class Gato : Animal
    {
        // Sobrescrita do método EmitirSom
        public override void EmitirSom()
        {
            MessageBox.Show($"{Nome} está miando.");
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