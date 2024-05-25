using appSimulado.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSimulado
{
    public partial class FrmCadastroProf : Form
    {
        public FrmCadastroProf()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ControllerProfessor controller = new ControllerProfessor();
            controller.Inserir(txtNome.Text,txtEmail.Text,txtSenha.Text.Trim());
            MessageBox.Show("Professor cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
        }
    }
}
