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
    public class AvaliacaoDesempenhoController : ControllerBase
    {
        [HttpPost]
        public async Task<object> InserirAvaliacao([FromBody] AvaliacaoDesempenho avaliacao)
        {
            var insert = AvaliacaoDesempenhoServico.GetInsert(avaliacao);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.InsertDados(insert);
        }

        [HttpPost]
        public async Task<object> AtualizarAvaliacao([FromBody] AvaliacaoDesempenho avaliacao)
        {
            var update = AvaliacaoDesempenhoServico.GetUpdate(avaliacao);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.AtualizarDados(update);
        }

        [HttpPost]
        public async Task<object> DeletarAvaliacao([FromBody] AvaliacaoDesempenho avaliacao)
        {
            var delete = AvaliacaoDesempenhoServico.GetDelete(avaliacao);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.DeletarDados(delete);
        }
    }
}
