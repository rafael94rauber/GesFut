using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GesFut
{
    public class AvaliacaoDesempenho: Avaliacao
    {
        public DateTime TempoJogo { get; set; }
        public double PercentualGordura { get; set; }
        public double VelocidadeMedia { get; set; }
    }
}
