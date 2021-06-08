using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using GesFut;
using GesFutApi.Servico;

namespace GestFutApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AvaliacaoMedicaController : ControllerBase
    {
        [HttpPost]
        public async Task<object> InserirAvaliacaoMedica([FromBody] AvaliacaoMedica avaliacaoMedica)
        {
            var insert = AvaliacaoMedicaServico.GetInsert(avaliacaoMedica);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.InsertDados(insert);
        }

        [HttpPost]
        public async Task<object> DeletarAvaliacaoMedica([FromBody] AvaliacaoMedica avaliacaoMedica)
        {
            var delete = AvaliacaoMedicaServico.GetDelete(avaliacaoMedica);
            var conexaoDB = new ConexaoDB();

            return conexaoDB.DeletarDados(delete);
        }

        [HttpPost]
        public async Task<object> BuscasAvaliacaoMedica()
        {
            var select = AvaliacaoMedicaServico.GetSelect();
            var conexaoDB = new ConexaoDB();

            return conexaoDB.RetornarDados(select);
        }
    }
}
