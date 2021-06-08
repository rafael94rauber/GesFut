using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GesFut
{
    public class Atleta: IBaseSQL
    {
        public int CodigoAtleta { get; }
        public String Nome { get; set; }
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public String Sexo { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String Endereco { get; set; }

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
            return $"insert into atleta (nome, cpf, data_nascimento) values ('{Nome}'," +
                   $"'{CPF}', '{DataNascimento.ToString("yyyy-MM-dd")}');";

        }

        public String GetUpdate()
        {
            return $"update atleta set" +
                   $"  nome = {Nome},  " +
                   $"  cpf = {CPF}," +
                   $"  data_nascimento = {DataNascimento}," +
                   $"where codigo_atleta = {CodigoAtleta};";

        }

        public String GetDelete()
        {
            return $"DELETE FROM atleta WHERE codigo_atleta = {CodigoAtleta}";

        }

        public String GetCampoCodigo()
        {
            return "codigo_atleta";
        }

        public static String GetSQLConsulta()
        {
            return "SELECT * FROM atleta order by nome";
        }

    }
}
