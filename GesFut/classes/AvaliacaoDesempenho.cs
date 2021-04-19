using System;
using System.Collections.Generic;
using System.Text;

namespace GesFut
{
    class AvaliacaoDesempenho : Avaliacao
    {
        public DateTime TempoJogo { get; set; }
        public double PercentualGordura { get; set; }
        public double VelocidadeMedia { get; set; }

        public override String GetInsert()
        {
            return $"INSERT INTO AVALIACAO_DESEMPENHO (codigo_atleta, data_avaliacao, usuario_responsavel, peso, tempo_jogo, percentual_gordura, velocidade_media) " +
                   $"values ({CodigoAtleta}, {DataAvaliacao.ToString("yyyy-MM-dd")}, {UsuarioResponsavel}, {Peso}, {TempoJogo.ToString("mm:HH:ss")}, {PercentualGordura}, {VelocidadeMedia}) ";
        }
        public override String GetUpdate()
        {
            return $"UPDATE AVALIACAO_DESEMPENHO set " +
                   $"  codigo_atleta = {CodigoAtleta}" +
                   $" ,data_avaliacao = {DataAvaliacao.ToString("yyyy-MM-dd")}" +
                   $" ,usuario_responsavel = {UsuarioResponsavel}" +
                   $" ,peso = {Peso}" +
                   $" ,tempo_jogo = {TempoJogo.ToString("mm:HH:ss")}" +
                   $" ,percentual_gordura = {PercentualGordura}" +
                   $" ,velocidade_media = {VelocidadeMedia}" +
                   $"WHERE codigo_avaliacao = {CodigoAvaliacao}";
        }
        public override String GetDelete()
        {
            return $"DELETE FROM AVALIACAO_DESEMPENHO WHERE codigo_avaliacao = {CodigoAvaliacao}";
        }
    }
}
