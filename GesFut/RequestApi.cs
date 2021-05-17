using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GesFut
{
    public class RequestApi
    {
        HttpClient client = new HttpClient();

        public  async Task<Uri> AtualizarAvaliacao(AvaliacaoMedica avaliacao)
        {
            client.BaseAddress = new Uri("https://localhost:44313/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.PostAsJsonAsync("AvaliacaoMedicaController/InserirAvaliacao", avaliacao);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        public async Task<Uri> IncluirAtleta(Atleta atleta)
        {
            client.BaseAddress = new Uri("https://localhost:44313/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.PostAsJsonAsync("AtletaController/InserirAtleta", atleta);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
    }
}