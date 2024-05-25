using appSimulado.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace appSimulado.Controller
{
    public class ControllerProfessor
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\AppSimulado\\appSimulado\\appSimulado\\BDSistema.mdf;Integrated Security=True");
                
        public void Inserir(string nome, string email, string senha)
        {
            string sql = "INSERT INTO professor(nome,email,senha) VALUES(@nome,@email,@senha)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@senha",SqlDbType.VarChar).Value = senha;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
        public void Excluir(int id)
        {
            string sql = "DELETE FROM professor WHERE id='" + id + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Editar(int id, string nome, string email, string senha)
        {
            string sql = "UPDATE professor SET nome=@nome, email=@email, senha=@senha WHERE id=@id";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@email",SqlDbType.VarChar).Value=email;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public Professor Login(string email,string senha)
        {
            Professor prof = new Professor();
            string sql = "SELECT * FROM professor WHERE email='" + email + "' AND senha= '"+senha+"'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                prof.id = (int)dr["id"];
                prof.nome = dr["nome"].ToString();
                prof.email = dr["email"].ToString();
                prof.senha = dr["senha"].ToString();

            }
            dr.Close();
            conn.Close();
            return prof;
        }
        public Professor Localizar(int id)
        {
            Professor prof = new Professor();
            string sql = "SELECT * FROM professor WHERE email='" + id + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                prof.id = (int)dr["id"];
                prof.nome = dr["nome"].ToString();
                prof.email = dr["email"].ToString();
                prof.senha = dr["senha"].ToString();

            }
            dr.Close();
            conn.Close();
            return prof;
        }
    }
}
