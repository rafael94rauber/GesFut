using System;
using System.Collections.Generic;

namespace GesFut
{
    public class Atleta: IBaseSQL
    {
        public int CodigoAtleta { get; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        private List<AvaliacaoDesempenho> avaliacoesDesempenho;

        private List<AvaliacaoMedica> avaliacoesMedicas;

        public Atleta(int codigoAtleta)
        {
            CodigoAtleta = codigoAtleta;
            avaliacoesDesempenho = new List<AvaliacaoDesempenho>();
            avaliacoesMedicas = new List<AvaliacaoMedica>();
        }

        public void adicionarAvaliacaoDesempenho(AvaliacaoDesempenho avaliacaoDesempenho)
        {
            avaliacoesDesempenho.Add(avaliacaoDesempenho);
        }

        public void adicionarAvaliacaoMedica(AvaliacaoMedica avaliacaoMedica)
        {
            avaliacoesMedicas.Add(avaliacaoMedica);
        }

        public string GetInsert()
        {
            return $"insert into atleta (nome, cpf, data_nascimento) values ('{Nome}'," +
                   $"'{CPF}', '{DataNascimento.ToString("yyyy-MM-dd")}');";

        }

        public string GetUpdate()
        {
            return $"update atleta set" +
                   $"  nome = {Nome},  " +
                   $"  cpf = {CPF}," +
                   $"  data_nascimento = {DataNascimento}," +
                   $"where codigo_atleta = {CodigoAtleta};";

        }

        public string GetDelete()
        {
            return $"DELETE FROM atleta WHERE codigo_atleta = {CodigoAtleta}";

        }

        public string GetCampoCodigo()
        {
            return "codigo_atleta";
        }

        public static string GetSQLConsulta()
        {
            return "SELECT * FROM atleta order by nome";
        }

        public string GetUpdate(int id)
        {
            throw new NotImplementedException();
        }

        public string GetDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
