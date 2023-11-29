using API;
using clmodel;
//using DinkToPdf;
//using DinkToPdf.Contracts;
//using Orientation = DinkToPdf.Orientation;

namespace wfuai
{
    public partial class frmHoletire : Form
    {
        private FuncionarioModel _funcionario;
        private ApiClient _apiClient;
        // private IConverter _pdfConverter;

        public frmHoletire()
        {
            InitializeComponent();
            _apiClient = new ApiClient("http://localhost:8083/api");
            //string caminhoDllWkhtmltox = @"C:\Program Files\wkhtmltopdf\bin\wkhtmltox.dll";
            // _pdfConverter = new SynchronizedConverter(new PdfTools());

        }
        private int ObterIdDoFuncionario()
        {
            if (int.TryParse(txtCodigo.Text, out int idFuncionario))
            {
                return idFuncionario;
            }
            else
            {
                // Se não for possível converter o texto para um número inteiro, retorne um valor indicativo de erro (por exemplo, -1).
                return -1;
            }
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            int idFuncionario = ObterIdDoFuncionario();

            if (idFuncionario > 0)
            {
                try
                {
                    FuncionarioModel funcionario = await _apiClient.ObterPorIdAsync(idFuncionario);

                    if (funcionario != null)
                    {
                        HoleriteModel holerite = await _apiClient.ObterHoleriteAsync(idFuncionario);

                        if (holerite != null)
                        {
                            GerarTxt(funcionario);
                        }
                        else
                        {
                            MessageBox.Show("Holerite não encontrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar a API: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário válido.");
            }

        }
        private void GerarTxt(FuncionarioModel funcionario)
        {
            try
            {
                string conteudoTxt = CriarConteudoTxt(funcionario);

                // Caminho do arquivo TXT no desktop do usuário
                string caminhoTxt = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{funcionario.Name} Holerite.txt");

                // Escreve o conteúdo no arquivo TXT
                File.WriteAllText(caminhoTxt, conteudoTxt);

                MessageBox.Show($"Arquivo TXT gerado com sucesso em {caminhoTxt}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar o arquivo TXT: {ex.Message}");
            }
        }

        private string CriarConteudoTxt(FuncionarioModel funcionario)
        {
            // Aqui você deve construir o conteúdo TXT do seu holerite
            // Adaptando para um formato de texto simples

            return $@"
                EMPRESA XYZ LTDA
                Rua da Empresa, 123 - Cidade/Estado - CEP: 12345-678
                Telefone: (12) 3456-7890 | Email: contato@empresa.com
                Funcionario: {funcionario.Name} | Cargo: {funcionario.Office}                

                HOLERITE - MÊS DE NOVEMBRO DE 2023
                   
                Salario Bruto: R${funcionario.Salary}
                Imposto de Renda: R${funcionario.ImpostoRenda}
                INSS: R${funcionario.Inss}
                Horas Extras Trabalhadas: R${funcionario.HorasExtrasTrabalhadas}

                Salário Total: R${funcionario.SalarioTotal}

                ";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Abre o formulário de pesquisa
            frmPesquisarFunc pesq = new frmPesquisarFunc();
            pesq.ShowDialog();

            if (pesq._funcionario.Id > 0)
            {
                // Atualiza os campos do formulário com os dados do funcionário
                txtCodigo.Text = pesq._funcionario.Id.ToString();
                txtNome.Text = pesq._funcionario.Name.ToString();

                // Atualiza o campo _funcionario
                _funcionario = pesq._funcionario;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


