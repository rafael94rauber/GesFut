﻿using System;

namespace GesFut
{
    public class AvaliacaoMedica: Avaliacao, IBaseSQL
    {
        public double TemperaturaCorporal { get; set; }
        public string Pressao { get; set; }
        public int BatimentosCardiacos { get; set; }
        public string Alergias { get; set; }
        public bool Lesao { get; set; }
        public int Fadiga { get; set; }
        public int Fitness { get; set; }

        public static string GetSQLConsulta(int CodigoAtleta)
        {
            return $"Select * from AVALIACAO_MEDICA where codigo_atleta = {CodigoAtleta} order by data_avaliacao desc";
        }
        public string GetDelete()
        {
            return $"DELETE FROM AVALIACAO_MEDICA WHERE codigo_avaliacao = {CodigoAvaliacao}";
        }
        public string GetInsert()
        {
            String lesao = "N";
            if (this.Lesao)
                lesao = "S";

            return $"INSERT INTO AVALIACAO_MEDICA (codigo_atleta, data_avaliacao, usuario_responsavel, peso, temperatura_corporal, pressao, batimentos_cardiacos, alergias, lesao) " +
                   $"values ({CodigoAtleta}, '{DataAvaliacao.ToString("yyyy-MM-dd")}', {UsuarioResponsavel}, {Peso}, {TemperaturaCorporal}, '{Pressao}', {BatimentosCardiacos}, '{Alergias}', '{lesao}') ";
        }
        public string GetUpdate()
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
        public string GetCampoCodigo()
        {
            return "codigo_avaliacao";
        }

        public string GetUpdate(int id)
        {
            throw new NotImplementedException();
        }

        public string GetDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
