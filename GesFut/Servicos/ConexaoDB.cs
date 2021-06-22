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
                " codigo_atleta bigserial primary key" +
                ", nome varchar(100)" +
                ", cpf varchar(11)" +
                ", data_nascimento date" +
                ", telefone text" +
                ", sexo text" +
                ", endereco text" +
                ", email text" +
                ");");

            ExecutarComando("create table jogo (codigo_jogo bigserial primary key, time_rival varchar(100), data_hora timestamp);");

            ExecutarComando("create table avaliacao_desempenho (codigo_avaliacao bigserial primary key," +
                " codigo_atleta bigint" +
                ",data_avaliacao date" +
                ",usuario_responsavel bigint" +
                ",peso double precision" +
                ",tempo_jogo time" +
                ",percentual_gordura double precision" +
                ",velocidade_media double precision" +
                ",constraint fk_avaliacao_desempenho_atleta foreign key(codigo_atleta) references atleta(codigo_atleta)" +
                ",constraint fk_avaliacao_desempenho_usuario foreign key(usuario_responsavel) references usuario(codigo_usuario)" +
                ");");

            ExecutarComando("create table avaliacao_medica(" +
                "codigo_avaliacao bigserial primary key" +
                ",codigo_atleta bigint" +
                ",data_avaliacao date" +
                ",usuario_responsavel bigint" +
                ",peso double precision" +
                ",temperatura_corporal double precision" +
                ",pressao varchar(30)" +
                ",batimentos_cardiacos int" +
                ",alergias text" +
                ",lesao char(1)" +
                ",fadiga int" +
                ",fitness int" +
                ",constraint fk_avaliacao_medica_atleta foreign key(codigo_atleta) references atleta(codigo_atleta)" +
                ",constraint fk_avaliacao_medica_usuario foreign key(usuario_responsavel) references usuario(codigo_usuario)" +
                ");");
            ExecutarComando("insert into jogo(time_rival, data_hora) values('Gremio', '01.01.2022')");

            ExecutarComando("insert into jogo(time_rival, data_hora) values('Internacional', '20.07.2021')");

            ExecutarComando("insert into jogo(time_rival, data_hora) values('Juventude', '03.06.2022')");

            ExecutarComando("insert into jogo(time_rival, data_hora) values('Flamengo', '09.09.2022')");

            ExecutarComando("insert into usuario (nome, usuario, senha) values ('admin', 'admin', '123mudar');");
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