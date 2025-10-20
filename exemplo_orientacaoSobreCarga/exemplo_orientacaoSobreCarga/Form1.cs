namespace exemplo_orientacaoSobreCarga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Instanciando um objeto da classe Calculadora
            Calculadora calculadora = new Calculadora();
            // Usando os métodos sobrecarregados
            int soma1 = calculadora.Somar(10, 20);
            int soma2 = calculadora.Somar(10, 20, 30);
            double soma3 = calculadora.Somar(10.5, 20.5);
            // Exibindo os resultados
            MessageBox.Show($"Soma de 10 e 20: {soma1}");
            MessageBox.Show($"Soma de 10, 20 e 30: {soma2}");
            MessageBox.Show($"Soma de 10.5 e 20.5: {soma3}");   
        }
    }
}
