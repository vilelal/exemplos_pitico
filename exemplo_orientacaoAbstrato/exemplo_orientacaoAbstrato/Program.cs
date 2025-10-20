namespace exemplo_orientacaoAbstrato
{
    // Definição da classe abstrata Animal
    public abstract class Animal
    {
        // Atributo
        public string Nome { get; set; }
        // Método abstrato
        public abstract void EmitirSom();
        // Método concreto
        public void Comer()
        {
            MessageBox.Show($"{Nome} está comendo.");
        }
    }
    // Definição da subclasse Cachorro
    public class Cachorro : Animal
    {
        // Implementação do método abstrato
        public override void EmitirSom()
        {
            MessageBox.Show($"{Nome} está latindo.");
        }
    }
    // Definição da subclasse Gato
    public class Gato : Animal
    {
        // Implementação do método abstrato
        public override void EmitirSom()
        {
            MessageBox.Show($"{Nome} está miando.");
        }
    }
    // Definição da interface IAnimal
    public interface IAnimal
    {
        // Propriedade
        string Nome { get; set; }
        // Métodos
        void EmitirSom();
        void Comer();
    }
    // Implementação da interface na classe Cachorro
    public class ICachorro : IAnimal
    {
        public string Nome { get; set; }
        public void EmitirSom()
        {
            MessageBox.Show($"{Nome} está latindo.");
        }
        public void Comer()
        {
            MessageBox.Show($"{Nome} está comendo.");
        }
    }
    // Implementação da interface na classe Gato
    public class IGato : IAnimal
    {
        public string Nome { get; set; }
        public void EmitirSom()
        {
            MessageBox.Show($"{Nome} está miando.");
        }
        public void Comer()
        {
            MessageBox.Show($"{Nome} está comendo.");
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