using appSimulado.Controller;
using appSimulado.Model;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ControllerProfessor controller = new ControllerProfessor();
            Professor prof = controller.Login(txtEmail.Text,txtSenha.Text.Trim());
            if (prof == null )
            {
                MessageBox.Show("Este usuário não existe no nosso Banco de dados ou senha e email estão incorretos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmPrincipal principal = new FrmPrincipal(prof.id);
                principal.Show();
                this.Hide();
            }
        }

        private void btnNovoProf_Click(object sender, EventArgs e)
        {
            FrmCadastroProf prof = new FrmCadastroProf();
            prof.Show();
        }
    }
}
