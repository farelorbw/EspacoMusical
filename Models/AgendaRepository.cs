using System;
using MySqlConnector;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;



namespace espacomusical.Models
{

    public class AgendaRepository
    {
        // ter as credenciais do meu banco de dados.
        private const string DadosConexao = "DataBase=espaco_musical;Data Source=localhost;User=root";

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

        public Agenda BuscarPorIdAgenda(int Id)
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para inserir.(insert)  
            string QuerySql = "select * FROM Agenda WHERE Id=@Id";

            //preparar um comando, passando: sql + conexão com o bd.  
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);


            //tratamento devido ao sql injection.
            Comando.Parameters.AddWithValue("@Id", Id);

            // executo no bd , que retorna  um unico  usuario quando encontrado.
            MySqlDataReader Reader = Comando.ExecuteReader();


            Agenda AgendaEncontrados = new Agenda();

            if (Reader.Read())
            {

                AgendaEncontrados.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    AgendaEncontrados.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Telefone")))
                    AgendaEncontrados.Telefone = Reader.GetInt32("Telefone");

                AgendaEncontrados.Data = Reader.GetDateTime("Data");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Instrumento")))
                    AgendaEncontrados.Instrumento = Reader.GetString("Instrumento");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Necessidade")))
                    AgendaEncontrados.Necessidade = Reader.GetString("Necessidade");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Usuario")))
                    AgendaEncontrados.Usuario = Reader.GetInt32("Usuario");



            }

            // fechar a conexão.
            Conexao.Close();

            // retornar o usuario encontrado.
            return AgendaEncontrados;

        }
        public List<Agenda> ListarAgenda()
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para inserir.(insert)  
            string QuerySql = "select * FROM Agenda";

            //preparar um comando, passando: sql + conexão com o bd.  
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            // executo no bd , que retorna  um unico  usuraio quando encontrado.
            MySqlDataReader Reader = Comando.ExecuteReader();

            // simplesmente criando a lista de usuarios.
            List<Agenda> Lista = new List<Agenda>();

            // percorre todos os registros retornados no banco de dados(obj Reader).
            while (Reader.Read())
            {

                Agenda AgEncontrado = new Agenda();

                AgEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    AgEncontrado.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Telefone")))
                AgEncontrado.Telefone = Reader.GetInt32("Telefone");

                AgEncontrado.Data = Reader.GetDateTime("Data");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Instrumento")))
                    AgEncontrado.Instrumento = Reader.GetString("Instrumento");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Necessidade")))
                    AgEncontrado.Necessidade = Reader.GetString("Necessidade");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Usuario")))
                    AgEncontrado.Usuario = Reader.GetInt32("Usuario");


                //add a lista de usuarios.
                Lista.Add(AgEncontrado);
            }

            // fechar a conexão.
            Conexao.Close();

            // retornamos a lista com todos os registros armazenados no banco de dados.

            return Lista;
        }
        public void InserirAgenda(Agenda Ag)  /////////////////////////////////////
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para inserir.(insert)  
            string QuerySql = "insert into Agenda (Nome,Telefone,Data,Instrumento,Necessidade,Usuario) values (@Nome, @Telefone, @Data, @Instrumento, @Necessidade, @Usuario)";

            //preparar um comando, passando: sql + conexão com o bd.   
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            //tratamento devido ao sql injection.
            Comando.Parameters.AddWithValue("@Nome", Ag.Nome);
            Comando.Parameters.AddWithValue("@Telefone", Ag.Telefone);
            Comando.Parameters.AddWithValue("@Data", Ag.Data);
            Comando.Parameters.AddWithValue("@Instrumento", Ag.Instrumento);
            Comando.Parameters.AddWithValue("@Necessidade", Ag.Necessidade);
            Comando.Parameters.AddWithValue("@Usuario", Ag.Usuario);
           
            




            //exeutar o comando no bd.
            Comando.ExecuteNonQuery();

            // fechar a conexão.
            Conexao.Close();
        }
        public void AlterarAgenda(Agenda Ag) //////////////////////////////////////////////
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para alterar.(update)  
            string QuerySql = "update Agenda set Nome=@Nome, Telefone=@Telefone, Data=@Data, Instrumento=@Instrumento, Necessidade=@Necessidade, Usuario=@Usuario WHERE Usuario=@Usuario";

            //preparar um comando, passando: sql + conexão com o bd.
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            //tratamento devido ao sql injection.
            Comando.Parameters.AddWithValue("@Nome", Ag.Nome);
            Comando.Parameters.AddWithValue("@Telefone", Ag.Telefone);
            Comando.Parameters.AddWithValue("@Data", Ag.Data);
            Comando.Parameters.AddWithValue("@Instrumento", Ag.Instrumento);
            Comando.Parameters.AddWithValue("@Necessidade", Ag.Necessidade);
            Comando.Parameters.AddWithValue("@Usuario", Ag.Usuario);


            //exeutar o comando no bd.
            Comando.ExecuteNonQuery();

            // fechar a conexão.
            Conexao.Close();
        }
        public void ExcluirAgenda(Agenda Ag)
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para excluir.(delete)  

            string QuerySql = "delete from Agenda WHERE Id=@Id";


            //preparar um comando, passando: sql + conexão com o bd.
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            //tratamento devido ao sql injection.
            Comando.Parameters.AddWithValue("@Id", Ag.Id);

            //exeutar o comando no bd.
            Comando.ExecuteNonQuery();

            // fechar a conexão.
            Conexao.Close();
        }

    }


}