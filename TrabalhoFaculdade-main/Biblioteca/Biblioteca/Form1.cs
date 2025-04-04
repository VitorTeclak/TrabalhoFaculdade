using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dvListaCliente.DataSource = listaCliente;
            dvListaLivro.DataSource = listaLivro; 
        }

        List<Cliente> listaCliente = new List<Cliente>();
        List<Livro> listaLivro = new List<Livro>();

        private void btnCasdastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente varCliente = new Cliente();
            cadastroCliente f = new cadastroCliente(varCliente);
            f.ShowDialog();
            listaCliente.Add(f.ClienteReturn);
            dvListaCliente.DataSource = listaCliente.ToList();
        }

        private void btnCasdastrarLivro_Click(object sender, EventArgs e)
        {
            Livro varLivro = new Livro();
            cadastroLivro h = new cadastroLivro(varLivro);
            h.ShowDialog();
            listaLivro.Add(h.LivroReturn);
            dvListaLivro.DataSource = listaLivro.ToList();
        }

        private void dvListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dvListaLivro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEditarDados_Click(object sender, EventArgs e)
        {
            if (dvListaCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvListaCliente.SelectedRows[0];
                Cliente varCliente = listaCliente[row.Index];
                cadastroCliente f = new cadastroCliente(varCliente);
                f.ShowDialog();
                listaCliente[row.Index] = f.ClienteReturn;
                dvListaCliente.DataSource = listaCliente;
            }
            else if (dvListaLivro.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvListaLivro.SelectedRows[0];
                Livro varLivro = listaLivro[row.Index];
                cadastroLivro f = new cadastroLivro(varLivro);
                f.ShowDialog();
                listaLivro[row.Index] = f.LivroReturn;
                dvListaLivro.DataSource = listaLivro;
            }
        }

        private void btnExluirDados_Click(object sender, EventArgs e)
        {
            if (dvListaCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvListaCliente.SelectedRows[0];
                listaCliente.RemoveAt(row.Index);
                dvListaCliente.DataSource = listaCliente.ToList();
            }
            else if (dvListaLivro.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvListaLivro.SelectedRows[0];
                listaLivro.RemoveAt(row.Index);
                dvListaLivro.DataSource = listaLivro.ToList();
            }
        }

        
        private int ContarTotal(DataGridView dgv)
        {
            return dgv.Rows.Count - 0; 
        }
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int quantidadeLivros = ContarTotal(dvListaLivro);
            int quantidadeCliente = ContarTotal(dvListaCliente);
            MessageBox.Show($"Quantidade de livros: {quantidadeLivros}\nQuantidade de clientes: {quantidadeCliente}");
        }
    }
}
