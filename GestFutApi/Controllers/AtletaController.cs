using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using GesFut;
using GesFutApi.Servico;

namespace GestFutApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AtletaController : ControllerBase
    {
        [HttpPost]
        public async Task<object> InserirAtleta([FromBody] Atleta atleta)
        {
            try
            {
                var insert = "";// AtletaServico.GetInsert(atleta);
                var conexaoDB = new ConexaoDB();

                return conexaoDB.InsertDados(insert);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        [HttpPost]
        public async Task<object> AtualizarAtleta([FromBody] Atleta atleta)
        {
            try
            {
                var update = "";// AtletaServico.GetUpdate(atleta);
                var conexaoDB = new ConexaoDB();

                return conexaoDB.AtualizarDados(update);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        [HttpPost]
        public async Task<object> DeletarAtleta([FromBody] Atleta atleta)
        {
            try
            {
                var delete = "";//AtletaServico.GetDelete(atleta);
                var conexaoDB = new ConexaoDB();

                return conexaoDB.DeletarDados(delete);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }            
        }
    }
}
