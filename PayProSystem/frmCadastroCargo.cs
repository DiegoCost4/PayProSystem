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
    public partial class frmCadastroCargo : Form
    {
        private CargosModel _cargo;
        private ApiCargos _apiCargo;
        public frmCadastroCargo()
        {
            InitializeComponent();
            _apiCargo = new ApiCargos("http://localhost:8083/api");
        }
        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtCargo.Text = string.Empty;

        }

        private async void button1_Click(object sender, EventArgs e) //btnCadastrar
        {

            // Criar um novo CargosModel com os dados do formulário
            CargosModel novoCargo = new CargosModel
            {
                Cargo = txtCargo.Text,
            };

            try
            {
                // Chame o método para cadastrar o novo funcionário
                await _apiCargo.CadastrarCargoAsync(novoCargo);
                MessageBox.Show("Cargo cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar Cargo: {ex.Message}");
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // Verifica se o ID do funcionário está preenchido
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um Cargo para atualizar.");
                return;
            }

            // Cria um novo objeto FuncionarioModel com os dados atualizados
            CargosModel cargoAtualizado = new CargosModel
            {
                Id = Convert.ToInt32(txtCodigo.Text),
                Cargo = txtCargo.Text
            };
            try
            {
                // Chama o método para atualizar o funcionário
                await _apiCargo.AtualizarCargoAsync(cargoAtualizado);
                MessageBox.Show("Cargo atualizado com sucesso!");

                // Limpa os campos após a atualização
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar Cargo: {ex.Message}");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            // Verifica se o ID do funcionário está preenchido
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um Cargo para remover.");
                return;
            }

            // Obtém o ID do funcionário a ser removido
            int idCargo = Convert.ToInt32(txtCodigo.Text);

            try
            {
                // Chama o método para remover o funcionário
                await _apiCargo.ExcluirCargoAsync(idCargo);
                MessageBox.Show("Cargo removido com sucesso!");

                // Limpa os campos após a remoção
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover Cargo: {ex.Message}");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmPesquisarCargos frmPesqCargo = new frmPesquisarCargos();
            frmPesqCargo.ShowDialog();

            if (frmPesqCargo._cargos.Id > 0)
            {
                txtCodigo.Text = frmPesqCargo._cargos.Id.ToString();
                txtCargo.Text = frmPesqCargo._cargos.Cargo.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


