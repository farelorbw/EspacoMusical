using System;
using MySqlConnector;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;



namespace espacomusical.Models
{

    public class FaleConoscoRepository
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

        public FaleConosco BuscarPorIdFaleConosco(int Id)
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para inserir.(insert)  
            string QuerySql = "select * FROM Faleconosco WHERE Id=@Id";

            //preparar um comando, passando: sql + conexão com o bd.  
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);


            //tratamento devido ao sql injection.
            Comando.Parameters.AddWithValue("@Id", Id);

            // executo no bd , que retorna  um unico  usuario quando encontrado.
            MySqlDataReader Reader = Comando.ExecuteReader();


            FaleConosco FaleConoscoEncontrados = new FaleConosco();

            if (Reader.Read())
            {

                FaleConoscoEncontrados.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    FaleConoscoEncontrados.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Telefone")))
                    FaleConoscoEncontrados.Telefone = Reader.GetInt32("Telefone");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                    FaleConoscoEncontrados.Email = Reader.GetString("Email");

                FaleConoscoEncontrados.Data = Reader.GetDateTime("Data");


                if (!Reader.IsDBNull(Reader.GetOrdinal("Necessidade")))
                    FaleConoscoEncontrados.Necessidade = Reader.GetString("Necessidade");


            }

            // fechar a conexão.
            Conexao.Close();

            // retornar o usuario encontrado.
            return FaleConoscoEncontrados;

        }
        public List<FaleConosco> ListarFaleConosco()
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para inserir.(insert)  
            string QuerySql = "select * FROM Faleconosco";

            //preparar um comando, passando: sql + conexão com o bd.  
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            // executo no bd , que retorna  um unico  usuraio quando encontrado.
            MySqlDataReader Reader = Comando.ExecuteReader();

            // simplesmente criando a lista de usuarios.
            List<FaleConosco> Lista = new List<FaleConosco>();

            // percorre todos os registros retornados no banco de dados(obj Reader).
            while (Reader.Read())
            {

                FaleConosco FcEncontrado = new FaleConosco();

                FcEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    FcEncontrado.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Telefone")))
                    FcEncontrado.Telefone = Reader.GetInt32("Telefone");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                    FcEncontrado.Email = Reader.GetString("Email");

                FcEncontrado.Data = Reader.GetDateTime("Data");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Necessidade")))
                    FcEncontrado.Necessidade = Reader.GetString("Necessidade");




                //add a lista de usuarios.
                Lista.Add(FcEncontrado);
            }

            // fechar a conexão.
            Conexao.Close();

            // retornamos a lista com todos os registros armazenados no banco de dados.

            return Lista;
        }
        public void InserirFaleConosco(FaleConosco Fc)  /////////////////////////////////////
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para inserir.(insert)  
            string QuerySql = "insert into Faleconosco (Nome,Telefone,Email,Data,Necessidade) values (@Nome, @Telefone, @Email, @Data, @Necessidade)";

            //preparar um comando, passando: sql + conexão com o bd.   
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            //tratamento devido ao sql injection.
            Comando.Parameters.AddWithValue("@Nome", Fc.Nome);
            Comando.Parameters.AddWithValue("@Telefone", Fc.Telefone);
            Comando.Parameters.AddWithValue("@Email", Fc.Email);
            Comando.Parameters.AddWithValue("@Data", Fc.Data);
            Comando.Parameters.AddWithValue("@Necessidade", Fc.Necessidade);
            






            //exeutar o comando no bd.
            Comando.ExecuteNonQuery();

            // fechar a conexão.
            Conexao.Close();
        }
       
        public void ExcluirFaleConosco(FaleConosco Fc)
        {

            //abrir a conexão banco de dados.
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // quary sql para excluir.(delete)  

            string QuerySql = "delete from Faleconosco WHERE Id=@Id";


            //preparar um comando, passando: sql + conexão com o bd.
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            //tratamento devido ao sql injection.
            Comando.Parameters.AddWithValue("@Id", Fc.Id);

            //exeutar o comando no bd.
            Comando.ExecuteNonQuery();

            // fechar a conexão.
            Conexao.Close();
        }

    }


}