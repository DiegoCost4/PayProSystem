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
    public partial class frmPesquisarLicenca : Form
    {
        private readonly ApiLicenca _apiLicenca;
        public LicencaModel _licenca;
        public frmPesquisarLicenca()
        {
            InitializeComponent();
            _apiLicenca = new ApiLicenca("http://localhost:8083/api");
            _licenca = new LicencaModel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void frmPesquisarLicenca_Load(object sender, EventArgs e)
        {

            try
            {
                // Chame o método para obter os cargos da API
                List<LicencaModel> licenca = await _apiLicenca.ObterLicencasAsync();

                // Associe a lista de funcionários ao DataGridView

                dataGridView1.DataSource = licenca;

                if (dataGridView1 != null && dataGridView1.Columns != null)
                {
                    dataGridView1.AutoGenerateColumns = false;

                    dataGridView1.Columns["Id"].Visible = true;
                    dataGridView1.Columns["Tipo"].Visible = true;
                    dataGridView1.Columns["Descricao"].Visible = true;

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
                    _licenca.Id = Int32.Parse(dataGridView1[0, i].Value.ToString());
                    _licenca.Tipo = dataGridView1[1, i].Value.ToString();
                    _licenca.Descricao = dataGridView1[2, i].Value.ToString();
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
    }
}
