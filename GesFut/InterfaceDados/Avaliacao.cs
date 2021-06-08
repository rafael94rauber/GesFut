using System;

namespace GesFut
{
    public class Avaliacao
    {
        public int CodigoAvaliacao { get; set; }
        public int CodigoAtleta { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public int UsuarioResponsavel { get; set; }
        public double Peso { get; set; }
    }
}
