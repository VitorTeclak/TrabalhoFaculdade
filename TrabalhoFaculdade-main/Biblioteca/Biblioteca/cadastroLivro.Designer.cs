namespace Biblioteca
{
    partial class cadastroLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbData = new TextBox();
            txbAutor = new TextBox();
            txbGenero = new TextBox();
            txbTitulo = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 105);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 134);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Genero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 163);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 192);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 3;
            label4.Text = "Data de lançamento";
            // 
            // txbData
            // 
            txbData.Location = new Point(178, 184);
            txbData.Name = "txbData";
            txbData.Size = new Size(107, 23);
            txbData.TabIndex = 7;
            txbData.Text = "Ex: DD/MM/AAAA\r\n\r\n";
            // 
            // txbAutor
            // 
            txbAutor.Location = new Point(178, 155);
            txbAutor.Name = "txbAutor";
            txbAutor.Size = new Size(107, 23);
            txbAutor.TabIndex = 6;
            // 
            // txbGenero
            // 
            txbGenero.Location = new Point(178, 126);
            txbGenero.Name = "txbGenero";
            txbGenero.Size = new Size(107, 23);
            txbGenero.TabIndex = 5;
            // 
            // txbTitulo
            // 
            txbTitulo.Location = new Point(178, 97);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(107, 23);
            txbTitulo.TabIndex = 4;
            txbTitulo.TextChanged += txbTitulo_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(178, 229);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(107, 23);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(291, 229);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cadastroLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txbTitulo);
            Controls.Add(txbGenero);
            Controls.Add(txbAutor);
            Controls.Add(txbData);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "cadastroLivro";
            Text = "cadastroLivro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbData;
        private TextBox txbAutor;
        private TextBox txbGenero;
        private TextBox txbTitulo;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}