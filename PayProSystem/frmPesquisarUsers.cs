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
    public partial class frmPesquisarUsers : Form
    {
        private readonly ApiUsers apiUser;
        public UsuarioModel _usuario;
        public frmPesquisarUsers()
        {
            InitializeComponent();
            apiUser = new ApiUsers("http://localhost:8083/api");
            _usuario = new UsuarioModel();
        }

        private async void frmPesquisarUsers_Load(object sender, EventArgs e)
        {
            try
            {
                // Chame o método para obter funcionários da API
                List<UsuarioModel> usuarios = await apiUser.ObterUsuariosAsync();

                // Associe a lista de funcionários ao DataGridView

                dataGridView1.DataSource = usuarios;

                if (dataGridView1 != null && dataGridView1.Columns != null)
                {
                    dataGridView1.AutoGenerateColumns = false;

                    dataGridView1.Columns["Id"].Visible = true;
                    dataGridView1.Columns["User"].Visible = true;
                    dataGridView1.Columns["Password"].Visible = true;
                    dataGridView1.Columns["Email"].Visible = true;
                    dataGridView1.Columns["UserType"].Visible = true;

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
                    _usuario.Id = Int32.Parse(dataGridView1[0, i].Value.ToString());
                    _usuario.User = dataGridView1[1, i].Value.ToString(); //erro
                    _usuario.Password = dataGridView1[2, i].Value.ToString();
                    _usuario.Email = dataGridView1[3, i].Value.ToString();
                    
                    _usuario.UserType = dataGridView1[4, i].Value.ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
