using System;
using System.Collections.Generic;
using System.Text;
using GesFut;

namespace GesFutApi.Servico
{
    class AtletaServico
    {
        public static String GetInsert(Atleta atleta)
        {
            return $"insert into atleta (nome, cpf, data_nascimento, altura) values ({atleta.Nome}," +
                   $"{atleta.CPF}, {atleta.DataNascimento.ToString("yyyy-MM-dd")}, {atleta.Altura});";

        }
        public static String GetUpdate(Atleta atleta)
        {
            return $"update atleta set" +
                   $"  nome = {atleta.Nome},  " +
                   $"  cpf = {atleta.CPF}," +
                   $"  data_nascimento = {atleta.DataNascimento}," +
                   $"  altura = {atleta.Altura}" +
                   $"where codigo_atleta = {atleta.CodigoAtleta};";

        }
        public static String GetDelete(Atleta atleta)
        {
            return $"DELETE FROM atleta WHERE codigo_atleta = {atleta.CodigoAtleta}";

        }
    }
}
