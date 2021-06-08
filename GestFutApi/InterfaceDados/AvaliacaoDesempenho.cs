using System;

namespace GesFut
{
    public class AvaliacaoDesempenho: Avaliacao
    {
        public DateTime TempoJogo { get; set; }
        public double PercentualGordura { get; set; }
        public double VelocidadeMedia { get; set; }
    }
}
