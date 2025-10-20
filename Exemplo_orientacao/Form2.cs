     using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_orientacao
{
    public partial class Form2 : Form
    {
        public Form2(Cliente cliente)
        {
            InitializeComponent();
            label1.Text = cliente.Nome;
            label2.Text = cliente.Telefone;
            label3.Text = cliente.Email;
        }

       
    }
}
