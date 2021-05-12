using System;
using System.Collections.Generic;
using System.Text;

namespace GesFut.classes
{
    class Atleta: IBaseSQL
    {
        public int CodigoAtleta { get; }
        public String Nome { get; set; }
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Altura { get; set; }

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

        public String GetInsert()
        {
            return $"insert into atleta (nome, cpf, data_nascimento, altura) values ({Nome}," +
                   $"{CPF}, {DataNascimento.ToString("yyyy-MM-dd")}, {Altura});";
        }
        public abstract String GetUpdate()
        {
            return $"update atleta set" +
                   $"  nome = {Nome},  " +
                   $"  cpf = {CPF}," +
                   $"  data_nascimento = {DataNascimento}," +
                   $"  altura = {Altura}" +
                   $"where codigo_atleta = {CodigoAtleta};";
        }
        public abstract String GetDelete()
        {
            return $"DELETE FROM atleta WHERE codigo_atleta = {CodigoAtleta}";
        }
    }
}
