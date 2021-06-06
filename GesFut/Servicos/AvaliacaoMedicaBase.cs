namespace GesFut
{
    public class AvaliacaoMedicaBase
    {
        public double TemperaturaCorporal { get; set; }
        public double TemperaturaCorporal { get; set; }
        public String Pressao { get; set; }
        public string Pressao { get; set; }
        public int BatimentosCardiacos { get; set; }
        public int BatimentosCardiacos { get; set; }
        public String Alergias { get; set; }
        public string Alergias { get; set; }
        public Boolean Lesao { get; set; }
        public bool Lesao { get; set; }
        public int Fadiga { get; set; }
        public int Fitness { get; set; }

        public static String GetSelect()
        {
            return "Select * from AVALIACAO_MEDICA";
        }
        public override String GetDelete()
        {
            return $"DELETE FROM AVALIACAO_MEDICA WHERE codigo_avaliacao = {CodigoAvaliacao}";
        }
        public override String GetInsert()
        {
            return $"INSERT INTO AVALIACAO_MEDICA (codigo_atleta, data_avaliacao, usuario_responsavel, peso, temperatura_corporal, pressao, batimentos_cardiacos, alergias, lesao) " +
                   $"values ({CodigoAtleta}, '{DataAvaliacao.ToString("yyyy-MM-dd")}', {UsuarioResponsavel}, {Peso}, {TemperaturaCorporal}, '{Pressao}', {BatimentosCardiacos}, '{Alergias}', '{Lesao.ToString()}') ";
        }
        public override String GetUpdate()
        {
            return "";/*return $"UPDATE AVALIACAO_DESEMPENHO set " +
                   $"  codigo_atleta = {CodigoAtleta}" +
                   $" ,data_avaliacao = {DataAvaliacao.ToString("yyyy-MM-dd")}" +
                   $" ,usuario_responsavel = {UsuarioResponsavel}" +
                   $" ,peso = {Peso}" +
                   $" ,tempo_jogo = {TempoJogo.ToString("mm:HH:ss")}" +
                   $" ,percentual_gordura = {PercentualGordura}" +
                   $" ,velocidade_media = {VelocidadeMedia}" +
                   $"WHERE codigo_avaliacao = {CodigoAvaliacao}";*/
        }
    }
}