namespace wfuai
{
    partial class frmCadastroLicenca
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
            panel1 = new Panel();
            btnVoltar = new Button();
            btnPesquisar = new Button();
            btnRemover = new Button();
            btnAtualizar = new Button();
            btnCadastrar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 28);
            panel1.TabIndex = 59;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(382, 295);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(82, 29);
            btnVoltar.TabIndex = 58;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(359, 234);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(82, 29);
            btnPesquisar.TabIndex = 57;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(261, 234);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(82, 29);
            btnRemover.TabIndex = 56;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(162, 234);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(82, 29);
            btnAtualizar.TabIndex = 55;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(64, 234);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(82, 29);
            btnCadastrar.TabIndex = 54;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 60;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 61;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(95, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 62;
            // 
            // frmCadastroLicenca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 365);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(btnVoltar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnRemover);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastrar);
            Name = "frmCadastroLicenca";
            Text = "PayPro - Cadastrar Licença";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnVoltar;
        private Button btnPesquisar;
        private Button btnRemover;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private Label label7;
        private ComboBox cbTipo;
        private Label label4;
        private TextBox tbEmail;
        private TextBox tbSenha;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}