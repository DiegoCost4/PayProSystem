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

    public partial class frmCadastroUser : Form
    {
        private UsuarioModel _usuarios;
        private ApiUsers _apiUsers;
        public frmCadastroUser()
        {
            InitializeComponent();
            _apiUsers = new ApiUsers("http://localhost:8083/api");
        }
        private void LimparCampos()
        {
            tbCodigo.Text = string.Empty;
            tbUsuario.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbSenha.Text = string.Empty;
            cbTipo.Text = string.Empty;

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            ShowDialog(frmPrincipal);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPesquisarUsers frmPesq = new frmPesquisarUsers();
            frmPesq.ShowDialog();

            if (frmPesq._usuario.Id > 0)
            {
                tbCodigo.Text = frmPesq._usuario.Id.ToString();
                tbUsuario.Text = frmPesq._usuario.User.ToString();
                tbSenha.Text = frmPesq._usuario.Password.ToString();
                tbEmail.Text = frmPesq._usuario.Email.ToString();
                cbTipo.Text = frmPesq._usuario.UserType.ToString();

            }


        }

        private async void button1_Click(object sender, EventArgs e) //btnCadastrar
        {
            // Criar um novo Usuario com os dados do formulário
            UsuarioModel novoUsuario = new UsuarioModel
            {
                User = tbUsuario.Text,
                Email = tbEmail.Text,
                Password = tbSenha.Text,
                UserType = cbTipo.Text

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

        private async void button2_Click(object sender, EventArgs e) //btnAtualizar
        {
            // Verifica se o ID do funcionário está preenchido
            if (string.IsNullOrWhiteSpace(tbCodigo.Text))
            {
                MessageBox.Show("Selecione um usuário para atualizar.");
                return;
            }

            // Cria um novo objeto UsuarioModel com os dados atualizados
            UsuarioModel usuarioAtualizado = new UsuarioModel
            {
                Id = Convert.ToInt32(tbCodigo.Text),
                User = tbUsuario.Text,
                Password = tbSenha.Text,
                Email = tbEmail.Text,
                UserType = cbTipo.Text,
            };

            try
            {
                // Chama o método para atualizar o funcionário
                await _apiUsers.AtualizarUsuarioAsync(usuarioAtualizado);
                MessageBox.Show("Usuário atualizado com sucesso!");

                // Limpa os campos após a atualização
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar usuário: {ex.Message}");
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            // Verifica se o ID do usuário está preenchido
            if (string.IsNullOrWhiteSpace(tbCodigo.Text))
            {
                MessageBox.Show("Selecione um usuário para remover.");
                return;
            }

            // Obtém o ID do usuário a ser removido
            int idUsuario = Convert.ToInt32(tbCodigo.Text);

            try
            {
                // Chama o método para remover o usuário
                await _apiUsers.ExcluirUsuarioAsync(idUsuario);
                MessageBox.Show("Usuário removido com sucesso!");

                // Limpa os campos após a remoção
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover usuário: {ex.Message}");
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
