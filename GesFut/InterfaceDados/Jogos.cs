using System;
using System.Collections.Generic;
using System.Text;

namespace GesFut
{
    public class Jogos : IBaseSQL
    {
        public string timeRival { get; set; }
        public DateTime dataJogo { get; set; }

        public string GetInsert()
        {
            return $"insert into jogo(time_rival, data_hora) values ('{timeRival}', '{dataJogo.ToString("yyyy-mm-dd")}');";
        }

        public string GetUpdate(int id)
        {
            return $"update jogo set" +
                   $"  time_rival = {timeRival},  " +
                   $"  data_hora = {dataJogo.ToString("yyyy-mm-dd")}," +
                   $"where codigo_jogo = {id};";

        }

        public string GetDelete(int id)
        {
            return $"DELETE FROM jogo WHERE codigo_jogo = {id}";

        }

        public string GetCampoCodigo()
        {
            return "codigo_jogo";
        }

        public static string GetSQLConsulta()
        {
            return "SELECT * FROM jogo order by data_hora desc";
        }

        public string GetUpdate()
        {
            throw new NotImplementedException();
        }

        public string GetDelete()
        {
            throw new NotImplementedException();
        }
    }
}
