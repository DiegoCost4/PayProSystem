using API;
using clmodel;
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
    public partial class frmGerenciarInfos : Form
    {
        private ApiLicenca _apiLicenca;
        private ApiClient _apiClient;
        public frmGerenciarInfos()
        {
            InitializeComponent();
            _apiLicenca = new ApiLicenca("http://localhost:8083/api");
            _apiClient = new ApiClient("http://localhost:8083/api");

            cbTipoLicenca.Text = string.Empty;
            CarregarLicencaAsync();
        }
        private void LimparCampos()
        {
            tbCodigo.Text = string.Empty;
            tbName.Text = string.Empty;
            cbTipoLicenca.Text = string.Empty;
            dtInicio.Text = string.Empty;
            dtInicio.Text = string.Empty;

        }

        private void frmGerenciarInfos_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFunc frm = new frmPesquisarFunc();
            frm.ShowDialog();

            if (frm._funcionario.Id > 0)
            {
                tbCodigo.Text = frm._funcionario.Id.ToString();
                tbName.Text = frm._funcionario.Name.ToString();
            }
        }
        private async void CarregarLicencaAsync()
        {
            try
            {
                // Obtenha a lista de cargos da API
                List<LicencaModel> licenca = await _apiLicenca.ObterLicencasAsync();

                // Atribua a lista de cargos ao DataSource do ComboBox
                cbTipoLicenca.DataSource = licenca;

                // Defina qual propriedade da classe CargoModel será exibida no ComboBox
                cbTipoLicenca.DisplayMember = "Tipo"; // Substitua "Nome" pelo nome da propriedade que contém o nome do cargo

                // Defina qual propriedade da classe CargoModel será usada como valor no ComboBox
                /* cbxOffice.ValueMember = "Id"; */// Substitua "Id" pelo nome da propriedade que contém o ID do cargo
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os cargos: {ex.Message}");
            }
        }

        private void cbTipoLicenca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbCodigo.Text, out int codigo))
            {
                try
                {
                    // Obtenha as informações atuais do funcionário
                    FuncionarioModel funcionario = await _apiClient.ObterPorIdAsync(codigo);

                    if (funcionario != null)
                    {
                        // Atribua as datas de início e fim da licença
                        funcionario.DtInicio = dtInicio.Value;
                        funcionario.DtFinal = dtFinal.Value;

                        // Atribua o tipo de licença escolhido
                        funcionario.Tipo = cbTipoLicenca.SelectedItem.ToString();

                        // Chame o método para atualizar o funcionário na API
                        await _apiClient.AtualizarFuncionarioAsync(funcionario);
                        MessageBox.Show("Licença incluída com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao associar Licença: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Insira um código válido.");
            }
        }
    }
}
