using GesFut;

namespace GesFutApi.Servico
{
    public class AvaliacaoDesempenhoServico 
    {
        public static string GetInsert(AvaliacaoDesempenho avaliacao)
        {
            return $"INSERT INTO AVALIACAO_DESEMPENHO (codigo_atleta, data_avaliacao, usuario_responsavel, peso, tempo_jogo, percentual_gordura, velocidade_media) " +
                   $"values ({avaliacao.CodigoAtleta}, '{avaliacao.DataAvaliacao:yyyy-MM-dd}', {avaliacao.UsuarioResponsavel}, {avaliacao.Peso}, '{avaliacao.TempoJogo:mmHHss}', {avaliacao.PercentualGordura}, {avaliacao.VelocidadeMedia}) ";            
        }
        public static string GetUpdate(AvaliacaoDesempenho avaliacao)
        {
            return $"UPDATE AVALIACAO_DESEMPENHO set " +
                   $"  codigo_atleta = {avaliacao.CodigoAtleta}" +
                   $" ,data_avaliacao = {avaliacao.DataAvaliacao:yyyy-MM-dd}" +
                   $" ,usuario_responsavel = {avaliacao.UsuarioResponsavel}" +
                   $" ,peso = {avaliacao.Peso}" +
                   $" ,tempo_jogo = {avaliacao.TempoJogo:mm:HH:ss}" +
                   $" ,percentual_gordura = {avaliacao.PercentualGordura}" +
                   $" ,velocidade_media = {avaliacao.VelocidadeMedia}" +
                   $"WHERE codigo_avaliacao = {avaliacao.CodigoAvaliacao}";
        }
        public static string GetDelete(AvaliacaoDesempenho avaliacao)
        {
            return $"DELETE FROM AVALIACAO_DESEMPENHO WHERE codigo_avaliacao = {avaliacao.CodigoAvaliacao}";
        }
    }
}
