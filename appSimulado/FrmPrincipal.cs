using appSimulado.Controller;
using appSimulado.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace appSimulado
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(int id)
        {
            InitializeComponent();
            lblIdProf.Text = id.ToString();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ControllerProfessor controller = new ControllerProfessor();
            Professor prof = controller.Localizar(Convert.ToInt32(lblIdProf.Text));
            lblNomeProfessor.Text = $"Prof. {prof.nome}";
            ControllerTurma controllerTurma = new ControllerTurma();
            List<Turma> li = controllerTurma.ListaTurmaProfessor(Convert.ToInt32(lblIdProf.Text));
            dgvTurma.DataSource = li;
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            FrmTurma turma = new FrmTurma(Convert.ToInt32(lblIdProf.Text));
            turma.Show();
        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTurma.Rows[e.RowIndex];
                this.dgvTurma.Rows[e.RowIndex].Selected = true;
                lblTurma.Text = row.Cells[1].Value.ToString();
                lblTurmaID.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnAtividade_Click(object sender, EventArgs e)
        {
            if (lblTurmaID.Text == "" && lblTurma.Text == "")
            {
                MessageBox.Show("Por favor selecione uma classe, quando selecionada, as informações da Turma serão apresentadas acima dos botões", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmAtividade atv = new FrmAtividade(Convert.ToInt32(lblTurmaID.Text), Convert.ToInt32(lblIdProf.Text));
                atv.Show();
            }            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ControllerTurma turma = new ControllerTurma();
            var result = MessageBox.Show("Deseja realmente excluir esta turma","ATENÇÃO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ControllerAtividade atv =new ControllerAtividade();
                int quantidade = atv.ListaAtividadeTurma(Convert.ToInt32(lblTurmaID.Text)).Count();
                if (quantidade != 0)
                {
                    MessageBox.Show("Impossível excluir turma que possua atividades cadastradas", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    turma.Excluir(Convert.ToInt32(lblTurmaID.Text));
                    MessageBox.Show("Turma excluída com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    List<Turma> li = turma.ListaTurmaProfessor(Convert.ToInt32(lblIdProf.Text));
                    dgvTurma.DataSource = li;
                }                
            }
            else
            {
                return;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ControllerTurma controllerTurma = new ControllerTurma();
            List<Turma> li = controllerTurma.ListaTurmaProfessor(Convert.ToInt32(lblIdProf.Text));
            dgvTurma.DataSource = li;
        }
    }
}
