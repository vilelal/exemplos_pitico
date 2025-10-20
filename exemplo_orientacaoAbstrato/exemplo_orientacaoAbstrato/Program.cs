namespace exemplo_orientacaoAbstrato
{
    // Defini��o da classe abstrata Animal
    public abstract class Animal
    {
        // Atributo
        public string Nome { get; set; }
        // M�todo abstrato
        public abstract void EmitirSom();
        // M�todo concreto
        public void Comer()
        {
            MessageBox.Show($"{Nome} est� comendo.");
        }
    }
    // Defini��o da subclasse Cachorro
    public class Cachorro : Animal
    {
        // Implementa��o do m�todo abstrato
        public override void EmitirSom()
        {
            MessageBox.Show($"{Nome} est� latindo.");
        }
    }
    // Defini��o da subclasse Gato
    public class Gato : Animal
    {
        // Implementa��o do m�todo abstrato
        public override void EmitirSom()
        {
            MessageBox.Show($"{Nome} est� miando.");
        }
    }
    // Defini��o da interface IAnimal
    public interface IAnimal
    {
        // Propriedade
        string Nome { get; set; }
        // M�todos
        void EmitirSom();
        void Comer();
    }
    // Implementa��o da interface na classe Cachorro
    public class ICachorro : IAnimal
    {
        public string Nome { get; set; }
        public void EmitirSom()
        {
            MessageBox.Show($"{Nome} est� latindo.");
        }
        public void Comer()
        {
            MessageBox.Show($"{Nome} est� comendo.");
        }
    }
    // Implementa��o da interface na classe Gato
    public class IGato : IAnimal
    {
        public string Nome { get; set; }
        public void EmitirSom()
        {
            MessageBox.Show($"{Nome} est� miando.");
        }
        public void Comer()
        {
            MessageBox.Show($"{Nome} est� comendo.");
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