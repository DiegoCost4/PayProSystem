using wfuai;

namespace PayProSystem
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesquisarFunc pesq = new frmPesquisarFunc();
            pesq.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCadastroFunc cadastroFunc = new frmCadastroFunc();
            cadastroFunc.FormClosed += (s, args) =>
            {
                this.Show(); // Exibe o formulário atual novamente
                this.TopMost = true; // Define o formulário atual como TopMost
            };
            cadastroFunc.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmOpcaoCadastro cadastroOpt = new frmOpcaoCadastro();
            cadastroOpt.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUser cadastroUser = new frmCadastroUser();
            cadastroUser.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPesquisarFunc pesq = new frmPesquisarFunc();
            pesq.ShowDialog();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCargo frmcadCargo = new frmCadastroCargo();
            frmcadCargo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHoletire frmHolerite = new frmHoletire();
            frmHolerite.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAjustarSalario frm = new frmAjustarSalario();
            frm.ShowDialog();
        }

        private void ajusteSalarialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjustarSalario frm = new frmAjustarSalario();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGerenciarInfos frm = new frmGerenciarInfos();
            frm.ShowDialog();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarLicenca frm = new frmCadastrarLicenca();
            frm.ShowDialog();
        }

        private void holeriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoletire frm = new frmHoletire();
            frm.ShowDialog();
        }

        private void gerenciarInformaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHoletire frm = new frmHoletire();
            frm.ShowDialog();
        }

        private void gerenciarInformaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerenciarInfos frm = new frmGerenciarInfos();
            frm.ShowDialog();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPesquisarUsers frm = new frmPesquisarUsers();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmRelatoriosGerais frm = new frmRelatoriosGerais();
            frm.ShowDialog();
        }

        private void relatóriosGeraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatoriosGerais frm = new frmRelatoriosGerais();
            frm.ShowDialog();
        }
    }
}