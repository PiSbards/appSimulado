using appSimulado.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSimulado.Controller
{
    public class ControllerAtividade
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\AppSimulado\\appSimulado\\appSimulado\\BDSistema.mdf;Integrated Security=True");

        public List<Atividade> ListaAtividadeTurma(int id_turma)
        {
            List<Atividade> li = new List<Atividade>();
            string sql = "SELECT * FROM atividade WHERE id_turma = '" + id_turma + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Atividade atv = new Atividade();
                atv.id = (int)dr["id"];
                atv.nomeAtividade = dr["nomeAtividade"].ToString();
                li.Add(atv);
            }
            dr.Close();
            conn.Close();
            return li;
        }
        public void Inserir(string nomeAtividade, int id_Turma)
        {
            string sql = "INSERT INTO atividade(nomeAtividade,id_turma) VALUES(@nomeAtividade,@id_turma)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nomeAtividade", SqlDbType.VarChar).Value = nomeAtividade;
                cmd.Parameters.Add("@id_turma", SqlDbType.VarChar).Value = id_Turma;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
        public void Excluir(int id)
        {
            string sql = "DELETE FROM atividade WHERE id='" + id + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Editar(int id, string nomeTurma)
        {
            string sql = "UPDATE Atividade SET nomeAtividade=@nomeAtividade WHERE id=@id";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nomeAtividade", SqlDbType.VarChar).Value = nomeTurma;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public Atividade Localizar(int id)
        {
            Atividade atv = new Atividade();
            string sql = "SELECT * FROM atividade WHERE id='" + id + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                atv.id = (int)dr["id"];
                atv.nomeAtividade = dr["nomeAtividade"].ToString();
            }
            dr.Close();
            conn.Close();
            return atv;
        }
    }
}
