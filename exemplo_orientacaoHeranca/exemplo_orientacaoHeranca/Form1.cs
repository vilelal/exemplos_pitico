using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace exemplo_orientacaoHeranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma nova inst�ncia da classe Cliente e preenche as propriedades com as informa��es do formul�rio
            Cliente cliente = new Cliente();
            cliente.Nome = textBox1.Text;
            cliente.Sobrenome = textBox2.Text;
            cliente.Idade = Convert.ToInt32(textBox3.Text);
            // cliente.Endereco = textBox4.Text;
            cliente.Email = textBox5.Text;
            // Cria uma nova inst�ncia do formul�rio 2 e passa a inst�ncia da classe Cliente como um argumento
            Form2 form2 = new Form2(cliente);
            form2.Show();
        }
    }
}
