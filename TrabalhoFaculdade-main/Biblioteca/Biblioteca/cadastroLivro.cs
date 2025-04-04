using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class cadastroLivro : Form
    {
        public Livro LivroReturn { get; set; }
        public cadastroLivro(Livro livro)
        {
            InitializeComponent();
            txbTitulo.Text = livro.titulo;
            txbGenero.Text = livro.genero;
            txbAutor.Text = livro.autor;
            txbData.Text = livro.data;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();

            livro.titulo = txbTitulo.Text;
            livro.genero = txbGenero.Text;
            livro.autor = txbAutor.Text;
            livro.data = txbData.Text;

            if (string.IsNullOrWhiteSpace(txbTitulo.Text) ||
                string.IsNullOrWhiteSpace(txbGenero.Text) ||
                string.IsNullOrWhiteSpace(txbAutor.Text) ||
                string.IsNullOrWhiteSpace(txbData.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.LivroReturn = livro;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txbTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
