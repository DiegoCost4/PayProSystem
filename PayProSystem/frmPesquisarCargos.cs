using API;
using clmodel;
namespace wfuai
{
    public partial class frmPesquisarCargos : Form
    {
        private readonly ApiCargos apiCargo;
        public CargosModel _cargos;
        public frmPesquisarCargos()
        {
            InitializeComponent();
            apiCargo = new ApiCargos("http://localhost:8083/api");
            _cargos = new CargosModel();
        }

        private async void frmPesquisarCargos_Load(object sender, EventArgs e)
        {
            try
            {
                // Chame o método para obter os cargos da API
                List<CargosModel> cargo = await apiCargo.ObterCargosAsync();

                // Associe a lista de funcionários ao DataGridView

                dataGridView1.DataSource = cargo;

                if (dataGridView1 != null && dataGridView1.Columns != null)
                {
                    dataGridView1.AutoGenerateColumns = false;

                    dataGridView1.Columns["Id"].Visible = true;
                    dataGridView1.Columns["Cargo"].Visible = true;

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
                if (dataGridView1.CurrentRow != null)
                {
                    Int32 i = dataGridView1.CurrentRow.Index;
                    _cargos.Id = Int32.Parse(dataGridView1[0, i].Value.ToString());
                    _cargos.Cargo = dataGridView1[1, i].Value.ToString();
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

        private void button1_Click(object sender, EventArgs e)
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
