using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GesFut
{
    public class Atleta
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

    }
}
