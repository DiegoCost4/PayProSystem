using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API;
using clmodel;
using OfficeOpenXml;

namespace wfuai
{
    public partial class frmRelatoriosGerais : Form
    {
        
        private ApiClient _apiClient;
        public frmRelatoriosGerais()
        {
            InitializeComponent();
            _apiClient = new ApiClient("http://localhost:8083/api");
        }
        private async Task<List<FuncionarioModel>> ObterFuncionarios()
        {
            try
            {
                List<FuncionarioModel> funcionarios = await _apiClient.ObterFuncionariosAsync();
                return funcionarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter funcionários: {ex.Message}");
                return new List<FuncionarioModel>(); // ou null, dependendo do que você prefere fazer em caso de erro
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            // Obtenha dados dos funcionários da API
            List<FuncionarioModel> funcionarios = await ObterFuncionarios();

            if (funcionarios.Any())
            {
                // Obtenha o diretório da área de trabalho
                string diretorioAreaTrabalho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Nome do arquivo de relatório
                string nomeArquivo = Path.Combine(diretorioAreaTrabalho, "RelatorioFuncionarios.txt");

                // Crie um StreamWriter para escrever no arquivo
                using (StreamWriter sw = new StreamWriter(nomeArquivo))
                {
                    // Escreva cabeçalhos
                    sw.WriteLine("Nome\tSalário");

                    // Escreva os dados dos funcionários
                    foreach (var funcionario in funcionarios)
                    {
                        sw.WriteLine($"{funcionario.Name}\t{funcionario.SalarioTotal}");
                    }

                    // Calcule e escreva a soma dos salários
                    double somaSalarios = funcionarios.Sum(f => f.SalarioTotal);
                    sw.WriteLine($"\nTotal\t{somaSalarios:C}");
                }

                MessageBox.Show($"Relatório gerado com sucesso! Confira o arquivo: {nomeArquivo}");
            }
            else
            {
                MessageBox.Show("Não foi possível obter dados dos funcionários para gerar o relatório.");
            }

        }
    }
}
