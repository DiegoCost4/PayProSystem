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
    public partial class frmCadastroLicenca : Form
    {
        private ApiLicenca _apiLicenca;
        public frmCadastroLicenca()
        {
            InitializeComponent();
            _apiLicenca = new ApiLicenca("http://localhost:8083/api");
        }
        private void LimparCampos()
        {
            tbCodigo.Text = string.Empty;
            tbTipo.Text = string.Empty;
            tbDescrição.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e) //btnCadastrar
        {
            LicencaModel novoLicenca = new LicencaModel
            {
                Id = tbUsuario.Text,
                Tipo = tbEmail.Text,
                Descricao = tbSenha.Text,


            };
            try
            {
                // Chame o método para cadastrar o novo Usuário
                await _apiUsers.CadastrarUsuarioAsync(novoUsuario);
                MessageBox.Show("Usuário cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar Usuário: {ex.Message}");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
