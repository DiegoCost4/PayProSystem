namespace wfuai
{
    partial class frmPesquisarFunc
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
            dataGridViewPesquisarFuncionario = new DataGridView();
            panel1 = new Panel();
            btnSelecionar = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisarFuncionario).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPesquisarFuncionario
            // 
            dataGridViewPesquisarFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisarFuncionario.Location = new Point(12, 44);
            dataGridViewPesquisarFuncionario.Name = "dataGridViewPesquisarFuncionario";
            dataGridViewPesquisarFuncionario.RowHeadersWidth = 51;
            dataGridViewPesquisarFuncionario.RowTemplate.Height = 29;
            dataGridViewPesquisarFuncionario.Size = new Size(776, 329);
            dataGridViewPesquisarFuncionario.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 28);
            panel1.TabIndex = 25;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(601, 405);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(88, 33);
            btnSelecionar.TabIndex = 26;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(704, 405);
            button2.Name = "button2";
            button2.Size = new Size(84, 33);
            button2.TabIndex = 27;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmPesquisarFunc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnSelecionar);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPesquisarFuncionario);
            Name = "frmPesquisarFunc";
            Text = "frmPesquisarFunc";
            Load += frmPesquisarFunc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisarFuncionario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPesquisarFuncionario;
        private Panel panel1;
        private Button btnSelecionar;
        private Button button2;
    }
}