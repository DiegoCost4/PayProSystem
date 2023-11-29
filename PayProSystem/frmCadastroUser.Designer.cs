namespace wfuai
{
    partial class frmCadastroUser
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
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbSenha = new TextBox();
            tbUsuario = new TextBox();
            tbCodigo = new TextBox();
            button5 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label7 = new Label();
            tbEmail = new TextBox();
            cbTipo = new ComboBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(476, 218);
            button3.Name = "button3";
            button3.Size = new Size(82, 29);
            button3.TabIndex = 41;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(378, 218);
            button4.Name = "button4";
            button4.Size = new Size(82, 29);
            button4.TabIndex = 40;
            button4.Text = "Remover";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(279, 218);
            button2.Name = "button2";
            button2.Size = new Size(82, 29);
            button2.TabIndex = 39;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(181, 218);
            button1.Name = "button1";
            button1.Size = new Size(82, 29);
            button1.TabIndex = 38;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(516, 67);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 31;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(192, 67);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 30;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 67);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 29;
            label1.Text = "Código";
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(516, 87);
            tbSenha.Name = "tbSenha";
            tbSenha.Size = new Size(191, 27);
            tbSenha.TabIndex = 24;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(192, 87);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(298, 27);
            tbUsuario.TabIndex = 23;
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = SystemColors.ScrollBar;
            tbCodigo.Enabled = false;
            tbCodigo.Location = new Point(81, 87);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(77, 27);
            tbCodigo.TabIndex = 22;
            // 
            // button5
            // 
            button5.Location = new Point(701, 262);
            button5.Name = "button5";
            button5.Size = new Size(82, 29);
            button5.TabIndex = 42;
            button5.Text = "Voltar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 28);
            panel1.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(81, 122);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 32;
            label4.Text = "E-mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(516, 121);
            label7.Name = "label7";
            label7.Size = new Size(106, 17);
            label7.TabIndex = 36;
            label7.Text = "Tipo de Usuário";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(81, 142);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(409, 27);
            tbEmail.TabIndex = 25;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(516, 141);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(127, 28);
            cbTipo.TabIndex = 35;
            // 
            // frmCadastroUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 303);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(cbTipo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbEmail);
            Controls.Add(tbSenha);
            Controls.Add(tbUsuario);
            Controls.Add(tbCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroUser";
            Text = "PayPro - Cadastro de Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbSenha;
        private TextBox tbUsuario;
        private TextBox tbCodigo;
        private Button button5;
        private Panel panel1;
        private Label label4;
        private Label label7;
        private TextBox tbEmail;
        private ComboBox cbTipo;
    }
}