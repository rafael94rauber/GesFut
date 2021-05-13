using System;
using System.Collections.Generic;
using System.Text;

namespace GesFut
{
    public class AvaliacaoDesempenhoServico 
    {
        public DateTime TempoJogo { get; set; }
        public double PercentualGordura { get; set; }
        public double VelocidadeMedia { get; set; }

        public string GetInsert(Avaliacao avaliacao)
        {
            return $"INSERT INTO AVALIACAO_DESEMPENHO (codigo_atleta, data_avaliacao, usuario_responsavel, peso, tempo_jogo, percentual_gordura, velocidade_media) " +
                   $"values ({avaliacao.CodigoAtleta}, '{avaliacao.DataAvaliacao:yyyy-MM-dd}', {avaliacao.UsuarioResponsavel}, {avaliacao.Peso}, '{TempoJogo:mmHHss}', {PercentualGordura}, {VelocidadeMedia}) ";            
        }
        public string GetUpdate(Avaliacao Avaliacao)
        {
            return $"UPDATE AVALIACAO_DESEMPENHO set " +
                   $"  codigo_atleta = {Avaliacao.CodigoAtleta}" +
                   $" ,data_avaliacao = {Avaliacao.DataAvaliacao:yyyy-MM-dd}" +
                   $" ,usuario_responsavel = {Avaliacao.UsuarioResponsavel}" +
                   $" ,peso = {Avaliacao.Peso}" +
                   $" ,tempo_jogo = {TempoJogo:mm:HH:ss}" +
                   $" ,percentual_gordura = {PercentualGordura}" +
                   $" ,velocidade_media = {VelocidadeMedia}" +
                   $"WHERE codigo_avaliacao = {Avaliacao.CodigoAvaliacao}";
        }
        public string GetDelete(Avaliacao Avaliacao)
        {
            return $"DELETE FROM AVALIACAO_DESEMPENHO WHERE codigo_avaliacao = {Avaliacao.CodigoAvaliacao}";
        }
    }
}
