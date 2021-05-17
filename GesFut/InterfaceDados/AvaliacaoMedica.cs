using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GesFut
{
    public class AvaliacaoMedica: Avaliacao
    {
        public double TemperaturaCorporal { get; set; }
        public string Pressao { get; set; }
        public int BatimentosCardiacos { get; set; }
        public string Alergias { get; set; }
        public bool Lesao { get; set; }
    }
}
