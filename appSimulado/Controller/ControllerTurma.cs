using appSimulado.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSimulado.Controller
{
    public class ControllerTurma
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\AppSimulado\\appSimulado\\appSimulado\\BDSistema.mdf;Integrated Security=True");

        public List<Turma> ListaTurmaProfessor(int id_Professor)
        {
            List<Turma> li = new List<Turma>();
            string sql = "SELECT * FROM Turma WHERE id_Professor = '"+id_Professor+"'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Turma turma = new Turma();
                turma.id = (int)dr["id"];
                turma.nomeTurma = dr["nomeTurma"].ToString();                
                li.Add(turma);
            }
            dr.Close();
            conn.Close();
            return li;
        }
        public void Inserir(string nomeTurma, int id_professor)
        {
            string sql = "INSERT INTO turma(nomeTurma,id_Professor) VALUES(@nomeTurma,@id_professor)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nomeTurma", SqlDbType.VarChar).Value = nomeTurma;
                cmd.Parameters.Add("@id_professor", SqlDbType.VarChar).Value = id_professor;                
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
        public void Excluir(int id)
        {
            string sql = "DELETE FROM turma WHERE id='" + id + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Editar(int id, string nomeTurma)
        {
            string sql = "UPDATE Turma SET nomeTurma=@nomeTurma WHERE id=@id";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nomeTurma", SqlDbType.VarChar).Value = nomeTurma;               

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public Turma Localizar(int id)
        {
            Turma turma = new Turma();
            string sql = "SELECT * FROM turma WHERE id='" + id + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                turma.id = (int)dr["id"];
                turma.nomeTurma = dr["nomeTurma"].ToString();                
            }
            dr.Close();
            conn.Close();
            return turma;
        }
    }
}
