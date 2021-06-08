using System;
using System.Collections.Generic;

namespace GesFut
{
    public class Atleta
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

    }
}
