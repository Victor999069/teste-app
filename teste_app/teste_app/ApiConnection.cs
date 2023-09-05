using RestSharp;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace teste_app
{
    public class ApiConnection
    {
        private readonly HttpClient httpClient;

        public async Task<dynamic> ApiConection()
        {

            //httpClient = new HttpClient
            //{
            //    BaseAddress = new Uri("http://localhost:5005/api/Cliente")
            //};
            //httpClient.DefaultRequestHeaders.Accept.Clear();
            //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var client = new RestClient("http://localhost:7009/api/Cliente");
            var request = new RestRequest(Method.Get.ToString());
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");

            //request.AddParameter("application/json", jsn, ParameterType.RequestBody);

            dynamic json = await client.ExecuteAsync(request);

            return json;
        }



        public async Task<string> GetSwaggerJsonAsync()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("Cliente");
                response.EnsureSuccessStatusCode(); // Lança exceção se o status da resposta for erro

                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                // Tratamento de erro caso ocorra uma exceção de requisição HTTP
                Console.WriteLine($"Erro na requisição HTTP: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Outros tratamentos de erro genéricos
                Console.WriteLine($"Erro na API: {ex.Message}");
                throw;
            }
        }
    }
}