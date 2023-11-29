namespace wfuai
{
    partial class frmOpcaoCadastro
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
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(253, 65);
            label1.Name = "label1";
            label1.Size = new Size(264, 31);
            label1.TabIndex = 0;
            label1.Text = "O que deseja cadastrar?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(112, 274);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 9;
            label2.Text = "Funcionário";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.add_user_8862448;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(100, 164);
            button1.Name = "button1";
            button1.Size = new Size(110, 107);
            button1.TabIndex = 8;
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(364, 270);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 11;
            label3.Text = "Usuário";
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.add_user_8862448;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(345, 160);
            button2.Name = "button2";
            button2.Size = new Size(110, 107);
            button2.TabIndex = 10;
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(600, 270);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 13;
            label4.Text = "Cargo";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.add_user_8862448;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(569, 160);
            button3.Name = "button3";
            button3.Size = new Size(110, 107);
            button3.TabIndex = 12;
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(677, 398);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "Voltar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // frmOpcaoCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "frmOpcaoCadastro";
            Text = "PayPro - Opções de Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label4;
        private Button button3;
        private Button button4;
    }
}