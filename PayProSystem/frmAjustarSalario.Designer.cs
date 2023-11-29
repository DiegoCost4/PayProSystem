namespace wfuai
{
    partial class frmAjustarSalario
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
            tbName = new TextBox();
            label2 = new Label();
            tbSalario = new TextBox();
            label3 = new Label();
            tbNovoSalario = new TextBox();
            label4 = new Label();
            btnAtualizar = new Button();
            button2 = new Button();
            btnPesquisar = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 49);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = SystemColors.ScrollBar;
            tbCodigo.Enabled = false;
            tbCodigo.Location = new Point(34, 72);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(62, 27);
            tbCodigo.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.ScrollBar;
            tbName.Enabled = false;
            tbName.Location = new Point(122, 72);
            tbName.Name = "tbName";
            tbName.Size = new Size(334, 27);
            tbName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 49);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome do Funcionario";
            // 
            // tbSalario
            // 
            tbSalario.BackColor = SystemColors.ScrollBar;
            tbSalario.Enabled = false;
            tbSalario.Location = new Point(481, 72);
            tbSalario.Name = "tbSalario";
            tbSalario.Size = new Size(139, 27);
            tbSalario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(481, 49);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 4;
            label3.Text = "Salario atual";
            // 
            // tbNovoSalario
            // 
            tbNovoSalario.Location = new Point(33, 130);
            tbNovoSalario.Name = "tbNovoSalario";
            tbNovoSalario.Size = new Size(139, 27);
            tbNovoSalario.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 109);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 6;
            label4.Text = "Novo Salario";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(181, 129);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(94, 28);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(594, 185);
            button2.Name = "button2";
            button2.Size = new Size(94, 28);
            button2.TabIndex = 9;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(526, 129);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 28);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 28);
            panel1.TabIndex = 25;
            // 
            // frmAjustarSalario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 225);
            Controls.Add(panel1);
            Controls.Add(btnPesquisar);
            Controls.Add(button2);
            Controls.Add(btnAtualizar);
            Controls.Add(tbNovoSalario);
            Controls.Add(label4);
            Controls.Add(tbSalario);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(tbCodigo);
            Controls.Add(label1);
            Name = "frmAjustarSalario";
            Text = "PayPro - Ajuste Salarial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCodigo;
        private TextBox tbName;
        private Label label2;
        private TextBox tbSalario;
        private Label label3;
        private TextBox tbNovoSalario;
        private Label label4;
        private Button btnAtualizar;
        private Button button2;
        private Button btnPesquisar;
        private Panel panel1;
    }
}