namespace Exemplo_orientacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma nova inst�ncia da classe Cliente
            // e preenche as propriedades com as informa��es
            // do formul�rio
            Cliente cliente = new Cliente();
            cliente.Nome = textBox1.Text;
            cliente.Telefone = textBox2.Text;
            cliente.Email = textBox3.Text;
            // Cria uma nova inst�ncia do formul�rio 2
            // e passa a inst�ncia da classe Cliente
            // como um argumento
            Form2 form2 = new Form2(cliente);
            form2.Show();
        }
    }
}
