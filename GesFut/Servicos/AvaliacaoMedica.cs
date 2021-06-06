using System;
using System.Collections.Generic;
using System.Text;

namespace GesFut
{
    public class AvaliacaoMedica : Avaliacao
    {
        public double TemperaturaCorporal { get; set; }
        public String Pressao { get; set; }
        public int BatimentosCardiacos { get; set; }
        public String Alergias { get; set; }
        public Boolean Lesao { get; set; }
       
    }
}
