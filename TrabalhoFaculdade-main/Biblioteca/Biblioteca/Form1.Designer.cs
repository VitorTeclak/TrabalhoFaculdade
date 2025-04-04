namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCasdastrarLivro = new Button();
            btnCasdastrarCliente = new Button();
            btnEditarDados = new Button();
            dvListaLivro = new DataGridView();
            dvListaCliente = new DataGridView();
            btnExluirDados = new Button();
            btnConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dvListaLivro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvListaCliente).BeginInit();
            SuspendLayout();
            // 
            // btnCasdastrarLivro
            // 
            btnCasdastrarLivro.Location = new Point(106, 88);
            btnCasdastrarLivro.Name = "btnCasdastrarLivro";
            btnCasdastrarLivro.Size = new Size(108, 23);
            btnCasdastrarLivro.TabIndex = 0;
            btnCasdastrarLivro.Text = "Cadastrar Livro";
            btnCasdastrarLivro.UseVisualStyleBackColor = true;
            btnCasdastrarLivro.Click += btnCasdastrarLivro_Click;
            // 
            // btnCasdastrarCliente
            // 
            btnCasdastrarCliente.Location = new Point(220, 88);
            btnCasdastrarCliente.Name = "btnCasdastrarCliente";
            btnCasdastrarCliente.Size = new Size(108, 23);
            btnCasdastrarCliente.TabIndex = 2;
            btnCasdastrarCliente.Text = "Cadastrar Cliente";
            btnCasdastrarCliente.UseVisualStyleBackColor = true;
            btnCasdastrarCliente.Click += btnCasdastrarCliente_Click;
            // 
            // btnEditarDados
            // 
            btnEditarDados.Location = new Point(334, 88);
            btnEditarDados.Name = "btnEditarDados";
            btnEditarDados.Size = new Size(108, 23);
            btnEditarDados.TabIndex = 4;
            btnEditarDados.Text = "Editar Dados";
            btnEditarDados.UseVisualStyleBackColor = true;
            btnEditarDados.Click += btnEditarDados_Click;
            // 
            // dvListaLivro
            // 
            dvListaLivro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvListaLivro.Location = new Point(12, 127);
            dvListaLivro.Name = "dvListaLivro";
            dvListaLivro.Size = new Size(372, 220);
            dvListaLivro.TabIndex = 5;
            dvListaLivro.CellContentClick += dvListaLivro_CellContentClick;
            // 
            // dvListaCliente
            // 
            dvListaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvListaCliente.Location = new Point(390, 127);
            dvListaCliente.Name = "dvListaCliente";
            dvListaCliente.Size = new Size(398, 220);
            dvListaCliente.TabIndex = 6;
            dvListaCliente.CellContentClick += dvListaCliente_CellContentClick;
            // 
            // btnExluirDados
            // 
            btnExluirDados.Location = new Point(448, 88);
            btnExluirDados.Name = "btnExluirDados";
            btnExluirDados.Size = new Size(75, 23);
            btnExluirDados.TabIndex = 7;
            btnExluirDados.Text = "Excluir";
            btnExluirDados.UseVisualStyleBackColor = true;
            btnExluirDados.Click += btnExluirDados_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(529, 88);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(109, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar Dados";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultar);
            Controls.Add(btnExluirDados);
            Controls.Add(dvListaCliente);
            Controls.Add(dvListaLivro);
            Controls.Add(btnEditarDados);
            Controls.Add(btnCasdastrarCliente);
            Controls.Add(btnCasdastrarLivro);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvListaLivro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvListaCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCasdastrarLivro;
        private Button btnCasdastrarCliente;
        private Button btnEditarDados;
        private DataGridView dvListaLivro;
        private DataGridView dvListaCliente;
        private Button btnExluirDados;
        private Button btnConsultar;
    }
}
