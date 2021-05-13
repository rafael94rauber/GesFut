using GesFut;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestFutApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AvaliacaoDesempenho : ControllerBase
    {
        [HttpPost]
        public async Task<object> InserirAvaliacao([FromBody] Avaliacao avaliacao)
        {
            var insert = new AvaliacaoDesempenhoServico().GetInsert(avaliacao);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.InsertDados(insert);
        }

        [HttpPost]
        public async Task<object> AtualizarAvaliacao([FromBody] Avaliacao avaliacao)
        {
            var update = new AvaliacaoDesempenhoServico().GetUpdate(avaliacao);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.AtualizarDados(update);
        }

        [HttpPost]
        public async Task<object> DeletarAvaliacao([FromBody] Avaliacao avaliacao)
        {
            var delete = new AvaliacaoDesempenhoServico().GetDelete(avaliacao);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.DeletarDados(delete);
        }
    }
}
