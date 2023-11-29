using API;
using clmodel;
using iText.StyledXmlParser.Jsoup.Nodes;
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

    public partial class frmAjustarSalario : Form
    {
        private ApiClient _apiClient;

        public frmAjustarSalario()
        {
            InitializeComponent();
            _apiClient = new ApiClient("http://localhost:8083/api");
        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbCodigo.Text, out int codigo) && float.TryParse(tbNovoSalario.Text, out float novoSalario))
            {
                try
                {
                    // Obtenha as informações atuais do funcionário
                    FuncionarioModel funcionario = await _apiClient.ObterPorIdAsync(codigo);

                    if (funcionario != null)
                    {
                        // Atualize o salário do funcionário
                        funcionario.Salary = novoSalario;

                        // Chame o método para atualizar o funcionário na API
                        await _apiClient.AtualizarFuncionarioAsync(funcionario);
                        MessageBox.Show("Salário ajustado com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o salário: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Insira um código e um novo salário válidos.");
            }

        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
           frmPesquisarFunc frm = new frmPesquisarFunc();
            frm.ShowDialog();

            if (frm._funcionario.Id > 0)
            {
                tbCodigo.Text = frm._funcionario.Id.ToString();
                tbName.Text = frm._funcionario.Name.ToString();
                tbSalario.Text = frm._funcionario.Salary.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
