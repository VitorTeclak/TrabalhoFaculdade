namespace Biblioteca
{
    partial class cadastroCliente
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
            Button btnCancelar;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbNome = new TextBox();
            txbEmail = new TextBox();
            txbIdade = new TextBox();
            txbSobrenome = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 71);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 100);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Sobrenome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 129);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 158);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(181, 63);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(114, 23);
            txbNome.TabIndex = 4;
            txbNome.TextChanged += txbNome_TextChanged;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(181, 150);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(114, 23);
            txbEmail.TabIndex = 5;
            // 
            // txbIdade
            // 
            txbIdade.Location = new Point(181, 121);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(114, 23);
            txbIdade.TabIndex = 6;
            // 
            // txbSobrenome
            // 
            txbSobrenome.Location = new Point(181, 92);
            txbSobrenome.Name = "txbSobrenome";
            txbSobrenome.Size = new Size(114, 23);
            txbSobrenome.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(181, 195);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(262, 195);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 404);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txbSobrenome);
            Controls.Add(txbIdade);
            Controls.Add(txbEmail);
            Controls.Add(txbNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "cadastroCliente";
            Text = "cadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbNome;
        private TextBox txbEmail;
        private TextBox txbIdade;
        private TextBox txbSobrenome;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}