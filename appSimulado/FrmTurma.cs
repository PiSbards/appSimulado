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
    public partial class FrmTurma : Form
    {
        public FrmTurma(int id_professor)
        {
            InitializeComponent();
            lblIdProf.Text = id_professor.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ControllerTurma turma = new ControllerTurma();
            turma.Inserir(txtNome.Text, Convert.ToInt32(lblIdProf.Text));
            MessageBox.Show("Turma Cadastrada com sucesso!","CADASTRO",MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNome.Text = "";
        }
    }
}
