using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Biblioteca
{
    public partial class cadastroCliente : Form
    {
        public Cliente ClienteReturn { get; set; }
        public cadastroCliente(Cliente cliente)
        {
            InitializeComponent();
            txbNome.Text = cliente.nome;
            txbSobrenome.Text = cliente.sobrenome;
            txbIdade.Text = cliente.idade.ToString();
            txbEmail.Text = cliente.email;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.nome = txbNome.Text;
            cliente.sobrenome = txbSobrenome.Text;
            cliente.idade = Convert.ToInt32(txbIdade.Text);
            cliente.email = txbEmail.Text;

            if (string.IsNullOrWhiteSpace(txbNome.Text) ||
                string.IsNullOrWhiteSpace(txbSobrenome.Text) ||
                string.IsNullOrWhiteSpace(txbEmail.Text) ||
                string.IsNullOrWhiteSpace(txbIdade.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idade;
            if (!int.TryParse(txbIdade.Text, out idade))
            {
                MessageBox.Show("Por favor, insira uma idade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            this.ClienteReturn = cliente;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
