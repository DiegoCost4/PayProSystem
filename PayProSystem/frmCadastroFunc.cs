using API;
using clmodel;
using PayProSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfuai
{
    public partial class frmCadastroFunc : Form
    {
        private FuncionarioModel _funcionario;
        private ApiClient _apiClient;
        private ApiCargos _apiCargos;

        public frmCadastroFunc()
        {
            InitializeComponent();
            _apiClient = new ApiClient("http://localhost:8083/api");
            _apiCargos = new ApiCargos("http://localhost:8083/api");

            CarregarCargosAsync();
        }
        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtAdress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cbxOffice.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtObservation.Text = string.Empty;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public frmCadastroFunc(FuncionarioModel funcionario) : this()
        {
            _funcionario = funcionario;
            //PreencherCampos(); // Método para preencher os campos com base no FuncionarioModel
        }

        private void button3_Click(object sender, EventArgs e) //btnPesquisar
        {
            // Abre o formulário de pesquisa
            frmPesquisarFunc pesq = new frmPesquisarFunc();
            pesq.ShowDialog();

            if (pesq._funcionario.Id > 0)
            {
                txtCodigo.Text = pesq._funcionario.Id.ToString();
                txtNome.Text = pesq._funcionario.Name.ToString();
                txtCpf.Text = pesq._funcionario.Cpf.ToString();
                txtAdress.Text = pesq._funcionario.Adress.ToString();
                txtPhone.Text = pesq._funcionario.Phone.ToString();
                cbxOffice.Text = pesq._funcionario.Office.ToString();
                txtSalary.Text = pesq._funcionario.Salary.ToString();
                txtObservation.Text = pesq._funcionario.Observation.ToString();
            }

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }

        private async void button1_Click(object sender, EventArgs e) //btnCadastrar
        {
            // Criar um novo FuncionarioModel com os dados do formulário
            FuncionarioModel novoFuncionario = new FuncionarioModel
            {
                Name = txtNome.Text,
                Cpf = Convert.ToDecimal(txtCpf.Text),
                Adress = txtAdress.Text,
                Phone = txtPhone.Text,
                Office = cbxOffice.Text,
                Salary = float.Parse(txtSalary.Text),
                Observation = txtObservation.Text
            };

            try
            {
                // Chame o método para cadastrar o novo funcionário
                await _apiClient.CadastrarFuncionarioAsync(novoFuncionario);
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar funcionário: {ex.Message}");
            }
        }

        private async void button2_Click(object sender, EventArgs e) //btnAtualizar
        {
            // Verifica se o ID do funcionário está preenchido
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um funcionário para atualizar.");
                return;
            }

            // Cria um novo objeto FuncionarioModel com os dados atualizados
            FuncionarioModel funcionarioAtualizado = new FuncionarioModel
            {
                Id = Convert.ToInt32(txtCodigo.Text),
                Name = txtNome.Text,
                Cpf = Convert.ToDecimal(txtCpf.Text),
                Adress = txtAdress.Text,
                Phone = txtPhone.Text,
                Office = cbxOffice.Text,
                Salary = float.Parse(txtSalary.Text),
                Observation = txtObservation.Text
            };

            try
            {
                // Chama o método para atualizar o funcionário
                await _apiClient.AtualizarFuncionarioAsync(funcionarioAtualizado);
                MessageBox.Show("Funcionário atualizado com sucesso!");

                // Limpa os campos após a atualização
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar funcionário: {ex.Message}");
            }

        }

        private async void button4_Click(object sender, EventArgs e) //btnRemover
        {
            // Verifica se o ID do funcionário está preenchido
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um funcionário para remover.");
                return;
            }

            // Obtém o ID do funcionário a ser removido
            int idFuncionario = Convert.ToInt32(txtCodigo.Text);

            try
            {
                // Chama o método para remover o funcionário
                await _apiClient.ExcluirFuncionarioAsync(idFuncionario);
                MessageBox.Show("Funcionário removido com sucesso!");

                // Limpa os campos após a remoção
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover funcionário: {ex.Message}");
            }

        }
        private async void CarregarCargosAsync()
        {
            try
            {
                // Obtenha a lista de cargos da API
                List<CargosModel> cargos = await _apiCargos.ObterCargosAsync();

                // Atribua a lista de cargos ao DataSource do ComboBox
                cbxOffice.DataSource = cargos;

                // Defina qual propriedade da classe CargoModel será exibida no ComboBox
                cbxOffice.DisplayMember = "Cargo"; // Substitua "Nome" pelo nome da propriedade que contém o nome do cargo

                // Defina qual propriedade da classe CargoModel será usada como valor no ComboBox
               /* cbxOffice.ValueMember = "Id"; */// Substitua "Id" pelo nome da propriedade que contém o ID do cargo
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os cargos: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CarregarCargosAsync();
        }
    }
}

