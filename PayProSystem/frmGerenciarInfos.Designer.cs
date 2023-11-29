namespace wfuai
{
    partial class frmGerenciarInfos
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
            cbTipoLicenca = new ComboBox();
            label3 = new Label();
            dtInicio = new DateTimePicker();
            dtFinal = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            btnConfirmar = new Button();
            btnPesquisar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 54);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = SystemColors.ScrollBar;
            tbCodigo.Enabled = false;
            tbCodigo.Location = new Point(50, 75);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(51, 27);
            tbCodigo.TabIndex = 2;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.ScrollBar;
            tbName.Enabled = false;
            tbName.Location = new Point(125, 75);
            tbName.Name = "tbName";
            tbName.Size = new Size(331, 27);
            tbName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 54);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 3;
            label2.Text = "Nome do Funcionario";
            // 
            // cbTipoLicenca
            // 
            cbTipoLicenca.FormattingEnabled = true;
            cbTipoLicenca.Location = new Point(477, 74);
            cbTipoLicenca.Name = "cbTipoLicenca";
            cbTipoLicenca.Size = new Size(151, 28);
            cbTipoLicenca.TabIndex = 5;
            cbTipoLicenca.SelectedIndexChanged += cbTipoLicenca_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 54);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 6;
            label3.Text = "Tipo de Licença";
            // 
            // dtInicio
            // 
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(47, 149);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(133, 27);
            dtInicio.TabIndex = 7;
            // 
            // dtFinal
            // 
            dtFinal.Format = DateTimePickerFormat.Short;
            dtFinal.Location = new Point(212, 149);
            dtFinal.Name = "dtFinal";
            dtFinal.Size = new Size(122, 27);
            dtFinal.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 126);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 9;
            label4.Text = "Data de Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 126);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 10;
            label5.Text = "Data Final";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(50, 217);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(168, 217);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 12;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(556, 244);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 29);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmGerenciarInfos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 303);
            Controls.Add(btnVoltar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnConfirmar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtFinal);
            Controls.Add(dtInicio);
            Controls.Add(label3);
            Controls.Add(cbTipoLicenca);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(tbCodigo);
            Controls.Add(label1);
            Name = "frmGerenciarInfos";
            Text = "PayPro - Gerenciar Informações";
            Load += frmGerenciarInfos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox tbCodigo;
        private TextBox tbName;
        private Label label2;
        private ComboBox cbTipoLicenca;
        private Label label3;
        private DateTimePicker dtInicio;
        private DateTimePicker dtFinal;
        private Label label4;
        private Label label5;
        private Button btnConfirmar;
        private Button btnPesquisar;
        private Button btnVoltar;
    }
}