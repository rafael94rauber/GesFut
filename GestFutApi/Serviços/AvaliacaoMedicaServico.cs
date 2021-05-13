using System;
using System.Collections.Generic;
using System.Text;

namespace GesFut
{
    class AvaliacaoMedicaServico
    {
        public double TemperaturaCorporal { get; set; }
        public string Pressao { get; set; }
        public int BatimentosCardiacos { get; set; }
        public string Alergias { get; set; }
        public bool Lesao { get; set; }
        
        public string GetInsert(Avaliacao avaliacao)
        {
            return $"INSERT INTO AVALIACAO_MEDICA (codigo_atleta, data_avaliacao, usuario_responsavel, peso, temperatura_corporal, pressao, batimentos_cardiacos, alergias, lesao) " +
                   $"values ({avaliacao.CodigoAtleta}" +
                   $", '{avaliacao.DataAvaliacao:yyyy-MM-dd}'" +
                   $", {avaliacao.UsuarioResponsavel}" +
                   $", {avaliacao.Peso}" +
                   $", {TemperaturaCorporal}" +
                   $", '{Pressao}'" +
                   $", {BatimentosCardiacos}" +
                   $", '{Alergias}'" +
                   $", '{Lesao}') ";
        }

        public string GetDelete(Avaliacao avaliacao)
        {
            return $"DELETE FROM AVALIACAO_MEDICA WHERE codigo_avaliacao = {avaliacao.CodigoAvaliacao}";
        }

        public string GetSelect()
        {
            return "Select * from AVALIACAO_MEDICA";
        }
    }
}
