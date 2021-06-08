namespace GesFut
{
    public class AvaliacaoMedica: Avaliacao
    {
        public double TemperaturaCorporal { get; set; }
        public string Pressao { get; set; }
        public int BatimentosCardiacos { get; set; }
        public string Alergias { get; set; }
        public bool Lesao { get; set; }
        public int Fadiga { get; set; }
        public int Fitness { get; set; }
    }
}
