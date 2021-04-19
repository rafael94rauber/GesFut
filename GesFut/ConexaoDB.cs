using Npgsql;
using System;
using System.Data.SqlClient;

namespace GesFut
{
    public class ConexaoDB
    {
        // dados de conexao
        private static string Host = "localhost";
        private static string Port = "5432";
        private static string DBname = "gesfut";
        private static string User = "postgres";
        private static string Password = "rer251994";
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

        public void RetornarDados()
        {
            using var conn = new NpgsqlConnection(ConexaoDb);
            conn.Open();

            using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM usuario", conn))
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(
                        string.Format(
                            "Reading from table=({0}, {1}, {2})",
                            reader.GetInt32(0).ToString(),
                            reader.GetString(1),
                            reader.GetInt32(2).ToString()
                            )
                        );
                }
                reader.Close();
            }
            conn.Close();
            conn.Dispose();
        }

        public int ExecutarComando()
        {
            using var conn = new NpgsqlConnection(ConexaoDb);
            Console.Out.WriteLine("Opening connection");
            conn.Open();

            using var command = new NpgsqlCommand("INSERT INTO usuario (nome, cpf, data_nascimento, email, endereco, telefone, RG, usuario, senha) VALUES (@p1, @p2, NOW(), @p4, @p5, @p6, @p7, @p8, @p9)", conn);
            command.Parameters.AddWithValue("p1", "banana");
            command.Parameters.AddWithValue("p2", "banana");
            command.Parameters.AddWithValue("p4", "banana");
            command.Parameters.AddWithValue("p5", "banana");
            command.Parameters.AddWithValue("p6", "banana");
            command.Parameters.AddWithValue("p7", "banana");
            command.Parameters.AddWithValue("p8", "banana");
            command.Parameters.AddWithValue("p9", "banana");


            int numeroLinhasAfetadas = command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return numeroLinhasAfetadas;
        }       

        public int AtualizarDados()
        {
            using var conn = new NpgsqlConnection(ConexaoDb);
            conn.Open();

            using var command = new NpgsqlCommand("UPDATE usuario SET nome = @p1 WHERE nome = @p2", conn);
            command.Parameters.AddWithValue("p1", "banana");
            command.Parameters.AddWithValue("p2", "banana");
            int numeroLinhasAfetadas = command.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            return numeroLinhasAfetadas;
        }

        public int DeletarDados()
        {
            using var conn = new NpgsqlConnection(ConexaoDb);
            conn.Open();

            using var command = new NpgsqlCommand("DELETE FROM usuario WHERE nome = @p1", conn);
            command.Parameters.AddWithValue("p1", "orange");

            int numeroLinhasAfetadas = command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return numeroLinhasAfetadas;
        }
    }
}