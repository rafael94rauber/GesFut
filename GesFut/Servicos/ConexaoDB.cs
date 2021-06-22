using Npgsql;
using System;
using System.Data;

namespace GesFut
{
    public class ConexaoDB
    {
        // dados de conexao
        private static string Host = "localhost";
        private static string Port = "5432";
        private static string DBname = "gesfut";
        private static string User = "postgres";
        //private static string Password = "rer251994";
        private static string Password = "123456";
        private static string ConexaoDb = "";


        public ConexaoDB()
        {
            ConexaoDb = $"Server={Host};Username={User};Database={DBname};Port={Port};Password={Password};SSLMode=Prefer";
        }

        public void CriarBancoDadosZerado(string BancoDados = "postgres")
        {
            ConexaoDb = $"Server={Host};Username={User};Database={BancoDados};Port={Port};Password={Password};SSLMode=Prefer";
            
            ExecutarComando($"DROP DATABASE IF EXISTS {DBname};");
            
            ExecutarComando($"CREATE DATABASE {DBname};");

            ConexaoDb = $"Server={Host};Username={User};Database={DBname};Port={Port};Password={Password};SSLMode=Prefer";

            ExecutarComando("create table usuario(" +
                " codigo_usuario bigserial primary key" +
                ", nome varchar(100)" +
                ", cpf varchar(11)" +
                ", data_nascimento date" +
                ", email varchar(100)" +
                ", endereco varchar(200)" +
                ", telefone varchar(20)" +
                ", RG varchar(20)" +
                ", usuario varchar(30)" +
                ", senha varchar(100)); ");

            ExecutarComando("create table atleta(" +
                "codigo_atleta bigserial primary key" +
                ", nome varchar(100)" +
                ", cpf varchar(11)" +
                ", data_nascimento date" +
                ", altura double precision); ");
        }

        private void ExecutarComando(string comandoSql)
        {            
            using var conn = new NpgsqlConnection(ConexaoDb);
            conn.Open();
            using (NpgsqlCommand command = new NpgsqlCommand(comandoSql, conn))
            {
                command.ExecuteNonQuery();
            }
            conn.Close();
            conn.Dispose();
        }

        public DataSet RetornarDados(string SQL)
        {
            DataSet ds;
            using var conn = new NpgsqlConnection(ConexaoDb);
            conn.Open();

            using (NpgsqlCommand command = new NpgsqlCommand(SQL, conn))
            {
                NpgsqlDataAdapter sda = new NpgsqlDataAdapter(command);
                ds = new DataSet();
                sda.Fill(ds);

            }
            conn.Close();
            conn.Dispose();
            return ds;
        }

        public int InsertDados(IBaseSQL dados)
        {
            using var conn = new NpgsqlConnection(ConexaoDb);
            Console.Out.WriteLine("Opening connection");
            conn.Open();

            using var command = new NpgsqlCommand(dados.GetInsert(), conn);

            int numeroLinhasAfetadas = command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return numeroLinhasAfetadas;
        }

        public int AtualizarDados(IBaseSQL dados)
        {
            using var conn = new NpgsqlConnection(ConexaoDb);
            conn.Open();

            using var command = new NpgsqlCommand(dados.GetUpdate(), conn);            
            int numeroLinhasAfetadas = command.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            return numeroLinhasAfetadas;
        }

        public int DeletarDados(IBaseSQL dados)
        {
            using var conn = new NpgsqlConnection(ConexaoDb);
            conn.Open();
            using var command = new NpgsqlCommand(dados.GetDelete(), conn);
            int numeroLinhasAfetadas = command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return numeroLinhasAfetadas;
        }
    }
}