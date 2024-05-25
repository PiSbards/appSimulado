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
    public partial class FrmAtividade : Form
    {
        public FrmAtividade(int id_turma, int id_professor)
        {
            InitializeComponent();
            lblIdProf.Text = id_professor.ToString();
            lblIdTurma.Text = id_turma.ToString();
            
        }

        private void FrmAtividade_Load(object sender, EventArgs e)
        {
            ControllerAtividade atv = new ControllerAtividade();
            List<Atividade> li = atv.ListaAtividadeTurma(Convert.ToInt32(lblIdTurma.Text));
            dgvAtividade.DataSource = li;
            ControllerProfessor controller = new ControllerProfessor();
            Professor prof = controller.Localizar(Convert.ToInt32(lblIdProf.Text));
            lblNomeProfessor.Text = $"Prof. {prof.nome}";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ControllerAtividade atv = new ControllerAtividade();
            var result = MessageBox.Show("Deseja realmente excluir esta turma", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                atv.Excluir(Convert.ToInt32(lblAtvId.Text));
                MessageBox.Show("Turma excluída com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Atividade> li = atv.ListaAtividadeTurma(Convert.ToInt32(lblIdTurma.Text));
                dgvAtividade.DataSource = li;
            }
            else
            {
                return;
            }
        }

        private void dgvAtividade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAtividade.Rows[e.RowIndex];
                this.dgvAtividade.Rows[e.RowIndex].Selected = true;
                lblAtvNome.Text = row.Cells[1].Value.ToString();
                lblAtvId.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
