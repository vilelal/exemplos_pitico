namespace exemplo_orientacaoEncap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância da classe Cliente e preenche 
            // as propriedades com as informações do formulário
            string fnome = textBox1.Text;
            int fidade = Convert.ToInt32(textBox2.Text);
            string femail = textBox3.Text;
            Cliente cliente = new Cliente(fnome, fidade, femail);
            // Cria uma nova instância do formulário 2 e passa a 
            // instância da classe Cliente como um argumento
            Form2 form2 = new Form2(cliente);
            form2.Show();
        }
    }
}
