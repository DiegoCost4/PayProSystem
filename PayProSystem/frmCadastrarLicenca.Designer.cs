namespace wfuai
{
    partial class frmCadastrarLicenca
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
            tbCodigo = new TextBox();
            tbTipo = new TextBox();
            label2 = new Label();
            tbDescricao = new TextBox();
            label3 = new Label();
            btnCadastrar = new Button();
            btnAtualizar = new Button();
            btnRemover = new Button();
            btnVoltar = new Button();
            btnPesquisar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 37);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = SystemColors.ScrollBar;
            tbCodigo.Enabled = false;
            tbCodigo.Location = new Point(61, 57);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(70, 27);
            tbCodigo.TabIndex = 1;
            // 
            // tbTipo
            // 
            tbTipo.Location = new Point(150, 57);
            tbTipo.Name = "tbTipo";
            tbTipo.Size = new Size(275, 27);
            tbTipo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 37);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipo";
            // 
            // tbDescricao
            // 
            tbDescricao.Location = new Point(61, 119);
            tbDescricao.Multiline = true;
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(364, 82);
            tbDescricao.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 99);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "Descrição";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(48, 221);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(148, 221);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(94, 29);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(248, 221);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(94, 29);
            btnRemover.TabIndex = 8;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(404, 299);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 29);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(348, 221);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // frmCadastrarLicenca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 340);
            Controls.Add(btnVoltar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnRemover);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastrar);
            Controls.Add(tbDescricao);
            Controls.Add(label3);
            Controls.Add(tbTipo);
            Controls.Add(label2);
            Controls.Add(tbCodigo);
            Controls.Add(label1);
            Name = "frmCadastrarLicenca";
            Text = "frmCadastrarLicenca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCodigo;
        private TextBox tbTipo;
        private Label label2;
        private TextBox tbDescricao;
        private Label label3;
        private Button btnCadastrar;
        private Button btnAtualizar;
        private Button btnRemover;
        private Button btnVoltar;
        private Button btnPesquisar;
    }
}