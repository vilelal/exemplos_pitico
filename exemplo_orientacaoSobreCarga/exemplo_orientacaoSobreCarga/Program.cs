namespace exemplo_orientacaoSobreCarga
{
    // Defini��o da classe Calculadora
    public class Calculadora
    {
        // M�todo para somar dois inteiros
        public int Somar(int a, int b)
        {
            return a + b;
        }
        // M�todo sobrecarregado para somar tr�s inteiros
        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }
        // M�todo sobrecarregado para somar dois n�meros de ponto flutuante
        public double Somar(double a, double b)
        {
            return a + b;
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