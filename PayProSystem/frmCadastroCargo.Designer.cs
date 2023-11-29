namespace wfuai
{
    partial class frmCadastroCargo
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
            label1 = new Label();
            txtCodigo = new TextBox();
            txtCargo = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 28);
            panel1.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 56);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 45;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.ScrollBar;
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(45, 79);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(73, 27);
            txtCodigo.TabIndex = 46;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(45, 146);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(425, 27);
            txtCargo.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 123);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 47;
            label2.Text = "Cargo";
            // 
            // button1
            // 
            button1.Location = new Point(45, 206);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 49;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(145, 206);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 50;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(245, 206);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 51;
            button3.Text = "Remover";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(345, 206);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 52;
            button4.Text = "Pesquisar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(513, 206);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 53;
            button5.Text = "Voltar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // frmCadastroCargo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 256);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCargo);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmCadastroCargo";
            Text = "frmCadastroCargo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtCargo;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}