using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var insert = AtletaServico.GetInsert(atleta);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.InsertDados(insert);
        }

        [HttpPost]
        public async Task<object> AtualizarAtleta([FromBody] Atleta atleta)
        {
            var update = AtletaServico.GetUpdate(atleta);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.AtualizarDados(update);
        }

        [HttpPost]
        public async Task<object> DeletarAtleta([FromBody] Atleta atleta)
        {
            var delete = AtletaServico.GetDelete(atleta);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.DeletarDados(delete);
        }
    }
}
