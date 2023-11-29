using API;
using clmodel;

namespace wfuai
{
    public partial class frmPesquisarFunc : Form
    {
        private readonly ApiClient apiClient;
        public FuncionarioModel _funcionario;

        public frmPesquisarFunc()
        {
            InitializeComponent();
            apiClient = new ApiClient("http://localhost:8083/api");
            _funcionario = new FuncionarioModel();
        }

        private async void frmPesquisarFunc_Load(object sender, EventArgs e)
        {
            try
            {
                // Chame o método para obter funcionários da API
                List<FuncionarioModel> funcionarios = await apiClient.ObterFuncionariosAsync();

                // Associe a lista de funcionários ao DataGridView

                dataGridViewPesquisarFuncionario.DataSource = funcionarios;

                if (dataGridViewPesquisarFuncionario != null && dataGridViewPesquisarFuncionario.Columns != null)
                {
                    dataGridViewPesquisarFuncionario.AutoGenerateColumns = false;

                    dataGridViewPesquisarFuncionario.Columns["Id"].Visible = true;
                    dataGridViewPesquisarFuncionario.Columns["Name"].Visible = true;
                    dataGridViewPesquisarFuncionario.Columns["Cpf"].Visible = true;
                    dataGridViewPesquisarFuncionario.Columns["Adress"].Visible = true;
                    dataGridViewPesquisarFuncionario.Columns["Phone"].Visible = true;
                    dataGridViewPesquisarFuncionario.Columns["Office"].Visible = true;
                    dataGridViewPesquisarFuncionario.Columns["Salary"].Visible = true;
                    dataGridViewPesquisarFuncionario.Columns["Observation"].Visible = true;
                    dataGridViewPesquisarFuncionario.Columns["Tipo"].Visible = true;
                    dataGridViewPesquisarFuncionario.Columns["DtInicio"].Visible = true;
                    dataGridViewPesquisarFuncionario.Columns["DtFinal"].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter funcionários: {ex.Message}");
            }

        }
            private void SelecionarItem()
        {
            try
            {
                if (dataGridViewPesquisarFuncionario.CurrentRow != null)
                {
                    Int32 i = dataGridViewPesquisarFuncionario.CurrentRow.Index;
                    _funcionario.Id = Int32.Parse(dataGridViewPesquisarFuncionario[0, i].Value.ToString());
                    _funcionario.Name = dataGridViewPesquisarFuncionario[1, i].Value.ToString();

                    // Verifica se a célula não está vazia e não é null antes de tentar fazer o parse
                    if (!string.IsNullOrEmpty(dataGridViewPesquisarFuncionario[2, i].Value?.ToString()))
                    {
                        _funcionario.Cpf = decimal.Parse(dataGridViewPesquisarFuncionario[2, i].Value.ToString());
                    }

                    _funcionario.Adress = dataGridViewPesquisarFuncionario[3, i].Value.ToString();
                    _funcionario.Phone = dataGridViewPesquisarFuncionario[4, i].Value.ToString();
                    _funcionario.Office = dataGridViewPesquisarFuncionario[5, i].Value.ToString();

                    // Verifica se a célula não está vazia e não é null antes de tentar fazer o parse
                    if (!string.IsNullOrEmpty(dataGridViewPesquisarFuncionario[6, i].Value?.ToString()))
                    {
                        _funcionario.Salary = float.Parse(dataGridViewPesquisarFuncionario[6, i].Value.ToString());
                    }

                    _funcionario.Observation = dataGridViewPesquisarFuncionario[7, i].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Nenhuma linha selecionada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar funcionário: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e) //btnSelecionar
        {
            this.SelecionarItem();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
