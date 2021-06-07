using Npgsql;
using System;
using System.Data.SqlClient;
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
            ConexaoDb = String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);
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