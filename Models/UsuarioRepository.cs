using System;
using MySqlConnector;
using System.Collections.Generic;

namespace espacomusical.Models
{

    public class UsuarioRepository
    {
        // ter as credenciais do meu banco de dados.
        private const string DadosConexao = "DataBase=Espaco_Musical;Data Source=localhost;User=root";

        // operações de manipulação de tabela.
        // (CRUD). Inerir, Listar, Alterar e Excluir.
        public void TestarConexao()
        {

            //infomar a credencial de acesso.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            //abrir conexão.
            Conexao.Open();

            //imprimir uma mensagem de tudo funcionando.
            Console.WriteLine("Banco de dados funcionando!");

            //fechar conexão.
            Conexao.Close();
        }

        public Usuario ValidarLogin(Usuario user){

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para buscar por Login e Senha.  
            string QuerySql = "select * FROM Usuario WHERE Login=@Login and Senha=@Senha";

            //preparar um comando, passando: sql + conexão com o bd.  
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);


            //tratamento devido ao sql injection.

            Comando.Parameters.AddWithValue("@Login",user.Login);
            Comando.Parameters.AddWithValue("@Senha",user.Senha);

            // executo no bd , que retorna  um unico  usuraio quando encontrado.
            MySqlDataReader Reader = Comando.ExecuteReader();

            //  iremos inicializar  o obj UsuarioEncontrado como null
            // pq caso o objeto Reader não encontrar registros o objeto retornará null. Caso encontre retorna o conjunto de dados.
            
            Usuario UsuarioEncontrado = null;

            // aqui esta a validação do obj Reader.
            if (Reader.Read()) {


            //se entrar aqui significa  que encontrou o usuario e senha informados.
                UsuarioEncontrado = new Usuario();
                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    UsuarioEncontrado.Login = Reader.GetString("Login");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");

                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }

            // fechar a conexão.
            Conexao.Close();

            // retornar o usuario encontrado.
            return UsuarioEncontrado;
        }
        public Usuario BuscarPorId(int Id)
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para buscar.(select)  
            string QuerySql = "select * FROM Usuario WHERE Id=@Id";

            //preparar um comando, passando: sql + conexão com o bd.  
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);


            //tratamento devido ao sql injection.
            Comando.Parameters.AddWithValue("@Id", Id);

            // executo no bd , que retorna  um unico  usuraio quando encontrado.
            MySqlDataReader Reader = Comando.ExecuteReader();


            Usuario UsuarioEncontrado = new Usuario();

            if (Reader.Read())
            {
                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    UsuarioEncontrado.Login = Reader.GetString("Login");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");

                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }

            // fechar a conexão.
            Conexao.Close();

            // retornar o usuario encontrado.
            return UsuarioEncontrado;

        }
        public List<Usuario> Listar()
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para inserir.(insert)  
            string QuerySql = "select * FROM Usuario";

            //preparar um comando, passando: sql + conexão com o bd.  
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            // executo no bd , que retorna  um unico  usuraio quando encontrado.
            MySqlDataReader Reader = Comando.ExecuteReader();

            // simplesmente criando a lista de usuarios.
            List<Usuario> Lista = new List<Usuario>();

            // percorre todos os registros retornados no banco de dados(obj Reader).
            while (Reader.Read())
            {

                Usuario userEncontrado = new Usuario();

                userEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    userEncontrado.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    userEncontrado.Senha = Reader.GetString("Senha");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    userEncontrado.Login = Reader.GetString("Login");

                userEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");

                //add a lista de usuarios.
                Lista.Add(userEncontrado);
            }

            // fechar a conexão.
            Conexao.Close(); 

            // retornamos a lista com todos os registros armazenados no banco de dados.

            return Lista;
        }
        public void Inserir(Usuario user)
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para inserir.(insert)  
            string QuerySql = "insert into Usuario (Nome,Login,Senha,DataNascimento) values (@Nome, @Login, @Senha, @DataNascimento)";

            //preparar um comando, passando: sql + conexão com o bd.   
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            //tratamento devido ao sql injection.
            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);

            //exeutar o comando no bd.
            Comando.ExecuteNonQuery();

            // fechar a conexão.
            Conexao.Close();
        }
        public void Alterar(Usuario user)
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para alterar.(update)  
            string QuerySql = "update Usuario set Nome=@Nome, Login=@Login, Senha=@Senha, DataNascimento=@DataNascimento WHERE Id=@Id";

            //preparar um comando, passando: sql + conexão com o bd.
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            //tratamento devido ao sql injection.
            Comando.Parameters.AddWithValue("@Id", user.Id);
            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);

            //exeutar o comando no bd.
            Comando.ExecuteNonQuery();

            // fechar a conexão.
            Conexao.Close();
        }
        public void Excluir(Usuario user)
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para excluir.(delete)  
            string QuerySql = "delete from Usuario WHERE Id=@Id";

            //preparar um comando, passando: sql + conexão com o bd.
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            //tratamento devido ao sql injection.
            Comando.Parameters.AddWithValue("@Id", user.Id);

            //exeutar o comando no bd.
            Comando.ExecuteNonQuery();

            // fechar a conexão.
            Conexao.Close();
        }

    }


}