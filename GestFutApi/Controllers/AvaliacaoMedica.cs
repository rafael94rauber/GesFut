using GesFut;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestFutApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AvaliacaoMedica : ControllerBase
    {
        [HttpPost]
        public async Task<object> InserirAvaliacaoMedica([FromBody] Avaliacao avaliacaoMedica)
        {
            var insert = new AvaliacaoMedicaServico().GetInsert(avaliacaoMedica);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.InsertDados(insert);
        }

        [HttpPost]
        public async Task<object> DeletarAvaliacaoMedica([FromBody] Avaliacao avaliacaoMedica)
        {
            var delete = new AvaliacaoMedicaServico().GetDelete(avaliacaoMedica);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.DeletarDados(delete);
        }

        [HttpPost]
        public async Task<object> BuscasAvaliacaoMedica()
        {
            var select = new AvaliacaoMedicaServico().GetSelect();
            var conexaoDB = new ConexaoDB();

            return conexaoDB.RetornarDados(select);
        }
    }
}
