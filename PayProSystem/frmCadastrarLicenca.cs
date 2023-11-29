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
    public partial class frmCadastrarLicenca : Form
    {
        private ApiLicenca _apiLicenca;
        public frmCadastrarLicenca()
        {
            InitializeComponent();
            _apiLicenca = new ApiLicenca("http://localhost:8083/api");
        }
        private void LimparCampos()
        {
            tbCodigo.Text = string.Empty;
            tbTipo.Text = string.Empty;
            tbDescricao.Text = string.Empty;

        }


        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar uma nova Licença com os dados do formulário
                LicencaModel novaLicenca = new LicencaModel
                {
                    Tipo = tbTipo.Text,
                    Descricao = tbDescricao.Text,
                };

                // Chame o método para cadastrar a nova Licença
                await _apiLicenca.CadastrarLicencaAsync(novaLicenca);

                MessageBox.Show("Licença cadastrada com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar Licença: {ex.Message}");
            }

        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Verifica se o ID do funcionário está preenchido
            if (string.IsNullOrWhiteSpace(tbCodigo.Text))
            {
                MessageBox.Show("Selecione uma Licença para atualizar.");
                return;
            }

            // Cria um novo objeto FuncionarioModel com os dados atualizados
            LicencaModel licencaAtualizada = new LicencaModel
            {
                Id = Convert.ToInt32(tbCodigo.Text),
                Tipo = tbTipo.Text,
                Descricao = tbDescricao.Text
               
            };
            try
            {
                // Chama o método para atualizar o funcionário
                await _apiLicenca.AtualizarLicencaAsync(licencaAtualizada);
                MessageBox.Show("Licença atualizada com sucesso!");

                // Limpa os campos após a atualização
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar Licença: {ex.Message}");
            }

        }

        private async void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifique se há um ID de usuário válido
                if (!int.TryParse(tbCodigo.Text, out int idDoUsuario))
                {
                    MessageBox.Show("Por favor, insira um valor válido para o ID do usuário.");
                    return;
                }

                // Verifique se há um ID de licença válido
                if (!int.TryParse(tbCodigo.Text, out int idLicenca))
                {
                    MessageBox.Show("Por favor, insira um valor válido para o ID da licença.");
                    return;
                }

                // Chame o método para excluir a Licença
                await _apiLicenca.ExcluirLicencaAsync(idLicenca);

                MessageBox.Show("Licença removida com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover Licença: {ex.Message}");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarLicenca frm = new frmPesquisarLicenca();
            frm.ShowDialog();

            if (frm._licenca.Id > 0)
            {
                tbCodigo.Text = frm._licenca.Id.ToString();
                tbTipo.Text = frm._licenca.Tipo.ToString();
                tbDescricao.Text = frm._licenca.Descricao.ToString();

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
