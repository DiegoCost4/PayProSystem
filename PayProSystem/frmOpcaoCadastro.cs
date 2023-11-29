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
    public partial class frmOpcaoCadastro : Form
    {
        public frmOpcaoCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroFunc frm = new frmCadastroFunc();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastroUser frm = new frmCadastroUser();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadastroCargo frm = new frmCadastroCargo();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
