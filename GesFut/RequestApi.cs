using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GesFut
{

    public class Avaliacao
    {
        public int CodigoAvaliacao { get; set; }
        public int CodigoAtleta { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public int UsuarioResponsavel { get; set; }
        public double Peso { get; set; }
    }
    public class RequestApi
    {
        HttpClient client = new HttpClient();

        public  async Task<Uri> AtualizarAvaliacao(Avaliacao avaliacao)
        {
            client.BaseAddress = new Uri("https://localhost:44313/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.PostAsJsonAsync("AvaliacaoDesempenho/InserirAvaliacao", avaliacao);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
    }
}