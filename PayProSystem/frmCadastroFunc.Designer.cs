namespace wfuai
{
    partial class frmCadastroFunc
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
            components = new System.ComponentModel.Container();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtAdress = new TextBox();
            txtCpf = new TextBox();
            txtObservation = new TextBox();
            txtSalary = new TextBox();
            txtPhone = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbxOffice = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            contextMenuStrip2 = new ContextMenuStrip(components);
            button5 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.ScrollBar;
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(79, 78);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(77, 27);
            txtCodigo.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(190, 78);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(298, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += textBox2_TextChanged;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(79, 133);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(409, 27);
            txtAdress.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(514, 78);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(191, 27);
            txtCpf.TabIndex = 2;
            // 
            // txtObservation
            // 
            txtObservation.Location = new Point(353, 185);
            txtObservation.Multiline = true;
            txtObservation.Name = "txtObservation";
            txtObservation.Size = new Size(352, 86);
            txtObservation.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(233, 185);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(105, 27);
            txtSalary.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(514, 133);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(191, 27);
            txtPhone.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(79, 58);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 9;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(190, 58);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 10;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(514, 58);
            label3.Name = "label3";
            label3.Size = new Size(31, 17);
            label3.TabIndex = 11;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(79, 113);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 12;
            label4.Text = "Endereço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(514, 113);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 13;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(236, 165);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 14;
            label6.Text = "Salário";
            // 
            // cbxOffice
            // 
            cbxOffice.FormattingEnabled = true;
            cbxOffice.Location = new Point(79, 185);
            cbxOffice.Name = "cbxOffice";
            cbxOffice.Size = new Size(127, 28);
            cbxOffice.TabIndex = 15;
            cbxOffice.SelectedIndexChanged += cbxOffice_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(79, 165);
            label7.Name = "label7";
            label7.Size = new Size(44, 17);
            label7.TabIndex = 16;
            label7.Text = "Cargo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(353, 165);
            label8.Name = "label8";
            label8.Size = new Size(80, 17);
            label8.TabIndex = 17;
            label8.Text = "Observação";
            // 
            // button1
            // 
            button1.Location = new Point(179, 293);
            button1.Name = "button1";
            button1.Size = new Size(82, 29);
            button1.TabIndex = 18;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(277, 293);
            button2.Name = "button2";
            button2.Size = new Size(82, 29);
            button2.TabIndex = 19;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(474, 293);
            button3.Name = "button3";
            button3.Size = new Size(82, 29);
            button3.TabIndex = 21;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(376, 293);
            button4.Name = "button4";
            button4.Size = new Size(82, 29);
            button4.TabIndex = 20;
            button4.Text = "Remover";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // button5
            // 
            button5.Location = new Point(701, 351);
            button5.Name = "button5";
            button5.Size = new Size(82, 29);
            button5.TabIndex = 23;
            button5.Text = "Voltar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 28);
            panel1.TabIndex = 24;
            // 
            // frmCadastroFunc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 392);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cbxOffice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtObservation);
            Controls.Add(txtSalary);
            Controls.Add(txtPhone);
            Controls.Add(txtAdress);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroFunc";
            Text = "PayPro - Cadastro de Fucionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtAdress;
        private TextBox txtCpf;
        private TextBox txtObservation;
        private TextBox txtSalary;
        private TextBox txtPhone;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbxOffice;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ContextMenuStrip contextMenuStrip2;
        private Button button5;
        private Panel panel1;
    }
}