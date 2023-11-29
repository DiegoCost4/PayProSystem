namespace wfuai
{
    partial class frmHoletire
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
            btnPesquisar = new Button();
            label1 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            btnConsultar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 28);
            panel1.TabIndex = 45;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(495, 109);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 46;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 53);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 47;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.ScrollBar;
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(42, 76);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(64, 27);
            txtCodigo.TabIndex = 48;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(148, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(441, 27);
            txtNome.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 53);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 49;
            label2.Text = "Nome ";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(368, 109);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(121, 29);
            btnConsultar.TabIndex = 51;
            btnConsultar.Text = "Gerar Holerite";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(547, 224);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 52;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmHoletire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 265);
            Controls.Add(button1);
            Controls.Add(btnConsultar);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(btnPesquisar);
            Controls.Add(panel1);
            Name = "frmHoletire";
            Text = "PayPro - Consultar Holerite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnPesquisar;
        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private Label label2;
        private Button btnConsultar;
        private Button button1;
    }
}