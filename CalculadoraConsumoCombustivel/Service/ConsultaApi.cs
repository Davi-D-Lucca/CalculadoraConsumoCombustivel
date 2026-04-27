using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace CalculadoraConsumoCombustivel.Service
{
    public class ConsultaApi
    {
        private readonly HttpClient _httpClient;

        public ConsultaApi()
        {

            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => true;
            _httpClient = new HttpClient(handler);

           // _httpClient = new HttpClient();
        }

        // =========================
        // GET GENÉRICO
        // =========================
        public async Task<T> GetAsync<T>(string url)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;


                HttpResponseMessage response = await _httpClient.GetAsync(url);


                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Erro na requisição: {response.StatusCode}");

                string json = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar API (GET): " + ex.Message);
            }
        }

        // =========================
        // POST GENÉRICO
        // =========================
        public async Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest data)
        {
            try
            {
                string jsonRequest = JsonConvert.SerializeObject(data);

                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync(url, content);

                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Erro na requisição: {response.StatusCode}");

                string jsonResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<TResponse>(jsonResponse);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar API (POST): " + ex.Message);
            }
        }
    }
}