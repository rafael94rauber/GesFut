using System;
using System.Collections.Generic;
using System.Text;

namespace GesFut
{
    public abstract class Avaliacao
    {
        public int CodigoAvaliacao { get; }
        public int CodigoAtleta  { get;set; }
        public DateTime DataAvaliacao { get; set; }
        public int UsuarioResponsavel { get; set; }
        public double Peso { get; set; }
        public abstract String GetInsert();
        public abstract String GetUpdate();
        public abstract String GetDelete();
        
    }
}
