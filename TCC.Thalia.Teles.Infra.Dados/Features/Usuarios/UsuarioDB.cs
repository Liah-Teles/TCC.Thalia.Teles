using System.Data;
using System.Data.SqlClient;
using TCC.Thalia.Teles.Dominio.Features.Usuarios;

namespace TCC.Thalia.Teles.Infra.Dados.Features.Usuarios
{
    public class UsuarioDB
    {
        private string _stringConexao;
        private string _tbName = "Usuarios";

        public UsuarioDB(string stringConexao)
        {
            _stringConexao = stringConexao;
        }

        public Usuario BuscaUsuarioPorLoginComSenha(string login, string senha)
        {
            var sqlQuery = $"select * from {_tbName} where login=@login and senha=@senha";

            var conexao = new SqlConnection(_stringConexao);
            
            var comandoSql = new SqlCommand(sqlQuery, conexao);
            comandoSql.Parameters.Add(new SqlParameter("@login", login));
            comandoSql.Parameters.Add(new SqlParameter("@senha", senha));

            comandoSql.Connection.Open();
            var dados = comandoSql.ExecuteReader();

            Usuario usuario = null;
            if (dados.Read())
            {
                usuario = new Usuario();
                usuario.Id = dados.GetInt32("Id");
                usuario.Login = dados.GetString("Login");
                usuario.Senha = dados.GetString("Senha");
            }

            return usuario;
        }

        public int Inserir(Usuario usuario)
        {
            var conexao = new SqlConnection(_stringConexao);
            var sqlQuery = $"insert into {_tbName} values(@login,@senha); SELECT SCOPE_IDENTITY()";
            
            var comandoSql = new SqlCommand(sqlQuery, conexao);
            comandoSql.Parameters.Add(new SqlParameter("@login", usuario.Login));
            comandoSql.Parameters.Add(new SqlParameter("@senha", usuario.Senha));
            
            comandoSql.Connection.Open();

            int id = Convert.ToInt32(comandoSql.ExecuteScalar());
            return id;
        }
    }
}