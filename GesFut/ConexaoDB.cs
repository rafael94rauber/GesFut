﻿using Npgsql;
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

        public DataSet RetornarDados()
        {
            DataSet ds;
            using var conn = new NpgsqlConnection(ConexaoDb);
            conn.Open();

            using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM usuario", conn))
            {
                NpgsqlDataAdapter sda = new NpgsqlDataAdapter(command);
                ds = new DataSet();
                sda.Fill(ds);

            }
            conn.Close();
            conn.Dispose();
            return ds;
        }

        public int InsertDados(Base obj)
        {
            using var conn = new NpgsqlConnection(ConexaoDb);
            Console.Out.WriteLine("Opening connection");
            conn.Open();

            using var command = new NpgsqlCommand(obj.GetInsert(), conn);


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