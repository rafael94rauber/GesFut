using System;
using System.Collections.Generic;
using System.Text;
using GesFut;

namespace GesFutApi.Servico
{
    class AvaliacaoMedicaServico
    {
        public static string GetInsert(AvaliacaoMedica avaliacao)
        {
            return $"INSERT INTO AVALIACAO_MEDICA (codigo_atleta, data_avaliacao, usuario_responsavel, peso, temperatura_corporal, pressao, batimentos_cardiacos, alergias, lesao) " +
                   $"values ({avaliacao.CodigoAtleta}" +
                   $", '{avaliacao.DataAvaliacao:yyyy-MM-dd}'" +
                   $", {avaliacao.UsuarioResponsavel}" +
                   $", {avaliacao.Peso}" +
                   $", {avaliacao.TemperaturaCorporal}" +
                   $", '{avaliacao.Pressao}'" +
                   $", {avaliacao.BatimentosCardiacos}" +
                   $", '{avaliacao.Alergias}'" +
                   $", '{avaliacao.Lesao}') ";
        }

        public static string GetDelete(AvaliacaoMedica avaliacao)
        {
            return $"DELETE FROM AVALIACAO_MEDICA WHERE codigo_avaliacao = {avaliacao.CodigoAvaliacao}";
        }

        public static string GetSelect()
        {
            return "Select * from AVALIACAO_MEDICA";
        }
    }
}
